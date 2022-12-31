
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
            this.btn_add_new_product = new System.Windows.Forms.Button();
            this.btn_see_all_product = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(110, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Storage Management";
            // 
            // btn_add_new_product
            // 
            this.btn_add_new_product.Location = new System.Drawing.Point(101, 112);
            this.btn_add_new_product.Name = "btn_add_new_product";
            this.btn_add_new_product.Size = new System.Drawing.Size(346, 55);
            this.btn_add_new_product.TabIndex = 1;
            this.btn_add_new_product.Text = "Add New Product";
            this.btn_add_new_product.UseVisualStyleBackColor = true;
            this.btn_add_new_product.Click += new System.EventHandler(this.btn_add_new_product_Click);
            // 
            // btn_see_all_product
            // 
            this.btn_see_all_product.Location = new System.Drawing.Point(101, 192);
            this.btn_see_all_product.Name = "btn_see_all_product";
            this.btn_see_all_product.Size = new System.Drawing.Size(346, 55);
            this.btn_see_all_product.TabIndex = 2;
            this.btn_see_all_product.Text = "See All Product";
            this.btn_see_all_product.UseVisualStyleBackColor = true;
            this.btn_see_all_product.Click += new System.EventHandler(this.btn_see_all_product_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(101, 325);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(346, 55);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "[Team\'s name]";
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_see_all_product);
            this.Controls.Add(this.btn_add_new_product);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_new_product;
        private System.Windows.Forms.Button btn_see_all_product;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label2;
    }
}

