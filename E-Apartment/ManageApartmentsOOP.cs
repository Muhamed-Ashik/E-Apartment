using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    internal class ManageApartmentsOOP
    {

        // database connection
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");

        // execute the query
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        // new data table
        DataTable dataTable;

        // ManageAPartmentEntites class propety, pssible to access the properties of ManageApartmenEntities
        public ManageApartmentsEntities Apartments { get; set; }

        public bool InsertRecord() // Method, used to insert the apartments
        {

            // insert query, which will insert the records which coming from the text feilds to database
                string insertQuery = "INSERT INTO Tbl_Manage_Apartments (ApartmentNumber, Class1, Class2, Class3, Suite, Location, ApartmentDescription, TotalParkingSlot, Status, BuildingNumber) " +
                    "VALUES ('" + Apartments.ApartmentNumber + "', '" + Apartments.Class1 + "', '" + Apartments.Class2 + "', '" + Apartments.Class3 + "', '" + Apartments.Suite + "', '"+ Apartments.ApartmentLocation +"', '" +
                    Apartments.ApartmentDescription + "',  '" + Apartments.TotalParkingSlot + "', '"+ Apartments.ApartmentStatus +"', '" + Apartments.BuildingNumber + "')";

                sqlConnection.Open();

            // executing thr sql query
                sqlCommand = new SqlCommand(insertQuery, sqlConnection);

            // this method will retrun the number of rows effected
                int insertRecordResult = sqlCommand.ExecuteNonQuery();

            // check the row count > 0
                if(insertRecordResult > 0)
                {
                    return true; // if true, return true
                }
                else
                {
                    return false; // if false, return false
                }

           
        } // End of the InsertRecord() method

        public List<ManageApartmentsEntities> GetApartmentList()
        {
            // fetch query, which will fetch all the records from the Tbl_Manage_Apartments table 
            string fetchQuery = "SELECT * FROM Tbl_Manage_Apartments";

            // passing the query and the database connectin to the sqlDataAdapter method
                sqlDataAdapter = new SqlDataAdapter(fetchQuery, sqlConnection);

            // creatng a new data tale
                dataTable = new DataTable();

            // filling the datatable using the sqlDataAdapter
                sqlDataAdapter.Fill(dataTable);

            // creating a new list of ManageApartmentEntities
                List<ManageApartmentsEntities> manageApartmentEnities = new List<ManageApartmentsEntities>();

            // for loop, to loop though the data table, which will loop until the loop equals to the data table rows count
                for(int loop = 0; loop < dataTable.Rows.Count; loop++)
                {

                // fethcing the and sotring in the array
                    var dataFetched = dataTable.Rows[loop].ItemArray;

                    manageApartmentEnities.Add(new ManageApartmentsEntities()
                    { // creating a new ManageApartmentsEntities object and adding in to manageApartmentEnities object

                        // fethcing the records from the array and storing it in the ManageApartmentsEntities propeties
                        ID = int.Parse(dataFetched[0].ToString()),
                        ApartmentNumber = dataFetched[1].ToString(),
                        Class1 = bool.Parse(dataFetched[2].ToString()),
                        Class2 = bool.Parse(dataFetched[3].ToString()), 
                        Class3 = bool.Parse(dataFetched[4].ToString()),
                        Suite = bool.Parse(dataFetched[5].ToString()),
                        ApartmentLocation = dataFetched[6].ToString(),
                        ApartmentDescription = dataFetched[7].ToString(),
                        TotalParkingSlot = dataFetched[8].ToString(),
                        ApartmentStatus= dataFetched[9].ToString(),
                        BuildingNumber = dataFetched[10].ToString()

                    });


                } // End of the loop

            // return the manageApartmentEnities
            return manageApartmentEnities;

        } // End of the GetApartmentList() method

        internal bool UpdateApartmentRecord(ManageApartmentsEntities apartments)
        { // method, used to update records of apartments

            // update query, which will update the records of the Tbl_Manage_Apartments table based on the ID
            string updateQuery = "Update Tbl_Manage_Apartments Set ApartmentNumber='" + apartments.ApartmentNumber + "', Class1='" + apartments.Class1 + "', Class2='" + apartments.Class2 + "', " +
                "Class3='" + apartments.Class3 + "', Suite='" + apartments.Suite+ "', Location='"+ apartments.ApartmentLocation +"', ApartmentDescription='"+ apartments.ApartmentDescription +"', " +
                "TotalParkingSlot='"+ apartments.TotalParkingSlot +"', Status='" + apartments.ApartmentStatus + "', BuildingNumber='" + apartments.BuildingNumber + "' WHERE ID='" + apartments.ID + "' ";

            // execute the command by passiing the query and database connetion
            sqlCommand = new SqlCommand(updateQuery, sqlConnection);

            sqlConnection.Open();

            // return the number of rows effected
            int updateRecordsResult = sqlCommand.ExecuteNonQuery();

            if(updateRecordsResult > 0) // if number of recorda affected is greater that 0
            {
                // return this
                return true;

            } else
            {
                // return this
                return false;

            }

        } // End of the UpdateApartmentRecord Method

        internal bool DeleteAparmentRecord()
        {

            // delete query, which will delete the records of the Tbl_Manage_Apartments table based on the ID
            string updateQuery = "DELETE FROM Tbl_Manage_Apartments WHERE ID='" + Apartments.ID + "' ";

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

        } // End of the DeleteApartmentRecord Method

        internal object GetApartment(string apartmentSearched)
        { // method, used to fetch the detaisl according to the user searched value

            // search query, which will filter the records of the Tbl_Manage_Apartments table based on the user searched value
            string searchQuery = "SELECT * FROM Tbl_Manage_Apartments WHERE ApartmentNumber = '"+ apartmentSearched + "' OR BuildingNumber = '"+ apartmentSearched +"' " +
                "OR Location = '"+ apartmentSearched +"' OR Class1 = '"+ apartmentSearched +"' OR Class2 = '"+ apartmentSearched +"'" +
                " OR Class3 = '"+ apartmentSearched +"' OR Suite = '"+ apartmentSearched +"' ";

            // passing the query and the database connectin to the sqlDataAdapter method
            sqlDataAdapter = new SqlDataAdapter(searchQuery, sqlConnection);

            // creating a new data table
            dataTable = new DataTable();

            // filling the datatable using the sqlDataAdapter
            sqlDataAdapter.Fill(dataTable);

            // creating a new list of ManageApartmentEntities
            List<ManageApartmentsEntities> manageApartmentsEntities = new List<ManageApartmentsEntities>();

            // for loop, to loop though the data table, which will loop until the loop equals to the data table rows count
            for (int loop = 0; loop < dataTable.Rows.Count; loop++)
            {
                // fethcing the and sotring in the array
                var data = dataTable.Rows[loop].ItemArray;

                manageApartmentsEntities.Add(new ManageApartmentsEntities()
                {// creating a new ManageApartmentsEntities object and adding in to manageApartmentEnities object

                    // fethcing the records from the array and storing it in the ManageApartmentsEntities propeties
                    ID = int.Parse(data[0].ToString()),
                    ApartmentNumber = data[1].ToString(),
                    Class1 = bool.Parse(data[2].ToString()),
                    Class2 = bool.Parse(data[3].ToString()),
                    Class3 = bool.Parse(data[4].ToString()),
                    Suite = bool.Parse(data[5].ToString()),
                    ApartmentLocation = data[6].ToString(),
                    ApartmentDescription = data[7].ToString(),
                    TotalParkingSlot = data[8].ToString(),
                    ApartmentStatus = data[9].ToString(),
                    BuildingNumber = data[10].ToString()


                }); // End of the ManageManageApartmentsEntities 

            } // End of the for loop

            return manageApartmentsEntities; 
            
        } // End of the GetApartment Method

    } // End of the class ManageApartmentsOOP

    class ManageApartmentsEntities
    { // class, which contain all entites realted to the apartment

        public int ID { get; set; }
        public string ApartmentNumber { get; set; }
        public bool Class1 { get; set; }
        public bool Class2 { get; set; }
        public bool Class3 { get; set; }
        public bool Suite { get; set; }
        public string  ApartmentStatus { get; set; }
        public string ApartmentLocation { get; set; }
        public string ApartmentDescription { get; set; }
        public string TotalParkingSlot { get; set; }
        public string BuildingNumber { get; set; }


    } // End of the class ManageApartmentEntities

} // End of the E_Apartment namespace
