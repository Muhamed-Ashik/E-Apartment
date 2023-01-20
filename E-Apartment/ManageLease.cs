using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    public partial class ManageLease : Form
    {
        public ManageLease()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        public void LoadDataToGridView() // method created
        {
            // instance or object of the manageLeaseOOP page which contains only codes
            ManageLeaseOOP manageLeaseOOP = new ManageLeaseOOP();

            // creating a GetLeaseList method using the object and getting the data which coming from the GetLeaseList method
            var data = manageLeaseOOP.GetLeaseList();

            // assigning the data to the grid view
            dgwLeaseList.DataSource = data;

        } // End of the LoadDataToGridView method

        private void btnUpdateLease_Click(object sender, EventArgs e)
        {



        } // End of the update button

        private void dgwLeaseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtBuildingNumber.Text = dgwLeaseList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApartmentNumber.Text = dgwLeaseList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtApartmentLocation.Text = dgwLeaseList.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTotalParkingSlot.Text = dgwLeaseList.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtApartmentStatus.Text = dgwLeaseList.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtOccupantName.Text = dgwLeaseList.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtOccupantNIC.Text = dgwLeaseList.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtOccupantAddress.Text = dgwLeaseList.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtOccupantContactNo.Text = dgwLeaseList.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtOccupantParkingSlotNeeded.Text = dgwLeaseList.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtLeasedPostedDate.Text = dgwLeaseList.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtDurationOfLease.Text = dgwLeaseList.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtComments.Text = dgwLeaseList.Rows[e.RowIndex].Cells[13].Value.ToString();

        } // End of the data grid view cell double click method

    } // ENd of the class
} // End of the namespace
