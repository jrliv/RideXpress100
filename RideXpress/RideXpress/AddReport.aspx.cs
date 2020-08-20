using RideXpress.BLL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideXpress_StarterKit
{
    public partial class AddReport : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarBLL bll = new CarBLL(connectionString);
                List<CarViewModel> cars = new List<CarViewModel>(bll.GetCarInventory());

                foreach (var car in cars)
                {
                    ddlRide.Items.Insert(cars.IndexOf(car), new ListItem(car.Name.ToString(), car.CarID.ToString()));
                }
            }
        }

        protected void btnAddReport_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                ReportBLL bll = new ReportBLL(connectionString);
                ReportViewModel report = new ReportViewModel();
                report.CarID = Convert.ToInt32(ddlRide.SelectedValue);
                report.DateOfIncident = Convert.ToDateTime(tbIncidentDate.Text);
                report.ReportName = tbReportName.Text;
                report.ReportDescription = tbDescription.Text;
                report.DateOfReport = DateTime.Now;
                bll.AddReport(report);
                Response.Redirect("~/Reports.aspx");
            }
        }
    }
}