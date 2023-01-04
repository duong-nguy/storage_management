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
        Dictionary<string, string> test = new Dictionary<string, string>();

        public Form_add_product()
        {
            InitializeComponent();
            cbox_product_to_add.DataSource =
                Enum.GetValues(typeof(enums.Product_types));
            cb_manufacturer.DataSource =
                Enum.GetValues(typeof(enums.Manufacturers));
            
            for (int i = 0; i < 4; i++)
            {
                test.Add("text"+i.ToString(), "string");
            }
        }



        private void btn_add_product_Click(object sender, EventArgs e)
        {
           
            enums.Product_types type;
            enums.Manufacturers m;

            Enum.TryParse(
                cbox_product_to_add.SelectedValue.ToString(), out type);
            Enum.TryParse(
                cb_manufacturer.SelectedValue.ToString(), out m);

            Form_product_info form = new Form_product_info();
            form.show_dialog(test,(int)type,(int)m,(int)nbox_quanity.Value,tb_model.Text);

            
        }
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_menu());
        }
    }
}
