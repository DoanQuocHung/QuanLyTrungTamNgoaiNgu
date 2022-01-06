
namespace QuanLyTourDuLich
{
    partial class ChiTietPhongThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietPhongThi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.griddangky = new System.Windows.Forms.DataGridView();
            this.cbCaThi = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridview_dsTS = new System.Windows.Forms.DataGridView();
            this.idBaiThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griddangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_dsTS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.griddangky);
            this.panel1.Controls.Add(this.cbCaThi);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datagridview_dsTS);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(9, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 526);
            this.panel1.TabIndex = 2;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblSoLuong.Location = new System.Drawing.Point(151, 132);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(105, 25);
            this.lblSoLuong.TabIndex = 24;
            this.lblSoLuong.Text = "number/30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label4.Location = new System.Drawing.Point(28, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Số Thí Sinh:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(894, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Thêm vào phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // griddangky
            // 
            this.griddangky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.griddangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddangky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMND,
            this.TenThiSinh,
            this.trinhdo});
            this.griddangky.Location = new System.Drawing.Point(605, 228);
            this.griddangky.Name = "griddangky";
            this.griddangky.RowHeadersWidth = 51;
            this.griddangky.RowTemplate.Height = 24;
            this.griddangky.Size = new System.Drawing.Size(477, 291);
            this.griddangky.TabIndex = 21;
            // 
            // cbCaThi
            // 
            this.cbCaThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.15F);
            this.cbCaThi.FormattingEnabled = true;
            this.cbCaThi.Location = new System.Drawing.Point(106, 78);
            this.cbCaThi.Name = "cbCaThi";
            this.cbCaThi.Size = new System.Drawing.Size(278, 23);
            this.cbCaThi.TabIndex = 20;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(406, 74);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 33);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu Ca Thi";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label3.Location = new System.Drawing.Point(17, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Danh sách Thí sinh";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(427, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 33);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = " Xóa Thí sinh";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtPhong
            // 
            this.txtPhong.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhong.Location = new System.Drawing.Point(111, 26);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.ShortcutsEnabled = false;
            this.txtPhong.Size = new System.Drawing.Size(104, 22);
            this.txtPhong.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label2.Location = new System.Drawing.Point(253, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Khóa:";
            // 
            // txtKhoa
            // 
            this.txtKhoa.BackColor = System.Drawing.SystemColors.Control;
            this.txtKhoa.Location = new System.Drawing.Point(328, 26);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.ReadOnly = true;
            this.txtKhoa.ShortcutsEnabled = false;
            this.txtKhoa.Size = new System.Drawing.Size(104, 22);
            this.txtKhoa.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ca thi:";
            // 
            // datagridview_dsTS
            // 
            this.datagridview_dsTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_dsTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBaiThi,
            this.Column1,
            this.sbd,
            this.Column3,
            this.cccd});
            this.datagridview_dsTS.Location = new System.Drawing.Point(9, 228);
            this.datagridview_dsTS.Name = "datagridview_dsTS";
            this.datagridview_dsTS.RowHeadersWidth = 51;
            this.datagridview_dsTS.RowTemplate.Height = 24;
            this.datagridview_dsTS.Size = new System.Drawing.Size(578, 291);
            this.datagridview_dsTS.TabIndex = 11;
            // 
            // idBaiThi
            // 
            this.idBaiThi.HeaderText = "Mã Bài thu";
            this.idBaiThi.MinimumWidth = 8;
            this.idBaiThi.Name = "idBaiThi";
            this.idBaiThi.Visible = false;
            this.idBaiThi.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // sbd
            // 
            this.sbd.HeaderText = "SBD";
            this.sbd.MinimumWidth = 8;
            this.sbd.Name = "sbd";
            this.sbd.ReadOnly = true;
            this.sbd.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Họ tên";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 175;
            // 
            // cccd
            // 
            this.cccd.HeaderText = "CCCD/CMND";
            this.cccd.MinimumWidth = 8;
            this.cccd.Name = "cccd";
            this.cccd.ReadOnly = true;
            this.cccd.Width = 160;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label5.Location = new System.Drawing.Point(28, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phòng:";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnHuy.Location = new System.Drawing.Point(415, 340);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 34);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(281, 340);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "      Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "(none)";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CCCD/CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // TenThiSinh
            // 
            this.TenThiSinh.HeaderText = "Họ Tên";
            this.TenThiSinh.MinimumWidth = 6;
            this.TenThiSinh.Name = "TenThiSinh";
            this.TenThiSinh.ReadOnly = true;
            // 
            // trinhdo
            // 
            this.trinhdo.HeaderText = "trinhdo";
            this.trinhdo.MinimumWidth = 6;
            this.trinhdo.Name = "trinhdo";
            this.trinhdo.ReadOnly = true;
            this.trinhdo.Visible = false;
            // 
            // ChiTietPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1107, 538);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ChiTietPhongThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Phòng thi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griddangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_dsTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridview_dsTS;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBaiThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView griddangky;
        private System.Windows.Forms.ComboBox cbCaThi;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdo;
    }
}