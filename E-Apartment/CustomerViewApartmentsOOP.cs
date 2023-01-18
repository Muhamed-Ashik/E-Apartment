using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    internal class CustomerViewApartmentsOOP
    {

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");
        DataTable dataTable;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;

        public OccupantEntities OccupantLeaseDetails { get; set; }
        public List<ApartmentEntities> GetApartmentsDetails()
        {
            try
            {

                

                string fetchQuery = "SELECT * FROM Tbl_Manage_Apartments";

                sqlDataAdapter = new SqlDataAdapter(fetchQuery, sqlConnection);

                dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                List<ApartmentEntities> apartmentEntitiesList = new List<ApartmentEntities>();

                for(int loop = 0; loop < dataTable.Rows.Count; loop++)
                {

                    var data = dataTable.Rows[loop].ItemArray;

                    apartmentEntitiesList.Add(new ApartmentEntities()
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


                    });
                    
                } //End of the for loop

                return apartmentEntitiesList;

            }   catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<ApartmentEntities>();
            }        
            
            
        } // End of the get ApartmentDetails

        internal bool InsertOccupantLeaseDetails()
        {

            try
            {

                string insertQuery = "INSERT INTO Tbl_Occupant_Lease_Details (SelectedBuildingNumber, SelectedApartmentNumber, SelectedApartmentLocation, AvailableTotalParkingSlot, Name,  NIC, Address, ContactNo, ParkingSlotNeeded, LeasePostedDate, DurationOfLease, Comments) " +
                    "VALUES ('" + OccupantLeaseDetails.SelectedBuildingNumber + "', '" + OccupantLeaseDetails.SelectedApartmentNumber + "', '" + OccupantLeaseDetails.SelectedApartmentLocation + "', '" + OccupantLeaseDetails.AvailableTotalParkingSlot + "', '" + OccupantLeaseDetails.OccupantName + "', '" + OccupantLeaseDetails.NIC + "', '" + OccupantLeaseDetails.Address + "',  '" + OccupantLeaseDetails.ContactNo + "', '" + OccupantLeaseDetails.ParkingSlotNeeded + "', '" + OccupantLeaseDetails.LeasePostedDate + "', '" + OccupantLeaseDetails.DurationOfLease + "', '" + OccupantLeaseDetails.OccupantComments + "')";

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

        } // ENd of the InsertOccupantLeaseDetails method
    } // End of the class

    class ApartmentEntities
    {
        public int ID { get; set; }
        public string ApartmentNumber { get; set; }
        public bool Class1 { get; set; }
        public bool Class2 { get; set; }
        public bool Class3 { get; set; }
        public bool Suite { get; set; }
        public string ApartmentStatus { get; set; }
        public string ApartmentLocation { get; set; }
        public string ApartmentDescription { get; set; }
        public string TotalParkingSlot { get; set; }
        public string BuildingNumber { get; set; }

    }

    class OccupantEntities
    {
        public int ID { get; set; }
        public string SelectedBuildingNumber { get; set; }
        public string SelectedApartmentNumber { get; set; }
        public string SelectedApartmentLocation { get; set; }
        public string AvailableTotalParkingSlot { get; set; }
        public string OccupantName { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string ParkingSlotNeeded { get; set; }
        public string LeasePostedDate { get; set; }
        public string DurationOfLease { get; set; }
        public string OccupantComments { get; set; }

    } // End of the class OccupantEntities

} // End of the namespace
