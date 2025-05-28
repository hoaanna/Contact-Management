using System.Windows.Forms;

namespace CNPM_FINAL.GUI
{
    partial class DashboardGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTotalContract = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartContractStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPaymentStage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.title = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbDateErr = new System.Windows.Forms.Label();
            this.btnGet = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.lbTotalContractErr = new System.Windows.Forms.Label();
            this.lbContractStatusErr = new System.Windows.Forms.Label();
            this.lbPaymentStageErr = new System.Windows.Forms.Label();
            this.lbRevenueErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartContractStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTotalContract
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalContract.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalContract.Legends.Add(legend1);
            this.chartTotalContract.Location = new System.Drawing.Point(25, 100);
            this.chartTotalContract.Margin = new System.Windows.Forms.Padding(0);
            this.chartTotalContract.Name = "chartTotalContract";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTotalContract.Series.Add(series1);
            this.chartTotalContract.Size = new System.Drawing.Size(470, 280);
            this.chartTotalContract.TabIndex = 0;
            this.chartTotalContract.Text = "chart2";
            title1.Name = "Title1";
            this.chartTotalContract.Titles.Add(title1);
            this.chartTotalContract.Click += new System.EventHandler(this.chartTotalContract_Click);
            // 
            // chartContractStatus
            // 
            chartArea2.Name = "ChartArea1";
            this.chartContractStatus.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartContractStatus.Legends.Add(legend2);
            this.chartContractStatus.Location = new System.Drawing.Point(550, 100);
            this.chartContractStatus.Margin = new System.Windows.Forms.Padding(0);
            this.chartContractStatus.Name = "chartContractStatus";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "bieudotron";
            this.chartContractStatus.Series.Add(series2);
            this.chartContractStatus.Size = new System.Drawing.Size(470, 280);
            this.chartContractStatus.TabIndex = 0;
            this.chartContractStatus.Text = "chart1";
            title2.Name = "bieudotron";
            this.chartContractStatus.Titles.Add(title2);
            this.chartContractStatus.Click += new System.EventHandler(this.chartContractStatus_Click);
            // 
            // chartPaymentStage
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPaymentStage.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPaymentStage.Legends.Add(legend3);
            this.chartPaymentStage.Location = new System.Drawing.Point(25, 430);
            this.chartPaymentStage.Margin = new System.Windows.Forms.Padding(0);
            this.chartPaymentStage.Name = "chartPaymentStage";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chartPaymentStage.Series.Add(series3);
            this.chartPaymentStage.Size = new System.Drawing.Size(470, 280);
            this.chartPaymentStage.TabIndex = 0;
            this.chartPaymentStage.Text = "chart3";
            this.chartPaymentStage.Click += new System.EventHandler(this.chartPaymentStage_Click);
            // 
            // chartRevenue
            // 
            chartArea4.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend4);
            this.chartRevenue.Location = new System.Drawing.Point(550, 430);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(0);
            this.chartRevenue.Name = "chartRevenue";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Tổng kinh doanh";
            series4.Name = "bieudoduong";
            series4.YValuesPerPoint = 2;
            this.chartRevenue.Series.Add(series4);
            this.chartRevenue.Size = new System.Drawing.Size(470, 280);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Text = "chart4";
            this.chartRevenue.Click += new System.EventHandler(this.chartRevenue_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(75, 20);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(350, 70);
            this.title.TabIndex = 0;
            this.title.Text = "Dashboard";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePicker.CustomFormat = "MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(670, 40);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(180, 30);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // lbDateTime
            // 
            this.lbDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lbDateTime.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbDateTime.Location = new System.Drawing.Point(460, 40);
            this.lbDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(170, 30);
            this.lbDateTime.TabIndex = 0;
            this.lbDateTime.Text = "Thời gian dữ liệu";
            this.lbDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDateErr
            // 
            this.lbDateErr.BackColor = System.Drawing.Color.Transparent;
            this.lbDateErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateErr.ForeColor = System.Drawing.Color.Red;
            this.lbDateErr.Location = new System.Drawing.Point(670, 80);
            this.lbDateErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbDateErr.Name = "lbDateErr";
            this.lbDateErr.Size = new System.Drawing.Size(350, 20);
            this.lbDateErr.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnGet.BackgroundColor = System.Drawing.Color.White;
            this.btnGet.BorderColor = System.Drawing.Color.Transparent;
            this.btnGet.BorderRadius = 10;
            this.btnGet.BorderSize = 1;
            this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGet.FlatAppearance.BorderSize = 0;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGet.ForeColor = System.Drawing.Color.White;
            this.btnGet.Location = new System.Drawing.Point(890, 35);
            this.btnGet.Margin = new System.Windows.Forms.Padding(0);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(130, 40);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Xem";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lbTotalContractErr
            // 
            this.lbTotalContractErr.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalContractErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalContractErr.ForeColor = System.Drawing.Color.Red;
            this.lbTotalContractErr.Location = new System.Drawing.Point(30, 380);
            this.lbTotalContractErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbTotalContractErr.Name = "lbTotalContractErr";
            this.lbTotalContractErr.Size = new System.Drawing.Size(450, 20);
            this.lbTotalContractErr.TabIndex = 0;
            // 
            // lbContractStatusErr
            // 
            this.lbContractStatusErr.BackColor = System.Drawing.Color.Transparent;
            this.lbContractStatusErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContractStatusErr.ForeColor = System.Drawing.Color.Red;
            this.lbContractStatusErr.Location = new System.Drawing.Point(550, 380);
            this.lbContractStatusErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbContractStatusErr.Name = "lbContractStatusErr";
            this.lbContractStatusErr.Size = new System.Drawing.Size(450, 20);
            this.lbContractStatusErr.TabIndex = 0;
            // 
            // lbPaymentStageErr
            // 
            this.lbPaymentStageErr.BackColor = System.Drawing.Color.Transparent;
            this.lbPaymentStageErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentStageErr.ForeColor = System.Drawing.Color.Red;
            this.lbPaymentStageErr.Location = new System.Drawing.Point(25, 710);
            this.lbPaymentStageErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbPaymentStageErr.Name = "lbPaymentStageErr";
            this.lbPaymentStageErr.Size = new System.Drawing.Size(450, 20);
            this.lbPaymentStageErr.TabIndex = 0;
            // 
            // lbRevenueErr
            // 
            this.lbRevenueErr.BackColor = System.Drawing.Color.Transparent;
            this.lbRevenueErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenueErr.ForeColor = System.Drawing.Color.Red;
            this.lbRevenueErr.Location = new System.Drawing.Point(550, 710);
            this.lbRevenueErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbRevenueErr.Name = "lbRevenueErr";
            this.lbRevenueErr.Size = new System.Drawing.Size(450, 20);
            this.lbRevenueErr.TabIndex = 0;
            // 
            // DashboardGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.ControlBox = false;
            this.Controls.Add(this.lbRevenueErr);
            this.Controls.Add(this.lbPaymentStageErr);
            this.Controls.Add(this.lbContractStatusErr);
            this.Controls.Add(this.lbTotalContractErr);
            this.Controls.Add(this.lbDateErr);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.title);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.chartPaymentStage);
            this.Controls.Add(this.chartContractStatus);
            this.Controls.Add(this.chartTotalContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardGUI";
            this.Text = "DashboardGUI";
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartContractStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalContract;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartContractStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPaymentStage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private Label lbDateTime;
        private CustomControl.BorderButton btnGet;
        private Label lbDateErr;
        private Label lbTotalContractErr;
        private Label lbContractStatusErr;
        private Label lbPaymentStageErr;
        private Label lbRevenueErr;
    }
}