using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogno_EMS
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            //FOLDER.CLASS.RETRIEVESDATA(SDFHE)
            CRUD.CRUD.RETRIEVECBO(cbSection, "SELECT [ID], [SECTION]FROM [tblSection] ORDER BY [Section] asc", "Section", "ID");
            //RETRIEVES AND DISPLAY SA DGVUSERS
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, "Select * From [Users]");
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"\d"))
            {
                lblNumber.Text = "✓ Number";
                lblNumber.ForeColor = Color.Green; //fontcolor
            }
            else
            {
                lblNumber.Text = "❌ Number";
                lblNumber.ForeColor = Color.Red;
            }
            Match();
        }
        private void Match()
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                lblMatch.Text = "✓ Match";
                lblMatch.ForeColor = Color.Green; //fontcolor
            }
            else
            {
                lblMatch.Text = "❌ Match";
                lblMatch.ForeColor = Color.Red;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Match();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to register?", "Confirmation",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "Insert into [Users] ([UserName], [Password],[Section],[Age], [FullName]) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cbSection.Text + "','" + txtAge.Text + "','" + txtFullName.Text + "')";
                CRUD.CRUD.CUD(query);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CRUD.CRUD.RETRIEVEDTG(dgvUsers, "Select * From [Users] ");
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            ExportDgv.ExportToExcel(dgvUsers, "ExportedData_" + DateTime.Now.ToString("MM-dd-yyyy"));
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string exportPath = @"C:\JognoCS2_OOP\Employee_Details_Template.xlsx";
            string SavePath = @"C:\JognoCS2_OOP\Employee_Details_Template.xlsx";

            ExportCellFromDgv.ExportFromTemplate(exportPath,
                SavePath,
                "B1", dgvUsers.Rows[e.RowIndex].Cells["FullName"].Value,
                "H1", dgvUsers.Rows[e.RowIndex].Cells["Section"].Value,
                "B2", dgvUsers.Rows[e.RowIndex].Cells["Username"].Value,
                "H2", dgvUsers.Rows[e.RowIndex].Cells["Age"].Value,
                "A32", LoginPage.fullname,
                "A33", DateTime.Now.ToString("yyyy-MM-dd")
            );
        }
    }
}
