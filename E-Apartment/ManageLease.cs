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
        { // click Method, execute when the Update button in the Manage Lease page is clicked

            // instance or object of the manageLeaseOOP page which contains only codes
            ManageLeaseOOP manageLeaseOOP = new ManageLeaseOOP();

            // creating a new Set of LeaseEntities by using the manageLeaseOOP object Lease class
            manageLeaseOOP.Lease = new LeaseEntities()
            {

                // getting the values and storing in the manageLeaseOOP pages Lease class
                ID = int.Parse(txtID.Text),
                SelectedBuildingNumber = txtBuildingNumber.Text,
                SelectedApartmentNumber = txtApartmentNumber.Text,
                SelectedApartmentLocation = txtApartmentLocation.Text,
                AvailableTotalParkingSlot = txtTotalParkingSlot.Text,
                ApartmentStatus = txtApartmentStatus.Text,
                OccupantName = txtOccupantName.Text,
                NIC = txtOccupantNIC.Text,
                Address = txtOccupantAddress.Text,
                ContactNo = txtOccupantContactNo.Text,
                ParkingSlotNeeded = txtOccupantParkingSlotNeeded.Text,
                LeasePostedDate = txtLeasedPostedDate.Text,
                DurationOfLease = txtDurationOfLease.Text,
                OccupantComments = txtComments.Text

            }; // End of the LeaseEntities method

            // using the object creating an UpdateLeaseDetails method to update the records and getting to bool result
            bool updateResult = manageLeaseOOP.UpdateLeaseDetails(manageLeaseOOP.Lease);

            if (updateResult == true) // if the record updated
            { // if true , execute the message
                MessageBox.Show("Record Updated Successfully");
            }
            else
            {// if false execute this message
                MessageBox.Show("Failed to Updated Record");
            }

            LoadDataToGridView(); // load the data to the grid view
            TextClear();


        } // End of the update button

        private void dgwLeaseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtID.Text = dgwLeaseList.Rows[e.RowIndex].Cells[0].Value.ToString();
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

        private void btnDeleteLease_Click(object sender, EventArgs e)
        { // click Method, execute when the Delete button in the Manage Lease page is clicked

            // instance or object of the ManageLeaseOOP page which contains only codes
            ManageLeaseOOP manageLease = new ManageLeaseOOP();

            // creating a new Set of LeaseEntities by using the manageLease object Lease class
            manageLease.Lease = new LeaseEntities()
            {

                // geeting only the id 
                ID = int.Parse(txtID.Text)

            }; // End of the LeaseEntities Method

            // using the object creating an DeleteLease method to delete the records and getting to bool result
            bool deleteResult = manageLease.DeleteLease();

            if (deleteResult == true) // if the record updated
            {// if true , execute the message
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            { //if false execute this message
                MessageBox.Show("Failed to Deleted Record");
            }

            LoadDataToGridView();
            TextClear();

        } // End of the delete button click method

        private void btnClearAllText_Click(object sender, EventArgs e)
        {

            TextClear();

        } // End of the button text clear click method

        public void TextClear()
        {
            txtBuildingNumber.Clear();
            txtApartmentNumber.Clear();
            txtTotalParkingSlot.Clear();
            txtApartmentLocation.Clear();
            txtOccupantName.Clear();
            txtOccupantNIC.Clear();
            txtOccupantAddress.Clear();
            txtOccupantContactNo.Clear();
            txtOccupantParkingSlotNeeded.Clear();
            txtComments.Clear();
            txtApartmentStatus.Clear();
            txtDurationOfLease.Clear();
            txtID.Clear();
        }

        private void btnLeaseSearch_Click(object sender, EventArgs e)
        {
            ManageLeaseOOP manageLeaseOOP = new ManageLeaseOOP();
            var data = manageLeaseOOP.GetLease(txtLeaseSearch.Text);
            dgwLeaseList.DataSource = data;

        } // End of the button search click method

        private void btnGenerateLeaseReport_Click(object sender, EventArgs e)
        {

            ManageLeaseReport manageLeaseReport = new ManageLeaseReport();
            this.Hide();
            manageLeaseReport.Show();

        } // End of the generate lease report button

        private void btnCustomerViewDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Hide();
            adminDashboard.Show();
        }

        private void btnCustomerLogout_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Hide();
            adminLogin.Show();
        }
    } // End of the class
} // End of the namespace
