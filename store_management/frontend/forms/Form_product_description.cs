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



        public void show_dialog(Dictionary<string,string> full_description, Image img)
        {
            foreach (KeyValuePair<string,string> keyValue in full_description)
            {
                richTextBox1.Text += $"{keyValue.Key}: {keyValue.Value} \n";
            }
            pictureBox1.Image = img;
            ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
        }
    }
}
