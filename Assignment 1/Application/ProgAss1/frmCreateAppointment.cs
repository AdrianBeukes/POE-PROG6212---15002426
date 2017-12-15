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
    public partial class frmCreateAppointment : Form
    {
        public frmCreateAppointment()
        {
            InitializeComponent();
            frmMainMenu MainMenu = new frmMainMenu();
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
                using (StreamWriter SW = File.AppendText("Appointments.txt"))
                {
                    string line = "\n" + txtName.Text + "\t\t" + txtSurname.Text + "\t\t" + txtNumber.Text + "\t" + txtDateTime.Text + "\t" + txtDescription.Text;
                    SW.WriteLine(line);
                    MessageBox.Show("New Appointment has been Succesfully Scheduled");

                    this.Hide();
                    frmMainMenu MainMenu = new frmMainMenu();
                    MainMenu.Show();
                }
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
