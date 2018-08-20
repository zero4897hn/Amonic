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

namespace Amonic_Session2
{
    public partial class frmManageFlightSchedules : Form
    {
        public frmManageFlightSchedules()
        {
            InitializeComponent();
        }

        SqlDataAccession accession = new SqlDataAccession();

        private void frmManageFlightSchedules_Load(object sender, EventArgs e)
        {
            try
            {
                cboSortBy.SelectedIndex = 0;
                FulfillTheFromCombobox();
                cboFrom.SelectedIndex = 0;
                cboTo.Items.Add("All Airport");
                cboTo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FulfillTheFromCombobox()
        {
            List<string> Airports = accession.AirportList();
            cboFrom.Items.Clear();
            cboFrom.Items.Add("All Airport");
            foreach (string x in Airports) cboFrom.Items.Add(x);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (txtOutbound.Text != "  /  /" && !Valid.Date(txtOutbound.Text))
                {
                    errorProvider1.SetError(txtOutbound, "The date is not valid");
                    return;
                }
                string from = (cboFrom.SelectedIndex == -1 || cboFrom.SelectedIndex == 0) ? "All Airport" : accession.GetIATACode(cboFrom.SelectedItem + "");
                string to = (cboTo.SelectedIndex == -1 || cboTo.SelectedIndex == 0) ? "All Airport" : accession.GetIATACode(cboTo.SelectedItem + "");
                int sortByIndex = cboSortBy.SelectedIndex == -1 ? 0 : cboSortBy.SelectedIndex;
                List<Schedule> Schedules = accession.ScheduleList(from, to, sortByIndex, txtOutbound.Text, txtFlightNumber.Text);
                lvSchedule.Items.Clear();
                foreach (Schedule x in Schedules)
                {
                    ListViewItem lvi = new ListViewItem(x.Date.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(x.Time.ToString(@"hh\:mm\:ss"));
                    lvi.SubItems.Add(x.IATACodeFrom);
                    lvi.SubItems.Add(x.IATACodeTo);
                    lvi.SubItems.Add(x.FlightNumber);
                    lvi.SubItems.Add(x.Aircraft);
                    lvi.SubItems.Add(x.EconomyPrice + "");
                    lvi.SubItems.Add((int)(x.EconomyPrice * 1.35) + "");
                    lvi.SubItems.Add((int)(x.EconomyPrice * 1.35 * 1.3) + "");
                    lvi.Tag = x.ID + "," + x.Confirmed;
                    if (!x.Confirmed)
                    {
                        lvi.BackColor = Color.Red;
                        lvi.ForeColor = Color.White;
                    }
                    lvSchedule.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> Airports = accession.AirportList();
                cboTo.Items.Clear();
                cboTo.Items.Add("All Airport");
                foreach (string x in Airports) if (x != cboFrom.SelectedItem.ToString()) cboTo.Items.Add(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelFlight_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvSchedule.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You haven't chose yet.");
                    return;
                }
                ListViewItem lvi = lvSchedule.SelectedItems[0];
                string[] str = lvi.Tag.ToString().Split(',');
                int ID = int.Parse(str[0]);
                bool confirm = Boolean.Parse(str[1]);
                accession.UpdateSchedule(ID, !confirm);
                btnApply.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvSchedule.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You haven't chose yet.");
                    return;
                }
                ListViewItem lvi = lvSchedule.SelectedItems[0];
                string[] str = lvi.Tag.ToString().Split(',');
                int ID = int.Parse(str[0]);
                bool confirm = Boolean.Parse(str[1]);
                frmScheduleEdit frm = new frmScheduleEdit();
                frm.ScheduleID = ID;
                frm.lblFrom.Text = lvi.SubItems[2].Text;
                frm.lblTo.Text = lvi.SubItems[3].Text;
                frm.lblAircraft.Text = lvi.SubItems[5].Text;
                frm.dtpDate.Value = DateTime.Parse(lvi.SubItems[0].Text);
                frm.txtTime.Text = lvi.SubItems[1].Text;
                frm.txtEconomyPrice.Text = lvi.SubItems[6].Text;
                if (frm.ShowDialog() == DialogResult.Cancel) btnApply.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImportChanges_Click(object sender, EventArgs e)
        {
            frmApplyScheduleChanges frm = new frmApplyScheduleChanges();
            if (frm.ShowDialog() == DialogResult.Cancel) btnApply.PerformClick();
        }
    }
}
