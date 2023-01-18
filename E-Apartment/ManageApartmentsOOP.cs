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

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public ManageApartmentsEntities Apartments { get; set; }

        public bool InsertRecord()
        {

            try
            {

                string insertQuery = "INSERT INTO Tbl_Manage_Apartments (ApartmentNumber, Class1, Class2, Class3, Suite, Location, ApartmentDescription, TotalParkingSlot, Status, BuildingNumber) " +
                    "VALUES ('" + Apartments.ApartmentNumber + "', '" + Apartments.Class1 + "', '" + Apartments.Class2 + "', '" + Apartments.Class3 + "', '" + Apartments.Suite + "', '"+ Apartments.ApartmentLocation +"', '" +
                    Apartments.ApartmentDescription + "',  '" + Apartments.TotalParkingSlot + "', '"+ Apartments.ApartmentStatus +"', '" + Apartments.BuildingNumber + "')";

                sqlConnection.Open();

                sqlCommand = new SqlCommand(insertQuery, sqlConnection);

                int insertRecordResult = sqlCommand.ExecuteNonQuery();

                if(insertRecordResult > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            } catch(Exception ex)
            {
                MessageBox.Show("Error Occured: " + ex.Message);
                return false;
            }

           
        } // End of the InsertRecord() method

        public List<ManageApartmentsEntities> GetApartmentList()
        {

            try
            {

                string fetchQuery = "SELECT * FROM Tbl_Manage_Apartments";

                sqlDataAdapter = new SqlDataAdapter(fetchQuery, sqlConnection);

                dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                List<ManageApartmentsEntities> manageApartmentEnities = new List<ManageApartmentsEntities>();

                for(int loop = 0; loop < dataTable.Rows.Count; loop++)
                {

                    var dataFetched = dataTable.Rows[loop].ItemArray;

                    manageApartmentEnities.Add(new ManageApartmentsEntities()
                    {

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

                return manageApartmentEnities;

            } catch(Exception ex)
            {
                MessageBox.Show("Error Occured: " + ex.Message);
            }

            throw new NotImplementedException();

        } // End of the GetApartmentList() method

        internal bool UpdateApartmentRecord(ManageApartmentsEntities apartments)
        {
        
            string updateQuery = "Update Tbl_Manage_Apartments Set ApartmentNumber='" + apartments.ApartmentNumber + "', Class1='" + apartments.Class1 + "', Class2='" + apartments.Class2 + "', Class3='" + apartments.Class3 + "', Suite='" + apartments.Suite+ "', Location='"+ apartments.ApartmentLocation +"', ApartmentDescription='"+ apartments.ApartmentDescription +"', TotalParkingSlot='"+ apartments.TotalParkingSlot +"', Status='" + apartments.ApartmentStatus + "', BuildingNumber='" + apartments.BuildingNumber + "' WHERE ID='" + apartments.ID + "' ";
            sqlCommand = new SqlCommand(updateQuery, sqlConnection);

            sqlConnection.Open();

            int updateRecordsResult = sqlCommand.ExecuteNonQuery();

            if(updateRecordsResult > 0)
            {
                
                return true;

            } else
            {

                return false;

            }

        } // End of the UpdateApartmentRecord Method

        internal bool DeleteAparmentRecord()
        {

            string updateQuery = "DELETE FROM Tbl_Manage_Apartments WHERE ID='" + Apartments.ID + "' ";
            sqlCommand = new SqlCommand(updateQuery, sqlConnection);

            sqlConnection.Open();

            int deleteRecordResult = sqlCommand.ExecuteNonQuery();

            if (deleteRecordResult > 0)
            {

                return true;

            }
            else
            {

                return false;

            }

        } // End of the DeleteApartmentRecord Method

        internal object GetApartment(string apartmentSearched)
        {

            string searchQuery = "SELECT * FROM Tbl_Manage_Apartments WHERE ApartmentNumber = '"+ apartmentSearched + "' OR BuildingNumber = '"+ apartmentSearched +"' OR Location = '"+ apartmentSearched +"' OR Class1 = '"+ apartmentSearched +"' OR Class2 = '"+ apartmentSearched +"' OR Class3 = '"+ apartmentSearched +"' OR Suite = '"+ apartmentSearched +"' ";
            sqlDataAdapter = new SqlDataAdapter(searchQuery, sqlConnection);

            dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            List<ManageApartmentsEntities> manageApartmentsEntities = new List<ManageApartmentsEntities>(); 

            for(int loop = 0; loop < dataTable.Rows.Count; loop++)
            {

                var data = dataTable.Rows[loop].ItemArray;

                manageApartmentsEntities.Add(new ManageApartmentsEntities()
                {

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
    {

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
