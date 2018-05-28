﻿using RideXpress.DAL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.BLL
{
    public class ReportBLL
    {
        private ReportDAL data;
        public ReportBLL(string connectionString)
        {
            data = new ReportDAL(connectionString);
        }
        public List<ReportViewModel> GetReportInventory()
        {
            List<ReportViewModel> reports = new List<ReportViewModel>();
            foreach (ReportViewModel model in data.GetReportInventory())
            {
                reports.Add(model);
            }
            return reports;
        }

        public ReportViewModel GetReportById(int id)
        {
            return data.GetReportById(id);
        }

        public int EditReport(ReportViewModel edit)
        {
            return data.EditReport(edit);
        }

        public int AddReport(ReportViewModel add)
        {
            return data.AddReport(add);
        }

        public int DeleteReport(int id)
        {
            return data.DeleteReport(id);
        }
    }
}
