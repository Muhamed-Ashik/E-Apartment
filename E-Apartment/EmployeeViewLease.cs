using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    public partial class EmployeeViewLease : Form
    {


        public EmployeeViewLease()
        {
            InitializeComponent();

            LoadDataToGridView();
        }

        public void LoadDataToGridView() // method created
        {
            // instance or object of the manageLeaseOOP page which contains only codes
            ManageLeaseOOP manageLeaseOOP = new ManageLeaseOOP();

            // creating a GetLeaseList method using the object and getting the data which coming from the GetLeaseList method
            var data = manageLeaseOOP.GetLeaseList();

            // assigning the data to the grid view
            dgwLeaseList.DataSource = data;

        } // End of the LoadDataToGridView method

        private void btnLeaseSearch_Click(object sender, EventArgs e)
        {
            ManageLeaseOOP manageLeaseOOP = new ManageLeaseOOP();
            var data = manageLeaseOOP.GetLease(txtLeaseSearch.Text);
            dgwLeaseList.DataSource = data;

        }
    } // End of the class
}
