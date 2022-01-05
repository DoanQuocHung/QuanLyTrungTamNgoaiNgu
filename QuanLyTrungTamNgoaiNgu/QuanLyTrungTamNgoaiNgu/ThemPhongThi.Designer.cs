
namespace QuanLyTrungTamNgoaiNgu
{
    partial class ThemPhongThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhongThi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCaThi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.cboCaThi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 152);
            this.panel1.TabIndex = 3;
            // 
            // cboCaThi
            // 
            this.cboCaThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaThi.Location = new System.Drawing.Point(207, 30);
            this.cboCaThi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboCaThi.Name = "cboCaThi";
            this.cboCaThi.Size = new System.Drawing.Size(317, 24);
            this.cboCaThi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label5.Location = new System.Drawing.Point(30, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ca Thi";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnHuy.Location = new System.Drawing.Point(415, 94);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 48);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(201, 94);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(188, 48);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "      Tạo Phòng thi";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ThemPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 172);
            this.Controls.Add(this.panel1);
            this.Name = "ThemPhongThi";
            this.Text = "ThemPhongThi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboCaThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
    }
}