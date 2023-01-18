using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    internal class CustomerSignUpOOP
    {

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");
        SqlCommand sqlCommand;

        public CustomerEntities Customer{ get; set; }

        public bool InsertCustomerSignUpRecord()
        {

            try
            {

                string insertQuery = "INSERT INTO Tbl_Customer_SignUp (Username, Password) VALUES ('" + Customer.Username + "', '" + Customer.Password + "') ";

                sqlConnection.Open();

                sqlCommand = new SqlCommand(insertQuery, sqlConnection);

                int insertRecordResult = sqlCommand.ExecuteNonQuery();

                if (insertRecordResult > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured: " + ex.Message);
                return false;
            }

        } // End of the InsertCustomerSignUpRecord method

    } // End of the class CustomerSignUpOOP



    class CustomerEntities {

        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    } // End of the CustomerEntities


} // End of the E_Aprtment namespace
