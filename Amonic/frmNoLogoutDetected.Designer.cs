namespace Amonic
{
    partial class frmNoLogoutDetected
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
            this.lblNotification = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.radSoftwareCrash = new System.Windows.Forms.RadioButton();
            this.radSystemCrash = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(12, 34);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(35, 13);
            this.lblNotification.TabIndex = 0;
            this.lblNotification.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reason:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(12, 94);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(328, 158);
            this.txtReason.TabIndex = 2;
            // 
            // radSoftwareCrash
            // 
            this.radSoftwareCrash.AutoSize = true;
            this.radSoftwareCrash.Location = new System.Drawing.Point(12, 261);
            this.radSoftwareCrash.Name = "radSoftwareCrash";
            this.radSoftwareCrash.Size = new System.Drawing.Size(97, 17);
            this.radSoftwareCrash.TabIndex = 3;
            this.radSoftwareCrash.TabStop = true;
            this.radSoftwareCrash.Text = "Software Crash";
            this.radSoftwareCrash.UseVisualStyleBackColor = true;
            // 
            // radSystemCrash
            // 
            this.radSystemCrash.AutoSize = true;
            this.radSystemCrash.Location = new System.Drawing.Point(115, 261);
            this.radSystemCrash.Name = "radSystemCrash";
            this.radSystemCrash.Size = new System.Drawing.Size(89, 17);
            this.radSystemCrash.TabIndex = 4;
            this.radSystemCrash.TabStop = true;
            this.radSystemCrash.Text = "System Crash";
            this.radSystemCrash.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(265, 258);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmNoLogoutDetected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 290);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.radSystemCrash);
            this.Controls.Add(this.radSoftwareCrash);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNotification);
            this.Name = "frmNoLogoutDetected";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No logout detected";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.RadioButton radSoftwareCrash;
        private System.Windows.Forms.RadioButton radSystemCrash;
        private System.Windows.Forms.Button btnConfirm;
        internal System.Windows.Forms.Label lblNotification;
    }
}