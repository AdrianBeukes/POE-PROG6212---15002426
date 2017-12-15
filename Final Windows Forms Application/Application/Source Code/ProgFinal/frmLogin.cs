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
using System.IO;
using System.Threading;

namespace ProgFinal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //***************************************************************************************************************
        private void btnExit_Click(object sender, EventArgs e)      //Exit
        {
            Environment.Exit(0);
        }
        //***************************************************************************************************************
        private void btnReset_Click(object sender, EventArgs e)     //reset
        {
            try
            {
                txtName.Text = null;                                                     //makes the fields blank
                txtPassword.Text = null;
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
            catch(Exception error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
        }
        //***************************************************************************************************************
        private void btnChange_Click(object sender, EventArgs e)        //Change Password
        {
            frmUpdatePassword UpdatePasswordForm = new frmUpdatePassword();     //create instance
            this.Hide();
            UpdatePasswordForm.Show();
        }
        //***************************************************************************************************************
        private void btnRegister_Click(object sender, EventArgs e)      //Register
        {
            frmRegister RegisterForm = new frmRegister();
            this.Hide();
            RegisterForm.Show();
        }
        //***************************************************************************************************************
        private void btnSubmit_Click(object sender, EventArgs e)        //submit
        {
            bool Valid = false;

            try
            {
                using (StreamReader sr = new StreamReader("Login.txt"))             //loads text file
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)                          //reads text file, until there is a match or no more lines to read
                    {
                        string[] data = line.Split(',');                            // split up each line between the delimiter
                        if (data[0] == txtName.Text && data[1] == txtPassword.Text)
                        {
                            Valid = true;                                           //places each line in a array, reading it, and looking for an exact match
                            break;
                        }
                    }
                }
                if (Valid)
                {
                    MessageBox.Show("Login Succesfull");                             //message login worked

                    frmMainMenu MainMenuForm = new frmMainMenu();                    // Create a new instance of the Form class

                    this.Hide();                                                     //hides current form

                    //Creating thread for BeginSplash Method so it can start and stop           //when successfully logged in, it will start the splash screen
                    Thread thrd = new Thread(new ThreadStart(BeginLoading));
                    thrd.Start();
                    Thread.Sleep(8500);

                    thrd.Abort();                                                    //when timer stops, so will the splash screen

                    MainMenuForm.Show();                                             // Shows the MainMenu form
                }
                else
                {
                    MessageBox.Show("Login Failed, Please Retry to Login");                                 //message login failed
                }
            }
            catch(NoNullAllowedException error) 
            {
                MessageBox.Show("Error occured " + error.Message);
            }
            catch (TimeoutException error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
            catch(Exception error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
        }
        //***************************************************************************************************************
        public void BeginLoading()                                               //method to call loading screen to appear
        {
            try
            {
                //Runs form (Splash screen)
            Application.Run(new frmLoading());
            }
            catch(Exception error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
        }
        //***************************************************************************************************************
    }
}
