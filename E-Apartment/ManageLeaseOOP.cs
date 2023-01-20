using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    internal class ManageLeaseOOP
    {

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");
        DataTable dataTable;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;

        public LeaseEntities Lease{ get; set; }

        internal bool DeleteLease()
        { // delete query, which will delete the records of the Tbl_Manage_Lease table based on the ID
            string updateQuery = "DELETE FROM Tbl_Occupant_Lease_Details WHERE ID='" + Lease.ID + "' ";

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

        } // End of the Delete Lease method

        internal object GetLease(string leaseSearched)
        { // method, used to fetch the detaisl according to the user searched value

            // search query, which will filter the records of the Tbl_Occupant_Lease_Details based on the user searched value
            string searchQuery = "SELECT * FROM Tbl_Occupant_Lease_Details WHERE SelectedBuildingNumber = '" + leaseSearched + "' OR SelectedApartmentNumber = '" + leaseSearched + "' " +
                "OR SelectedApartmentLocation = '" + leaseSearched + "' OR Name = '" + leaseSearched + "' OR NIC = '" + leaseSearched + "'" +
                " OR LeasePostedDate = '" + leaseSearched + "' OR DurationOfLease = '" + leaseSearched + "' ";

            // passing the query and the database connectin to the sqlDataAdapter method
            sqlDataAdapter = new SqlDataAdapter(searchQuery, sqlConnection);

            // creating a new data table
            dataTable = new DataTable();

            // filling the datatable using the sqlDataAdapter
            sqlDataAdapter.Fill(dataTable);

            // creating a new list of LeaseEntities
            List<LeaseEntities> leaseEntities = new List<LeaseEntities>();

            // for loop, to loop though the data table, which will loop until the loop equals to the data table rows count
            for (int loop = 0; loop < dataTable.Rows.Count; loop++)
            {
                // fethcing the and sotring in the array
                var data = dataTable.Rows[loop].ItemArray;

                leaseEntities.Add(new LeaseEntities()
                {// creating a new LeaseEntities object and adding in to leaseEntities object

                    // fethcing the records from the array and storing it in the LeaseEntities propeties
                    ID = int.Parse(data[0].ToString()),
                    SelectedBuildingNumber = data[1].ToString(),
                    SelectedApartmentNumber = data[2].ToString(),
                    SelectedApartmentLocation = data[3].ToString(),
                    AvailableTotalParkingSlot = data[4].ToString(),
                    ApartmentStatus = data[5].ToString(),
                    OccupantName = data[6].ToString(),
                    NIC = data[7].ToString(),
                    Address = data[8].ToString(),
                    ContactNo = data[9].ToString(),
                    ParkingSlotNeeded = data[10].ToString(),
                    LeasePostedDate = data[11].ToString(),
                    DurationOfLease = data[12].ToString(),
                    OccupantComments = data[13].ToString(),


                }); // End of the LeaseEntities 

            } // End of the for loop

            return leaseEntities;

        } // End of the GetLease MEthod

        internal List<LeaseEntities> GetLeaseList()
        {

            try
            {

                string fetchQuery = "SELECT * FROM Tbl_Occupant_Lease_Details";

                sqlDataAdapter = new SqlDataAdapter(fetchQuery, sqlConnection);

                dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                List<LeaseEntities> leaseEntities = new List<LeaseEntities>();

                for (int loop = 0; loop < dataTable.Rows.Count; loop++)
                {

                    var data = dataTable.Rows[loop].ItemArray;

                    leaseEntities.Add(new LeaseEntities()
                    {

                        ID = int.Parse(data[0].ToString()),
                        SelectedBuildingNumber = data[1].ToString(),
                        SelectedApartmentNumber = data[2].ToString(),
                        SelectedApartmentLocation = data[3].ToString(),
                        AvailableTotalParkingSlot = data[4].ToString(),
                        ApartmentStatus = data[5].ToString(),
                        OccupantName = data[6].ToString(),
                        NIC = data[7].ToString(),
                        Address = data[8].ToString(),
                        ContactNo = data[9].ToString(),
                        ParkingSlotNeeded = data[10].ToString(),
                        LeasePostedDate = data[11].ToString(),
                        DurationOfLease = data[12].ToString(),
                        OccupantComments = data[13].ToString(),

                    }); ;

                } //End of the for loop

                return leaseEntities;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<LeaseEntities>();
            }


        } // End of the lease method

        internal bool UpdateLeaseDetails(LeaseEntities lease)
        { // method, used to update records of lease

            // update query, which will update the records of the Tbl_Manage_Lease table based on the ID
            string updateQuery = "Update Tbl_Occupant_Lease_Details Set SelectedBuildingNumber='" + lease.SelectedBuildingNumber + "', SelectedApartmentNumber='" + lease.SelectedApartmentNumber + "', SelectedApartmentLocation='" + lease.SelectedApartmentLocation + "', " +
                "AvailableTotalParkingSlot='" + lease.AvailableTotalParkingSlot + "', SelectedApartmentStatus='" + lease.ApartmentStatus + "', Name='" + lease.OccupantName + "', NIC='" + lease.NIC + "', " +
                "Address='" + lease.Address + "', ContactNo='" + lease.ContactNo + "', ParkingSlotNeeded='" + lease.ParkingSlotNeeded + "', LeasePostedDate='" + lease.LeasePostedDate + "', DurationOfLease='" + lease.DurationOfLease + "', Comments='" + lease.OccupantComments +"' WHERE ID='" + lease.ID + "' ";

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


        } // End of the UpdateLeaseDetails method

    } // End of the ManageLeaseOOP class

} // End of the ManageLeaseOOP

class LeaseEntities
{
    public int ID { get; set; }
    public string SelectedBuildingNumber { get; set; }
    public string SelectedApartmentNumber { get; set; }
    public string SelectedApartmentLocation { get; set; }
    public string AvailableTotalParkingSlot { get; set; }
    public string ApartmentStatus { get; set; }
    public string OccupantName { get; set; }
    public string NIC { get; set; }
    public string Address { get; set; }
    public string ContactNo { get; set; }
    public string ParkingSlotNeeded { get; set; }
    public string LeasePostedDate { get; set; }
    public string DurationOfLease { get; set; }
    public string OccupantComments { get; set; }

} // End of the class LeaseEntities
