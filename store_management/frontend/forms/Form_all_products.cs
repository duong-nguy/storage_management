﻿using System;
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
            cb_type.DataSource =
                Enum.GetValues(typeof(enums.Product_types));
        }
        enums.Search search;
        List<backend.abstractions.PRODUCT> search_result;
        int index = 0;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_menu());
        }

        private void btn_see_full_info_Click(object sender, EventArgs e)
        {
            Form_product_description form =  new Form_product_description();
            Hide();
            form.show_dialog(
                search_result[index].full_description(),
                backend.Database.get_image(search_result[index].id));
            Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            enums.Product_types type;
            Enum.TryParse(
                cb_type.SelectedValue.ToString(), out type);
            search_result = backend.Database.search(tb_keywords.Text,type, search);

        }
        private void render_product()
        {
            lb_index_of.Text = $"";
            lb_product_type.Text = $"";
            lb_id.Text = $"";
            lb_product_manufacturer.Text = $"";
            lb_product_model.Text = $"";
            lb_product_quantity.Text = $"";
            
            if (search_result.Count == 0) return;
            lb_index_of.Text = $"{index+1} of {search_result.Count}";
            lb_product_type.Text = $"{search_result[index].type}";
            lb_id.Text = $"{search_result[index].id}";
            lb_product_manufacturer.Text = $"{search_result[index].manufacturer}";
            lb_product_model.Text = $"{search_result[index].model}";
            lb_product_quantity.Text = $"{search_result[index].quantity}";
            pictureBox1.Image = backend.Database.get_image(search_result[index].id);

        }



        private void rb_by_manufacturer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            switch (radio.Text)
            {
                case "By Product Model":
                    search = enums.Search.by_model;
                    break;
                case "By Product Id":
                    search = enums.Search.by_id;
                    break;
                case "By Manufacturer":
                    search = enums.Search.by_manufacturer;
                    break;
                default:
                    break;
            }
        }

        private void btn_last_product_Click(object sender, EventArgs e)
        {
            index = index <= 0 ? search_result.Count -1: index - 1;
            render_product();
        }

        private void btn_next_product_Click(object sender, EventArgs e)
        {
            index = index > search_result.Count -2 ? 0 : index + 1;
            render_product();
        }

        private void btn_delete_product_Click(object sender, EventArgs e)
        {
            if (search_result.Count() == 0) return;
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            backend.Database.delete_product(search_result[index].id);
            search_result.Remove(search_result[index]);
            render_product();
        }

        private void btn_load_all_products_Click(object sender, EventArgs e)
        {
            search_result = backend.Database.get_all_product();
            render_product();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_keywords.Text = "";
            rb_byid.Checked = false;
            rb_by_manufacturer.Checked = false;
            rb_by_product_model.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utility.exit();
        }
    }
}
