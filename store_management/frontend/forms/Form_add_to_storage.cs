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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_menu());
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_product_info());

        }

        private void Form_add_product_Load(object sender, EventArgs e)
        {

        }
    }
}
