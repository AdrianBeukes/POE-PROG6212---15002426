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

namespace ProgAss3
{
    public partial class frmMainMenu : Form
    {
        //********************************************************************************************************
        public frmMainMenu()
        {
            InitializeComponent();
            Information();
            timerMessage.Start();
        }
        //********************************************************************************************************
        public void Information()       //gives bit information about users, name and time signed in
        {
            try
            {
                lblAnsTimeSignedIn.Text = DateTime.Now.ToString();
            }
            catch(TimeZoneNotFoundException error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
            catch(Exception error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
        }
        //********************************************************************************************************
        private void timerClock_Tick(object sender, EventArgs e)        //clock
        {
            try
            {
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt");   //gives a live time with intervals
            }
            catch (TimeZoneNotFoundException error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
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
        private void timerMessage_Tick(object sender, EventArgs e)
        {
            try
            {
                lblMovingMessage.Location = new Point(lblMovingMessage.Location.X + 5, lblMovingMessage.Location.Y);

                if (lblMovingMessage.Location.X > this.Width)
                {
                    lblMovingMessage.Location = new Point(0 - lblMovingMessage.Width, lblMovingMessage.Location.Y);

                    lblMovingMessage.Text = "Always Be Thankfull....Every Smile Can Change A Life....Changing The World Through Smiles";
                }
            }
            catch(ConstraintException error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
        }
        //********************************************************************************************************
        private void rbtnCreate_Click(object sender, EventArgs e)       //create new appointment button
        {
            this.Hide();
            frmCreateAppointment SearchForm = new frmCreateAppointment();
            SearchForm.Show();
        }
        //********************************************************************************************************
        private void rbtnView_Click(object sender, EventArgs e)     //view appointment button
        {
            frmDisplay DisplayForm = new frmDisplay();
            this.Hide();
            DisplayForm.Show();
        }
        //********************************************************************************************************
        private void rbtnSignOut_Click(object sender, EventArgs e)      //sign-out button
        {
            this.Hide();
            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
        }
        //********************************************************************************************************
        private void rbtnExit_Click(object sender, EventArgs e)     //exit button
        {
            Environment.Exit(0);
        }
        //********************************************************************************************************
    }
}
