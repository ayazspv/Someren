using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class ReportDao : BaseDao
    {
        public List<Report> GetReport()
        {
            string query = "SELECT [Quantity], [Total Price], [purchase_datetime] FROM orders";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Report> GetReportBetweenDates(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT [Quantity], [Total Price], [purchase_datetime] FROM orders WHERE [purchase_datetime] BETWEEN @StartDate AND @EndDate";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Report> ReadTables(DataTable dataTable)
        {
            List<Report> reports = new List<Report>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Report report = new Report()
                {
                    DrinksAmount = (int)dr["Quantity"],
                    TotalPrice = (double)dr["Total Price"],
                    PurchasedTime = (DateTime)dr["purchase_datetime"]
                };
                reports.Add(report);
            }
            return reports;
        }
    }
}