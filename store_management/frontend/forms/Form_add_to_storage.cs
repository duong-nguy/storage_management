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
            cbox_product_to_add.DataSource =
                Enum.GetValues(typeof(enums.Product_types));
        }



        private void btn_add_product_Click(object sender, EventArgs e)
        {
            // TODO: Read the decription in TODO.txt
            enums.Product_types type;
            Enum.TryParse(
                cbox_product_to_add.SelectedValue.ToString(), out type);
            List<string> product_properties =
                backend.Database.get_product_properties(type);
            Form_product_info form = new Form_product_info();
            List<Object> product_fields = form.show_dialog(product_properties);
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_menu());
        }
    }
}
