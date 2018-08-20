namespace Amonic_Session3
{
    partial class frmBookingConfirmation
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFromOutbound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToOutbound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCabinTypeOutbound = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDateOutbound = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFlightNumberOutbound = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFromReturn = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblToReturn = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCabinTypeReturn = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDateReturn = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblFlightNumberReturn = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cboPassportCountry = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.lvPassenger = new System.Windows.Forms.ListView();
            this.btnBackToSearch = new System.Windows.Forms.Button();
            this.btnComfirmBooking = new System.Windows.Forms.Button();
            this.btnRemovePassenger = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFlightNumberOutbound);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblDateOutbound);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblCabinTypeOutbound);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblToOutbound);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFromOutbound);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outbound flight details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // lblFromOutbound
            // 
            this.lblFromOutbound.AutoSize = true;
            this.lblFromOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromOutbound.Location = new System.Drawing.Point(66, 27);
            this.lblFromOutbound.Name = "lblFromOutbound";
            this.lblFromOutbound.Size = new System.Drawing.Size(41, 13);
            this.lblFromOutbound.TabIndex = 1;
            this.lblFromOutbound.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To:";
            // 
            // lblToOutbound
            // 
            this.lblToOutbound.AutoSize = true;
            this.lblToOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToOutbound.Location = new System.Drawing.Point(152, 27);
            this.lblToOutbound.Name = "lblToOutbound";
            this.lblToOutbound.Size = new System.Drawing.Size(41, 13);
            this.lblToOutbound.TabIndex = 3;
            this.lblToOutbound.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cabin Type:";
            // 
            // lblCabinTypeOutbound
            // 
            this.lblCabinTypeOutbound.AutoSize = true;
            this.lblCabinTypeOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinTypeOutbound.Location = new System.Drawing.Point(286, 27);
            this.lblCabinTypeOutbound.Name = "lblCabinTypeOutbound";
            this.lblCabinTypeOutbound.Size = new System.Drawing.Size(41, 13);
            this.lblCabinTypeOutbound.TabIndex = 5;
            this.lblCabinTypeOutbound.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date:";
            // 
            // lblDateOutbound
            // 
            this.lblDateOutbound.AutoSize = true;
            this.lblDateOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOutbound.Location = new System.Drawing.Point(429, 27);
            this.lblDateOutbound.Name = "lblDateOutbound";
            this.lblDateOutbound.Size = new System.Drawing.Size(41, 13);
            this.lblDateOutbound.TabIndex = 7;
            this.lblDateOutbound.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Flight number:";
            // 
            // lblFlightNumberOutbound
            // 
            this.lblFlightNumberOutbound.AutoSize = true;
            this.lblFlightNumberOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumberOutbound.Location = new System.Drawing.Point(630, 27);
            this.lblFlightNumberOutbound.Name = "lblFlightNumberOutbound";
            this.lblFlightNumberOutbound.Size = new System.Drawing.Size(48, 13);
            this.lblFlightNumberOutbound.TabIndex = 9;
            this.lblFlightNumberOutbound.Text = "label10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFlightNumberReturn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblFromReturn);
            this.groupBox2.Controls.Add(this.lblDateReturn);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblToReturn);
            this.groupBox2.Controls.Add(this.lblCabinTypeReturn);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return flight details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "From:";
            // 
            // lblFromReturn
            // 
            this.lblFromReturn.AutoSize = true;
            this.lblFromReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromReturn.Location = new System.Drawing.Point(66, 30);
            this.lblFromReturn.Name = "lblFromReturn";
            this.lblFromReturn.Size = new System.Drawing.Size(41, 13);
            this.lblFromReturn.TabIndex = 1;
            this.lblFromReturn.Text = "label2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "To:";
            // 
            // lblToReturn
            // 
            this.lblToReturn.AutoSize = true;
            this.lblToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToReturn.Location = new System.Drawing.Point(152, 30);
            this.lblToReturn.Name = "lblToReturn";
            this.lblToReturn.Size = new System.Drawing.Size(41, 13);
            this.lblToReturn.TabIndex = 3;
            this.lblToReturn.Text = "label4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Cabin Type:";
            // 
            // lblCabinTypeReturn
            // 
            this.lblCabinTypeReturn.AutoSize = true;
            this.lblCabinTypeReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinTypeReturn.Location = new System.Drawing.Point(286, 30);
            this.lblCabinTypeReturn.Name = "lblCabinTypeReturn";
            this.lblCabinTypeReturn.Size = new System.Drawing.Size(41, 13);
            this.lblCabinTypeReturn.TabIndex = 5;
            this.lblCabinTypeReturn.Text = "label6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(390, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Date:";
            // 
            // lblDateReturn
            // 
            this.lblDateReturn.AutoSize = true;
            this.lblDateReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturn.Location = new System.Drawing.Point(429, 30);
            this.lblDateReturn.Name = "lblDateReturn";
            this.lblDateReturn.Size = new System.Drawing.Size(41, 13);
            this.lblDateReturn.TabIndex = 7;
            this.lblDateReturn.Text = "label8";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(551, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Flight number:";
            // 
            // lblFlightNumberReturn
            // 
            this.lblFlightNumberReturn.AutoSize = true;
            this.lblFlightNumberReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumberReturn.Location = new System.Drawing.Point(630, 30);
            this.lblFlightNumberReturn.Name = "lblFlightNumberReturn";
            this.lblFlightNumberReturn.Size = new System.Drawing.Size(48, 13);
            this.lblFlightNumberReturn.TabIndex = 9;
            this.lblFlightNumberReturn.Text = "label10";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddPassenger);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.dtpBirthdate);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.cboPassportCountry);
            this.groupBox3.Controls.Add(this.txtLastName);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtFirstName);
            this.groupBox3.Controls.Add(this.txtPassportNumber);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 135);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passenger details";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "First name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(27, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Passport number:";
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(122, 61);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPassportNumber.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(93, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(129, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(253, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Last name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(253, 65);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "Passport country:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(318, 27);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(144, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // cboPassportCountry
            // 
            this.cboPassportCountry.FormattingEnabled = true;
            this.cboPassportCountry.Location = new System.Drawing.Point(349, 61);
            this.cboPassportCountry.Name = "cboPassportCountry";
            this.cboPassportCountry.Size = new System.Drawing.Size(113, 21);
            this.cboPassportCountry.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(507, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Birthdate:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(565, 27);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(157, 20);
            this.dtpBirthdate.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(507, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(554, 61);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Location = new System.Drawing.Point(609, 90);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(113, 23);
            this.btnAddPassenger.TabIndex = 12;
            this.btnAddPassenger.Text = "Add passenger";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 301);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 13);
            this.label27.TabIndex = 3;
            this.label27.Text = "Passengers list";
            // 
            // lvPassenger
            // 
            this.lvPassenger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvPassenger.FullRowSelect = true;
            this.lvPassenger.GridLines = true;
            this.lvPassenger.HideSelection = false;
            this.lvPassenger.Location = new System.Drawing.Point(12, 317);
            this.lvPassenger.Name = "lvPassenger";
            this.lvPassenger.Size = new System.Drawing.Size(752, 187);
            this.lvPassenger.TabIndex = 4;
            this.lvPassenger.UseCompatibleStateImageBehavior = false;
            this.lvPassenger.View = System.Windows.Forms.View.Details;
            // 
            // btnBackToSearch
            // 
            this.btnBackToSearch.Location = new System.Drawing.Point(213, 535);
            this.btnBackToSearch.Name = "btnBackToSearch";
            this.btnBackToSearch.Size = new System.Drawing.Size(170, 23);
            this.btnBackToSearch.TabIndex = 6;
            this.btnBackToSearch.Text = "Back to search for flights";
            this.btnBackToSearch.UseVisualStyleBackColor = true;
            // 
            // btnComfirmBooking
            // 
            this.btnComfirmBooking.Location = new System.Drawing.Point(406, 535);
            this.btnComfirmBooking.Name = "btnComfirmBooking";
            this.btnComfirmBooking.Size = new System.Drawing.Size(133, 23);
            this.btnComfirmBooking.TabIndex = 7;
            this.btnComfirmBooking.Text = "Confirm booking";
            this.btnComfirmBooking.UseVisualStyleBackColor = true;
            // 
            // btnRemovePassenger
            // 
            this.btnRemovePassenger.Location = new System.Drawing.Point(637, 510);
            this.btnRemovePassenger.Name = "btnRemovePassenger";
            this.btnRemovePassenger.Size = new System.Drawing.Size(127, 23);
            this.btnRemovePassenger.TabIndex = 5;
            this.btnRemovePassenger.Text = "Remove passenger";
            this.btnRemovePassenger.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Birthdate";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Passport number";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Passport country";
            this.columnHeader5.Width = 143;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phone";
            this.columnHeader6.Width = 143;
            // 
            // frmBookingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 570);
            this.Controls.Add(this.btnRemovePassenger);
            this.Controls.Add(this.btnComfirmBooking);
            this.Controls.Add(this.btnBackToSearch);
            this.Controls.Add(this.lvPassenger);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBookingConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking confirmation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToOutbound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFromOutbound;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCabinTypeOutbound;
        private System.Windows.Forms.Label lblFlightNumberOutbound;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDateOutbound;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFlightNumberReturn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblFromReturn;
        private System.Windows.Forms.Label lblDateReturn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblToReturn;
        private System.Windows.Forms.Label lblCabinTypeReturn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cboPassportCountry;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ListView lvPassenger;
        private System.Windows.Forms.Button btnBackToSearch;
        private System.Windows.Forms.Button btnComfirmBooking;
        private System.Windows.Forms.Button btnRemovePassenger;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}