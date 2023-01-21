﻿using Microsoft.SqlServer.Server;
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
    public partial class AdminLogin : Form
    {
        private int sqlConnection;

        public AdminLogin()
        {
            InitializeComponent();
        }

        public string Username;
        public string Password;
        public string UserType;
        public string AdminUserType = "Admin";
        public string EmployeeUserType = "Employee";

        // Method which runs once the admin login page login button clicked
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {


            // checking the admin login page text fields are empty
            if (txtAdminUsername.Text == "" || txtAdminPassword.Text == "")
            {

                // show an error message
                MessageBox.Show("Please Fill the Details");

            }
            else
            { // redirect to the admin dashboard

                // database connection
                SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");
                SqlDataAdapter sqlDataAdapter; // ????
                DataTable dataTable; // creating a data table class assinging a variable ??????

                // query to fetch the record from the admin login table
                // string fetchQuery = "SELECT * FROM Tbl_Admin_Login";
                string fetchQuery = "SELECT * FROM Tbl_Authorized_Login_Details";

                // ?????
                sqlDataAdapter = new SqlDataAdapter(fetchQuery, sqlConnection);

                // creating a new empty data table and storing in the dataTable classs ???????????/
                dataTable = new DataTable();

                // filling the data table ??????????????????//
                sqlDataAdapter.Fill(dataTable);

                // for loop to loop though the entire dataTable rows count
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    // getting the data one by one and assigning in to a ItemArray object and storing in the data variable
                    var data = dataTable.Rows[i].ItemArray;

                    // accessing the data in the data table row 1 and converting it to a string and storing in the Name Variable????
                    // Name = data[1].ToString();
                    // accessing the data in the data table row 2 and converting in to a string and stroing in the Username Variable ???? 
                    Username = data[1].ToString();

                    UserType = data[2].ToString();
                    // accessing the data in the data table row 3 and converting in to a string and stroing in the Password Variable ???? 
                    Password = data[3].ToString();


                } // End of the for loop

                // checking the user entered username and password are matching with the database fetched username and password
                    if (txtAdminUsername.Text == Username && txtAdminPassword.Text == Password && UserType == AdminUserType)
                    {// if the both are matched

                        AdminDashboard adminDashboard = new AdminDashboard();
                        this.Hide();
                        adminDashboard.Show();


                    }

                     else
                     {

                    EmployeeDashboard employeeDashboard = new EmployeeDashboard();
                    this.Hide();
                    employeeDashboard.Show();

                     }
                    
            } // End of the fields empty check if condition


        } // End of the method btnAdminLoginClick Event 

        private void btnAdminTextClear_Click(object sender, EventArgs e)
        { // Method, executed when clear button is clicked


            txtAdminUsername.Clear(); // clear the text of admin username field
            txtAdminPassword.Clear(); // clear the text of admin password field

        } // ENd of the Admin Text Clear button

        private void lblIamCustomer_Click(object sender, EventArgs e)
        {
            CustomerSignUp customerSignUpPage = new CustomerSignUp();
            this.Hide();
            customerSignUpPage.Show();

        } // End of the lblIamCustomer click method

    } // End of the class AdminLogin
} // End of the namespace E_Apartment
