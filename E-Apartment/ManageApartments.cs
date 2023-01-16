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
    public partial class ManageApartments : Form
    {


        public ManageApartments()
        {
            InitializeComponent();

        }

    
        private void btnManageApartmentsToDashboard_Click(object sender, EventArgs e)
        { // Method, Execte when the Dashboard button clicked

            // Object or Instance of the Admin Dashboard
            AdminDashboard adminDashboard = new AdminDashboard();

            // Hide the Current open window
            this.Hide();

            // Show the dashboard
            adminDashboard.Show();

        } // End of the Dashboard Button

        private void btnAdminLogout_Click(object sender, EventArgs e)
        { // Method, Execte when the logout button clicked


            // Object or instance of the admin login page
            AdminLogin adminLogin = new AdminLogin();

            // message to show once logout
            MessageBox.Show("Thanks for Visiting! Logouted!");

            // hide the current open window
            this.Hide();

            // show the adminLogin page
            adminLogin.Show();


        } // End of the Admin Logout button

        private void btnApartmentTextClear_Click(object sender, EventArgs e)
        { // Method, execute when the clear all text button clicked

            // Clear all the fields text
            txtBuildingNumber.Clear();
            txtApartmentNumber.Clear();
            txtTotalParkingSlot.Clear();
            txtApartmentDescription.Clear();
            cbxClass1.Checked = false;
            cbxClass2.Checked = false;
            cbxClass3.Checked = false;
            cbxSuite.Checked = false;

        } // End of the Text Clear Button

        private void btnAdminApartmentInsert_Click(object sender, EventArgs e)
        { // Method, execute when insert button clicked

            // check the fields are empty
            if(txtBuildingNumber.Text == "" || txtApartmentNumber.Text == "" || txtTotalParkingSlot.Text == "" ||
               txtApartmentDescription.Text == "")
            {

                MessageBox.Show("incorecct");

            } else
            {
                MessageBox.Show("correct");
            }

        } // End of the Insert Button

    } // End of the ManageApartment Class
} // End of the namespace E_Apartment
