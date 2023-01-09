
namespace store_management.frontend.forms
{
    partial class Form_all_products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_load_all_products = new System.Windows.Forms.Button();
            this.rb_byid = new System.Windows.Forms.RadioButton();
            this.rb_by_manufacturer = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.rb_by_product_model = new System.Windows.Forms.RadioButton();
            this.tb_keywords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_index_of = new System.Windows.Forms.Label();
            this.btn_see_full_info = new System.Windows.Forms.Button();
            this.btn_delete_product = new System.Windows.Forms.Button();
            this.btn_next_product = new System.Windows.Forms.Button();
            this.btn_last_product = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_product_quantity = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_product_type = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_product_manufacturer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_product_model = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Products";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_type);
            this.groupBox1.Controls.Add(this.btn_load_all_products);
            this.groupBox1.Controls.Add(this.rb_byid);
            this.groupBox1.Controls.Add(this.rb_by_manufacturer);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.rb_by_product_model);
            this.groupBox1.Controls.Add(this.tb_keywords);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cb_type
            // 
            this.cb_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Androids",
            "Drones",
            "Exoskeletons",
            "Space Guns",
            "Warp Drive",
            "None"});
            this.cb_type.Location = new System.Drawing.Point(233, 73);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(129, 21);
            this.cb_type.TabIndex = 9;
            // 
            // btn_load_all_products
            // 
            this.btn_load_all_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load_all_products.Image = global::store_management.Properties.Resources.view_all;
            this.btn_load_all_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load_all_products.Location = new System.Drawing.Point(478, 25);
            this.btn_load_all_products.Name = "btn_load_all_products";
            this.btn_load_all_products.Size = new System.Drawing.Size(81, 30);
            this.btn_load_all_products.TabIndex = 9;
            this.btn_load_all_products.Text = "Load All";
            this.btn_load_all_products.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_load_all_products.UseVisualStyleBackColor = true;
            this.btn_load_all_products.Click += new System.EventHandler(this.btn_load_all_products_Click);
            // 
            // rb_byid
            // 
            this.rb_byid.AutoSize = true;
            this.rb_byid.Location = new System.Drawing.Point(19, 48);
            this.rb_byid.Name = "rb_byid";
            this.rb_byid.Size = new System.Drawing.Size(89, 17);
            this.rb_byid.TabIndex = 8;
            this.rb_byid.Text = "By Product Id";
            this.rb_byid.UseVisualStyleBackColor = true;
            this.rb_byid.CheckedChanged += new System.EventHandler(this.rb_by_manufacturer_CheckedChanged);
            // 
            // rb_by_manufacturer
            // 
            this.rb_by_manufacturer.AutoSize = true;
            this.rb_by_manufacturer.Location = new System.Drawing.Point(19, 73);
            this.rb_by_manufacturer.Name = "rb_by_manufacturer";
            this.rb_by_manufacturer.Size = new System.Drawing.Size(103, 17);
            this.rb_by_manufacturer.TabIndex = 7;
            this.rb_by_manufacturer.Text = "By Manufacturer";
            this.rb_by_manufacturer.UseVisualStyleBackColor = true;
            this.rb_by_manufacturer.CheckedChanged += new System.EventHandler(this.rb_by_manufacturer_CheckedChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Image = global::store_management.Properties.Resources.icons8_eraser_20;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(398, 60);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 30);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(165, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Type";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = global::store_management.Properties.Resources.search;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(398, 25);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 30);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rb_by_product_model
            // 
            this.rb_by_product_model.AutoSize = true;
            this.rb_by_product_model.Location = new System.Drawing.Point(19, 25);
            this.rb_by_product_model.Name = "rb_by_product_model";
            this.rb_by_product_model.Size = new System.Drawing.Size(109, 17);
            this.rb_by_product_model.TabIndex = 2;
            this.rb_by_product_model.Text = "By Product Model";
            this.rb_by_product_model.UseVisualStyleBackColor = true;
            this.rb_by_product_model.CheckedChanged += new System.EventHandler(this.rb_by_manufacturer_CheckedChanged);
            // 
            // tb_keywords
            // 
            this.tb_keywords.Location = new System.Drawing.Point(233, 29);
            this.tb_keywords.Name = "tb_keywords";
            this.tb_keywords.Size = new System.Drawing.Size(129, 20);
            this.tb_keywords.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Keywords";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_back);
            this.groupBox2.Controls.Add(this.lb_index_of);
            this.groupBox2.Controls.Add(this.btn_see_full_info);
            this.groupBox2.Controls.Add(this.btn_delete_product);
            this.groupBox2.Controls.Add(this.btn_next_product);
            this.groupBox2.Controls.Add(this.btn_last_product);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lb_product_quantity);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lb_product_type);
            this.groupBox2.Controls.Add(this.lb_id);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lb_product_manufacturer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_product_model);
            this.groupBox2.Location = new System.Drawing.Point(37, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 300);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Information";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Image = global::store_management.Properties.Resources.exit;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_back.Location = new System.Drawing.Point(476, 222);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(72, 72);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Exit";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_index_of
            // 
            this.lb_index_of.AutoSize = true;
            this.lb_index_of.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_index_of.Location = new System.Drawing.Point(132, 26);
            this.lb_index_of.Name = "lb_index_of";
            this.lb_index_of.Size = new System.Drawing.Size(0, 20);
            this.lb_index_of.TabIndex = 14;
            // 
            // btn_see_full_info
            // 
            this.btn_see_full_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_see_full_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_full_info.Image = global::store_management.Properties.Resources.view;
            this.btn_see_full_info.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_see_full_info.Location = new System.Drawing.Point(285, 222);
            this.btn_see_full_info.Name = "btn_see_full_info";
            this.btn_see_full_info.Size = new System.Drawing.Size(72, 72);
            this.btn_see_full_info.TabIndex = 4;
            this.btn_see_full_info.Text = "Detail";
            this.btn_see_full_info.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_see_full_info.UseVisualStyleBackColor = true;
            this.btn_see_full_info.Click += new System.EventHandler(this.btn_see_full_info_Click);
            // 
            // btn_delete_product
            // 
            this.btn_delete_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_product.Image = global::store_management.Properties.Resources.delete;
            this.btn_delete_product.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delete_product.Location = new System.Drawing.Point(378, 222);
            this.btn_delete_product.Name = "btn_delete_product";
            this.btn_delete_product.Size = new System.Drawing.Size(72, 72);
            this.btn_delete_product.TabIndex = 5;
            this.btn_delete_product.Text = "Delete";
            this.btn_delete_product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete_product.UseVisualStyleBackColor = true;
            this.btn_delete_product.Click += new System.EventHandler(this.btn_delete_product_Click);
            // 
            // btn_next_product
            // 
            this.btn_next_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_next_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next_product.Image = global::store_management.Properties.Resources.forward;
            this.btn_next_product.Location = new System.Drawing.Point(136, 222);
            this.btn_next_product.Name = "btn_next_product";
            this.btn_next_product.Size = new System.Drawing.Size(60, 28);
            this.btn_next_product.TabIndex = 13;
            this.btn_next_product.UseVisualStyleBackColor = true;
            this.btn_next_product.Click += new System.EventHandler(this.btn_next_product_Click);
            // 
            // btn_last_product
            // 
            this.btn_last_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_last_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last_product.Image = global::store_management.Properties.Resources.back;
            this.btn_last_product.Location = new System.Drawing.Point(19, 222);
            this.btn_last_product.Name = "btn_last_product";
            this.btn_last_product.Size = new System.Drawing.Size(60, 28);
            this.btn_last_product.TabIndex = 12;
            this.btn_last_product.UseVisualStyleBackColor = true;
            this.btn_last_product.Click += new System.EventHandler(this.btn_last_product_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(354, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Product Quantity";
            // 
            // lb_product_quantity
            // 
            this.lb_product_quantity.AutoSize = true;
            this.lb_product_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_product_quantity.Location = new System.Drawing.Point(187, 174);
            this.lb_product_quantity.Name = "lb_product_quantity";
            this.lb_product_quantity.Size = new System.Drawing.Size(0, 13);
            this.lb_product_quantity.TabIndex = 9;
            this.lb_product_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Product Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Product type";
            // 
            // lb_product_type
            // 
            this.lb_product_type.AutoSize = true;
            this.lb_product_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_product_type.Location = new System.Drawing.Point(187, 66);
            this.lb_product_type.Name = "lb_product_type";
            this.lb_product_type.Size = new System.Drawing.Size(0, 13);
            this.lb_product_type.TabIndex = 6;
            this.lb_product_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(187, 93);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(0, 13);
            this.lb_id.TabIndex = 5;
            this.lb_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Product ID";
            // 
            // lb_product_manufacturer
            // 
            this.lb_product_manufacturer.AutoSize = true;
            this.lb_product_manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_product_manufacturer.Location = new System.Drawing.Point(187, 120);
            this.lb_product_manufacturer.Name = "lb_product_manufacturer";
            this.lb_product_manufacturer.Size = new System.Drawing.Size(0, 13);
            this.lb_product_manufacturer.TabIndex = 3;
            this.lb_product_manufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Product Manufacturer";
            // 
            // lb_product_model
            // 
            this.lb_product_model.AutoSize = true;
            this.lb_product_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_product_model.Location = new System.Drawing.Point(187, 147);
            this.lb_product_model.Name = "lb_product_model";
            this.lb_product_model.Size = new System.Drawing.Size(0, 13);
            this.lb_product_model.TabIndex = 1;
            this.lb_product_model.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::store_management.Properties.Resources.close_window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(662, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_all_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_all_products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Products";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.RadioButton rb_by_product_model;
        private System.Windows.Forms.TextBox tb_keywords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_product_manufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_product_model;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_product_quantity;
        private System.Windows.Forms.Button btn_see_full_info;
        private System.Windows.Forms.Button btn_delete_product;
        private System.Windows.Forms.Button btn_next_product;
        private System.Windows.Forms.Button btn_last_product;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb_byid;
        private System.Windows.Forms.RadioButton rb_by_manufacturer;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_index_of;
        private System.Windows.Forms.Button btn_load_all_products;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_product_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button button1;
    }
}