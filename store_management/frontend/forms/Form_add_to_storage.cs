using System;
using System.Collections.Generic;
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
            enums.Validation_result result = check_controls();
            if (result != enums.Validation_result.Yes)
            {
                switch (result)
                {
                    case enums.Validation_result.cbox_is_empty:
                        MessageBox.Show("Please choose a valid information");

                        break;
                    case enums.Validation_result.tbox_is_empty:
                        MessageBox.Show("Please fill in all information");
                        break;
                }
                return;
            }
            Dictionary<string, string> product_type_properties =
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
        private enums.Validation_result check_controls()
        {
            if (Input_valid.validation(cbox_product_to_add, cb_manufacturer) ==
                 enums.Validation_result.No)
                return enums.Validation_result.cbox_is_empty;

            if (Input_valid.validation(tb_model) == enums.Validation_result.No)
                return enums.Validation_result.tbox_is_empty;

            return enums.Validation_result.Yes;
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
