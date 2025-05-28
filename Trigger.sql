CREATE TRIGGER trg_check_contract_dates
ON contracts
AFTER UPDATE
AS
BEGIN
    -- Khai báo biến để lưu trữ các giá trị ngày ký và ngày hết hạn mới
    DECLARE @contract_id INT;
    DECLARE @new_signed_date DATE;
    DECLARE @new_expiration_date DATE;
    DECLARE @min_payment_date DATE;
    DECLARE @max_payment_date DATE;

    -- Lấy thông tin hợp đồng mới cập nhật
    SELECT @contract_id = id,
           @new_signed_date = signed_date,
           @new_expiration_date = expiration_date
    FROM inserted;

    -- Kiểm tra xem hợp đồng có giao dịch nào phát sinh không
    IF EXISTS (SELECT 1 FROM payment_stages WHERE contract_id = @contract_id)
    BEGIN
        -- Lấy ngày thanh toán nhỏ nhất và lớn nhất từ các giao dịch liên quan đến hợp đồng này
        SELECT @min_payment_date = MIN(payment_date),
               @max_payment_date = MAX(payment_date)
        FROM payment_stages
        WHERE contract_id = @contract_id;

        DECLARE @errSignedDate NVARCHAR(255) = N'Ngày ký hợp đồng không được nhỏ hơn ngày thanh toán đầu tiên của hợp đồng.'  + CHAR(13) + CHAR(10) +  N'The contract signing date cannot be less than the first payment date of the contract.';
        -- Kiểm tra nếu ngày ký không được lớn hơn ngày thanh toán bé nhất
        IF @new_signed_date > @min_payment_date
        BEGIN
            RAISERROR(@errSignedDate, 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

		DECLARE @errExpiredDate NVARCHAR(255) = N'Ngày hết hạn hợp đồng không được bé hơn ngày thanh toán cuối cùng của hợp đồng.'  + CHAR(13) + CHAR(10) +  N'The contract expiration date must be greater than or equal the final payment date of the contract.';
        -- Kiểm tra nếu ngày hết hạn không được nhỏ hơn ngày thanh toán lớn nhất
        IF @new_expiration_date < @max_payment_date
        BEGIN
            RAISERROR(@errExpiredDate, 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
    END
END;
GO

CREATE TRIGGER trg_check_payment_stage
ON payment_stages
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @contract_id INT;
    DECLARE @total_stage_amount DECIMAL(15, 2);
    DECLARE @contract_value DECIMAL(15, 2);
    DECLARE @contract_start_date DATE;
    DECLARE @contract_end_date DATE;

    -- Lấy contract_id từ các bản ghi mới
    SELECT TOP 1 @contract_id = contract_id FROM inserted;

    -- Lấy thông tin hợp đồng
    SELECT 
        @contract_value = total_value, 
        @contract_start_date = signed_date, 
        @contract_end_date = expiration_date
    FROM contracts
    WHERE id = @contract_id;

    -- Tính tổng giá trị thanh toán của tất cả các giai đoạn cho hợp đồng này
    SELECT @total_stage_amount = SUM(amount)
    FROM payment_stages
    WHERE contract_id = @contract_id;

DECLARE @errorDate NVARCHAR(255) = N'Ngày thanh toán phải nằm trong khoảng thời gian hợp đồng.'  + CHAR(13) + CHAR(10) +  N'Payment date must be within the contract duration.';
    -- Kiểm tra ngày thanh toán nằm trong khoảng thời gian hợp đồng
    IF EXISTS (
        SELECT 1 
        FROM inserted
        WHERE payment_date < @contract_start_date OR payment_date > @contract_end_date
    )
    BEGIN
        RAISERROR (@errorDate, 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END


	DECLARE @errTotal NVARCHAR(255) = N'Tổng giá trị thanh toán không được vượt quá giá trị hợp đồng.'  + CHAR(13) + CHAR(10) +  N'Total payment value must not exceed the contract value.';
    -- Kiểm tra tổng giá trị thanh toán không vượt quá giá trị hợp đồng
    IF @total_stage_amount > @contract_value
    BEGIN
        RAISERROR (@errTotal, 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
GO