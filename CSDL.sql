--setting commission date
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'settings')
BEGIN
	CREATE TABLE settings (
		id int IDENTITY(1,1) PRIMARY KEY,
		value INT NOT NULL,
		effective_date DATE DEFAULT GETDATE()
	);
END;
GO

-- Users
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'users')
BEGIN
    CREATE TABLE users (
		id int IDENTITY(1,1) PRIMARY KEY,
        user_code NVARCHAR(10) UNIQUE NOT NULL,
        role_name NVARCHAR(50) NOT NULL CHECK (role_name IN (N'Sale', N'Director', N'Admin', N'Accountant')),
        full_name NVARCHAR(100) NOT NULL,
        username NVARCHAR(50) UNIQUE NOT NULL,
        password NVARCHAR(255) NOT NULL,
        email NVARCHAR(100) NOT NULL,
        phone NVARCHAR(15) NOT NULL
    );
END;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'permissions')
BEGIN
	CREATE TABLE permissions 
	(
		id INT IDENTITY(1,1) PRIMARY KEY,
		name NVARCHAR(20) NOT NULL UNIQUE
	);
END;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'user_permissions')
BEGIN
	CREATE TABLE user_permissions
	(
		user_id INT NOT NULL,
		permission_id INT NOT NULL,
		PRIMARY KEY (user_id, permission_id),
		FOREIGN KEY (user_id) REFERENCES users(id),
		FOREIGN KEY (permission_id) REFERENCES permissions(id),
	);
END;
GO


INSERT INTO permissions (name) VALUES
	('GET_Contract'), ('CREATE_Contract'), ('UPDATE_Contract'), ('DELETE_Contract'), 
	('GET_Task'), ('CREATE_Task'), ('UPDATE_Task'), ('DELETE_Task'), 
	('GET_Payment'), ('CREATE_Payment'), ('UPDATE_Payment'), ('DELETE_Payment'),
	('BusinessReport'), ('CommissionReport');

-- Contracts
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'contracts')
BEGIN
    CREATE TABLE contracts (
		id INT IDENTITY(1,1) PRIMARY KEY,
        contract_code NVARCHAR(20) UNIQUE NOT NULL,
        user_id INT NOT NULL,
        commission_percentage DECIMAL(5, 2) NOT NULL,
        contract_name NVARCHAR(255) NOT NULL,
        contract_content NVARCHAR(MAX) NOT NULL,
        signed_date DATETIME NOT NULL,
        expiration_date DATETIME NOT NULL,
        partner_name NVARCHAR(255) NOT NULL,
        contact_email NVARCHAR(100) NOT NULL,
        contact_phone NVARCHAR(15) NOT NULL,
        total_value DECIMAL(15, 2) NOT NULL,
        status NVARCHAR(50) NOT NULL CHECK (status IN (N'In Progress', N'Completed', N'New')),
        organization_name NVARCHAR(255) NOT NULL,
        created_at DATE DEFAULT GETDATE(),
        updated_at DATE,
        FOREIGN KEY (user_id) REFERENCES users(id)
    );
END;
GO

-- Task Progress
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'task_progress')
BEGIN
    CREATE TABLE task_progress (
        id INT IDENTITY(1,1) PRIMARY KEY,
        contract_id INT NOT NULL,
        task_name NVARCHAR(255) NOT NULL,
        assigned_to INT NOT NULL,
        start_date DATE NOT NULL,
        end_date DATE NOT NULL,
        status NVARCHAR(50) NOT NULL CHECK (status IN (N'In Progress', N'Completed', N'Canceled')),
        FOREIGN KEY (contract_id) REFERENCES contracts(id),
        FOREIGN KEY (assigned_to) REFERENCES users(id)
    );
END;
GO


-- Payment Stages
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'payment_stages')
BEGIN
    CREATE TABLE payment_stages (
        id INT IDENTITY(1,1) PRIMARY KEY,
        contract_id INT NOT NULL,
        stage_name NVARCHAR(255),
        amount DECIMAL(15, 2),
        payment_date DATE DEFAULT GETDATE(),
        description NVARCHAR(MAX),
        status NVARCHAR(50) NOT NULL CHECK (status IN (N'Unpaid', N'Completed')),
        FOREIGN KEY (contract_id) REFERENCES contracts(id)
    );
END;
GO

-- HoaHong (Commissions)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'commissions')
BEGIN
    CREATE TABLE commissions (
        user_id INT NOT NULL,
		payment_stage_id INT NOT NULL,
        commission_percentage DECIMAL(5, 2),
        commission_amount DECIMAL(15, 2),
        commission_date DATE DEFAULT GETDATE(),
        status NVARCHAR(10) CHECK (status IN (N'Active', N'Inactive')),
        FOREIGN KEY (user_id) REFERENCES users(id),
		FOREIGN KEY (payment_stage_id) REFERENCES payment_stages(id),
        CONSTRAINT PK_Commission PRIMARY KEY (user_id,payment_stage_id)
    );
END;
GO

INSERT INTO users 
	(user_code, email, full_name, password, username, role_name, phone)
VALUES
	('AD001', 'admin1@gmail.com', N'Nhân viên A', '$2y$10$6tq6aghRAXS85GK2YRH5t.ueOjbnDSFySj0P12QJpJjVBW5yC.jjO', 'admin1', 'Admin', '0123456789'),
	('AD002', 'admin2@gmail.com', N'Nhân viên A', '$2y$10$6tq6aghRAXS85GK2YRH5t.ueOjbnDSFySj0P12QJpJjVBW5yC.jjO', 'admin2', 'Admin', '0123456789')