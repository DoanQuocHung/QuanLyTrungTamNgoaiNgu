
namespace QuanLyTrungTamNgoaiNgu
{
    partial class QuanLyKhoaThi
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.cb_searchkhoa = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_searchkhoa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.datagridview_qlkhoathi = new System.Windows.Forms.DataGridView();
            this.Id_KhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_KhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_qlkhoathi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trang Quản Lý Khoa Thi";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.cb_searchkhoa);
            this.panel7.Controls.Add(this.button5);
            this.panel7.Controls.Add(this.txt_searchkhoa);
            this.panel7.Location = new System.Drawing.Point(503, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(568, 62);
            this.panel7.TabIndex = 6;
            // 
            // cb_searchkhoa
            // 
            this.cb_searchkhoa.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_searchkhoa.FormattingEnabled = true;
            this.cb_searchkhoa.Location = new System.Drawing.Point(372, 12);
            this.cb_searchkhoa.Name = "cb_searchkhoa";
            this.cb_searchkhoa.Size = new System.Drawing.Size(73, 37);
            this.cb_searchkhoa.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(451, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 36);
            this.button5.TabIndex = 1;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_searchkhoa
            // 
            this.txt_searchkhoa.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchkhoa.Location = new System.Drawing.Point(3, 12);
            this.txt_searchkhoa.Name = "txt_searchkhoa";
            this.txt_searchkhoa.Size = new System.Drawing.Size(363, 36);
            this.txt_searchkhoa.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.datagridview_qlkhoathi);
            this.panel1.Location = new System.Drawing.Point(10, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 560);
            this.panel1.TabIndex = 5;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(814, 18);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 48);
            this.button11.TabIndex = 13;
            this.button11.Text = "Chi tiết";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(937, 18);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 48);
            this.button10.TabIndex = 12;
            this.button10.Text = "Reload";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(691, 18);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 48);
            this.button9.TabIndex = 11;
            this.button9.Text = "Xóa";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(568, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 48);
            this.button8.TabIndex = 10;
            this.button8.Text = "Sửa";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(443, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 48);
            this.button7.TabIndex = 9;
            this.button7.Text = "Thêm";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // datagridview_qlkhoathi
            // 
            this.datagridview_qlkhoathi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_qlkhoathi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_qlkhoathi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_KhoaThi,
            this.Ten_KhoaThi,
            this.NgayThi});
            this.datagridview_qlkhoathi.Location = new System.Drawing.Point(6, 81);
            this.datagridview_qlkhoathi.Name = "datagridview_qlkhoathi";
            this.datagridview_qlkhoathi.RowHeadersWidth = 51;
            this.datagridview_qlkhoathi.RowTemplate.Height = 24;
            this.datagridview_qlkhoathi.Size = new System.Drawing.Size(1048, 473);
            this.datagridview_qlkhoathi.TabIndex = 7;
            // 
            // Id_KhoaThi
            // 
            this.Id_KhoaThi.HeaderText = "Id_KhoaThi";
            this.Id_KhoaThi.MinimumWidth = 6;
            this.Id_KhoaThi.Name = "Id_KhoaThi";
            this.Id_KhoaThi.ReadOnly = true;
            this.Id_KhoaThi.Visible = false;
            // 
            // Ten_KhoaThi
            // 
            this.Ten_KhoaThi.HeaderText = "Khóa Thi";
            this.Ten_KhoaThi.MinimumWidth = 6;
            this.Ten_KhoaThi.Name = "Ten_KhoaThi";
            this.Ten_KhoaThi.ReadOnly = true;
            // 
            // NgayThi
            // 
            this.NgayThi.HeaderText = "Ngày bắt đầu khóa thi";
            this.NgayThi.MinimumWidth = 6;
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách Khoa thi";
            // 
            // QuanLyKhoaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1074, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyKhoaThi";
            this.Text = "QuanLyKhoaThi";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_qlkhoathi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cb_searchkhoa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_searchkhoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView datagridview_qlkhoathi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_KhoaThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_KhoaThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThi;
        private System.Windows.Forms.Label label2;
    }
}