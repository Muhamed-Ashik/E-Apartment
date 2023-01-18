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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_Apartment
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        public string Username;
        public string Password;

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {

            // checking the customer login page text fields are empty
            if (txtCustomerLoginUsername.Text == "" || txtCustomerLoginPassword.Text == "")
            {// if empty,

                // show an error message
                MessageBox.Show("Please Enter the Correct Username and Password!");

            } else
            { // redirect to the customer dashboard

                // database connection
                SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");
                SqlDataAdapter sqlDataAdapter; // ????
                DataTable dataTable; // creating a data table class assinging a variable ??????

                // query to fetch the record from the customer login table
                string fetchQuery = "SELECT * FROM Tbl_Customer_SignUp";

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
                   
                    // accessing the data in the data table row 2 and converting in to a string and stroing in the Username Variable ???? 
                    Username = data[1].ToString();
                    // accessing the data in the data table row 3 and converting in to a string and stroing in the Password Variable ???? 
                    Password = data[2].ToString();


                } // End of the for loop

                // checking the user entered username and password are matching with the database fetched username and password
                if (txtCustomerLoginUsername.Text == Username && txtCustomerLoginPassword.Text == Password)
                {// if the both are matched

                    CustomerDashboard customerDashboard = new CustomerDashboard();  

                    // hiding the current open customer login page
                    this.Hide();

                    // showing the customer dashboard
                    customerDashboard.Show();

                }
                else
                { // if both are not matched

                    // show this message
                    MessageBox.Show("Please Enter the Correct Username or Password!");

                } // End of the username and password match check if condition

            } // ENd of the fields empty check if and else 

        } // End of the CUstomer Login button

        private void btnCustomerClearAllText_Click(object sender, EventArgs e)
        {
            txtCustomerLoginUsername.Clear(); // clear the text of customer username field
            txtCustomerLoginPassword.Clear(); // clear the text of customer password field

        } // ENd of the Customrr Clear All Text button

    } // End of the CUstomerLogin class
} // End of the namespace
