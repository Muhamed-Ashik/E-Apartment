using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Apartment
{
    public partial class ManageApartments : Form
    {


        public ManageApartments()
        {
            InitializeComponent();

            // Method envoked, display the apartment list to the gridview when the application executed
            LoadDataToGridView(); 

        }

    
        private void btnManageApartmentsToDashboard_Click(object sender, EventArgs e)
        { // Method, Execte when the Dashboard button clicked in the Manage Apartment Page

            // Object or Instance of the Admin Dashboard
            AdminDashboard adminDashboard = new AdminDashboard();

            this.Hide();  // Hide the Current open window
            
            adminDashboard.Show(); // Show the dashboard

        } // End of the Dashboard Button

        private void btnAdminLogout_Click(object sender, EventArgs e)
        { // Method, Execute when the logout button clicked in the Manage Apartment Page


            // Object or instance of the admin login page
            AdminLogin adminLogin = new AdminLogin();

            // message to show once logout
            MessageBox.Show("Thanks for Visiting! Logouted!");
            
            this.Hide(); // hide the current open window

            adminLogin.Show(); // show the adminLogin page


        } // End of the Admin Logout button

        private void btnApartmentTextClear_Click(object sender, EventArgs e)
        { // Method, execute when the clear all text button clicked in in the Manage Apartment Page

            // Clear all the fields text
            txtBuildingNumber.Clear();
            txtApartmentNumber.Clear();
            txtTotalParkingSlot.Clear();
            txtApartmentDescription.Clear();
            txtApartmentLocation.Clear();
            cmbApartmentStatus.SelectedItem = String.Empty;
            cbxClass1.Checked = false;
            cbxClass2.Checked = false;
            cbxClass3.Checked = false;
            cbxSuite.Checked = false;

        } // End of the Text Clear Button

        private void btnAdminApartmentInsert_Click(object sender, EventArgs e)
        { // click Method, execute when insert button clicked in the Manage Apartment Page

            // check the fields are empty
            if (txtBuildingNumber.Text == "" || txtApartmentNumber.Text == "" || txtTotalParkingSlot.Text == "" ||
               txtApartmentDescription.Text == "" || cmbApartmentStatus.Text == "" || txtApartmentLocation.Text == "" || 
               cbxClass1.Checked == false && cbxClass2.Checked == false &&
               cbxClass3.Checked == false && cbxSuite.Checked == false)
            {
                // if the fields empty, then show the message
                MessageBox.Show("Please fill the text fields!");

            } else
            { // if the fields are not empty, execute the below code

                // instance or object of the manageApartmentsOOP page which contains only codes
                ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();

                // creating a new Set of ManageApartmentsEntities by using the manageApartmentsOOP object Apartments class
                manageApartmentsOOP.Apartments = new ManageApartmentsEntities()
                {

                    // getting the values and storing in the manageApartmentsOOP pages Apartment class
                    BuildingNumber = txtBuildingNumber.Text,
                    ApartmentNumber = txtApartmentNumber.Text,
                    TotalParkingSlot = txtTotalParkingSlot.Text,
                    ApartmentDescription = txtApartmentDescription.Text,
                    ApartmentLocation = txtApartmentLocation.Text,
                    ApartmentStatus = cmbApartmentStatus.Text,
                    Class1 = cbxClass1.Checked,
                    Class2 = cbxClass2.Checked,
                    Class3 = cbxClass3.Checked,
                    Suite = cbxSuite.Checked

                }; // End of the ManageApartmentsEntities Method

                // using the manageApartmentsOOP creating a InsertRecord() method inside of of the  manageApartmentsOOP page and geeting the final out as bool
                bool insertResult = manageApartmentsOOP.InsertRecord();

                if(insertResult) // if the result is true, then record inserted, 
                {// print the message
                    MessageBox.Show("Record Inserted");
                }else
                {// if the result is false, then record not inserted, 
                    // print the below message
                    MessageBox.Show("Record Not Inserted");
                }

                LoadDataToGridView(); // method created below which assign the data to the gridview
                ClearAllText(); // method created below which clear all text written in the fields


            } // End of the fields empty check if condition

        } // End of the Insert Button


        public void LoadDataToGridView() // method created
        {
            // instance or object of the manageApartmentsOOP page which contains only codes
            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();

            // creating a GetApartmentList method using the object and getting the data which coming from the GetApartmentList method
            var data = manageApartmentsOOP.GetApartmentList();

            // assigning the data to the grid view
            dgwApartmentList.DataSource = data;

        } // End of the LoadDataToGridView method

        private void dgwApartmentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // once the data grid view data is double clicked then will push the clicked record to the text feidls
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

        } // End of the data grid view cell double click event method

        private void btnAdminApartmentUpdate_Click(object sender, EventArgs e)
        { // click Method, execute when the Update button in the Manage Apartment page is clicked

            // instance or object of the manageApartmentsOOP page which contains only codes
            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();

            // creating a new Set of ManageApartmentsEntities by using the manageApartmentsOOP object Apartments class
            manageApartmentsOOP.Apartments = new ManageApartmentsEntities()
            {

                // getting the values and storing in the manageApartmentsOOP pages Apartment class
                ID = int.Parse(txtID.Text),
                BuildingNumber = txtBuildingNumber.Text,
                ApartmentNumber = txtApartmentNumber.Text,
                TotalParkingSlot = txtTotalParkingSlot.Text,
                ApartmentDescription = txtApartmentDescription.Text,
                Class1 = cbxClass1.Checked,
                Class2 = cbxClass2.Checked,
                Class3 = cbxClass3.Checked,
                Suite = cbxSuite.Checked,
                ApartmentLocation = txtApartmentLocation.Text,
                ApartmentStatus = cmbApartmentStatus.Text

            }; // End of the ManageApartments method

            // using the object creating an UpdateApartmentRecord method to update the records and getting to bool result
            bool updateResult = manageApartmentsOOP.UpdateApartmentRecord(manageApartmentsOOP.Apartments);

            if (updateResult == true) // if the record updated
            { // if true , execute the message
                MessageBox.Show("Record Updated Successfully");
            }
            else
            {// if false execute this message
                MessageBox.Show("Failed to Updated Record");
            }

            LoadDataToGridView(); // load the data to the grid view
            ClearAllText();

        } // End of the Manage APartment update button click event method

        private void btnAdminApartmentDelete_Click(object sender, EventArgs e)
        { // click Method, execute when the Delete button in the Manage Apartment page is clicked

            // instance or object of the manageApartmentsOOP page which contains only codes
            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();

            // creating a new Set of ManageApartmentsEntities by using the manageApartmentsOOP object Apartments class
            manageApartmentsOOP.Apartments = new ManageApartmentsEntities()
            {

                // geeting only the id 
                ID = int.Parse(txtID.Text)

            }; // End of the ManageApartmentsEntities Method

            // using the object creating an DeleteAparmentRecord method to delete the records and getting to bool result
            bool deleteResult = manageApartmentsOOP.DeleteAparmentRecord();

            if (deleteResult == true) // if the record updated
            {// if true , execute the message
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            { //if false execute this message
                MessageBox.Show("Failed to Deleted Record");
            }

            LoadDataToGridView();
            ClearAllText();

        } // End of the Manage Apartment Delete Button

        public void ClearAllText()
        {// Method, clear all the text when it's is enovoked
            
            txtBuildingNumber.Clear();
            txtApartmentNumber.Clear();
            txtTotalParkingSlot.Clear();
            txtApartmentDescription.Clear();
            cmbApartmentStatus.SelectedItem = String.Empty;
            txtApartmentLocation.Clear();
            cbxClass1.Checked = false;
            cbxClass2.Checked = false;
            cbxClass3.Checked = false;
            cbxSuite.Checked = false;

        } // End of the ClearAllText Method

        private void btnApartmentSearch_Click(object sender, EventArgs e)
        { // click Method, execute when the search apartment button is clicked in manage apartment page

            // instance or object of the manageApartmentsOOP page which contains only codes
            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();

            // creating method using object and passing the text value by the user and fetching the record from the method and sotring in the data
            var data = manageApartmentsOOP.GetApartment(txtApartmentSearch.Text);

            // assigning the data to data grid view
            dgwApartmentList.DataSource = data;

        } // End of the Apartment Search Button 

        private void txtApartmentSearch_TextChanged(object sender, EventArgs e)
        {// text change Method, execute when the search text fields contain a text in manage apartment page

            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();
            var data = manageApartmentsOOP.GetApartment(txtApartmentSearch.Text);
            dgwApartmentList.DataSource = data;

        } // End of the Apartment Text Changed Method

        

        private void btnManageApartmentsToDashboard_Click_1(object sender, EventArgs e)
        {

            AdminDashboard adminDashboardPage = new AdminDashboard();
            this.Hide();
            adminDashboardPage.Show();


        } // End of the Dashboard button click method

    } // End of the ManageApartment Class
} // End of the namespace E_Apartment
