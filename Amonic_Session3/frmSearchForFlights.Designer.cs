namespace Amonic_Session3
{
    partial class frmSearchForFlights
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.cboCabinType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpOutbound = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.radOneWay = new System.Windows.Forms.RadioButton();
            this.radReturn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkThreeDaysDisplayOutbound = new System.Windows.Forms.CheckBox();
            this.lvOutboundFlight = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblReturnFlightDetails = new System.Windows.Forms.Label();
            this.chkThreeDaysDisplayReturn = new System.Windows.Forms.CheckBox();
            this.lvReturnFlight = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfPassengers = new System.Windows.Forms.MaskedTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.dtpReturn);
            this.groupBox1.Controls.Add(this.cboCabinType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpOutbound);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboFrom);
            this.groupBox1.Controls.Add(this.radOneWay);
            this.groupBox1.Controls.Add(this.radReturn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Parameters";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(655, 63);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(477, 64);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(126, 20);
            this.dtpReturn.TabIndex = 11;
            // 
            // cboCabinType
            // 
            this.cboCabinType.FormattingEnabled = true;
            this.cboCabinType.Location = new System.Drawing.Point(499, 28);
            this.cboCabinType.Name = "cboCabinType";
            this.cboCabinType.Size = new System.Drawing.Size(104, 21);
            this.cboCabinType.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Return:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cabin Type:";
            // 
            // cboTo
            // 
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(247, 28);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(132, 21);
            this.cboTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To:";
            // 
            // dtpOutbound
            // 
            this.dtpOutbound.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOutbound.Location = new System.Drawing.Point(281, 64);
            this.dtpOutbound.Name = "dtpOutbound";
            this.dtpOutbound.Size = new System.Drawing.Size(98, 20);
            this.dtpOutbound.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Outbound:";
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(69, 28);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(94, 21);
            this.cboFrom.TabIndex = 1;
            this.cboFrom.SelectedIndexChanged += new System.EventHandler(this.cboFrom_SelectedIndexChanged);
            // 
            // radOneWay
            // 
            this.radOneWay.AutoSize = true;
            this.radOneWay.Location = new System.Drawing.Point(96, 66);
            this.radOneWay.Name = "radOneWay";
            this.radOneWay.Size = new System.Drawing.Size(67, 17);
            this.radOneWay.TabIndex = 7;
            this.radOneWay.Text = "One way";
            this.radOneWay.UseVisualStyleBackColor = true;
            // 
            // radReturn
            // 
            this.radReturn.AutoSize = true;
            this.radReturn.Checked = true;
            this.radReturn.Location = new System.Drawing.Point(30, 66);
            this.radReturn.Name = "radReturn";
            this.radReturn.Size = new System.Drawing.Size(57, 17);
            this.radReturn.TabIndex = 6;
            this.radReturn.TabStop = true;
            this.radReturn.Text = "Return";
            this.radReturn.UseVisualStyleBackColor = true;
            this.radReturn.CheckedChanged += new System.EventHandler(this.radReturn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Outbound flight details:";
            // 
            // chkThreeDaysDisplayOutbound
            // 
            this.chkThreeDaysDisplayOutbound.AutoSize = true;
            this.chkThreeDaysDisplayOutbound.Location = new System.Drawing.Point(568, 133);
            this.chkThreeDaysDisplayOutbound.Name = "chkThreeDaysDisplayOutbound";
            this.chkThreeDaysDisplayOutbound.Size = new System.Drawing.Size(190, 17);
            this.chkThreeDaysDisplayOutbound.TabIndex = 2;
            this.chkThreeDaysDisplayOutbound.Text = "Display three days before and after";
            this.chkThreeDaysDisplayOutbound.UseVisualStyleBackColor = true;
            // 
            // lvOutboundFlight
            // 
            this.lvOutboundFlight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvOutboundFlight.Location = new System.Drawing.Point(12, 160);
            this.lvOutboundFlight.Name = "lvOutboundFlight";
            this.lvOutboundFlight.Size = new System.Drawing.Size(764, 153);
            this.lvOutboundFlight.TabIndex = 3;
            this.lvOutboundFlight.UseCompatibleStateImageBehavior = false;
            this.lvOutboundFlight.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "From";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "To";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Flight Number(s)";
            this.columnHeader5.Width = 147;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cabin Price";
            this.columnHeader6.Width = 141;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Number of stops";
            this.columnHeader7.Width = 145;
            // 
            // lblReturnFlightDetails
            // 
            this.lblReturnFlightDetails.AutoSize = true;
            this.lblReturnFlightDetails.Location = new System.Drawing.Point(12, 330);
            this.lblReturnFlightDetails.Name = "lblReturnFlightDetails";
            this.lblReturnFlightDetails.Size = new System.Drawing.Size(100, 13);
            this.lblReturnFlightDetails.TabIndex = 4;
            this.lblReturnFlightDetails.Text = "Return flight details:";
            // 
            // chkThreeDaysDisplayReturn
            // 
            this.chkThreeDaysDisplayReturn.AutoSize = true;
            this.chkThreeDaysDisplayReturn.Location = new System.Drawing.Point(568, 328);
            this.chkThreeDaysDisplayReturn.Name = "chkThreeDaysDisplayReturn";
            this.chkThreeDaysDisplayReturn.Size = new System.Drawing.Size(190, 17);
            this.chkThreeDaysDisplayReturn.TabIndex = 5;
            this.chkThreeDaysDisplayReturn.Text = "Display three days before and after";
            this.chkThreeDaysDisplayReturn.UseVisualStyleBackColor = true;
            // 
            // lvReturnFlight
            // 
            this.lvReturnFlight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvReturnFlight.Location = new System.Drawing.Point(12, 355);
            this.lvReturnFlight.Name = "lvReturnFlight";
            this.lvReturnFlight.Size = new System.Drawing.Size(764, 153);
            this.lvReturnFlight.TabIndex = 6;
            this.lvReturnFlight.UseCompatibleStateImageBehavior = false;
            this.lvReturnFlight.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "From";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "To";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Date";
            this.columnHeader10.Width = 112;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Time";
            this.columnHeader11.Width = 77;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Flight Number(s)";
            this.columnHeader12.Width = 147;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Cabin Price";
            this.columnHeader13.Width = 141;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Number of stops";
            this.columnHeader14.Width = 145;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBookFlight);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNumberOfPassengers);
            this.groupBox2.Location = new System.Drawing.Point(200, 514);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 52);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirm booking for";
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Location = new System.Drawing.Point(211, 17);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(89, 23);
            this.btnBookFlight.TabIndex = 2;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Passengers";
            // 
            // txtNumberOfPassengers
            // 
            this.txtNumberOfPassengers.Location = new System.Drawing.Point(37, 19);
            this.txtNumberOfPassengers.Mask = "000";
            this.txtNumberOfPassengers.Name = "txtNumberOfPassengers";
            this.txtNumberOfPassengers.Size = new System.Drawing.Size(72, 20);
            this.txtNumberOfPassengers.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(537, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmSearchForFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 578);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvReturnFlight);
            this.Controls.Add(this.lvOutboundFlight);
            this.Controls.Add(this.chkThreeDaysDisplayReturn);
            this.Controls.Add(this.chkThreeDaysDisplayOutbound);
            this.Controls.Add(this.lblReturnFlightDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSearchForFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for flights";
            this.Load += new System.EventHandler(this.frmSearchForFlights_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radReturn;
        private System.Windows.Forms.RadioButton radOneWay;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpOutbound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.ComboBox cboCabinType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkThreeDaysDisplayOutbound;
        private System.Windows.Forms.ListView lvOutboundFlight;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblReturnFlightDetails;
        private System.Windows.Forms.CheckBox chkThreeDaysDisplayReturn;
        private System.Windows.Forms.ListView lvReturnFlight;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtNumberOfPassengers;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.Button btnExit;
    }
}

