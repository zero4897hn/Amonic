using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BU;
using Utilities;

namespace Amonic
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlDataAccession accession = new SqlDataAccession();
        int loginFailTime = 3;
        int loginTimeLeft = 10;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginFailTime != 0)
                {
                    if (accession.LoginCheck(txtUsername.Text, Encryption.ConvertToMD5(txtPassword.Text)))
                    {
                        if (accession.IsEmailActive(txtUsername.Text))
                        {
                            if (accession.GetUsersRole(txtUsername.Text) == "Administrator")
                            {
                                frmAmonicAirlinesAutomationSystem frm = new frmAmonicAirlinesAutomationSystem();
                                frm.Email = txtUsername.Text;
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                frmAmonicAirlinesAutomationSystemForUser frm = new frmAmonicAirlinesAutomationSystemForUser();
                                frm.lblWelcome.Text = "Hi " + accession.GetUserFirstName(txtUsername.Text) + ", Welcome to AMONIC Airlines.";
                                frm.Email = txtUsername.Text;
                                frm.Show();
                                this.Hide();
                            }
                        }
                        else MessageBox.Show("Your email is not activated.\r\nPlease call administrator to activate your email.");
                    }
                    else
                    {
                        loginFailTime--;
                        if (loginFailTime != 0) MessageBox.Show("You have entered an invalid username or password.\r\nTry again with another username or password.\r\nYou have " + loginFailTime + " time(s) left to login.");
                        else
                        {
                            lblLoggingNotification.Text = "Your login time is over. Try again after 10 second(s).";
                            timer1.Enabled = true;
                            MessageBox.Show("Your login time is over. Try again after 10 second(s).");
                        }
                    }
                }
                else MessageBox.Show("Your login time is over. Try again after " + loginTimeLeft + " second(s).");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loginTimeLeft--;
            lblLoggingNotification.Text = "Your login time is over. Try again after " + loginTimeLeft + " second(s).";
            if (loginTimeLeft == 0)
            {
                loginFailTime = 3;
                loginTimeLeft = 10;
                lblLoggingNotification.Text = "";
                timer1.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
