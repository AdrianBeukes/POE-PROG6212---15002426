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
    public partial class frmDelete : Form
    {
        frmDisplay DisplayForm = new frmDisplay();
        //*******************************************************************************************************
        public string dlt                                                      //allows for editing of labels in this form, from another form
        {
            get
            {
                return this.lblSelected.Text;
            }
            set
            {
                this.lblSelected.Text = value;
            }
        }
        //*******************************************************************************************************
        public frmDelete()
        {
            InitializeComponent();
        }
        //*******************************************************************************************************
        private void btnYes_Click(object sender, EventArgs e)       //Yes
        {
            string line = null;
            string lineDelete = lblSelected.Text;                                   //get selected product

            using (StreamReader reader = new StreamReader("Appointments.txt"))
            {
                using (StreamWriter writer = new StreamWriter("Appointments2.txt"))        //need new text file to save updated information on
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, lineDelete) == 0)                  //removes the line when match is found on the product
                            continue;
                        writer.WriteLine(line);
                    }
                }
            }
            MessageBox.Show("Appointment has been removed");

            using (StreamReader sr = new StreamReader("Appointments2.txt"))                 //opens file reader, where stock was saved from main menu
            {
                var line2 = "";                                                      //decalration
                while ((line2 = sr.ReadLine()) != null)                              //read files untill there is nothing left
                {
                    DisplayForm.Appointments = line2;                                        //add files to the list box
                }
            }
            this.Hide();                                                             //hides current form
            DisplayForm.Show();                                                      // Shows the Display form
        }
        //*******************************************************************************************************
        private void btnNo_Click(object sender, EventArgs e)        //no
        {
            using (StreamReader sr = new StreamReader("Appointments.txt"))                 //opens file reader, where stock was saved from main menu
            {
                var line2 = "";                                                     //decalration
                while ((line2 = sr.ReadLine()) != null)                             //read files untill there is nothing left
                {
                    DisplayForm.Appointments = line2;                                       //add files to the list box
                }
            }
            this.Hide();                                                             //hides current form
            DisplayForm.Show();                                                      // Shows the Display form
        }
        //*******************************************************************************************************
        private void mnuHelp_Click(object sender, EventArgs e)      //menu help
        {
            this.Hide();
            frmHelp Help = new frmHelp();
            Help.Show();
        }
        //*******************************************************************************************************
        private void mnuAbout_Click(object sender, EventArgs e)     //menu About
        {
            this.Hide();
            frmAbout About = new frmAbout();
            About.Show();
        }
        //*******************************************************************************************************
        private void mnuSignOut_Click(object sender, EventArgs e)       //menu signout
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }
        //*******************************************************************************************************
        private void mnuExit_Click(object sender, EventArgs e)      //menu exit
        {
            Environment.Exit(0);
        }
        //*******************************************************************************************************

    }
}
