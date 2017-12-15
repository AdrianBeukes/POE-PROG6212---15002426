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
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }
        //******************************************************************************************************************
        private void timerLoad_Tick(object sender, EventArgs e)     //timer on the progress bar
        {
            try
            {
                progBarLoad.Increment(1);
                lblPercentage.Text = progBarLoad.Value.ToString() + "%";                    //shows percentage value of progress bar as it increments
                if (progBarLoad.Value == 100)
                    timerLoad.Stop();                                                       //stops the timer if progress bar reaches 100
            }
            catch (TimeoutException error)
            {
                MessageBox.Show("error occured" + error.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show("error occured" + error.Message);
            }
        }
        //******************************************************************************************************************
    }
}
