using RideXpress.BLL;
using RideXpress.Models;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideXpress_StarterKit
{
    public partial class EditReport : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarBLL carBL = new CarBLL(connectionString);
                ReportBLL reportBL = new ReportBLL(connectionString);
                ReportViewModel report = reportBL.GetReportById(Convert.ToInt32(Request.QueryString["ReportID"]));

                List<CarViewModel> cars = new List<CarViewModel>(carBL.GetCarInventory());

                foreach (var car in cars)
                {
                    ddlRide.Items.Insert(cars.IndexOf(car), new ListItem(car.Name.ToString(), car.CarID.ToString()));
                }

                tbIncidentDate.Text = report.DateOfIncident.ToString();
                tbReportName.Text = report.ReportName.ToString();
                tbDescription.Text = report.ReportDescription;
            }
        }

        protected void btnEditReport_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                ReportBLL reportBL = new ReportBLL(connectionString);
                ReportViewModel report = new ReportViewModel();
                report.CarID = Convert.ToInt32(ddlRide.SelectedValue);
                report.DateOfIncident = Convert.ToDateTime(tbIncidentDate.Text);
                report.ReportName = tbReportName.Text;
                report.ReportDescription = tbDescription.Text;
                report.DateOfReport = DateTime.Now;
                reportBL.EditReport(report);
                Response.Redirect("~/Reports.aspx");
            }
        }
    }
}