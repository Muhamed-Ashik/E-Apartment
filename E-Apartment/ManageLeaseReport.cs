using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    public partial class ManageLeaseReport : Form
    {
        public ManageLeaseReport()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UU5O8KP;Initial Catalog=_E-Apartment;Integrated Security=True");

        private void ManageLeaseReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '___E_ApartmentDataSet.Tbl_Occupant_Lease_Details' table. You can move, or remove it, as needed.
            this.tbl_Occupant_Lease_DetailsTableAdapter.Fill(this.___E_ApartmentDataSet.Tbl_Occupant_Lease_Details);

            this.reportViewer1.RefreshReport();
        }
    }
}
