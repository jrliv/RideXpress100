using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.DAL
{
    class ReportDAL
    {
        private string _connectionString;
        public ReportDAL(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<ReportViewModel> GetReportInventory()
        {
            string sqlQuery = "SELECT * FROM IncidentReport";
            List<ReportViewModel> reports = new List<ReportViewModel>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReportViewModel temp = new ReportViewModel()
                        {

                        };
                        reports.Add(temp);
                    }
                }
            }
            return reports;
        }

        public ReportViewModel GetReportById(int id)
        {

        }
        public int EditCar(ReportViewModel edit)
        {

        }
        public int AddCar(ReportViewModel add)
        {

        }
        public int DeleteCar(int id)
        {

        }
    }
}
