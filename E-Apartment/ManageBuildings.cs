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
    public partial class ManageBuildings : Form
    {
        public ManageBuildings()
        {
            InitializeComponent();
            LoadToDataGridView();
        }

        private void btnAdminApartmentInsert_Click(object sender, EventArgs e)
        { // Method, execute when the insert button is clicked

            // check the text fields are empty
            if(txtBuildingNumber.Text == "" || txtBuildingLocation.Text == "")
            {
                
                MessageBox.Show("Please fill the record!");

            } else
            {
                
                ManageBuildingsOOP manageBuildingsOOP = new ManageBuildingsOOP();
                manageBuildingsOOP.Buildings = new BuildingEntities()
                {
                    BuildingNumber = txtBuildingNumber.Text,
                    BuildingLocation = txtBuildingLocation.Text,
                };

                bool result = manageBuildingsOOP.InsertRecord();

                if(result)
                {
                    
                    MessageBox.Show("Building Details Inserted Successfully");

                } else
                {
                    
                    MessageBox.Show("Failed to Inserted Building Details");


                } // End of the record insert check if and else condition

            } // End of the check text fiedls empty if and condition

            LoadToDataGridView();

        } // End of the insert button click method

        public void LoadToDataGridView()
        {

            // instance or object of the manageBuildingsOOP page which contains only codes
            ManageBuildingsOOP manageBuildingsOOP = new ManageBuildingsOOP();

            // creating a GetBuldingList method using the object and getting the data which coming from the GetBuildingList method
            var data = manageBuildingsOOP.GetBuildingList();

            // assigning the data to the grid view
            dgwBuildingList.DataSource = data;

        } // End of the LoadToDataGridView method

        
        private void dgwBuildingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { // method execute when the data grid view records click twice

            // once the data grid view data is double clicked then will push the clicked record to the text feidls
            txtID.Text = dgwBuildingList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBuildingNumber.Text = dgwBuildingList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBuildingLocation.Text = dgwBuildingList.Rows[e.RowIndex].Cells[2].Value.ToString();

        } // End of the data grid view cell double click method
        private void btnManageBuildingUpdate_Click(object sender, EventArgs e)
        { // click Method, execute when the Update button in the Manage Building page is clicked

            // instance or object of the manageBuildingsOOP page which contains only codes
            ManageBuildingsOOP manageBuildingsOOP = new ManageBuildingsOOP();

            // creating a new Set of BuildingEntities by using the manageBuildingsOOP object Buildings class
            manageBuildingsOOP.Buildings = new BuildingEntities()
            {

                // getting the values and storing in the manageBuildingsOOP pages Buldings class
                ID = int.Parse(txtID.Text),
                BuildingNumber = txtBuildingNumber.Text,
                BuildingLocation = txtBuildingLocation.Text,

            }; // End of the ManageBuldings method

            // using the object creating an UpdateBuildingRecord method to update the records and getting to bool result
            bool updateResult = manageBuildingsOOP.UpdateBuildingRecord(manageBuildingsOOP.Buildings);

            if (updateResult == true) // if the record updated
            { // if true , execute the message
                MessageBox.Show("Building Record Updated Successfully");
            }
            else
            {// if false execute this message
                MessageBox.Show("Failed to Update Building Record");
            }

            LoadToDataGridView(); // load the data to the grid view

        } // End of the Update button click method

        private void btnManageBuildingDelete_Click(object sender, EventArgs e)
        { // click Method, execute when the Delete button in the Manage Building page is clicked

            // instance or object of the manageBuildingsOOP page which contains only codes
            ManageBuildingsOOP manageBuildingsOOP = new ManageBuildingsOOP();

            // creating a new Set of ManageBuildingEntities by using the manageBuildingsOOP object Buildings class
            manageBuildingsOOP.Buildings = new BuildingEntities()
            {

                // geeting only the id 
                ID = int.Parse(txtID.Text)

            }; // End of the ManageBuildingEntities Method

            // using the object creating an DeleteBuuldingRecord method to delete the records and getting to bool result
            bool deleteResult = manageBuildingsOOP.DeleteBuildingRecord();

            if (deleteResult == true) // if the record updated
            {// if true , execute the message
                MessageBox.Show("Bulding Record Deleted Successfully");
            }
            else
            { //if false execute this message
                MessageBox.Show("Failed to Delete Bulding Record");
            }

            LoadToDataGridView();

        } // End of the Delete button click method

        private void btnManageBuildingTextClear_Click(object sender, EventArgs e)
        {
            // Method, execute when the clear all text button clicked in in the Manage building Page

            // Clear all the fields text
            txtID.Clear();
            txtBuildingNumber.Clear();
            txtBuildingLocation.Clear();
            
        } // end of the button clear al text

        private void btnManageBuildingSearch_Click(object sender, EventArgs e)
        {
            // click Method, execute when the search  button is clicked in manage building page

            // instance or object of the manageBuildingsOOP page which contains only codes
            ManageBuildingsOOP manageBuildingsOOP = new ManageBuildingsOOP();

            // creating method using object and passing the text value by the user and fetching the record from the method and sotring in the data
            var data = manageBuildingsOOP.GetBuilding(txtBuildingtSearch.Text);

            // assigning the data to data grid view
            dgwBuildingList.DataSource = data;

        } // End of the button search click method

        private void txtBuildingtSearch_TextChanged(object sender, EventArgs e)
        {
            // text change Method, execute when the search text fields contain a text in manage apartment page

            ManageBuildingsOOP manageBuildingsOOP = new ManageBuildingsOOP();
            var data = manageBuildingsOOP.GetBuilding(txtBuildingtSearch.Text);
            dgwBuildingList.DataSource = data;

        } // End of the TextChanged search method

        private void button1_Click(object sender, EventArgs e)
        {

            AdminDashboard adminDashboard = new AdminDashboard();
            this.Show();
            adminDashboard.Show();

        } // End of the dashboard click method

    } // End of the ManageBuildings Class
} // End of the namespace
