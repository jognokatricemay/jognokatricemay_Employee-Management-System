namespace Jogno_EMS
{
    partial class frmAddEmployee
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
            this.pnlSubTitle = new System.Windows.Forms.Panel();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblLocalNumber = new System.Windows.Forms.Label();
            this.lblRequestorName = new System.Windows.Forms.Label();
            this.gbEmployeeInput = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.tbRequestorName = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbLocalNumber = new System.Windows.Forms.TextBox();
            this.tbEmployeeNumber = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.pnlSubTitle.SuspendLayout();
            this.gbEmployeeInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubTitle
            // 
            this.pnlSubTitle.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlSubTitle.Controls.Add(this.lblAddEmployee);
            this.pnlSubTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlSubTitle.Name = "pnlSubTitle";
            this.pnlSubTitle.Size = new System.Drawing.Size(564, 52);
            this.pnlSubTitle.TabIndex = 0;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(12, 15);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(133, 20);
            this.lblAddEmployee.TabIndex = 0;
            this.lblAddEmployee.Text = "Add Employees";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(29, 45);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(143, 16);
            this.lblEmployeeNumber.TabIndex = 1;
            this.lblEmployeeNumber.Text = "Employee Number :";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(104, 149);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(67, 16);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Section :";
            // 
            // lblLocalNumber
            // 
            this.lblLocalNumber.AutoSize = true;
            this.lblLocalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalNumber.Location = new System.Drawing.Point(60, 126);
            this.lblLocalNumber.Name = "lblLocalNumber";
            this.lblLocalNumber.Size = new System.Drawing.Size(111, 16);
            this.lblLocalNumber.TabIndex = 3;
            this.lblLocalNumber.Text = "Local Number :";
            // 
            // lblRequestorName
            // 
            this.lblRequestorName.AutoSize = true;
            this.lblRequestorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestorName.Location = new System.Drawing.Point(40, 72);
            this.lblRequestorName.Name = "lblRequestorName";
            this.lblRequestorName.Size = new System.Drawing.Size(132, 16);
            this.lblRequestorName.TabIndex = 4;
            this.lblRequestorName.Text = "Requestor Name :";
            // 
            // gbEmployeeInput
            // 
            this.gbEmployeeInput.Controls.Add(this.btnDelete);
            this.gbEmployeeInput.Controls.Add(this.btnInsertUpdate);
            this.gbEmployeeInput.Controls.Add(this.cmbSection);
            this.gbEmployeeInput.Controls.Add(this.tbRequestorName);
            this.gbEmployeeInput.Controls.Add(this.tbEmailAddress);
            this.gbEmployeeInput.Controls.Add(this.tbLocalNumber);
            this.gbEmployeeInput.Controls.Add(this.tbEmployeeNumber);
            this.gbEmployeeInput.Controls.Add(this.lblEmailAddress);
            this.gbEmployeeInput.Controls.Add(this.lblEmployeeNumber);
            this.gbEmployeeInput.Controls.Add(this.lblSection);
            this.gbEmployeeInput.Controls.Add(this.lblRequestorName);
            this.gbEmployeeInput.Controls.Add(this.lblLocalNumber);
            this.gbEmployeeInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEmployeeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployeeInput.Location = new System.Drawing.Point(0, 52);
            this.gbEmployeeInput.Name = "gbEmployeeInput";
            this.gbEmployeeInput.Size = new System.Drawing.Size(564, 247);
            this.gbEmployeeInput.TabIndex = 5;
            this.gbEmployeeInput.TabStop = false;
            this.gbEmployeeInput.Text = "Employee Details Manual Insert and Update :";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(333, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertUpdate.Location = new System.Drawing.Point(182, 195);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(145, 30);
            this.btnInsertUpdate.TabIndex = 6;
            this.btnInsertUpdate.Text = "INSERT / UPDATE";
            this.btnInsertUpdate.UseVisualStyleBackColor = true;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "BPS",
            "IT",
            "HR",
            "GA",
            "Printer",
            "Tape"});
            this.cmbSection.Location = new System.Drawing.Point(182, 149);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(209, 23);
            this.cmbSection.TabIndex = 5;
            // 
            // tbRequestorName
            // 
            this.tbRequestorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequestorName.Location = new System.Drawing.Point(182, 69);
            this.tbRequestorName.Name = "tbRequestorName";
            this.tbRequestorName.Size = new System.Drawing.Size(352, 21);
            this.tbRequestorName.TabIndex = 2;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailAddress.Location = new System.Drawing.Point(182, 96);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(352, 21);
            this.tbEmailAddress.TabIndex = 3;
            // 
            // tbLocalNumber
            // 
            this.tbLocalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalNumber.Location = new System.Drawing.Point(182, 122);
            this.tbLocalNumber.Name = "tbLocalNumber";
            this.tbLocalNumber.Size = new System.Drawing.Size(209, 21);
            this.tbLocalNumber.TabIndex = 4;
            // 
            // tbEmployeeNumber
            // 
            this.tbEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeNumber.Location = new System.Drawing.Point(182, 42);
            this.tbEmployeeNumber.Name = "tbEmployeeNumber";
            this.tbEmployeeNumber.Size = new System.Drawing.Size(176, 21);
            this.tbEmployeeNumber.TabIndex = 1;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(56, 100);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(116, 16);
            this.lblEmailAddress.TabIndex = 6;
            this.lblEmailAddress.Text = "Email Address :";
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 383);
            this.Controls.Add(this.gbEmployeeInput);
            this.Controls.Add(this.pnlSubTitle);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.Click += new System.EventHandler(this.frmAddEmployee_Click);
            this.pnlSubTitle.ResumeLayout(false);
            this.pnlSubTitle.PerformLayout();
            this.gbEmployeeInput.ResumeLayout(false);
            this.gbEmployeeInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubTitle;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblLocalNumber;
        private System.Windows.Forms.Label lblRequestorName;
        private System.Windows.Forms.GroupBox gbEmployeeInput;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.TextBox tbRequestorName;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbLocalNumber;
        private System.Windows.Forms.TextBox tbEmployeeNumber;
        private System.Windows.Forms.Button btnInsertUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}