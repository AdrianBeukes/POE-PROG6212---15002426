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
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.Collections;

namespace ProgAss2
{
    public partial class frmDisplay : Form
    {
        //***********************************************************************************************
        private Font printFont;                                     //importing print functionality
        private StreamReader streamToPrint;
        //***********************************************************************************************
        public frmDisplay()
        {
            InitializeComponent();
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
            try
            {
                foreach (DataGridViewRow item in this.dataGridViewInfo.SelectedRows)
                {
                    if (MessageBox.Show("Are you Sure you want to Delete Entry?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        dataGridViewInfo.Rows.RemoveAt(item.Index);
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please select the entire row in the table to delete this Appointment", "Delete Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //***********************************************************************************************
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
        private void frmDisplay_Load(object sender, EventArgs e)        //loads data
        {
            // Loads the data into the gridview
            this.appointmentsTableAdapter.Fill(this.dFHDataSet.Appointments);
        }
        //***********************************************************************************************
        private void btnAdd_Click(object sender, EventArgs e)       //Add new entry button
        {
            this.Hide();
            frmCreateAppointment Create = new frmCreateAppointment();
            Create.Show();
        }
        //***********************************************************************************************
        private void btnSearch_Click_1(object sender, EventArgs e)      //search button
        {
            string searchValue = txtSearch.Text;
            int rowIndex = 1;                                           //specify position of name column

            dataGridViewInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool Result = true;
                foreach (DataGridViewRow row in dataGridViewInfo.Rows)
                {
                    while (row.Cells[rowIndex].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridViewInfo.Rows[rowIndex].Selected = true;
                        rowIndex++;
                        Result = false;
                    }
                }
                if (Result != false)
                {
                    MessageBox.Show("Entry not found for name searched, make sure it is spelled correctly, and remember case sensitivity for -> " + txtSearch.Text, "No Entry Found");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //***********************************************************************************************h
        private void btnUpdate_Click(object sender, EventArgs e)        //save update button
        {
            MessageBox.Show("Your Appointments has been updated", "Appointment Update", MessageBoxButtons.OK, MessageBoxIcon.Information);        
        }
        //***********************************************************************************************
    }
}
