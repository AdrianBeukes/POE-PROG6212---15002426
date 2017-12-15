//Name: Adrian Beukes
//Student Number: 15002426
//Date: 10 August 2016
//Description: this is my program assignment 1, I created a Patient appointment display list
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

namespace ProgAss1
{
    public partial class frmMainMenu : Form
    {
        //********************************************************************************************************
        public frmMainMenu()
        {
            InitializeComponent();
            Information();
        }
        //********************************************************************************************************
        private void btnExit_Click(object sender, EventArgs e)      //Exit
        {
            Environment.Exit(0);
        }
        //********************************************************************************************************
        private void btnSignOut_Click(object sender, EventArgs e)       //sign-out
        {
            this.Hide();
            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
        }
        //********************************************************************************************************
        private void btnSearch_Click(object sender, EventArgs e)        //Search
        {
            this.Hide();
            frmSearch SearchForm = new frmSearch();
            SearchForm.Show();
        }
        //********************************************************************************************************
        private void btnView_Click(object sender, EventArgs e)      //View Appointments
        {
            frmDisplay DisplayForm = new frmDisplay();

            using (StreamReader sr = new StreamReader("Appointments.txt"))                 //opens file reader, where Appointments are saved
            {
                var line = "";                                                        //decalration
                while ((line = sr.ReadLine()) != null)                              //read files untill there is nothing left
                {
                    DisplayForm.Appointments = line;                                    //add files to the list box
                }
            }
            this.Hide();
            DisplayForm.Show();
        }
        //********************************************************************************************************
        private void btnCreate_Click(object sender, EventArgs e)        //Create Appointment
        {
            this.Hide();
            frmCreateAppointment SearchForm = new frmCreateAppointment();
            SearchForm.Show();
        }
        //********************************************************************************************************
        public void Information()       //gives bit information about users, name and time signed in
        {
            //lblAnsName.Text = *Person signed in*;
            lblAnsTimeSignedIn.Text = DateTime.Now.ToString();
        }
        //********************************************************************************************************
        private void timerClock_Tick(object sender, EventArgs e)        //clock
        {
           lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt");   //gives a live time with intervals
        }
        //********************************************************************************************************
        private void mnuHelp_Click(object sender, EventArgs e)      //menu help
        {
            this.Hide();
            frmHelp Help = new frmHelp();
            Help.Show();
        }
        //********************************************************************************************************
        private void mnuAbout_Click(object sender, EventArgs e)     //menu about
        {
            this.Hide();
            frmAbout About = new frmAbout();
            About.Show();
        }
        //********************************************************************************************************
        private void mnuSignOut_Click(object sender, EventArgs e)       //menu logout
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }
        //********************************************************************************************************
        private void mnuExit_Click(object sender, EventArgs e)      //menu exit
        {
            Environment.Exit(0);
        }
        //********************************************************************************************************
    }
}
