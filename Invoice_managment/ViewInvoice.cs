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
    public partial class ViewInvoice : Form
    {
        public ViewInvoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void VI_lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void VI_Btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void VI_Btn_gotoInvoive_Click(object sender, EventArgs e)
        {
            this.Close();
            InvoiceGenerator invoiceGeneratorForm = new InvoiceGenerator();
            invoiceGeneratorForm.Show();
        }
    }
}
