//Name: Adrian Beukes
//Student Number: 15002426
//Date: 7 November 2016
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

namespace ProgFinal
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }
        //****************************************************************************************************
        private void btnSubmit_Click(object sender, EventArgs e)        //submit
        {
            try
            {
                if (cboxreturn.SelectedItem.ToString().Equals("Main menu"))               //see which one equals selected option
                {
                    this.Hide();                                                            //hides current form
                    frmMainMenu MainMenuForm = new frmMainMenu();                           // Create a new instance of the Form class

                    MainMenuForm.Show();                                                    // Shows the MainMenu form
                }
                else if (cboxreturn.SelectedItem.ToString().Equals("Sign-out"))
                {
                    this.Hide();                                                            //hides current form
                    frmLogin LoginForm = new frmLogin();                                    // Create a new instance of the Form class

                    LoginForm.Show();                                                       // Shows the Login form
                }
                else
                    MessageBox.Show("No input selected, Please select an item from the drop down list");   //shows message if no option was chosen
            }
            catch(Exception error)
            {
                MessageBox.Show("error occured" + error.Message);
            }
        }
        //****************************************************************************************************
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //****************************************************************************************************
    }
}
