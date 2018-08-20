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

namespace Amonic
{
    public partial class frmAmonicAirlinesAutomationSystemForUser : Form
    {
        public frmAmonicAirlinesAutomationSystemForUser()
        {
            InitializeComponent();
        }

        SqlDataAccession accession = new SqlDataAccession();

        internal string Email { get; set; }

        private void frmAmonicAirlinesAutomationSystemForUser_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime timeLogin = DateTime.Now;
                ShowTimeLoggingOnListView();
                lblTimeSpentOnSystem.Text = TotalTimeSpent().ToString(@"hh\:mm\:ss");
                lblNumberOfCrashes.Text = CrashesCount() + "";
                if (accession.GetLastTimeLoggingID(accession.GetUserID(Email)) != 0 && accession.LastLogoutTime(Email).ToString(@"hh\:mm\:ss") == "00:00:00")
                {
                    frmNoLogoutDetected frm = new frmNoLogoutDetected();
                    frm.lblNotification.Text = "No logout detected for your last login on " + accession.GetLoginDate(Email).ToString("dd/MM/yyyy") + " at " + accession.GetLoginTime(Email).ToString(@"hh\:mm\:ss");
                    frm.Email = Email;
                    frm.ShowDialog();
                }
                accession.InsertIntoTimeLoggingManagement(Email, timeLogin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int CrashesCount()
        {
            List<TimeLoggingManagement> TimeLoggingManagements = accession.GetTimeLoggingManagement();
            int count = 0;
            foreach (TimeLoggingManagement x in TimeLoggingManagements) if (x.UserID == accession.GetUserID(Email) && x.LogoutTime.ToString(@"hh\:mm\:ss") == "00:00:00") count++;
            return count;
        }

        private TimeSpan TotalTimeSpent()
        {
            List<TimeLoggingManagement> TimeLoggingManagements = accession.GetTimeLoggingManagement();
            TimeSpan total = new TimeSpan(0, 0, 0);
            foreach (TimeLoggingManagement x in TimeLoggingManagements) if (x.UserID == accession.GetUserID(Email)) total += x.TimeSpentOnSystem;
            return total;
        }

        private void ShowTimeLoggingOnListView()
        {
            List<TimeLoggingManagement> TimeLoggingManagements = accession.GetTimeLoggingManagement();
            lvTime.Items.Clear();
            foreach (TimeLoggingManagement x in TimeLoggingManagements) if (x.UserID == accession.GetUserID(Email))
            {
                ListViewItem lvi = new ListViewItem(x.Date.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(x.LoginTime.ToString(@"hh\:mm\:ss"));
                if (x.LogoutTime.ToString(@"hh\:mm\:ss") != "00:00:00")
                {
                    lvi.SubItems.Add(x.LogoutTime.ToString(@"hh\:mm\:ss"));
                    lvi.SubItems.Add(x.TimeSpentOnSystem.ToString(@"hh\:mm\:ss"));
                } 
                else
                {
                    lvi.BackColor = Color.Red;
                    lvi.ForeColor = Color.White;
                    lvi.SubItems.Add("**");
                    lvi.SubItems.Add("**");
                }
                lvi.SubItems.Add(x.UnsuccessfulLogoutReason);
                lvTime.Items.Add(lvi);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    frmLogin frm = new frmLogin();
                    accession.UpdateTimeLoggingManagement(Email, DateTime.Now);
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAmonicAirlinesAutomationSystemForUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
