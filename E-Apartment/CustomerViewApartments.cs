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

            
            txtApartmentNumber.Text = dgwApartmentList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApartmentLocation.Text = dgwApartmentList.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtTotalParkingSlot.Text = dgwApartmentList.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtBuildingNumber.Text = dgwApartmentList.Rows[e.RowIndex].Cells[10].Value.ToString();

        } // End of the data grid veiw cell double click method

        private void btnClearSelectedApartment_Click(object sender, EventArgs e)
        {
            txtBuildingNumber.Clear();
            txtApartmentNumber.Clear();
            txtTotalParkingSlot.Clear();
            txtApartmentLocation.Clear();
            
        }

        private void btnLeaseSelectedApartment_Click(object sender, EventArgs e)
        { // Method execute, when the lease apartment button clicked

            // check the fiedls are empty or not
            if(txtApartmentNumber.Text == "" || txtApartmentLocation.Text == "" || txtBuildingNumber.Text == "" || txtTotalParkingSlot.Text == "")
            {
                
                MessageBox.Show("Please select the apartment");

            } else
            {
                // check the occupant details fiedls are empty
                if(txtOccupantName.Text == "" || txtOccupantNIC.Text == "" || txtOccupantAddress.Text == "" || txtOccupantContactNo.Text == "" || txtOccupantParkingSlotNeeded.Text == "" || txtDurationOfLease.Text == "" || txtComments.Text == "")
                { // if empty, show the message below
                    MessageBox.Show("Please fill the required details");
                } else
                { // if not empty, execute the code

                    CustomerViewApartmentsOOP customerViewApartmentsOOP = new CustomerViewApartmentsOOP();
                    customerViewApartmentsOOP.OccupantLeaseDetails = new OccupantEntities()
                    {
                        SelectedApartmentNumber = txtApartmentNumber.Text,
                        SelectedApartmentLocation = txtApartmentLocation.Text,
                        SelectedBuildingNumber = txtBuildingNumber.Text,
                        AvailableTotalParkingSlot = txtTotalParkingSlot.Text,
                        OccupantName = txtOccupantName.Text,
                        NIC = txtOccupantNIC.Text,
                        Address = txtOccupantAddress.Text,
                        ContactNo = txtOccupantContactNo.Text,
                        ParkingSlotNeeded = txtOccupantParkingSlotNeeded.Text,
                        LeasePostedDate = DateTime.Now.ToString("MM/dd/yyyy"),
                        DurationOfLease = txtDurationOfLease.Text,
                        OccupantComments = txtComments.Text

                    };

                    bool insertResult = customerViewApartmentsOOP.InsertOccupantLeaseDetails();

                    if (insertResult)
                    {
                        MessageBox.Show("Record Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Record Not Inserted");
                    }



                } // End of the customer detaisl field empty check if and else condition

            } // end of the selected apartment field empty check if and else condition

        } // End of the button lease apartment 

        private void btnClearAllText_Click(object sender, EventArgs e)
        {

            txtOccupantName.Clear();
            txtOccupantNIC.Clear();
            txtOccupantAddress.Clear();
            txtOccupantContactNo.Clear();
            txtOccupantParkingSlotNeeded.Clear();
            txtComments.Clear();

        } // End of the button Clear ALl Text

        
    } // End of the Customer View Apartments class
} // End of the namespace
