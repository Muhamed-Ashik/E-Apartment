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
