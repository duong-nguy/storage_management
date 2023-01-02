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
    public partial class Form_product_info : Form
    {
        public Form_product_info()
        {
            InitializeComponent();
            this.CancelButton = btn_cancel;
        }

        private void form_product_info_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
        }
        public List<Object> show_dialog(List<string> product_properties)
        {
            lable_init(product_properties);
            List<Object> object_fields = new List<object>();
            if(ShowDialog()==DialogResult.Cancel) 
                return object_fields;

            return object_fields;
        }
        private void lable_init(List<string> product_properties)
        {
            
        }
        
    }
}
