
namespace store_management.frontend.forms
{
    partial class Form_add_product
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
            this.cbox_product_to_add = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbox_quanity = new System.Windows.Forms.NumericUpDown();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_manufacturer = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_history = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbox_quanity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product to Store";
            // 
            // cbox_product_to_add
            // 
            this.cbox_product_to_add.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbox_product_to_add.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_product_to_add.FormattingEnabled = true;
            this.cbox_product_to_add.Items.AddRange(new object[] {
            "Androids",
            "Drones",
            "Exoskeletons",
            "Space Guns",
            "Warp drives"});
            this.cbox_product_to_add.Location = new System.Drawing.Point(111, 94);
            this.cbox_product_to_add.Name = "cbox_product_to_add";
            this.cbox_product_to_add.Size = new System.Drawing.Size(114, 21);
            this.cbox_product_to_add.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product type";
            // 
            // nbox_quanity
            // 
            this.nbox_quanity.Location = new System.Drawing.Point(368, 97);
            this.nbox_quanity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nbox_quanity.Name = "nbox_quanity";
            this.nbox_quanity.Size = new System.Drawing.Size(55, 20);
            this.nbox_quanity.TabIndex = 7;
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(309, 142);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(114, 20);
            this.tb_model.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Model";
            // 
            // cb_manufacturer
            // 
            this.cb_manufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_manufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_manufacturer.FormattingEnabled = true;
            this.cb_manufacturer.Items.AddRange(new object[] {
            "Stark Industry",
            "LNet",
            "Cyber Media",
            "UAS",
            "SHI"});
            this.cb_manufacturer.Location = new System.Drawing.Point(111, 139);
            this.cb_manufacturer.Name = "cb_manufacturer";
            this.cb_manufacturer.Size = new System.Drawing.Size(114, 21);
            this.cb_manufacturer.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_history);
            this.groupBox1.Controls.Add(this.cb_manufacturer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_model);
            this.groupBox1.Controls.Add(this.nbox_quanity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbox_product_to_add);
            this.groupBox1.Location = new System.Drawing.Point(23, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::store_management.Properties.Resources.exit;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(272, 365);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(91, 86);
            this.btn_back.TabIndex = 6;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add_product
            // 
            this.btn_add_product.BackgroundImage = global::store_management.Properties.Resources.add_new;
            this.btn_add_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_product.Location = new System.Drawing.Point(118, 365);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(84, 86);
            this.btn_add_product.TabIndex = 3;
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::store_management.Properties.Resources.close_window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(464, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_history
            // 
            this.lb_history.AutoSize = true;
            this.lb_history.Location = new System.Drawing.Point(267, 230);
            this.lb_history.Name = "lb_history";
            this.lb_history.Size = new System.Drawing.Size(0, 13);
            this.lb_history.TabIndex = 13;
            // 
            // Form_add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_add_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.nbox_quanity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbox_product_to_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbox_quanity;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_manufacturer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_history;
    }
}