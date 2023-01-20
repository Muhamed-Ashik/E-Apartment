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
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        private void btnViewDashboard_Click(object sender, EventArgs e)
        {

            AdminDashboard adminDashboard = new AdminDashboard();
            this.Hide();
            adminDashboard.Show();

        } // End of the button dashboard

        private void btnLogout_Click(object sender, EventArgs e)
        {

            AdminLogin adminLogin = new AdminLogin();
            this.Hide();
            adminLogin.Show();

        } // End of the button logout

        private void btnInsertUser_Click(object sender, EventArgs e)
        { // click Method, execute when insert button clicked in the Manage employee Page

            // check the fields are empty
            if (txtUsername.Text == "" || txtPassword.Text == "" || cmbxUserType.Text == "")
            {
                // if the fields empty, then show the message
                MessageBox.Show("Please fill the text fields!");

            }
            else
            { // if the fields are not empty, execute the below code

                // instance or object of the manageEmployeesOOP page which contains only codes
                ManageEmployeesOOP manageEmployeesOOP = new ManageEmployeesOOP();

                // creating a new Set of UserEntities by using the manageEmployeesOOP object User class
                manageEmployeesOOP.User = new UserEntities()
                {

                    // getting the values and storing in the manageEmployeesOOP pages Apartment class
                    Username = txtUsername.Text,
                    UserType = cmbxUserType.Text,
                    Password = txtPassword.Text

                }; // End of the UserEntities Method

                // using the manageEmployeesOOP creating a InsertRecord() method inside of of the  manageEmployeesOOP page and geeting the final out as bool
                bool insertResult = manageEmployeesOOP.InsertUser();

                if (insertResult) // if the result is true, then record inserted, 
                {// print the message
                    MessageBox.Show("New User Details Inserted Successfully");
                }
                else
                {// if the result is false, then record not inserted, 
                    // print the below message
                    MessageBox.Show("Failed to Insert New User Detail");
                }


            } // End of the fields empty check if condition

            LoadDataToGridView();
            TextClear();

        } // End of the button insert

        public void LoadDataToGridView() // method created to load the to grid view
        {
            // instance or object of the manageEmployeesOOP page which contains only codes
            ManageEmployeesOOP manageEmployeesOOP = new ManageEmployeesOOP();

            // creating a GetUsers method using the object and getting the data which coming from the GetUsers method
            var data = manageEmployeesOOP.GetUsers();

            // assigning the data to the grid view
            dgwUserList.DataSource = data;

        } // End of the LoadDataToGridView method

        private void btnUpdateUser_Click(object sender, EventArgs e)
        { // click Method, execute when the Update button in the Manage Employees page is clicked

            // instance or object of the manageEmployeesOOP page which contains only codes
            ManageEmployeesOOP manageEmployeesOOP = new ManageEmployeesOOP();

            // creating a new Set of ManageApartmentsEntities by using the manageEmployeesOOP object User class
            manageEmployeesOOP.User = new UserEntities()
            {

                // getting the values and storing in the manageEmployeesOOP pages Apartment class
                ID = int.Parse(txtID.Text),
                Username = txtUsername.Text,
                UserType = cmbxUserType.Text,
                Password = txtPassword.Text

            }; // End of the ManageApartments method

            // using the object creating an UpdateApartmentRecord method to update the records and getting to bool result
            bool updateResult = manageEmployeesOOP.UpdateUserDetails(manageEmployeesOOP.User);

            if (updateResult == true) // if the record updated
            { // if true , execute the message

                MessageBox.Show("User Details Updated Successfully");

            }
            else
            {// if false execute this message

                MessageBox.Show("Failed to Updated User Details");

            }

            LoadDataToGridView();
            TextClear();

        } // End of the update button

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // click Method, execute when the Delete button in the Manage Employees page is clicked

            // instance or object of the manageEmployeesOOP page which contains only codes
            ManageEmployeesOOP manageEmployeesOOP = new ManageEmployeesOOP();

            // creating a new Set of UserEntities by using the manageEmployeesOOP object User class
            manageEmployeesOOP.User = new UserEntities()
            {

                // geeting only the id 
                ID = int.Parse(txtID.Text)

            }; // End of the UserEntities Method

            // using the object creating an DeleteUser method to delete the records and getting to bool result
            bool deleteResult = manageEmployeesOOP.DeleteUser();

            if (deleteResult == true) // if the record updated
            {// if true , execute the message

                MessageBox.Show("User Deleted Successfully");

            }
            else
            { //if false execute this message

                MessageBox.Show("Failed to Deleted User");

            }

            LoadDataToGridView();
            TextClear();

        } // End of the button delete 

        public void TextClear()
        {

            txtID.Clear();
            txtUsername.Clear();
            cmbxUserType.Text = "";
            txtPassword.Clear();

        } // End of the TextCLear method

        private void btnClearAllText_Click(object sender, EventArgs e)
        {
            TextClear();
        } // End of the button clear all text click method

        private void dgwUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtID.Text = dgwUserList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgwUserList.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbxUserType.Text = dgwUserList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgwUserList.Rows[e.RowIndex].Cells[0].Value.ToString();

        } // End of the cell double click method

    } // End of the class
} // End of the namespace
