using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WebApp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        //*************************************************************************************************
        protected void btnAvailability_Click(object sender, EventArgs e)    //availability check button
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Messagebox", "alert('Date and Time is available, please go ahead and book, thank you');", true);
            btnBook.Enabled = true;
        }
        //*************************************************************************************************
        protected void btnClear_Click(object sender, EventArgs e)   //clear button
        {
            txtName.Text = null;                                    //clear all field values
            txtSurname.Text = null;
            txtNumber.Text = null;
            txtDescription.Text = null;
        }
        //*************************************************************************************************
        protected void btnBook_Click(object sender, EventArgs e)  //booking button
        {
            if (txtName.Text == "")                               //validation checking
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Messagebox", "alert('Enter Name');", true);
            else if (txtSurname.Text == "")
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Messagebox", "alert('Enter Surname');", true);
            else if (txtNumber.Text == "")
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Messagebox", "alert('Enter Phone Number');", true);
            else if (txtDescription.Text == "")
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Messagebox", "alert('Enter Short Description');", true);
            else
            {
                String ConnectionString = "Data Source=MSI;" + "Initial Catalog=DFH;" + "Integrated Security=SSPI;";        //connecting to database

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Appointments (NAME, SURNAME, PHONE_NUMBER, DATE, TIME, DESCRIPTION) VALUES (@Name, @Surname, @PhoneNumber, @Date, @Time, @Description)");
                    //cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);     //places values into parametes, for insertion into database
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtNumber.Text);
                    cmd.Parameters.AddWithValue("@Date", CalDate.SelectedDate.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Time", DropDwnTime.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Messagebox", "alert('Your Booking has been succesfully made');", true);

                txtName.Text = null;                                        //clears fields after succesfull booking
                txtSurname.Text = null;
                txtNumber.Text = null;
                txtDescription.Text = null;
            }
        }
        //*************************************************************************************************
    }
}