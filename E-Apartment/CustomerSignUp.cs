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
    public partial class CustomerSignUp : Form
    {
        public CustomerSignUp()
        {
            InitializeComponent();
        }

        private void btnCustomerSignUp_Click(object sender, EventArgs e)
        {

            // checking the customer signup page text fields are empty
            if (txtCustomerUsername.Text == "" || txtCustomerPassword.Text == "")
            { // if empty

                // show an error message
                MessageBox.Show("Please Enter the Correct Username and Password!");

            } else
            { // if not empty

                CustomerSignUpOOP customerSignUpOOP = new CustomerSignUpOOP();
                customerSignUpOOP.Customer = new CustomerEntities()
                {

                    Username = txtCustomerUsername.Text,   
                    Password = txtCustomerPassword.Text,

                };

                bool insertRecordResult = customerSignUpOOP.InsertCustomerSignUpRecord();

                if (insertRecordResult)
                {
                    
                    MessageBox.Show("Record Inserted");
                    CustomerLogin customerLogin = new CustomerLogin();
                    this.Hide();
                    customerLogin.Show();

                }
                else
                {
                    
                    MessageBox.Show("Record Not Inserted");

                } // End of the insertRecordResult result check method

            } // End of the customer signup fields empty check

        } // End of the Customer SignUp Button Method

        public void ClearAllText()
        {// Method, clear all the text when it's is enovoked

            txtCustomerUsername.Clear();
            txtCustomerPassword.Clear();

        } // End of the ClearAllText Method

        private void btnClearTextAll_Click(object sender, EventArgs e)
        {

            ClearAllText();

        } // End of the button Clear All Text

    } // End of the class Customer SignUp
} // End of the namespace E_Apartment
