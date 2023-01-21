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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void btnAdminManageApartments_Click(object sender, EventArgs e)
        {
            EmployeeViewApartments employeeViewApartments = new EmployeeViewApartments();
            this.Hide();
            employeeViewApartments.Show();
        }

        private void btnAdminManageLease_Click(object sender, EventArgs e)
        {
            EmployeeViewLease employeeViewLease = new EmployeeViewLease();
            this.Hide();
            employeeViewLease.Show();
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Hide();
            adminLogin.Show();
        }
    }
}
