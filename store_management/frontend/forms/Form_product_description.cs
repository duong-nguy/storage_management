using store_management.backend.abstractions;
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
    public partial class Form_product_description : Form
    {
        public Form_product_description()
        {
            InitializeComponent();
            CancelButton = btn_cancel;
        }



        private void show_dialog(PRODUCT product)
        {
            foreach (KeyValuePair<string,string> keyValue in product.full_description())
            {
                richTextBox1.Text += $"{keyValue.Key}: {keyValue.Value} \n";
            }
            pictureBox1.Image = backend.Database.get_image(product.id);
            ShowDialog();

        }
    }
}
