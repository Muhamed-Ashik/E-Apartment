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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void btnCustomerViewApartments_Click(object sender, EventArgs e)
        {

            CustomerViewApartments customerViewApartments = new CustomerViewApartments();
            this.Hide();
            customerViewApartments.Show();

        } // End of the Customer View Apartment button

    } // End of the customer dashboard class
} // End of the namespace
