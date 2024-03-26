using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SomerenService
{
    public class ReportService
    {
        private ReportDao reportdb;

        public ReportService()
        {
            reportdb = new ReportDao();
        }

        public List<Report> GetReport()
        {
            return reportdb.GetReport();
        }

        public List<Report> GetReportBetweenDates(DateTime startDate, DateTime endDate)
        {
            return reportdb.GetReportBetweenDates(startDate, endDate);
        }

        public (int, double, string) GetTurnover(List<Report> reports)
        {
            int totalDrinksSold = reports.Sum(r => r.DrinksAmount);
            double totalTurnover = CalculateTurnover(reports);

            return (reports.Count, totalDrinksSold, totalTurnover.ToString("C"));
        }
        private double CalculateTurnover(List<Report> reports)
        {
            double totalTurnover = 0;

            foreach (var report in reports)
            {
                totalTurnover += report.DrinksAmount * report.TotalPrice;
            }

            return totalTurnover;
        }
    }
}