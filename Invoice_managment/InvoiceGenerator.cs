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
    public partial class InvoiceGenerator : Form
    {
        public InvoiceGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void IG_lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void IG_TxtB_Discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void IG_lbl_Discount_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceGenerator_Load(object sender, EventArgs e)
        {

        }

        private void IG_TxtB_Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void IG_Btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void IG_Btn_Print_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewInvoice viewInvoiceForm = new ViewInvoice();
            viewInvoiceForm.Show();
        }
    }
}
