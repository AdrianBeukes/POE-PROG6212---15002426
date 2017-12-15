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
using System.Drawing.Printing;

namespace ProgAss1
{
    public partial class frmDisplay : Form
    {
        //***********************************************************************************************
        private System.Windows.Forms.Button printButton;
        private Font printFont;
        private StreamReader streamToPrint;
        //***********************************************************************************************
        public dynamic Appointments     //allows inheritance from other forms
        {
            get
            {
                return this.lstBoxDisplay.Items;
            }
            set
            {
                this.lstBoxDisplay.Items.Add(value);
            }
        }
        //***********************************************************************************************
        public frmDisplay()
        {
            InitializeComponent();
        }
        //***********************************************************************************************
        private void btnSearch_Click(object sender, EventArgs e)        //search
        {
            this.Hide();
            frmSearch Search = new frmSearch();
            Search.Show();
        }
        //***********************************************************************************************
        private void btnExit_Click(object sender, EventArgs e)      //exit
        {
            Environment.Exit(0);
        }
        //***********************************************************************************************
        private void btnBack_Click(object sender, EventArgs e)      //back
        {
            this.Hide();
            frmMainMenu MainMenu = new frmMainMenu();
            MainMenu.Show();
        }
        //***********************************************************************************************
        private void btnDelete_Click(object sender, EventArgs e)        //delete
        {
            frmDelete DeleteForm = new frmDelete();                                     // Create a new instance of the Form class
            if (lstBoxDisplay.SelectedIndex == -1)                                        //checks to see if listbox is selected
                MessageBox.Show("Please select an product to update first");
            else
            {
                DeleteForm.dlt = lstBoxDisplay.SelectedItem.ToString();                   //adds listbox item selected to Delete form
                this.Hide();                                                            //hides current form
                DeleteForm.Show();                                                      // Shows the Delete form
            }
        }
        //***********************************************************************************************
        private void btnUpdate_Click(object sender, EventArgs e)        //update
        {
            frmUpdate UpdateForm = new frmUpdate();                                     // Create a new instance of the Form class
            if (lstBoxDisplay.SelectedIndex == -1)                                        //checks to see if listbox is selected
                MessageBox.Show("Please select an product to update first");
            else
            {
                UpdateForm.Update = lstBoxDisplay.SelectedItem.ToString();                //adds listbox item selected to Update form
                this.Hide();                                                            //hides current form
                UpdateForm.Show();                                                      // Shows the Update form
            }
        }
        //***********************************************************************************************
        private void btnPrint_Click(object sender, EventArgs e)     //printing report  //note only prints txt file
        {
            try
            {
                streamToPrint = new StreamReader("Appointments.txt");       //gets file to be printed
                try
                {
                    printFont = new Font("Arial", 10);                      //sets size, font, how many pages
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                                //exception handler message
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)      // The PrintPage event is raised for each page to be printed.
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            linesPerPage = ev.MarginBounds.Height /                 // determines how many lines can be printed on the page
               printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage &&                          //starts printing each line
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)                                        // if there is stil lines left, it continue's on the next page
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
        //***********************************************************************************************
        private void mnuHelp_Click(object sender, EventArgs e)      //menu help
        {
            this.Hide();
            frmHelp Help = new frmHelp();
            Help.Show();
        }
        //***********************************************************************************************
        private void mnuAbout_Click(object sender, EventArgs e)     //menu about
        {
            this.Hide();
            frmAbout About = new frmAbout();
            About.Show();
        }
        //***********************************************************************************************
        private void mnuSignOut_Click(object sender, EventArgs e)       //menu signout
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }
        //***********************************************************************************************
        private void mnuExit_Click(object sender, EventArgs e)      //menu exit
        {
            Environment.Exit(0);
        }
        //***********************************************************************************************
    }
}
