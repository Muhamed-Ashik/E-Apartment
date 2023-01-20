using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment
{
    internal class ManageEmployeesOOP
    {

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");
        DataTable dataTable;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;


        public UserEntities User{ get; set; }

        internal  bool UpdateUserDetails(UserEntities user)
        {
            // method, used to update records of apartments

            // update query, which will update the records of the Tbl_Authorized_Login_Details table based on the ID
            string updateQuery = "Update Tbl_Authorized_Login_Details Set Username='" + user.Username + "', UserType ='" + user.UserType + "', Password='" + user.Password + "' WHERE ID='" + user.ID + "' ";

            // execute the command by passiing the query and database connetion
            sqlCommand = new SqlCommand(updateQuery, sqlConnection);

            sqlConnection.Open();

            // return the number of rows effected
            int updateRecordsResult = sqlCommand.ExecuteNonQuery();

            if (updateRecordsResult > 0) // if number of recorda affected is greater that 0
            {
                // return this
                return true;

            }
            else
            {
                // return this
                return false;

            }


        } // End of the UpdateUserDetails method

        internal List<UserEntities> GetUsers()
        {
            // fetch query, which will fetch all the records from the Tbl_Authorized_Login_Details table 
            string fetchQuery = "SELECT * FROM Tbl_Authorized_Login_Details";

            // passing the query and the database connectin to the sqlDataAdapter method
            sqlDataAdapter = new SqlDataAdapter(fetchQuery, sqlConnection);

            // creatng a new data tale
            dataTable = new DataTable();

            // filling the datatable using the sqlDataAdapter
            sqlDataAdapter.Fill(dataTable);

            // creating a new list of UserEntities
            List<UserEntities> userEntities = new List<UserEntities>();

            // for loop, to loop though the data table, which will loop until the loop equals to the data table rows count
            for (int loop = 0; loop < dataTable.Rows.Count; loop++)
            {

                // fethcing the and sotring in the array
                var data= dataTable.Rows[loop].ItemArray;

                userEntities.Add(new UserEntities()
                { // creating a new UserEntities object and adding in to userEntities object

                    // fethcing the records from the array and storing it in the UserEntities propeties
                    ID = int.Parse(data[0].ToString()),
                    Username = data[1].ToString(),
                    UserType = data[2].ToString(),
                    Password = data[3].ToString()

                });


            } // End of the loop

            // return the userEntities
            return userEntities;

        } // End of the GetUsers Method

        internal bool InsertUser()
        {
            // insert query, which will insert the records which coming from the text feilds to database
            string insertQuery = "INSERT INTO Tbl_Authorized_Login_Details (Username, UserType, Password) " +
                "VALUES ('" + User.Username + "', '" + User.UserType + "', '" + User.Password + "' )";

            sqlConnection.Open();

            // executing thr sql query
            sqlCommand = new SqlCommand(insertQuery, sqlConnection);

            // this method will retrun the number of rows effected
            int insertRecordResult = sqlCommand.ExecuteNonQuery();

            // check the row count > 0
            if (insertRecordResult > 0)
            {
                return true; // if true, return true
            }
            else
            {
                return false; // if false, return false
            }

        } // End of the Insert User method

        internal bool DeleteUser()
        {
            // delete query, which will delete the records of the Tbl_Authorized_Login_Details table based on the ID
            string updateQuery = "DELETE FROM Tbl_Authorized_Login_Details WHERE ID='" + User.ID + "' ";

            // execute the command by passiing the query and database connetion
            sqlCommand = new SqlCommand(updateQuery, sqlConnection);

            sqlConnection.Open(); // open the connection

            // return the number of rows effected
            int deleteRecordResult = sqlCommand.ExecuteNonQuery();

            if (deleteRecordResult > 0) // if number of recorda affected is greater that 0
            {
                // return this
                return true;

            }
            else
            {
                // return  this
                return false;

            }
        } // ENd of the delete method

    } // End of the class ManageEmployeesOOP
}

class UserEntities
{
    public int ID { get; set; }
    public string Username { get; set; }
    public string UserType { get; set; }
    public string Password { get; set; }

} // End of the UserEntities
