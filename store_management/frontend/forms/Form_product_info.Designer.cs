﻿
namespace store_management.frontend.forms
{
    partial class Form_product_info
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.picb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add [product]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.picb);
            this.groupBox1.Location = new System.Drawing.Point(30, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[product] Information";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::store_management.Properties.Resources.exit;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(164, 199);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 71);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::store_management.Properties.Resources.add_new;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(32, 199);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 71);
            this.btn_add.TabIndex = 8;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // picb
            // 
            this.picb.BackgroundImage = global::store_management.Properties.Resources.pic_upload;
            this.picb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb.ErrorImage = global::store_management.Properties.Resources.close_window;
            this.picb.InitialImage = global::store_management.Properties.Resources.pic_upload;
            this.picb.Location = new System.Drawing.Point(290, 19);
            this.picb.Name = "picb";
            this.picb.Size = new System.Drawing.Size(110, 149);
            this.picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb.TabIndex = 1;
            this.picb.TabStop = false;
            this.picb.Click += new System.EventHandler(this.picb_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::store_management.Properties.Resources.close_window;
            this.button1.Location = new System.Drawing.Point(489, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_product_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_product_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picb;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}