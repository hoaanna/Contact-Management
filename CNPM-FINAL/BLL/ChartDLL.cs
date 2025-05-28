using CNPM_FINAL.DAL;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CNPM_FINAL.BLL
{
    public class ChartDLL
    {
        private readonly ChartDAL chartDAL = new ChartDAL();
        public List<KeyValuePair<string, int>> GetTotalContractPerWeek(DateTime dateTime)
        {
            int currentYear = dateTime.Year;
            int currentMonth = dateTime.Month;
            return chartDAL.GetTotalContractByMonth(currentYear, currentMonth);
        }

        public List<KeyValuePair<string, int>> GetContractStatus(DateTime dateTime)
        {
            int currentYear = dateTime.Year;
            int currentMonth = dateTime.Month;
            return chartDAL.GetContractStatusCountByMonth(currentYear, currentMonth);
        }

        public List<KeyValuePair<string, int>> GetRevenue(DateTime dateTime)
        {
            int currentYear = dateTime.Year;
            int currentMonth = dateTime.Month;
            return chartDAL.GetRevenueByMonth(currentYear, currentMonth);
        }

        public List<(PaymentStage, Color)> GetPaymentStagesWithColors(DateTime dateTime)
        {
            int currentYear = dateTime.Year;
            int currentMonth = dateTime.Month;
            var stages = chartDAL.GetPaymentStages(currentYear, currentMonth);
            List<(PaymentStage, Color)> stagesWithColors = new List<(PaymentStage, Color)>();
            Random rand = new Random();

            foreach (var stage in stages)
            {
                Color barColor;
                double remainingAmount = stage.totalValue - stage.cumulativeAmount;

                if (remainingAmount <= 0)
                    barColor = Color.Black;
                else if (DateTime.Now > stage.expirationDate)
                    barColor = Color.Red;
                else
                    barColor = Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256));

                stagesWithColors.Add((stage, barColor));
            }

            return stagesWithColors;
        }
    }
}
