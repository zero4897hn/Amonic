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
    public partial class frmScheduleEdit : Form
    {
        public frmScheduleEdit()
        {
            InitializeComponent();
        }

        SqlDataAccession accession = new SqlDataAccession();
        public int ScheduleID { get; set; }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bool correct = true;
                if (!Valid.Time(txtTime.Text))
                {
                    errorProvider1.SetError(txtTime, "Invalid Time");
                    correct = false;
                }

                if (correct)
                {
                    accession.UpdateSchedule(ScheduleID, dtpDate.Value, TimeSpan.Parse(txtTime.Text), int.Parse(txtEconomyPrice.Text));
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
