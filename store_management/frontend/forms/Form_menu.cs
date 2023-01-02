using store_management.frontend.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_management
{
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
            backend.Database.database_init();
        }

        private void btn_add_new_product_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_add_product());
        }

        private void btn_see_all_product_Click(object sender, EventArgs e)
        {
            Utility.close_open_form(this, new Form_all_products());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Utility.exit();
        }
    }
}
