namespace Amonic
{
    partial class frmAmonicAirlinesAutomationSystem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOffice = new System.Windows.Forms.ComboBox();
            this.lvUser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.btnEnableOrDisableLogin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddUser,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAddUser
            // 
            this.mnuAddUser.Name = "mnuAddUser";
            this.mnuAddUser.Size = new System.Drawing.Size(66, 20);
            this.mnuAddUser.Text = "Add user";
            this.mnuAddUser.Click += new System.EventHandler(this.mnuAddUser_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Office:";
            // 
            // cboOffice
            // 
            this.cboOffice.FormattingEnabled = true;
            this.cboOffice.Location = new System.Drawing.Point(70, 38);
            this.cboOffice.Name = "cboOffice";
            this.cboOffice.Size = new System.Drawing.Size(121, 21);
            this.cboOffice.TabIndex = 2;
            this.cboOffice.Text = "All offices";
            this.cboOffice.SelectedIndexChanged += new System.EventHandler(this.cboOffice_SelectedIndexChanged);
            // 
            // lvUser
            // 
            this.lvUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvUser.FullRowSelect = true;
            this.lvUser.GridLines = true;
            this.lvUser.HideSelection = false;
            this.lvUser.Location = new System.Drawing.Point(12, 76);
            this.lvUser.Name = "lvUser";
            this.lvUser.Size = new System.Drawing.Size(628, 315);
            this.lvUser.TabIndex = 3;
            this.lvUser.UseCompatibleStateImageBehavior = false;
            this.lvUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Age";
            this.columnHeader3.Width = 43;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "User Role";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email Address";
            this.columnHeader5.Width = 222;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Office";
            this.columnHeader6.Width = 90;
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.Location = new System.Drawing.Point(12, 397);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(107, 23);
            this.btnChangeRole.TabIndex = 4;
            this.btnChangeRole.Text = "Change Role";
            this.btnChangeRole.UseVisualStyleBackColor = true;
            this.btnChangeRole.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // btnEnableOrDisableLogin
            // 
            this.btnEnableOrDisableLogin.Location = new System.Drawing.Point(125, 397);
            this.btnEnableOrDisableLogin.Name = "btnEnableOrDisableLogin";
            this.btnEnableOrDisableLogin.Size = new System.Drawing.Size(124, 23);
            this.btnEnableOrDisableLogin.TabIndex = 5;
            this.btnEnableOrDisableLogin.Text = "Enable/Disable Login";
            this.btnEnableOrDisableLogin.UseVisualStyleBackColor = true;
            this.btnEnableOrDisableLogin.Click += new System.EventHandler(this.btnEnableOrDisableLogin_Click);
            // 
            // frmAmonicAirlinesAutomationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 432);
            this.Controls.Add(this.btnEnableOrDisableLogin);
            this.Controls.Add(this.btnChangeRole);
            this.Controls.Add(this.lvUser);
            this.Controls.Add(this.cboOffice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAmonicAirlinesAutomationSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAmonicAirlinesAutomationSystem_FormClosing);
            this.Load += new System.EventHandler(this.frmAmonicAirlinesAutomationSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAddUser;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOffice;
        private System.Windows.Forms.ListView lvUser;
        private System.Windows.Forms.Button btnChangeRole;
        private System.Windows.Forms.Button btnEnableOrDisableLogin;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}