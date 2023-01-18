using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment
{
    internal class CustomerLoginOOP
    {

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;
        DataTable dataTable;

        public CustomerLoginEntites CustomerLogin { get; set; }

        public List<CustomerLoginEntites> GetCustomerLoginDetails()
        {

            string fetchQuery = "SELECT * FROM Tbl_Customer_SignUp";
            sqlDataAdapter = new SqlDataAdapter(fetchQuery, sqlConnection);

            dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            List<CustomerLoginEntites> customerLoginEntities = new List<CustomerLoginEntites>();

            for(int loop = 0; loop < dataTable.Rows.Count; loop++)
            {

                var dataFetched = dataTable.Rows[loop].ItemArray;

                customerLoginEntities.Add(new CustomerLoginEntites()
                {

                    ID = int.Parse(dataFetched[0].ToString()),
                    Username = dataFetched[1].ToString(),
                    Password = dataFetched[2].ToString()

                });

            } // End of the for loop

            

            return customerLoginEntities;

            throw new NotImplementedException();
        } // End of the GetCustomerLoginDetails

    } // End of the class CustomerLoginOOP

    class CustomerLoginEntites
    {

        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    } // End of the CUstomerLoginEntities class

} // End of the namespace E_Aprtment
