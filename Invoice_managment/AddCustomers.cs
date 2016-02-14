using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_managment
{
    public partial class AddCustomers : Form
    {
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AC_Btn_goHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void AC_Btn_gotoProducts_Click(object sender, EventArgs e)
        {
            this.Close();
            Customers customersForm = new Customers();
            customersForm.Show();
        }
    }
}
