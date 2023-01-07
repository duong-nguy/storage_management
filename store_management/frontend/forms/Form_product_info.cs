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
        Image image;
        int quanity;
        enums.Product_types type;
        enums.Manufacturers manufacturer;
        string model;
        public Form_product_info()
        {
            InitializeComponent();
            CancelButton = btn_cancel;
            
            
        }
         private void btn_add_Click(object sender, EventArgs e)
        {
            List<string> fields = new List<string>();
            foreach (Control control in groupBox1.Controls)
            {
                if (control.Name.Contains("fields"))
                {
                    if (control.Name.Contains("tb"))//check empty 
                    {
                        TextBox textBox =(TextBox) control;
                        fields.Add(textBox.Text);
                    }
                    else if (control.Name.Contains("cb"))//not yet implement
                    {
                        CheckBox check = (CheckBox)control;
                        fields.Add(check.Checked.ToString());
                    }
                    else if (control.Name.Contains("nb"))
                    {
                        NumericUpDown num = (NumericUpDown)control;
                        fields.Add(num.Value.ToString());
                    }
                }
            }
            backend.Database.add_product(type, manufacturer, model
                ,quanity,image,fields.ToArray());
            Close();
        }
        public void show_dialog(
            Dictionary<string, string> product_properties,
            int type, int manufacturer, int quantity, string model)
        {
            this.type = (enums.Product_types) type;
            this.manufacturer = (enums.Manufacturers) manufacturer;
            this.quanity = quantity;
            this.model = model;
            lable_init(product_properties);
            ShowDialog();
        }
        private void lable_init(
            Dictionary<string, string> product_properties)
        {
            int y_step = (int) groupBox1.Height / (product_properties.Count() + 1);
            int x_step = groupBox1.Width * 1 / 5;
            int x = groupBox1.Width * 1 / 10;
            int y = y_step;
            lb_product_type.Text = type.ToString();
            groupBox1.Text = $"{type} infomation";
            
            foreach (KeyValuePair<string,string> keyValue in product_properties)
            {
                if (keyValue.Value != "bool")
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Font = new Font(
                        "Microsoft Sans Serif", 8.5F,
                        FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    label.Location = new Point(x, y);
                    label.Name = $"label_{keyValue.Key}";
                    label.Size = new Size(189, 31);
                    label.TabIndex = 0;
                    label.Text = $"{keyValue.Key}";
                    groupBox1.Controls.Add(label);
                }
                switch (keyValue.Value)
                {
                    case "string":
                        {
                            TextBox text = new TextBox();
                            text.Location = new Point(x + x_step, y);
                            text.Name = $"tb_{keyValue.Key}_fields";
                            text.Size = new Size(100, 20);
                            text.TabIndex = 4;
                            groupBox1.Controls.Add(text);
                            break;
                        }

                    case "int":
                        {
                            NumericUpDown num = new NumericUpDown();
                            num.Location = new Point(x + x_step, y);
                            num.Name = $"nb_{keyValue.Key}_fields";
                            num.Size = new Size(100, 20);
                            num.TabIndex = 4;
                            num.Maximum = 100;
                            groupBox1.Controls.Add(num);
                            break;
                        }
                    case "bool":
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.AutoSize = true;
                            checkBox.Font = new Font(
                                "Microsoft Sans Serif", 8.5F,
                                FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                            checkBox.Text = $"{keyValue.Key}";
                            checkBox.Location = new Point(x, y);
                            checkBox.Name = $"cb_{keyValue.Key}_fields";
                            checkBox.Size = new Size(100, 20);
                            checkBox.TabIndex = 0;
                            groupBox1.Controls.Add(checkBox);
                            break;
                        }
                    default:
                        {
                            throw new Exception
                                ($"Can not find control for {keyValue.Value}");
                        }
                }
                y += y_step;
            }
        }



        private void picb_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg Image | *.jpg|png Image|*.png";
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.Cancel) return;
            image = Image.FromFile(openFileDialog1.FileName);
            picb.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
