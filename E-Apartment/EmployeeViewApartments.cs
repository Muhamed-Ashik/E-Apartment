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
    public partial class EmployeeViewApartments : Form
    {
        public EmployeeViewApartments()
        {
            InitializeComponent();
            LoadToDataGridView();
        }


        public void LoadToDataGridView()
        {
            // instance or object of the manageApartmentsOOP page which contains only codes
            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();

            // creating a GetApartmentList method using the object and getting the data which coming from the GetApartmentList method
            var data = manageApartmentsOOP.GetApartmentList();

            // assigning the data to the grid view
            dgwViewApartmentList.DataSource = data;

        } // End of the LoadToDataGridView

        private void btnApartmentSearch_Click(object sender, EventArgs e)
        {
            // click Method, execute when the search apartment button is clicked in manage apartment page

            // instance or object of the manageApartmentsOOP page which contains only codes
            ManageApartmentsOOP manageApartmentsOOP = new ManageApartmentsOOP();

            // creating method using object and passing the text value by the user and fetching the record from the method and sotring in the data
            var data = manageApartmentsOOP.GetApartment(txtApartmentSearch.Text);

            // assigning the data to data grid view
            dgwViewApartmentList.DataSource = data;

        }
    } // End of the class
} 
