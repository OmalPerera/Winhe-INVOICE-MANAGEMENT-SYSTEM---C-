﻿using System;
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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cus_Btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void Cus_Btn_AddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomers addCustomerForm = new AddCustomers();
            addCustomerForm.Show();
        }
    }
}
