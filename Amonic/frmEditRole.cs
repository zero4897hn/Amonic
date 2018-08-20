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
    public partial class frmEditRole : Form
    {
        public frmEditRole()
        {
            InitializeComponent();
        }

        SqlDataAccession accession = new SqlDataAccession();

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (radAdministrator.Checked) accession.UpdateUser(txtEmailAddress.Text, 1);
            else accession.UpdateUser(txtEmailAddress.Text, 2);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
