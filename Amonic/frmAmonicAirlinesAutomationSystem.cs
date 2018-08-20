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
    public partial class frmAmonicAirlinesAutomationSystem : Form
    {
        public frmAmonicAirlinesAutomationSystem()
        {
            InitializeComponent();
        }

        SqlDataAccession accession = new SqlDataAccession();
        internal string Email { get; set; }

        private void frmAmonicAirlinesAutomationSystem_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime timeLogin = DateTime.Now;
                FulfilTheOfficeCombobox();
                cboOffice.SelectedIndex = 0;
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

        private void FulfilTheOfficeCombobox()
        {
            try
            {
                List<string> Offices = accession.OfficeList();
                cboOffice.Items.Clear();
                cboOffice.Items.Add("All offices");
                foreach (string x in Offices) cboOffice.Items.Add(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboOffice.SelectedIndex == -1) return;
                if (cboOffice.SelectedIndex == 0) ShowUserOnListView();
                else ShowUserOnListView(cboOffice.SelectedItem + "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowUserOnListView(string office)
        {
            lvUser.Items.Clear();
            List<User> Users = accession.GetUserFromSQL();
            foreach (User x in Users) if (x.Office == office)
            {
                ListViewItem lvi = new ListViewItem(x.FirstName);
                lvi.SubItems.Add(x.LastName);
                lvi.SubItems.Add(x.Age + "");
                lvi.SubItems.Add(x.UserRole);
                lvi.SubItems.Add(x.EmailAddress);
                lvi.SubItems.Add(x.Office);
                lvi.Tag = x.Active;
                if (x.UserRole == "Administrator") lvi.BackColor = Color.Green;
                if (!x.Active)
                {
                    lvi.BackColor = Color.Red;
                    lvi.ForeColor = Color.White;
                }
                lvUser.Items.Add(lvi);
            }
        }

        private void ShowUserOnListView()
        {
            lvUser.Items.Clear();
            List<User> Users = accession.GetUserFromSQL();
            foreach (User x in Users)
            {
                ListViewItem lvi = new ListViewItem(x.FirstName);
                lvi.SubItems.Add(x.LastName);
                lvi.SubItems.Add(x.Age + "");
                lvi.SubItems.Add(x.UserRole);
                lvi.SubItems.Add(x.EmailAddress);
                lvi.SubItems.Add(x.Office);
                lvi.Tag = x.Active;
                if (x.UserRole == "Administrator") lvi.BackColor = Color.Green;
                if (!x.Active)
                {
                    lvi.BackColor = Color.Red;
                    lvi.ForeColor = Color.White;
                }
                lvUser.Items.Add(lvi);
            }
        }

        private void mnuAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddUser frm = new frmAddUser();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    if (cboOffice.SelectedIndex == 0 || cboOffice.SelectedIndex == -1) ShowUserOnListView();
                    else ShowUserOnListView(cboOffice.SelectedItem + "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    accession.UpdateTimeLoggingManagement(Email, DateTime.Now);
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvUser.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You haven't chose yet");
                    return;
                }
                ListViewItem lvi = lvUser.SelectedItems[0];
                frmEditRole frm = new frmEditRole();
                frm.txtEmailAddress.Text = lvi.SubItems[4].Text;
                frm.txtFirstName.Text = lvi.SubItems[0].Text;
                frm.txtLastName.Text = lvi.SubItems[1].Text;
                frm.txtOffice.Text = lvi.SubItems[5].Text;
                if (lvi.SubItems[3].Text == "Administrator") frm.radAdministrator.Checked = true;
                else frm.radUser.Checked = true;
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    if (cboOffice.SelectedIndex == 0 || cboOffice.SelectedIndex == -1) ShowUserOnListView();
                    else ShowUserOnListView(cboOffice.SelectedItem + "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnableOrDisableLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvUser.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You haven't chose yet");
                    return;
                }
                ListViewItem lvi = lvUser.SelectedItems[0];
                if (accession.UpdateUser(lvi.SubItems[4].Text, !(bool)lvi.Tag) > 0)
                {
                    if (cboOffice.SelectedIndex == 0 || cboOffice.SelectedIndex == -1) ShowUserOnListView();
                    else ShowUserOnListView(cboOffice.SelectedItem + "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAmonicAirlinesAutomationSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
