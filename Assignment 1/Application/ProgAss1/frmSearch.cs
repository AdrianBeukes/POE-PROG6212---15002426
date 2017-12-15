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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        //*******************************************************************************************
        private void btnExit_Click(object sender, EventArgs e)      //Exit
        {
            Environment.Exit(0);
        }
        //*******************************************************************************************
        private void btnBack_Click(object sender, EventArgs e)      //Back
        {
            this.Hide();
            frmMainMenu mainmenu = new frmMainMenu();
            mainmenu.Show();
        }
        //*******************************************************************************************
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmDisplay Display = new frmDisplay();

            using (StreamReader sr = new StreamReader("Appointments.txt"))             //loads text file
            {
                string line;
                while ((line = sr.ReadLine()) != null)                          //reads text file, until there is a match or no more lines to read
                {
                    if (line.Contains(txtSearch.Text))
                    {
                        Display.Appointments = line;
                    }
                }
            }
            MessageBox.Show("If no clients are displayed, it means there was no match found");
            this.Hide();
            Display.Show();
        }
        //*******************************************************************************************
        private void mnuHelp_Click(object sender, EventArgs e)      //menu help
        {
            this.Hide();
            frmHelp Help = new frmHelp();
            Help.Show();
        }
        //*******************************************************************************************
        private void mnuAbout_Click(object sender, EventArgs e)     //menu about
        {
            this.Hide();
            frmAbout About = new frmAbout();
            About.Show();
        }
        //*******************************************************************************************
        private void mnuSignOut_Click(object sender, EventArgs e)       //menu signout
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }
        //*******************************************************************************************
        private void mnuExit_Click(object sender, EventArgs e)      //menu exit
        {
            Environment.Exit(0);
        }
        //*******************************************************************************************
    }
}
