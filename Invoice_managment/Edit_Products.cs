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
    public partial class Edit_Products : Form
    {
        public Edit_Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AP_Btn_goHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void AP_Btn_gotoProducts_Click(object sender, EventArgs e)
        {
            this.Close();
            Products productsForm = new Products();
            productsForm.Show();
        }

        private void AP_Btn_AddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
