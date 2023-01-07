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
    public partial class Form_add_product : Form
    {
     
        public Form_add_product()
        {
            InitializeComponent();
        }



        private void btn_add_product_Click(object sender, EventArgs e)
        {

           Dictionary<string,string> product_type_properties =
                backend.Database.get_product_properties(
                (enums.Product_types)cbox_product_to_add.SelectedIndex);
            Form_product_info form = new Form_product_info();
            form.show_dialog(
                 product_type_properties,
                cbox_product_to_add.SelectedIndex,
                cb_manufacturer.SelectedIndex,
                (int)nbox_quanity.Value,
                tb_model.Text);
        }
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_menu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utility.exit();
        }
    }
}
