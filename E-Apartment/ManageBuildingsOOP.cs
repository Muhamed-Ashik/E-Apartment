using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment
{
    internal class ManageBuildingsOOP
    {

        // database connection
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");

        // SqlCommand class
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        // new data table
        DataTable dataTable;

        // BuildingEntities class propety, possible to access the properties of BuildingEntities class
        public BuildingEntities Buildings { get; set; }

    public bool InsertRecord()
        {
            // insert query, which will insert the records which coming from the text feilds to database
            string insertQuery = "INSERT INTO Tbl_Manage_Buildings (BuildingNumber, BuildingLocation) VALUES ('"+ Buildings.BuildingNumber +"', '"+ Buildings.BuildingLocation +"' )";

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

            

        } // End of the InsertRecord method

      

        internal List<BuildingEntities> GetBuildingList()
        {

            // fetch query, which will fetch all the records from the Tbl_Manage_Buildings table 
            string fetchQuery = "SELECT * FROM Tbl_Manage_Buildings";

            // passing the query and the database connectin to the sqlDataAdapter method
            sqlDataAdapter = new SqlDataAdapter(fetchQuery, sqlConnection);

            // creatng a new data tale
            dataTable = new DataTable();

            // filling the datatable using the sqlDataAdapter
            sqlDataAdapter.Fill(dataTable);

            // creating a new list of ManageApartmentEntities
            List<BuildingEntities> buildingEntities = new List<BuildingEntities>();

            // for loop, to loop though the data table, which will loop until the loop equals to the data table rows count
            for (int loop = 0; loop < dataTable.Rows.Count; loop++)
            {

                // fethcing the and sotring in the array
                var data = dataTable.Rows[loop].ItemArray;

                buildingEntities.Add(new BuildingEntities()
                { // creating a new BuildingEntities object and adding in to buildingEntities object

                    // fethcing the records from the array and storing it in the BuildingEntities propeties
                    ID = int.Parse(data[0].ToString()),
                    BuildingNumber = data[1].ToString(),
                    BuildingLocation = data[2].ToString(),

                });


            } // End of the loop

            // returning the buildingEntities
            return buildingEntities;

        } // End of the GetBuildingList() method

        internal bool UpdateBuildingRecord(BuildingEntities buildings)
        {// method, used to update records of buildings

            // update query, which will update the records of the Tbl_Manage_Buildings table based on the ID
            string updateQuery = "Update Tbl_Manage_Buildings Set BuildingNumber='" + buildings.BuildingNumber + "', BuildingLocation='" + buildings.BuildingLocation + "' WHERE ID='" + buildings.ID + "' ";

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

        } // End of the UpdateBuildingRecord method

        internal bool DeleteBuildingRecord()
        {
            // delete query, which will delete the records of the Tbl_Manage_Buildings table based on the ID
            string updateQuery = "DELETE FROM Tbl_Manage_Buildings WHERE ID='" + Buildings.ID + "' ";

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

        } // End of the deleteBuldingRecord method

        internal List<BuildingEntities> GetBuilding(string buildingSearched)
        { // method, used to fetch the details according to the user searched value

            // search query, which will filter the records of the Tbl_Manage_Buildings table based on the user searched value
            string searchQuery = "SELECT * FROM Tbl_Manage_Buildings WHERE BuildingNumber = '" + buildingSearched + "' OR BuildingLocation = '" + buildingSearched + "' ";

            // passing the query and the database connectin to the sqlDataAdapter method
            sqlDataAdapter = new SqlDataAdapter(searchQuery, sqlConnection);

            // creating a new data table
            dataTable = new DataTable();

            // filling the datatable using the sqlDataAdapter
            sqlDataAdapter.Fill(dataTable);

            // creating a new list of BuildingEntities
            List<BuildingEntities> buildingEntities = new List<BuildingEntities>();

            // for loop, to loop though the data table, which will loop until the loop equals to the data table rows count
            for (int loop = 0; loop < dataTable.Rows.Count; loop++)
            {
                // fethcing the and sotring in the array
                var data = dataTable.Rows[loop].ItemArray;

                buildingEntities.Add(new BuildingEntities()
                {// creating a new BuildingEntities object and adding in to buildingEntities object

                    // fethcing the records from the array and storing it in the BuildingEntities propeties
                    ID = int.Parse(data[0].ToString()),
                    BuildingNumber = data[1].ToString(),
                    BuildingLocation = data[2].ToString(),

                }); // End of the BuildingEntities 

            } // End of the for loop

            return buildingEntities;

    } // End of the GetBuilding method



    } 

} // End of the class ManageBuildingsOOP


    class BuildingEntities
    {

        public int ID { get; set; }
        public string BuildingNumber { get; set; }
        public string BuildingLocation { get; set; }

    } // End of the BuildingEntities class



