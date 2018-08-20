using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using BU;

namespace Amonic_Session2
{
    public partial class frmApplyScheduleChanges : Form
    {
        public frmApplyScheduleChanges()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
                FileFactory.MissingFieldCount = 0;
                FileFactory.DuplicateRecordCount = 0;
                FileFactory.SuccessfullyChangesCount = ;
                List<ScheduleStream> ScheduleStreams = FileFactory.ImportScheduleFromTextFile(txtPath.Text);
                foreach (ScheduleStream x in ScheduleStreams)
                {

                }
                lblSuccessfulChanges.Text = FileFactory.SuccessfullyChangesCount + "";
                lblDuplicateRecords.Text = FileFactory.DuplicateRecordCount + "";
                lblMissingFlieds.Text = FileFactory.MissingFieldCount + "";
            }
        }
    }
}
