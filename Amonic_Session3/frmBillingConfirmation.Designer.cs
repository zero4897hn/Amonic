namespace Amonic_Session3
{
    partial class frmBillingConfirmation
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
            this.label2 = new System.Windows.Forms.Label();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radVoucher = new System.Windows.Forms.RadioButton();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnIssueTickets = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paid using:";
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Checked = true;
            this.radCreditCard.Location = new System.Drawing.Point(121, 86);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(77, 17);
            this.radCreditCard.TabIndex = 3;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(121, 118);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(49, 17);
            this.radCash.TabIndex = 4;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radVoucher
            // 
            this.radVoucher.AutoSize = true;
            this.radVoucher.Location = new System.Drawing.Point(121, 150);
            this.radVoucher.Name = "radVoucher";
            this.radVoucher.Size = new System.Drawing.Size(65, 17);
            this.radVoucher.TabIndex = 5;
            this.radVoucher.Text = "Voucher";
            this.radVoucher.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Location = new System.Drawing.Point(190, 25);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(100, 23);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIssueTickets
            // 
            this.btnIssueTickets.Location = new System.Drawing.Point(51, 186);
            this.btnIssueTickets.Name = "btnIssueTickets";
            this.btnIssueTickets.Size = new System.Drawing.Size(109, 23);
            this.btnIssueTickets.TabIndex = 6;
            this.btnIssueTickets.Text = "Issue tickets";
            this.btnIssueTickets.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmBillingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 244);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIssueTickets);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.radVoucher);
            this.Controls.Add(this.radCash);
            this.Controls.Add(this.radCreditCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBillingConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBillingConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radVoucher;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnIssueTickets;
        private System.Windows.Forms.Button btnCancel;
    }
}