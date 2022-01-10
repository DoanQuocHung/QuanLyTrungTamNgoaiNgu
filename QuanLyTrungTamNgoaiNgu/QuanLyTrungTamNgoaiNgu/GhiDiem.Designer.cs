
namespace QuanLyTrungTamNgoaiNgu
{
    partial class GhiDiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_phongthi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_trinhdo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_khoathi = new System.Windows.Forms.ComboBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridGhiDiem = new System.Windows.Forms.DataGridView();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBaiThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGhiDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ghi Điểm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cb_phongthi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_trinhdo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_khoathi);
            this.panel1.Controls.Add(this.btnTao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gridGhiDiem);
            this.panel1.Location = new System.Drawing.Point(10, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 560);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(754, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_phongthi
            // 
            this.cb_phongthi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_phongthi.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_phongthi.FormattingEnabled = true;
            this.cb_phongthi.Location = new System.Drawing.Point(493, 18);
            this.cb_phongthi.Name = "cb_phongthi";
            this.cb_phongthi.Size = new System.Drawing.Size(122, 37);
            this.cb_phongthi.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phòng thi";
            // 
            // cb_trinhdo
            // 
            this.cb_trinhdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trinhdo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_trinhdo.FormattingEnabled = true;
            this.cb_trinhdo.Location = new System.Drawing.Point(276, 18);
            this.cb_trinhdo.Name = "cb_trinhdo";
            this.cb_trinhdo.Size = new System.Drawing.Size(122, 37);
            this.cb_trinhdo.TabIndex = 14;
            this.cb_trinhdo.SelectedIndexChanged += new System.EventHandler(this.cb_trinhdo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Trình độ";
            // 
            // cb_khoathi
            // 
            this.cb_khoathi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_khoathi.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_khoathi.FormattingEnabled = true;
            this.cb_khoathi.Location = new System.Drawing.Point(75, 18);
            this.cb_khoathi.Name = "cb_khoathi";
            this.cb_khoathi.Size = new System.Drawing.Size(122, 37);
            this.cb_khoathi.TabIndex = 3;
            this.cb_khoathi.SelectedIndexChanged += new System.EventHandler(this.cb_khoathi_SelectedIndexChanged);
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(877, 19);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(169, 48);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Lưu";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Khóa";
            // 
            // gridGhiDiem
            // 
            this.gridGhiDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGhiDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGhiDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCCD,
            this.HoTen,
            this.DiemNghe,
            this.DiemNoi,
            this.DiemDoc,
            this.DiemViet,
            this.MaBaiThi,
            this.TrungBinh});
            this.gridGhiDiem.Location = new System.Drawing.Point(6, 81);
            this.gridGhiDiem.Name = "gridGhiDiem";
            this.gridGhiDiem.RowHeadersWidth = 51;
            this.gridGhiDiem.RowTemplate.Height = 24;
            this.gridGhiDiem.Size = new System.Drawing.Size(1048, 473);
            this.gridGhiDiem.TabIndex = 7;
            // 
            // CCCD
            // 
            this.CCCD.HeaderText = "CCCD/CMND";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // DiemNghe
            // 
            this.DiemNghe.HeaderText = "Điểm Nghe";
            this.DiemNghe.MinimumWidth = 6;
            this.DiemNghe.Name = "DiemNghe";
            this.DiemNghe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DiemNoi
            // 
            this.DiemNoi.HeaderText = "Điểm Nói";
            this.DiemNoi.MinimumWidth = 6;
            this.DiemNoi.Name = "DiemNoi";
            // 
            // DiemDoc
            // 
            this.DiemDoc.HeaderText = "Điểm Đọc";
            this.DiemDoc.MinimumWidth = 6;
            this.DiemDoc.Name = "DiemDoc";
            // 
            // DiemViet
            // 
            this.DiemViet.HeaderText = "Điểm Viết";
            this.DiemViet.MinimumWidth = 6;
            this.DiemViet.Name = "DiemViet";
            // 
            // MaBaiThi
            // 
            this.MaBaiThi.HeaderText = "Mã Bài Thi";
            this.MaBaiThi.MinimumWidth = 6;
            this.MaBaiThi.Name = "MaBaiThi";
            this.MaBaiThi.ReadOnly = true;
            this.MaBaiThi.Visible = false;
            // 
            // TrungBinh
            // 
            this.TrungBinh.HeaderText = "Điểm TB";
            this.TrungBinh.MinimumWidth = 6;
            this.TrungBinh.Name = "TrungBinh";
            this.TrungBinh.ReadOnly = true;
            // 
            // GhiDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GhiDiem";
            this.Text = "GhiDiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGhiDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_trinhdo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_khoathi;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridGhiDiem;
        private System.Windows.Forms.ComboBox cb_phongthi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemViet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBaiThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
    }
}