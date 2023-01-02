
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
            this.tb_manufacturer = new System.Windows.Forms.TextBox();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.nbox_quanity = new System.Windows.Forms.NumericUpDown();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbox_quanity)).BeginInit();
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
            this.cbox_product_to_add.FormattingEnabled = true;
            this.cbox_product_to_add.Location = new System.Drawing.Point(127, 48);
            this.cbox_product_to_add.Name = "cbox_product_to_add";
            this.cbox_product_to_add.Size = new System.Drawing.Size(114, 21);
            this.cbox_product_to_add.TabIndex = 1;
            // 
            // tb_manufacturer
            // 
            this.tb_manufacturer.Location = new System.Drawing.Point(127, 91);
            this.tb_manufacturer.Name = "tb_manufacturer";
            this.tb_manufacturer.Size = new System.Drawing.Size(100, 20);
            this.tb_manufacturer.TabIndex = 2;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(14, 151);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(446, 40);
            this.btn_add_product.TabIndex = 3;
            this.btn_add_product.Text = "Add Product";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product to Add";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_add_product);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_model);
            this.groupBox1.Controls.Add(this.nbox_quanity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbox_product_to_add);
            this.groupBox1.Controls.Add(this.tb_manufacturer);
            this.groupBox1.Location = new System.Drawing.Point(34, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(304, 92);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(114, 20);
            this.tb_model.TabIndex = 8;
            // 
            // nbox_quanity
            // 
            this.nbox_quanity.Location = new System.Drawing.Point(363, 48);
            this.nbox_quanity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nbox_quanity.Name = "nbox_quanity";
            this.nbox_quanity.Size = new System.Drawing.Size(55, 20);
            this.nbox_quanity.TabIndex = 7;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(34, 283);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(478, 38);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back to Menu";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form_add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 381);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_add_product";
            this.Text = "Add Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbox_quanity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_product_to_add;
        private System.Windows.Forms.TextBox tb_manufacturer;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.NumericUpDown nbox_quanity;
        private System.Windows.Forms.Button btn_back;
    }
}