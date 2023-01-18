using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    public partial class CustomerViewApartments : Form
    {
        public CustomerViewApartments()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        private void btnCustomerViewDashboard_Click(object sender, EventArgs e)
        {

            CustomerDashboard customerDashboard = new CustomerDashboard();
            this.Hide();
            customerDashboard.Show();

        } // End of the view dashboard button

        public void LoadDataToGridView()
        {

            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();
            var data = manageApartmentsOOP.GetApartmentList();
            dgwApartmentList.DataSource = data;

        } // End of the LoadDataToGridView method

        private void btnApartmentSearch_Click(object sender, EventArgs e)
        {
            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();
            var data = manageApartmentsOOP.GetApartment(txtApartmentSearch.Text);
            dgwApartmentList.DataSource = data;

        } // End of the Apartment Search button

        private void txtApartmentSearch_TextChanged(object sender, EventArgs e)
        {
            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();
            var data = manageApartmentsOOP.GetApartment(txtApartmentSearch.Text);
            dgwApartmentList.DataSource = data;

        } // ENd of the Apartmetn search text changed method

        private void dgwApartmentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtID.Text = dgwApartmentList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtApartmentNumber.Text = dgwApartmentList.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbxClass1.Checked = bool.Parse(dgwApartmentList.Rows[e.RowIndex].Cells[2].Value.ToString());
            cbxClass2.Checked = bool.Parse(dgwApartmentList.Rows[e.RowIndex].Cells[3].Value.ToString());
            cbxClass3.Checked = bool.Parse(dgwApartmentList.Rows[e.RowIndex].Cells[4].Value.ToString());
            cbxSuite.Checked = bool.Parse(dgwApartmentList.Rows[e.RowIndex].Cells[5].Value.ToString());
            cmbApartmentStatus.Text = dgwApartmentList.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtApartmentLocation.Text = dgwApartmentList.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtApartmentDescription.Text = dgwApartmentList.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtTotalParkingSlot.Text = dgwApartmentList.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtBuildingNumber.Text = dgwApartmentList.Rows[e.RowIndex].Cells[10].Value.ToString();

        } // End of the data grid veiw cell double click method

        private void btnClearSelectedApartment_Click(object sender, EventArgs e)
        {
            txtBuildingNumber.Clear();
            txtApartmentNumber.Clear();
            txtTotalParkingSlot.Clear();
            txtApartmentDescription.Clear();
            cmbApartmentStatus.Text = "";
            txtApartmentLocation.Clear();
            cbxClass1.Checked = false;
            cbxClass2.Checked = false;
            cbxClass3.Checked = false;
            cbxSuite.Checked = false;
        }
    } // End of the Customer View Apartments class
} // End of the namespace
