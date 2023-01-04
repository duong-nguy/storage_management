
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_load_photo = new System.Windows.Forms.Button();
            this.picb = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_load_photo);
            this.groupBox1.Controls.Add(this.picb);
            this.groupBox1.Location = new System.Drawing.Point(30, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[product] Information";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(23, 221);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(391, 38);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add [product]";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_load_photo
            // 
            this.btn_load_photo.Location = new System.Drawing.Point(290, 183);
            this.btn_load_photo.Name = "btn_load_photo";
            this.btn_load_photo.Size = new System.Drawing.Size(111, 23);
            this.btn_load_photo.TabIndex = 0;
            this.btn_load_photo.Text = "Load Photo";
            this.btn_load_photo.UseVisualStyleBackColor = true;
            this.btn_load_photo.Click += new System.EventHandler(this.btn_load_photo_Click);
            // 
            // picb
            // 
            this.picb.Location = new System.Drawing.Point(290, 19);
            this.picb.Name = "picb";
            this.picb.Size = new System.Drawing.Size(111, 149);
            this.picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb.TabIndex = 1;
            this.picb.TabStop = false;

            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(30, 349);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(440, 38);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_product_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 408);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button btn_load_photo;
        private System.Windows.Forms.PictureBox picb;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}