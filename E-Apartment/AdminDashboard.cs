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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {

            InitializeComponent();
 

        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        { // Execute when the logout button clicked

            // Object or instance of the admin login page
            AdminLogin adminLogin = new AdminLogin();

            // message to show once logout
            MessageBox.Show("Thanks for Visiting! Logouted!");

            // hide the current open dashboard
            this.Hide();

            // show the adminLogin page
            adminLogin.Show();

        } // End of the Admin Logout Button

        private void btnAdminManageApartments_Click(object sender, EventArgs e)
        { // Method, Execute when the Manage Apartment button clicked

            // Object or instance of the ManageAparments page
            ManageApartments manageApartments = new ManageApartments();

            this.Hide();  // hide the current open dashboard

            manageApartments.Show();// show the ManageAparments page


        } // End of the Manage Apartment Button

        private void btnManageBuildings_Click(object sender, EventArgs e)
        {

            ManageBuildings manageBuildings = new ManageBuildings();
            this.Show();
            manageBuildings.Show();

        } // End of the manage building button click

        private void btnAdminManageLease_Click(object sender, EventArgs e)
        {

            ManageLease manageLease = new ManageLease();
            this.Hide();
            manageLease.Show();

        } // End of the manage lease button

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {

            ManageEmployees manageEmployees = new ManageEmployees();
            this.Hide();
            manageEmployees.Show();

        } // End of the Manage EMployees button

        private void btnAdminManageReports_Click(object sender, EventArgs e)
        {
            ManageLease manageLease = new ManageLease();
            this.Hide();
            manageLease.Show();
        }
    } // End of the AdminDashboard
} // End of E_Apartment namespace
