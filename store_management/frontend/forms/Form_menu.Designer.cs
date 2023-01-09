
namespace store_management
{
    partial class Form_menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_see_all_product = new System.Windows.Forms.Button();
            this.btn_add_new_product = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(70, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Storage Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "[Team\'s name]";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::store_management.Properties.Resources.close_window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(466, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::store_management.Properties.Resources.exit;
            this.btn_exit.Location = new System.Drawing.Point(339, 191);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 100);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_see_all_product
            // 
            this.btn_see_all_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_see_all_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_all_product.Image = global::store_management.Properties.Resources.database;
            this.btn_see_all_product.Location = new System.Drawing.Point(192, 191);
            this.btn_see_all_product.Name = "btn_see_all_product";
            this.btn_see_all_product.Size = new System.Drawing.Size(100, 100);
            this.btn_see_all_product.TabIndex = 2;
            this.btn_see_all_product.Text = "Database";
            this.btn_see_all_product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_see_all_product.UseVisualStyleBackColor = true;
            this.btn_see_all_product.Click += new System.EventHandler(this.btn_see_all_product_Click);
            // 
            // btn_add_new_product
            // 
            this.btn_add_new_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add_new_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new_product.Image = global::store_management.Properties.Resources.add_new;
            this.btn_add_new_product.Location = new System.Drawing.Point(42, 191);
            this.btn_add_new_product.Name = "btn_add_new_product";
            this.btn_add_new_product.Size = new System.Drawing.Size(100, 100);
            this.btn_add_new_product.TabIndex = 1;
            this.btn_add_new_product.Text = "Add Product";
            this.btn_add_new_product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add_new_product.UseVisualStyleBackColor = true;
            this.btn_add_new_product.Click += new System.EventHandler(this.btn_add_new_product_Click);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_see_all_product);
            this.Controls.Add(this.btn_add_new_product);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage Management";
            this.Load += new System.EventHandler(this.Form_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_new_product;
        private System.Windows.Forms.Button btn_see_all_product;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

