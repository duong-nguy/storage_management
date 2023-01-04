using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_management.frontend.forms
{
    public partial class Form_all_products : Form
    {
        public Form_all_products()
        {
            InitializeComponent();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_menu());
        }

        private void btn_see_full_info_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_product_description());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_all_products_Click(object sender, EventArgs e)
        {
 
        }

        private void btn_delete_product_Click(object sender, EventArgs e)
        {

        }

        private void btn_last_product_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_product_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
