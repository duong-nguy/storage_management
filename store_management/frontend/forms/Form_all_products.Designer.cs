
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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rb_by_manufacturer = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.rb_by_product_model = new System.Windows.Forms.RadioButton();
            this.tb_keywords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_product_manufacturer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_product_model = new System.Windows.Forms.Label();
            this.btn_load_all_products = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.rb_by_manufacturer);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tb_type);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.rb_by_product_model);
            this.groupBox1.Controls.Add(this.tb_keywords);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(167, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "By Product Id";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rb_by_manufacturer
            // 
            this.rb_by_manufacturer.AutoSize = true;
            this.rb_by_manufacturer.Location = new System.Drawing.Point(304, 70);
            this.rb_by_manufacturer.Name = "rb_by_manufacturer";
            this.rb_by_manufacturer.Size = new System.Drawing.Size(103, 17);
            this.rb_by_manufacturer.TabIndex = 7;
            this.rb_by_manufacturer.TabStop = true;
            this.rb_by_manufacturer.Text = "By Manufacturer";
            this.rb_by_manufacturer.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(478, 67);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(92, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(255, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Type";
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(307, 27);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(100, 20);
            this.tb_type.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(478, 26);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rb_by_product_model
            // 
            this.rb_by_product_model.AutoSize = true;
            this.rb_by_product_model.Location = new System.Drawing.Point(26, 70);
            this.rb_by_product_model.Name = "rb_by_product_model";
            this.rb_by_product_model.Size = new System.Drawing.Size(109, 17);
            this.rb_by_product_model.TabIndex = 2;
            this.rb_by_product_model.TabStop = true;
            this.rb_by_product_model.Text = "By Product Model";
            this.rb_by_product_model.UseVisualStyleBackColor = true;
            // 
            // tb_keywords
            // 
            this.tb_keywords.Location = new System.Drawing.Point(93, 27);
            this.tb_keywords.Name = "tb_keywords";
            this.tb_keywords.Size = new System.Drawing.Size(129, 20);
            this.tb_keywords.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Keywords";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
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
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lb_product_manufacturer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_product_model);
            this.groupBox2.Location = new System.Drawing.Point(37, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 300);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(278, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "[n out of num]";
            // 
            // btn_see_full_info
            // 
            this.btn_see_full_info.Location = new System.Drawing.Point(49, 209);
            this.btn_see_full_info.Name = "btn_see_full_info";
            this.btn_see_full_info.Size = new System.Drawing.Size(286, 23);
            this.btn_see_full_info.TabIndex = 4;
            this.btn_see_full_info.Text = "See Full Infomation";
            this.btn_see_full_info.UseVisualStyleBackColor = true;
            this.btn_see_full_info.Click += new System.EventHandler(this.btn_see_full_info_Click);
            // 
            // btn_delete_product
            // 
            this.btn_delete_product.Location = new System.Drawing.Point(49, 248);
            this.btn_delete_product.Name = "btn_delete_product";
            this.btn_delete_product.Size = new System.Drawing.Size(286, 23);
            this.btn_delete_product.TabIndex = 5;
            this.btn_delete_product.Text = "Delete Product";
            this.btn_delete_product.UseVisualStyleBackColor = true;
            this.btn_delete_product.Click += new System.EventHandler(this.btn_delete_product_Click);
            // 
            // btn_next_product
            // 
            this.btn_next_product.Location = new System.Drawing.Point(541, 21);
            this.btn_next_product.Name = "btn_next_product";
            this.btn_next_product.Size = new System.Drawing.Size(75, 23);
            this.btn_next_product.TabIndex = 13;
            this.btn_next_product.Text = ">>";
            this.btn_next_product.UseVisualStyleBackColor = true;
            this.btn_next_product.Click += new System.EventHandler(this.btn_next_product_Click);
            // 
            // btn_last_product
            // 
            this.btn_last_product.Location = new System.Drawing.Point(6, 21);
            this.btn_last_product.Name = "btn_last_product";
            this.btn_last_product.Size = new System.Drawing.Size(75, 23);
            this.btn_last_product.TabIndex = 12;
            this.btn_last_product.Text = "<<";
            this.btn_last_product.UseVisualStyleBackColor = true;
            this.btn_last_product.Click += new System.EventHandler(this.btn_last_product_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(365, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 205);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Product Quantity";
            // 
            // lb_product_quantity
            // 
            this.lb_product_quantity.AutoSize = true;
            this.lb_product_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_product_quantity.Location = new System.Drawing.Point(187, 177);
            this.lb_product_quantity.Name = "lb_product_quantity";
            this.lb_product_quantity.Size = new System.Drawing.Size(92, 13);
            this.lb_product_quantity.TabIndex = 9;
            this.lb_product_quantity.Text = "[product_quantity]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 150);
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
            this.lb_product_type.Size = new System.Drawing.Size(75, 13);
            this.lb_product_type.TabIndex = 6;
            this.lb_product_type.Text = "[product_type]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "[product_id]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 91);
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
            this.lb_product_manufacturer.Size = new System.Drawing.Size(117, 13);
            this.lb_product_manufacturer.TabIndex = 3;
            this.lb_product_manufacturer.Text = "[product_manufacturer]";
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
            this.lb_product_model.Location = new System.Drawing.Point(187, 150);
            this.lb_product_model.Name = "lb_product_model";
            this.lb_product_model.Size = new System.Drawing.Size(83, 13);
            this.lb_product_model.TabIndex = 1;
            this.lb_product_model.Text = "[product_model]";
            // 
            // btn_load_all_products
            // 
            this.btn_load_all_products.Location = new System.Drawing.Point(541, 12);
            this.btn_load_all_products.Name = "btn_load_all_products";
            this.btn_load_all_products.Size = new System.Drawing.Size(129, 23);
            this.btn_load_all_products.TabIndex = 9;
            this.btn_load_all_products.Text = "Load All Products";
            this.btn_load_all_products.UseVisualStyleBackColor = true;
            this.btn_load_all_products.Click += new System.EventHandler(this.btn_load_all_products_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(37, 477);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(633, 50);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back to Menu";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form_all_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 538);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_load_all_products);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rb_by_manufacturer;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_load_all_products;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_product_type;
    }
}