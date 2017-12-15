using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Master : System.Web.UI.MasterPage
    {
        //navigation to switch between the pages
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("pgeHome.aspx"); //home page
        }

        protected void btnBooking_Click(object sender, EventArgs e)
        {
            Response.Redirect("pgeBooking.aspx"); //booking page
        }

        protected void btnAboutUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("pgeAboutUs.aspx"); //about us page
        }
    }
}