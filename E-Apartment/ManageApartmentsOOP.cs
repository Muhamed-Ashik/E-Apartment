using System;
using System.Collections.Generic;
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
        public ManageApartmentsEntities Apartments { get; set; }

        public bool InsertRecord()
        {

            try
            {

                string insertQuery = "INSERT INTO Tbl_Manage_Apartments (ApartmentNumber, Class1, Class2, Class3, Suite, ApartmentDescription, TotalParkingSlot, BuildingNumber) " +
                    "VALUES ('" + Apartments.ApartmentNumber + "', '" + Apartments.Class1 + "', '" + Apartments.Class2 + "', '" + Apartments.Class3 + "', '" + Apartments.Suite + "', '" +
                    Apartments.ApartmentDescription + "',  '" + Apartments.TotalParkingSlot + "',  '" + Apartments.BuildingNumber + "')";

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


    } // End of the class ManageApartmentsOOP

    class ManageApartmentsEntities
    {

        public int ID { get; set; }
        public string ApartmentNumber { get; set; }
        public bool Class1 { get; set; }
        public bool Class2 { get; set; }
        public bool Class3 { get; set; }
        public bool Suite { get; set; }
        public string ApartmentDescription { get; set; }
        public string TotalParkingSlot { get; set; }
        public string BuildingNumber { get; set; }


    } // End of the class ManageApartmentEntities

} // End of the E_Apartment namespace
