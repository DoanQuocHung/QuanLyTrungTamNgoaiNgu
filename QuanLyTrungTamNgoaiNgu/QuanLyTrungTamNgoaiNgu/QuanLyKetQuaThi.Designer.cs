﻿
namespace QuanLyTrungTamNgoaiNgu
{
    partial class QuanLyKetQuaThi
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKhoaThi = new System.Windows.Forms.ComboBox();
            this.btnTim2 = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenThiSinh = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridview_qlketquathi = new System.Windows.Forms.DataGridView();
            this.Ten_KhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cccd_TS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen_TS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt_TS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_BaiThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBaoDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_PhongThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_qlketquathi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trang Quản Lý Kết quả thi";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.cbKhoaThi);
            this.panel7.Controls.Add(this.btnTim2);
            this.panel7.Controls.Add(this.btnTim);
            this.panel7.Controls.Add(this.txtSDT);
            this.panel7.Controls.Add(this.txtTenThiSinh);
            this.panel7.Controls.Add(this.txtCCCD);
            this.panel7.Location = new System.Drawing.Point(413, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(654, 89);
            this.panel7.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "CCCD - Khóa Thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên - SĐT";
            // 
            // cbKhoaThi
            // 
            this.cbKhoaThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoaThi.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoaThi.FormattingEnabled = true;
            this.cbKhoaThi.Location = new System.Drawing.Point(316, 6);
            this.cbKhoaThi.Name = "cbKhoaThi";
            this.cbKhoaThi.Size = new System.Drawing.Size(218, 37);
            this.cbKhoaThi.TabIndex = 2;
            // 
            // btnTim2
            // 
            this.btnTim2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim2.Location = new System.Drawing.Point(539, 50);
            this.btnTim2.Name = "btnTim2";
            this.btnTim2.Size = new System.Drawing.Size(110, 36);
            this.btnTim2.TabIndex = 1;
            this.btnTim2.Text = "Tìm kiếm";
            this.btnTim2.UseVisualStyleBackColor = true;
            this.btnTim2.Click += new System.EventHandler(this.btnTim2_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(539, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(110, 36);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(316, 50);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(218, 36);
            this.txtSDT.TabIndex = 0;
            // 
            // txtTenThiSinh
            // 
            this.txtTenThiSinh.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThiSinh.Location = new System.Drawing.Point(140, 50);
            this.txtTenThiSinh.Name = "txtTenThiSinh";
            this.txtTenThiSinh.Size = new System.Drawing.Size(170, 36);
            this.txtTenThiSinh.TabIndex = 0;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(140, 6);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(170, 36);
            this.txtCCCD.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.datagridview_qlketquathi);
            this.panel1.Location = new System.Drawing.Point(6, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 536);
            this.panel1.TabIndex = 5;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(939, 18);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(117, 48);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách Kết quả thi";
            // 
            // datagridview_qlketquathi
            // 
            this.datagridview_qlketquathi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_qlketquathi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten_KhoaThi,
            this.NgayThi,
            this.TrinhDo,
            this.Cccd_TS,
            this.HoTen_TS,
            this.Sdt_TS,
            this.Id_BaiThi,
            this.SoBaoDanh,
            this.Ten_PhongThi,
            this.DiemNghe,
            this.DiemNoi,
            this.DiemDoc,
            this.DiemViet});
            this.datagridview_qlketquathi.Location = new System.Drawing.Point(6, 86);
            this.datagridview_qlketquathi.Name = "datagridview_qlketquathi";
            this.datagridview_qlketquathi.RowHeadersWidth = 51;
            this.datagridview_qlketquathi.RowTemplate.Height = 24;
            this.datagridview_qlketquathi.Size = new System.Drawing.Size(1050, 443);
            this.datagridview_qlketquathi.TabIndex = 7;
            // 
            // Ten_KhoaThi
            // 
            this.Ten_KhoaThi.HeaderText = "Ten_KhoaThi";
            this.Ten_KhoaThi.MinimumWidth = 8;
            this.Ten_KhoaThi.Name = "Ten_KhoaThi";
            this.Ten_KhoaThi.Width = 150;
            // 
            // NgayThi
            // 
            this.NgayThi.HeaderText = "NgayThi";
            this.NgayThi.MinimumWidth = 8;
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.Width = 150;
            // 
            // TrinhDo
            // 
            this.TrinhDo.HeaderText = "TrinhDo";
            this.TrinhDo.MinimumWidth = 8;
            this.TrinhDo.Name = "TrinhDo";
            this.TrinhDo.Width = 150;
            // 
            // Cccd_TS
            // 
            this.Cccd_TS.HeaderText = "Cccd_TS";
            this.Cccd_TS.MinimumWidth = 8;
            this.Cccd_TS.Name = "Cccd_TS";
            this.Cccd_TS.Width = 95;
            // 
            // HoTen_TS
            // 
            this.HoTen_TS.HeaderText = "HoTen_TS";
            this.HoTen_TS.MinimumWidth = 8;
            this.HoTen_TS.Name = "HoTen_TS";
            this.HoTen_TS.Width = 140;
            // 
            // Sdt_TS
            // 
            this.Sdt_TS.HeaderText = "Sdt_TS";
            this.Sdt_TS.MinimumWidth = 8;
            this.Sdt_TS.Name = "Sdt_TS";
            this.Sdt_TS.Width = 110;
            // 
            // Id_BaiThi
            // 
            this.Id_BaiThi.HeaderText = "Id_BaiThi";
            this.Id_BaiThi.MinimumWidth = 8;
            this.Id_BaiThi.Name = "Id_BaiThi";
            this.Id_BaiThi.Width = 80;
            // 
            // SoBaoDanh
            // 
            this.SoBaoDanh.HeaderText = "SoBaoDanh";
            this.SoBaoDanh.MinimumWidth = 8;
            this.SoBaoDanh.Name = "SoBaoDanh";
            this.SoBaoDanh.Width = 150;
            // 
            // Ten_PhongThi
            // 
            this.Ten_PhongThi.HeaderText = "Ten_PhongThi";
            this.Ten_PhongThi.MinimumWidth = 8;
            this.Ten_PhongThi.Name = "Ten_PhongThi";
            this.Ten_PhongThi.Width = 120;
            // 
            // DiemNghe
            // 
            this.DiemNghe.HeaderText = "DiemNghe";
            this.DiemNghe.MinimumWidth = 8;
            this.DiemNghe.Name = "DiemNghe";
            this.DiemNghe.Width = 90;
            // 
            // DiemNoi
            // 
            this.DiemNoi.HeaderText = "DiemNoi";
            this.DiemNoi.MinimumWidth = 8;
            this.DiemNoi.Name = "DiemNoi";
            this.DiemNoi.Width = 80;
            // 
            // DiemDoc
            // 
            this.DiemDoc.HeaderText = "DiemDoc";
            this.DiemDoc.MinimumWidth = 8;
            this.DiemDoc.Name = "DiemDoc";
            this.DiemDoc.Width = 80;
            // 
            // DiemViet
            // 
            this.DiemViet.HeaderText = "DiemViet";
            this.DiemViet.MinimumWidth = 8;
            this.DiemViet.Name = "DiemViet";
            this.DiemViet.Width = 80;
            // 
            // QuanLyKetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1074, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyKetQuaThi";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_qlketquathi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbKhoaThi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridview_qlketquathi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_KhoaThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cccd_TS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen_TS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt_TS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_BaiThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBaoDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_PhongThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemViet;
    }
}