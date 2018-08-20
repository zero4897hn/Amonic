namespace Amonic_Session2
{
    partial class frmApplyScheduleChanges
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMissingFlieds = new System.Windows.Forms.Label();
            this.lblDuplicateRecords = new System.Windows.Forms.Label();
            this.lblSuccessfulChanges = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the text file with the changes";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(27, 61);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(307, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(340, 60);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMissingFlieds);
            this.groupBox1.Controls.Add(this.lblDuplicateRecords);
            this.groupBox1.Controls.Add(this.lblSuccessfulChanges);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // lblMissingFlieds
            // 
            this.lblMissingFlieds.Location = new System.Drawing.Point(272, 89);
            this.lblMissingFlieds.Name = "lblMissingFlieds";
            this.lblMissingFlieds.Size = new System.Drawing.Size(105, 24);
            this.lblMissingFlieds.TabIndex = 5;
            this.lblMissingFlieds.Text = "0";
            this.lblMissingFlieds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDuplicateRecords
            // 
            this.lblDuplicateRecords.Location = new System.Drawing.Point(272, 58);
            this.lblDuplicateRecords.Name = "lblDuplicateRecords";
            this.lblDuplicateRecords.Size = new System.Drawing.Size(105, 24);
            this.lblDuplicateRecords.TabIndex = 3;
            this.lblDuplicateRecords.Text = "0";
            this.lblDuplicateRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuccessfulChanges
            // 
            this.lblSuccessfulChanges.Location = new System.Drawing.Point(272, 27);
            this.lblSuccessfulChanges.Name = "lblSuccessfulChanges";
            this.lblSuccessfulChanges.Size = new System.Drawing.Size(105, 24);
            this.lblSuccessfulChanges.TabIndex = 1;
            this.lblSuccessfulChanges.Text = "0";
            this.lblSuccessfulChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Record with missing flieds discarded:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duplicate Records Discarded:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Successful Changes Applied:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmApplyScheduleChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Name = "frmApplyScheduleChanges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply Schedule Changes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMissingFlieds;
        private System.Windows.Forms.Label lblDuplicateRecords;
        private System.Windows.Forms.Label lblSuccessfulChanges;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}