using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CNPM_FINAL.GUI
{
    public partial class DashboardGUI : Form
    {
        private readonly ChartDLL chartDLL = new ChartDLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        public EventHandler<EventArgs> OpenStatusReport;
        public EventHandler<EventArgs> OpenQuantityReport;
        public EventHandler<EventArgs> OpenRevenueReport;
        public EventHandler<EventArgs> OpenPaymentReport;

        public DashboardGUI()
        {
            InitializeComponent();
            InitTextContent();
            ShowChartData(DateTime.Now);
        }

        #region language
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (this.MdiParent is MainGUI mainForm)
            {
                mainForm.LanguageChanged += MainForm_LanguageChanged;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (this.MdiParent is MainGUI mainForm)
            {
                mainForm.LanguageChanged -= MainForm_LanguageChanged;
            }
        }

        private void MainForm_LanguageChanged(object sender, EventArgs e)
        {
            InitTextContent();
        }
        #endregion

        public void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.DASHBOARD_GUI, typeof(DashboardGUI).Assembly);

            this.lbDateTime.Text = GetLocalizedString("lbDate");
            this.btnGet.Text = SettingContext.Language == "vi" ?
                "Xem" : "View";

            this.lbContractStatusErr.Text = this.lbDateErr.Text
                = this.lbPaymentStageErr.Text = this.lbRevenueErr.Text
                = this.lbTotalContractErr.Text = "";

            #region total contract
            if (chartTotalContract.Titles.Count > 0 && chartTotalContract.Titles[0].Text != null)
            {
                chartTotalContract.Titles[0].Text = GetLocalizedString("lbContactPerWeek");
            }

            if (chartTotalContract.ChartAreas[0].AxisX.Title != null)
            {
                chartTotalContract.ChartAreas[0].AxisX.Title = GetLocalizedString("lbWeek");
            }

            if (chartTotalContract.ChartAreas[0].AxisY.Title != null)
            {
                chartTotalContract.ChartAreas[0].AxisY.Title = GetLocalizedString("lbTotalContract");
            }
            #endregion

            if (chartContractStatus.Titles.Count > 0 && chartContractStatus.Titles[0].Text != null)
            {
                chartContractStatus.Titles[0].Text = GetLocalizedString("lbContractStatus");
            }

            #region revenue
            if (chartRevenue.Titles.Count > 0 && chartRevenue.Titles[0].Text != null)
            {
                chartRevenue.Titles[0].Text = GetLocalizedString("lbTotalRevenue");
            }

            if (chartRevenue.ChartAreas[0].AxisX.Title != null)
            {
                chartRevenue.ChartAreas[0].AxisX.Title = GetLocalizedString("lbWeek");
            }

            if (chartRevenue.ChartAreas[0].AxisY.Title != null)
            {
                chartRevenue.ChartAreas[0].AxisY.Title = GetLocalizedString("lbTotalRevenue");
            }
            #endregion

            #region payment stage
            if (chartPaymentStage.Titles.Count > 0 && chartPaymentStage.Titles[0].Text != null)
            {
                chartPaymentStage.Titles[0].Text = GetLocalizedString("lbPaymentStage");
            }

            if (chartPaymentStage.ChartAreas[0].AxisX.Title != null)
            {
                chartPaymentStage.ChartAreas[0].AxisX.Title = GetLocalizedString("lbPaymentDate");
            }

            if (chartPaymentStage.ChartAreas[0].AxisY.Title != null)
            {
                chartPaymentStage.ChartAreas[0].AxisY.Title = GetLocalizedString("lbAccummulate");
            }
            #endregion
        }

        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);

        private void LoadTotalContractPerWeek(DateTime dateTime)
        {
            chartTotalContract.Series.Clear();
            chartTotalContract.Titles.Clear();
            chartTotalContract.Titles.Add(GetLocalizedString("lbContactPerWeek"));

            var contractData = chartDLL.GetTotalContractPerWeek(dateTime);
            Series series = new Series
            {
                Name = "Contracts",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            foreach (var entry in contractData)
            {
                if (entry.Value > 0)
                {
                    series.Points.AddXY(entry.Key, entry.Value);
                }
            }

            chartTotalContract.ChartAreas[0].AxisX.Title = $"{GetLocalizedString("lbWeek")} {dateTime.Month}";
            chartTotalContract.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chartTotalContract.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chartTotalContract.ChartAreas[0].AxisY.Title = GetLocalizedString("lbTotalContract");
            chartTotalContract.ChartAreas[0].AxisY.Interval = 1;
            chartTotalContract.ChartAreas[0].AxisY.LabelStyle.Format = "0";
            chartTotalContract.Series.Add(series);
        }

        private void LoadContractStatus(DateTime dateTime)
        {
            chartContractStatus.Series.Clear();
            chartContractStatus.Titles.Clear();
            chartContractStatus.Titles.Add(GetLocalizedString("lbContractStatus"));

            Series pieSeries = new Series("ContractStatus")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            var contractStatusData = chartDLL.GetContractStatus(dateTime);
            foreach (var entry in contractStatusData)
            {
                pieSeries.Points.AddXY(entry.Key, entry.Value);
            }
            chartContractStatus.Series.Add(pieSeries);
        }

        private void LoadRevenue(DateTime dateTime)
        {
            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();
            chartRevenue.Titles.Add(GetLocalizedString("lbTotalRevenue"));
            Series revenueSeries = new Series(GetLocalizedString("lbTotalRevenue"))
            {
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true
            };

            var contractRevenueData = chartDLL.GetRevenue(dateTime);
            foreach (var entry in contractRevenueData)
            {
                revenueSeries.Points.AddXY(entry.Key, entry.Value);
            }
            chartRevenue.Series.Add(revenueSeries);

            chartRevenue.ChartAreas[0].AxisX.Title = GetLocalizedString("lbWeek");
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = 1;

            chartRevenue.ChartAreas[0].AxisY.Title = GetLocalizedString("lbTotalRevenue");
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";
            chartRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void LoadPaymentStage(DateTime dateTime)
        {
            chartPaymentStage.Series.Clear();
            chartPaymentStage.Titles.Clear();
            chartPaymentStage.Titles.Add(GetLocalizedString("lbPaymentStage"));

            var paymentStages = chartDLL.GetPaymentStagesWithColors(dateTime);
            foreach (var (stage, barColor) in paymentStages)
            {
                Series series;
                if (chartPaymentStage.Series.IndexOf(stage.contractCode) == -1)
                {
                    series = new Series(stage.contractCode)
                    {
                        ChartType = SeriesChartType.RangeBar,
                        XValueType = ChartValueType.DateTime,
                        Color = barColor,
                    };
                    chartPaymentStage.Series.Add(series);
                }
                else
                {
                    series = chartPaymentStage.Series[stage.contractCode];
                }

                if (series.Points.Count > 0)
                {
                    double previousAmount = series.Points[series.Points.Count - 1].YValues[1];
                    series.Points.AddXY(stage.paymentDate, previousAmount, stage.cumulativeAmount);
                }
                else
                {
                    series.Points.AddXY(stage.paymentDate, 0, stage.cumulativeAmount);
                }
            }

            chartPaymentStage.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chartPaymentStage.ChartAreas[0].AxisY.Minimum = 0;
            chartPaymentStage.ChartAreas[0].RecalculateAxesScale();
            chartPaymentStage.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartPaymentStage.ChartAreas[0].AxisX.Title = GetLocalizedString("lbPaymentDate");
            chartPaymentStage.ChartAreas[0].AxisY.Title = GetLocalizedString("lbAccummulate");
        }

        private void ShowChartData(DateTime dateTime)
        {
            try
            {
                LoadTotalContractPerWeek(dateTime);
                LoadContractStatus(dateTime);
                LoadRevenue(dateTime);
                LoadPaymentStage(dateTime);

                var message = SettingContext.Language == "vi" ?
                    "Không có dữ liệu" : "No data";

                if (chartTotalContract.Series.Count == 0 || chartTotalContract.Series[0].Points.Count == 0)
                {
                    lbTotalContractErr.Text = message;
                }

                if (chartContractStatus.Series.Count == 0 || chartContractStatus.Series[0].Points.Count == 0)
                {
                    lbContractStatusErr.Text = message;
                }

                if (chartRevenue.Series.Count == 0 || chartRevenue.Series[0].Points.Count == 0)
                {
                    lbRevenueErr.Text = message;
                }

                if (chartPaymentStage.Series.Count == 0 || chartPaymentStage.Series[0].Points.Count == 0)
                {
                    lbPaymentStageErr.Text = message;
                }
            }
            catch (BuisinessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                var message = SettingContext.Language == "vi" ?
                    "Có lỗi xảy ra khi tải dữ liệu" : "An error occurred while loading data";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            int selectedMonth = dateTimePicker.Value.Month;
            int selectedYear = dateTimePicker.Value.Year;

            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            if (selectedYear > currentYear || (selectedYear == currentYear && selectedMonth > currentMonth))
            {
                this.lbDateErr.Text = GetLocalizedString("lbDateErr ");
                return;
            }

            ShowChartData(dateTimePicker.Value);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.lbContractStatusErr.Text = this.lbDateErr.Text
                = this.lbPaymentStageErr.Text = this.lbRevenueErr.Text
                = this.lbTotalContractErr.Text = "";
        }

        private void chartContractStatus_Click(object sender, EventArgs e) => OpenStatusReport?.Invoke(sender, e);
        private void chartTotalContract_Click(object sender, EventArgs e) => OpenQuantityReport?.Invoke(sender, e);
        private void chartPaymentStage_Click(object sender, EventArgs e) => OpenPaymentReport?.Invoke(sender, e);
        private void chartRevenue_Click(object sender, EventArgs e) => OpenRevenueReport?.Invoke(sender, e);
    }
}
