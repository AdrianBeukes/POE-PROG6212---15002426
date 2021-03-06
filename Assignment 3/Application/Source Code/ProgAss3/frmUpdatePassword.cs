﻿//Name: Adrian Beukes
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
    public partial class frmUpdatePassword : Form
    {
        public frmUpdatePassword()
        {
            InitializeComponent();
        }
        //**********************************************************************************************************
        private void btnBack_Click(object sender, EventArgs e)      //back
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }
        //**********************************************************************************************************
        private void btnReset_Click(object sender, EventArgs e)     //reset
        {
            try
            {
                txtName = null;
                txtPassword = null;
                txtNewPass = null;
                txtConfirmPass = null;
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show("error occured" + error.Message);
            }
            catch(Exception error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
        }
        //**********************************************************************************************************
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
                    if (txtNewPass.Text.Equals(txtConfirmPass.Text))                                    //checks that new password and retyped password matches
                    {
                        string line = null;
                        string lineDelete = txtName.Text + "," + txtPassword.Text;                                   //get selected line to update

                        using (StreamReader reader = new StreamReader("Login.txt"))
                        {
                            using (StreamWriter writer = new StreamWriter("Login2.txt"))        //need new text file to save updated information on
                            {
                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (String.Compare(line, lineDelete) == 0)                  //removes the line when match is found
                                        continue;
                                    writer.WriteLine(line);
                                }
                            }
                        }
                        //checks for empty text box
                        if (string.IsNullOrWhiteSpace(txtName.Text))
                        {
                            MessageBox.Show("Please Fill in a Name");
                        }
                        else if (string.IsNullOrWhiteSpace(txtPassword.Text))
                        {
                            MessageBox.Show("Please Fill  old Password field");
                        }
                        if (string.IsNullOrWhiteSpace(txtNewPass.Text))
                        {
                            MessageBox.Show("Please Fill in new Password field");
                        }
                        if (string.IsNullOrWhiteSpace(txtConfirmPass.Text))
                        {
                            MessageBox.Show("Please Fill in confirmation of new password");
                        }
                        else
                        {
                            using (StreamWriter SW = File.AppendText("Login2.txt"))              //writes the updated entry
                            {
                                string line2 = txtName.Text + "," + txtNewPass.Text;
                                SW.WriteLine(line2);
                            }
                        }
                        using (StreamReader reader = new StreamReader("Login2.txt"))
                        {
                            using (StreamWriter writer = new StreamWriter("Login.txt"))        //writes all updated information back to the 1st text file
                            {
                                while ((line = reader.ReadLine()) != null)
                                {
                                    writer.WriteLine(line);
                                }
                            }
                        }
                        MessageBox.Show("Users password has been updated");

                        this.Hide();                                                       //hides current form
                        frmLogin loginForm = new frmLogin();                               // Create a new instance of the Form class

                        loginForm.Show();                                                  // Shows the login form
                    }
                    else
                        MessageBox.Show("The password does not match the retyped password");
                }
                else
                {
                    MessageBox.Show("registration failed, get an valid user to register new users");    //message failed to register
                }
            }
            catch (OverflowException error)
            {
                MessageBox.Show("error occured" + error.Message);
            }
            catch (OutOfMemoryException error)
            {
                MessageBox.Show("error occured" + error.Message);
            }
            catch (NoNullAllowedException error)
            {
                MessageBox.Show("error occured" + error.Message);
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show("error occured" + error.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
        }
        //**********************************************************************************************************
    }
}
