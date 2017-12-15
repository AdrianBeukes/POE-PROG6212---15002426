using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void btnBooking_Click(object sender, EventArgs e)
        {
            Response.Redirect("pgeBooking.aspx"); //navigation towards the booking page
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("pgeAboutUs.aspx"); //navigate to the about us page
        }
    }
}