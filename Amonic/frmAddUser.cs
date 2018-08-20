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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        SqlDataAccession accession = new SqlDataAccession();

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            try
            {
                FulfilTheOfficeCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FulfilTheOfficeCombobox()
        {
            List<string> Offices = accession.OfficeList();
            cboOffice.Items.Clear();
            foreach (string x in Offices) cboOffice.Items.Add(x);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bool correct = true;
                if (txtEmailAddress.Text == "")
                {
                    errorProvider1.SetError(txtEmailAddress, "This box mustn't be left blank.");
                    correct = false;
                }
                else if (txtEmailAddress.Text.IndexOf('@') < 0)
                {
                    errorProvider1.SetError(txtEmailAddress, "Invalid email.");
                    correct = false;
                }
                if (txtFirstName.Text == "")
                {
                    errorProvider1.SetError(txtFirstName, "This box mustn't be left blank.");
                    correct = false;
                }
                if (txtLastName.Text == "")
                {
                    errorProvider1.SetError(txtLastName, "This box mustn't be left blank.");
                    correct = false;
                }
                if (cboOffice.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cboOffice, "You haven't chose yet.");
                    correct = false;
                }
                if (dtpBirthdate.Value.Year >= DateTime.Now.Year)
                {
                    errorProvider1.SetError(dtpBirthdate, "Invalid birthdate.");
                    correct = false;
                }
                if (txtPassword.Text == "")
                {
                    errorProvider1.SetError(txtPassword, "This box mustn't be left blank.");
                    correct = false;
                }
                if (correct)
                {
                    accession.InsertUser(txtEmailAddress.Text, Encryption.ConvertToMD5(txtPassword.Text), txtFirstName.Text, txtLastName.Text, accession.GetOfficeID(cboOffice.SelectedItem + ""), dtpBirthdate.Value);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
