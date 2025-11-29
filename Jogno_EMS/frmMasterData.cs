using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jogno_EMS
{
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }
        public static string employeeNumber, requestorName, requestorEmail, localNumber, RequestorSection;
        int id;
        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "select * from tblEmployeeData order by EmployeeNumber desc";
            CRUD.CRUD.RETRIEVEDTG(dgvMasterdata, select_tblrequestorlist);
        }

        private void dgvMasterdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMasterdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTransactionNo.Text = dgvMasterdata.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
            employeeNumber = dgvMasterdata.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
            requestorName = dgvMasterdata.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
            requestorEmail = dgvMasterdata.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString();
            localNumber = dgvMasterdata.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString();
            RequestorSection = dgvMasterdata.Rows[e.RowIndex].Cells["Section"].Value.ToString();

        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            frmAddEmployee editData = new frmAddEmployee("addEmployee");
            editData.ShowDialog();
            CRUD.CRUD.RETRIEVEDTG(dgvMasterdata, "Select * from [tblEmployeeData]");
        }
    }
}
