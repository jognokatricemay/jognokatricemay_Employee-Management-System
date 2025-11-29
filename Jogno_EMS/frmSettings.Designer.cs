namespace Jogno_EMS
{
    partial class frmSettings
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
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpageUserRegistration = new System.Windows.Forms.TabPage();
            this.btnDownload = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tPageSectionRegistration = new System.Windows.Forms.TabPage();
            this.tcSettings.SuspendLayout();
            this.tpageUserRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpageUserRegistration);
            this.tcSettings.Controls.Add(this.tPageSectionRegistration);
            this.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSettings.Location = new System.Drawing.Point(0, 0);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(800, 450);
            this.tcSettings.TabIndex = 0;
            // 
            // tpageUserRegistration
            // 
            this.tpageUserRegistration.Controls.Add(this.btnDownload);
            this.tpageUserRegistration.Controls.Add(this.dgvUsers);
            this.tpageUserRegistration.Controls.Add(this.pnlSideBar);
            this.tpageUserRegistration.Location = new System.Drawing.Point(4, 22);
            this.tpageUserRegistration.Name = "tpageUserRegistration";
            this.tpageUserRegistration.Padding = new System.Windows.Forms.Padding(3, 28, 3, 3);
            this.tpageUserRegistration.Size = new System.Drawing.Size(792, 424);
            this.tpageUserRegistration.TabIndex = 0;
            this.tpageUserRegistration.Text = "User Registration";
            this.tpageUserRegistration.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(9, 4);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(68, 19);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(203, 28);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(586, 393);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Controls.Add(this.btnExecute);
            this.pnlSideBar.Controls.Add(this.lblNumber);
            this.pnlSideBar.Controls.Add(this.lblMatch);
            this.pnlSideBar.Controls.Add(this.cbSection);
            this.pnlSideBar.Controls.Add(this.lblSection);
            this.pnlSideBar.Controls.Add(this.txtFullName);
            this.pnlSideBar.Controls.Add(this.lblFullName);
            this.pnlSideBar.Controls.Add(this.txtConfirmPassword);
            this.pnlSideBar.Controls.Add(this.lblConPass);
            this.pnlSideBar.Controls.Add(this.txtPassword);
            this.pnlSideBar.Controls.Add(this.lblPassword);
            this.pnlSideBar.Controls.Add(this.txtAge);
            this.pnlSideBar.Controls.Add(this.lblAge);
            this.pnlSideBar.Controls.Add(this.txtUserName);
            this.pnlSideBar.Controls.Add(this.lblUserName);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(3, 28);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 393);
            this.pnlSideBar.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(97, 290);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(79, 23);
            this.btnExecute.TabIndex = 14;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(19, 274);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(55, 13);
            this.lblNumber.TabIndex = 13;
            this.lblNumber.Text = "✓ Number";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Location = new System.Drawing.Point(19, 261);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(48, 13);
            this.lblMatch.TabIndex = 12;
            this.lblMatch.Text = "✓ Match";
            // 
            // cbSection
            // 
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(18, 111);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(158, 21);
            this.cbSection.TabIndex = 11;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(19, 95);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 10;
            this.lblSection.Text = "Section";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(18, 72);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(158, 20);
            this.txtFullName.TabIndex = 9;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(19, 56);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Full Name";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(18, 229);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(158, 20);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblConPass
            // 
            this.lblConPass.AutoSize = true;
            this.lblConPass.Location = new System.Drawing.Point(15, 213);
            this.lblConPass.Name = "lblConPass";
            this.lblConPass.Size = new System.Drawing.Size(114, 13);
            this.lblConPass.TabIndex = 6;
            this.lblConPass.Text = "Password Confirmation";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(18, 190);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(18, 151);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(158, 20);
            this.txtAge.TabIndex = 3;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(19, 135);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(18, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(17, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // tPageSectionRegistration
            // 
            this.tPageSectionRegistration.Location = new System.Drawing.Point(4, 22);
            this.tPageSectionRegistration.Name = "tPageSectionRegistration";
            this.tPageSectionRegistration.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tPageSectionRegistration.Size = new System.Drawing.Size(792, 424);
            this.tPageSectionRegistration.TabIndex = 1;
            this.tPageSectionRegistration.Text = "Section Registration";
            this.tPageSectionRegistration.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcSettings);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tcSettings.ResumeLayout(false);
            this.tpageUserRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpageUserRegistration;
        private System.Windows.Forms.TabPage tPageSectionRegistration;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Button btnDownload;
    }
}