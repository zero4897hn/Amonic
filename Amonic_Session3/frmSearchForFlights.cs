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

namespace Amonic_Session3
{
    public partial class frmSearchForFlights : Form
    {
        public frmSearchForFlights()
        {
            InitializeComponent();
        }

        SqlDataAccession accession = new SqlDataAccession();

        private void frmSearchForFlights_Load(object sender, EventArgs e)
        {
            try
            {
                FulfillTheFromCombobox();
                cboFrom.SelectedIndex = 0;
                cboTo.Items.Add("All");
                cboTo.SelectedIndex = 0;
                FulfillTheCabinTypeCombobox();
                cboCabinType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FulfillTheCabinTypeCombobox()
        {
            List<string> CabinTypes = accession.CabinTypeList();
            cboCabinType.Items.Clear();
            foreach (string x in CabinTypes) cboCabinType.Items.Add(x);
        }

        private void FulfillTheFromCombobox()
        {
            List<string> Airports = accession.AirportIATACodeList();
            cboFrom.Items.Clear();
            cboFrom.Items.Add("All");
            foreach (string x in Airports) cboFrom.Items.Add(x);
        }

        private void cboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> Airports = accession.AirportIATACodeList();
                cboTo.Items.Clear();
                cboTo.Items.Add("All");
                foreach (string x in Airports) if (x != cboFrom.SelectedItem.ToString()) cboTo.Items.Add(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (radReturn.Checked)
            {
                lblReturnFlightDetails.Visible = true;
                chkThreeDaysDisplayReturn.Visible = true;
                lvReturnFlight.Visible = true;
            }
            else
            {
                lblReturnFlightDetails.Visible = false;
                chkThreeDaysDisplayReturn.Visible = false;
                lvReturnFlight.Visible = false;
            }
        }
    }
}
