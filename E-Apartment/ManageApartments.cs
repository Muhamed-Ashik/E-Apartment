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
        { // Method, Execte when the Dashboard button clicked

            // Object or Instance of the Admin Dashboard
            AdminDashboard adminDashboard = new AdminDashboard();

            this.Hide();  // Hide the Current open window
            
            adminDashboard.Show(); // Show the dashboard

        } // End of the Dashboard Button

        private void btnAdminLogout_Click(object sender, EventArgs e)
        { // Method, Execte when the logout button clicked


            // Object or instance of the admin login page
            AdminLogin adminLogin = new AdminLogin();

            // message to show once logout
            MessageBox.Show("Thanks for Visiting! Logouted!");
            
            this.Hide(); // hide the current open window

            adminLogin.Show(); // show the adminLogin page


        } // End of the Admin Logout button

        private void btnApartmentTextClear_Click(object sender, EventArgs e)
        { // Method, execute when the clear all text button clicked

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
        { // Method, execute when insert button clicked

            // check the fields are empty
            if (txtBuildingNumber.Text == "" || txtApartmentNumber.Text == "" || txtTotalParkingSlot.Text == "" ||
               txtApartmentDescription.Text == "" || cmbApartmentStatus.Text == "" || txtApartmentLocation.Text == "" || cbxClass1.Checked == false && cbxClass2.Checked == false &&
               cbxClass3.Checked == false && cbxSuite.Checked == false)
            {
                // if the fields empty, then show the message
                MessageBox.Show("Please fill the text fields!");

            } else
            { // if the fields are not empty, execute the below code

                ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();
                manageApartmentsOOP.Apartments = new ManageApartmentsEntities()
                {

                    BuildingNumber = txtBuildingNumber.Text,
                    ApartmentNumber = txtApartmentNumber.Text,
                    TotalParkingSlot = txtTotalParkingSlot.Text,
                    ApartmentDescription = txtApartmentDescription.Text,
                    Class1 = cbxClass1.Checked,
                    Class2 = cbxClass2.Checked,
                    Class3 = cbxClass3.Checked,
                    Suite = cbxSuite.Checked

                }; // End of the ManageApartmentsEntities Method

                bool insertResult = manageApartmentsOOP.InsertRecord();

                if(insertResult)
                {
                    MessageBox.Show("Record Inserted");
                }else
                {
                    MessageBox.Show("Record Not Inserted");
                }

                LoadDataToGridView();
                ClearAllText();


            } // End of the fields empty check if condition

        } // End of the Insert Button


        public void LoadDataToGridView()
        {

            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();
            var data = manageApartmentsOOP.GetApartmentList();
            dgwApartmentList.DataSource = data;

        } // End of the LoadDataToGridView method

        private void dgwApartmentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtID.Text = dgwApartmentList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtApartmentNumber.Text = dgwApartmentList.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbxClass1.Checked = bool.Parse(dgwApartmentList.Rows[e.RowIndex].Cells[2].Value.ToString());
            cbxClass2.Checked = bool.Parse(dgwApartmentList.Rows[e.RowIndex].Cells[3].Value.ToString());
            cbxClass3.Checked = bool.Parse(dgwApartmentList.Rows[e.RowIndex].Cells[4].Value.ToString());
            cbxSuite.Checked = bool.Parse(dgwApartmentList.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtApartmentDescription.Text = dgwApartmentList.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtTotalParkingSlot.Text = dgwApartmentList.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBuildingNumber.Text = dgwApartmentList.Rows[e.RowIndex].Cells[8].Value.ToString();

        } // End of the data grid view cell double click event method

        private void btnAdminApartmentUpdate_Click(object sender, EventArgs e)
        {

            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();

            manageApartmentsOOP.Apartments = new ManageApartmentsEntities()
            {

                ID = int.Parse(txtID.Text),
                BuildingNumber = txtBuildingNumber.Text,
                ApartmentNumber = txtApartmentNumber.Text,
                TotalParkingSlot = txtTotalParkingSlot.Text,
                ApartmentDescription = txtApartmentDescription.Text,
                Class1 = cbxClass1.Checked,
                Class2 = cbxClass2.Checked,
                Class3 = cbxClass3.Checked,
                Suite = cbxSuite.Checked

            }; // End of the ManageApartments method

            bool updateResult = manageApartmentsOOP.UpdateApartmentRecord(manageApartmentsOOP.Apartments);

            if (updateResult == true)
            {
                MessageBox.Show("Record Updated Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Updated Record");
            }

            LoadDataToGridView(); // load the data to the grid view
            ClearAllText();

        } // End of the Manage APartment update button click event method

        private void btnAdminApartmentDelete_Click(object sender, EventArgs e)
        {

            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();

            manageApartmentsOOP.Apartments = new ManageApartmentsEntities()
            {

                ID = int.Parse(txtID.Text)

            }; // End of the ManageApartmentsEntities Method

            bool deleteResult = manageApartmentsOOP.DeleteAparmentRecord();

            if (deleteResult == true)
            {
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            {
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
            cbxClass1.Checked = false;
            cbxClass2.Checked = false;
            cbxClass3.Checked = false;
            cbxSuite.Checked = false;

        } // End of the ClearAllText Method

        private void btnApartmentSearch_Click(object sender, EventArgs e)
        {

            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();
            var data = manageApartmentsOOP.GetApartment(txtApartmentSearch.Text);
            dgwApartmentList.DataSource = data;

        } // End of the Apartment Search Button 

    } // End of the ManageApartment Class
} // End of the namespace E_Apartment
