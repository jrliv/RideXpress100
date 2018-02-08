using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.Models
{
    // This is a POCO that represents the model of a report.
    class ReportViewModel
    {
        public int ReportID { get; set; }
        public int CarID { get; set; }
        public string CarName { get; set; } // Property to represent the name of the car.
        public DateTime GetDateOfIncident { get; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public DateTime GetDateOfReport { get; }
    }
}

/* Just like TraineeViewModel, you will now create a View Model or POCO (Plain Old CLR Object) for Incident Reports to the RideXpress.Models project.

The ReportViewModel should have properties that represent the columns in the Incident Report table in the database. Check out the CarViewModel to get a better idea of how it should look like.

Properties are covered in the Constructors & References video if you want to review how to use properties.

In addition to the properties representing the columns in the database, you will need to add read-only properties that will be used to display the DateTime properties of the Incident Report table.

Also you will need to add a property representing the Name of the Car, since they need to be displayed in the Report listing. Check out the Showcase project in order to see how the Report Listing should look like:

http://showcase.revature.com/ridexpress100/Reports.aspx */
