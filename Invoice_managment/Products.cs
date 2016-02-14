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

    public partial class Products : Form
    {

        

        public Products()
        {
            InitializeComponent();
        }

        private void P_Btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeForm = new Home();
            homeForm.Show();
            
            

        }

        private void P_Btn_add_Click(object sender, EventArgs e)
        {
            this.Close();
            AddProducts addProductsForm = new AddProducts();
            addProductsForm.Show();
        }

        private void P_Btn_edit_Click(object sender, EventArgs e)
        {
            this.Close();
            Edit_Products editproductForm = new Edit_Products();
            editproductForm.Show();
        }

        private void P_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void P_TxtB_searchKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_Btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void P_Btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
