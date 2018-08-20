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
    public partial class frmNoLogoutDetected : Form
    {
        public frmNoLogoutDetected()
        {
            InitializeComponent();
        }

        SqlDataAccession accession = new SqlDataAccession();
        internal string Email { get; set; }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                accession.UpdateTimeLoggingManagement(Email, txtReason.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}
