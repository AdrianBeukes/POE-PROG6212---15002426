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
using System.Collections;

namespace ProgAss1
{
    public partial class frmUpdate : Form
    {
        frmDisplay DisplayForm = new frmDisplay();
        //**********************************************************************************************
        public string Update                                            //allows update of a label in this form from another form
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
        //**********************************************************************************************
        public frmUpdate()
        {
            InitializeComponent();
        }
        //**********************************************************************************************
        private void btnExit_Click(object sender, EventArgs e)      //exit
        {
            Environment.Exit(0);
        }
        //**********************************************************************************************
        private void btnBack_Click(object sender, EventArgs e)      //back
        {
            using (StreamReader sr = new StreamReader("Appointments.txt"))                 //opens file reader, where stock was saved from main menu
            {
                var line = "";                                                        //decalration
                while ((line = sr.ReadLine()) != null)                              //read files untill there is nothing left
                {
                    DisplayForm.Appointments = line;                                    //add files to the list box
                }
            }
            this.Hide();                                                             //hides current form
            DisplayForm.Show();                                                      // Shows the Display form
        }
        //**********************************************************************************************
        private void btnUpdate_Click(object sender, EventArgs e)        //update
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
            //checks for empty text box
            if (string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtSurname.Text) && string.IsNullOrWhiteSpace(txtNumber.Text) && string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please Fill in all fields");
            }
            else
            {
                using (StreamWriter SW = File.AppendText("Appointments2.txt"))              //writes the updated entry
                {
                    string line2 = txtName.Text + "\t\t" + txtSurname.Text + "\t\t" + txtNumber.Text + "\t" + txtDateTime.Text + "\t" + txtDescription.Text;
                    SW.WriteLine(line2);
                }
            }

            string line3 = null;
            using (StreamReader reader = new StreamReader("Appointments2.txt"))
            {
                using (StreamWriter writer = new StreamWriter("Appointments.txt"))        //writes all updated information back to the 1st text file
                {
                    while ((line3 = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line3);
                    }
                }
            }
            MessageBox.Show("Appointment has been Updated");

            using (StreamReader sr = new StreamReader("Appointments.txt"))                 //opens file reader, where stock was saved from main menu
            {
                var line4 = "";                                                      //decalration
                while ((line4 = sr.ReadLine()) != null)                              //read files untill there is nothing left
                {
                    DisplayForm.Appointments = line4;                                        //add files to the list box
                }
            }
            this.Hide();                                                             //hides current form
            DisplayForm.Show();                                                      // Shows the Display form 
        }
        //**********************************************************************************************
        private void mnuHelp_Click(object sender, EventArgs e)      //menu Help
        {
            this.Hide();
            frmHelp Help = new frmHelp();
            Help.Show();
        }
        //**********************************************************************************************
        private void mnuAbout_Click(object sender, EventArgs e)     //menu about
        {
            this.Hide();
            frmAbout About = new frmAbout();
            About.Show();
        }
        //**********************************************************************************************
        private void mnuSignOut_Click(object sender, EventArgs e)       //menu logout
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }
        //**********************************************************************************************
        private void mnuExit_Click(object sender, EventArgs e)      //menu exit
        {
            Environment.Exit(0);
        }
        //**********************************************************************************************
    }
}
