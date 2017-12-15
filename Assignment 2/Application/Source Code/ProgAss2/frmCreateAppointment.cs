//Name: Adrian Beukes
//Student Number: 15002426
//Date: 26 September 2016
//Description: this is my program assignment 2, I created a Patient appointment display list from a database
//              The main function needed for the program was adding, removing and editing appointments to a
//              health centre, as well as a login screen that will allow and give a bit of safety and confidentiallity
//              so that just staff may access the informatioin.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ProgAss2
{
    public partial class frmCreateAppointment : Form
    {
        public frmCreateAppointment()
        {
            InitializeComponent();
            frmMainMenu MainMenu = new frmMainMenu();
            DateTimePickers();
        }
        //*****************************************************************************************
        private void DateTimePickers()                              //only allows for date picking of current date and future dates
        {
            DatePicker.MinDate = DateTime.Today;
        }
        //*****************************************************************************************
        private void btnExit_Click(object sender, EventArgs e)      //Exit
        {
            Environment.Exit(0);
        }
        //*****************************************************************************************
        private void btnCancel_Click(object sender, EventArgs e)        //Cancel
        {
            this.Hide();
            frmMainMenu MainMenu = new frmMainMenu();
            MainMenu.Show();
        }
        //*****************************************************************************************
        private void btnSubmit_Click(object sender, EventArgs e)        //Submit
        {
            //checks for empty text box and force you to enter something
            if (string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtSurname.Text) && string.IsNullOrWhiteSpace(txtNumber.Text) && string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please Fill in all fields");
            }

            else
            {
                    String ConnectionString = "Data Source=MSI;" + "Initial Catalog=DFH;" + "Integrated Security=SSPI;";

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Appointments (NAME, SURNAME, PHONE_NUMBER, DATE, TIME, DESCRIPTION) VALUES (@Name, @Surname, @PhoneNumber, @Date, @Time, @Description)");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtNumber.Text);
                        cmd.Parameters.AddWithValue("@Date", DatePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@Time", cboxTime.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("New Appointment has been Succesfully Scheduled");

                    txtName.Text = null;
                    txtSurname.Text = null;
                    txtNumber.Text = null;
                    cboxTime.SelectedItem = null;
                    txtDescription.Text = null;
                }
        }
        //*****************************************************************************************
        private void mnuHelp_Click(object sender, EventArgs e)      //menu help
        {
            this.Hide();
            frmHelp Help = new frmHelp();
            Help.Show();
        }
        //*****************************************************************************************
        private void mnuAbout_Click(object sender, EventArgs e)     //menu About
        {
            this.Hide();
            frmAbout About = new frmAbout();
            About.Show();
        }
        //*****************************************************************************************
        private void mnuExit_Click(object sender, EventArgs e)      //menu exit
        {
            Environment.Exit(0);
        }
        //*****************************************************************************************
        private void mnuSignOut_Click(object sender, EventArgs e)       //menu signout
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }
        //*****************************************************************************************
    }
}
