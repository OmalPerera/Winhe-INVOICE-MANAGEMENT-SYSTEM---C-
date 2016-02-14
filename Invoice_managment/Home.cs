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
    public partial class Home : Form
    {
        

        public Home()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void H_L_organizationName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvoiceGenerator invoiveGeneratorForm = new InvoiceGenerator();
            invoiveGeneratorForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void H_Btn_Products_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products productForm = new Products();
            productForm.Show();
        }

        private void H_Btn_Customers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customersForm = new Customers();
            customersForm.Show();
        }
    }
}
