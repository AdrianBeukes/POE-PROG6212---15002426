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

namespace ProgFinal
{
    public partial class frmRegister : Form
    {
        List<string> Accounts = new List<string>();
        public frmRegister()
        {
            InitializeComponent();
        }
        //*********************************************************************************************************
        private void btnRegister_Click(object sender, EventArgs e)      //register user
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
                    if (txtNewPass.Text.Equals(txtConfirm.Text))                                    //checks that new password and retyped password matches
                    {
                        string newAccount = txtNewName.Text + "," + txtNewPass.Text;
                        Accounts.Add(newAccount);                                   //adds the new account to the list
                        using (StreamWriter SW = File.AppendText("Login.txt"))
                        {
                            for (int i = 0; i < Accounts.Count; i++)
                            {
                                SW.WriteLine("\n" + Accounts[i]);                          //saves the new account with a delimiter in the text file
                            }
                        }
                        MessageBox.Show("new user has been registered, and can now login");

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
            catch(Exception error)
            {
                MessageBox.Show("Error occured " + error.Message);
            }
        }
        //*********************************************************************************************************
        private void btnClear_Click(object sender, EventArgs e)     //Clear
        {
            try
            {
                txtName.Text = null;                      //clears the typing fields of all information on this form
                txtPassword.Text = null;
                txtNewName.Text = null;
                txtNewPass.Text = null;
                txtConfirm.Text = null;
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
        //*********************************************************************************************************
        private void btnBack_Click(object sender, EventArgs e)      //Back
        {
            this.Hide();                                                       //hides current form
            frmLogin loginForm = new frmLogin();                               // Create a new instance of the Form class
            loginForm.Show();                                                  // Shows the login form
        }
        //*********************************************************************************************************
    }
}
