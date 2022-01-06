using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class QuanLyThiSinh_Them : Form
    {
        public ThiSinhDTO thisinh { get; set; }
        public DangKyDTO dangky { get; set; }
        public QuanLyThiSinh_Them(string khoathi,string trinhdo)
        {
            InitializeComponent();
            dangky = new DangKyDTO();
            thisinh = new ThiSinhDTO();
            dangky.LePhiThi = "500.000 VND";
            dangky.Id_KhoaThi = khoathi;
            dangky.TrinhDo = trinhdo;
            List<string> trinhdocb = new List<string> { "A2", "B1" };
            List<string> gioi = new List<string> { "Nam", "Nữ" };
            cb_gioitinh.DataSource = gioi;
            cbTrinhDo.DataSource = trinhdocb;
            //textBox1.Text = new ThiSinhBUS().MakeID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thisinh.Cccd_TS = txtCCCD.Text;
            thisinh.HoTen_TS = txtHoTen.Text;
            thisinh.GioiTinh_TS = cb_gioitinh.SelectedItem.ToString();
            thisinh.NgaySinh_TS = dtNgaySinh.Text;
            thisinh.NoiSinh_TS = txtNoiSinh.Text;
            thisinh.NgayCap_TS = dtNgayCap.Text;
            thisinh.NoiCap_TS = txtNoiCap.Text;
            thisinh.Sdt_TS = txtSDT.Text;
            thisinh.Email_TS = txtEmail.Text;
            if (thisinh.Cccd_TS == ""
                || thisinh.HoTen_TS == "" 
                || thisinh.NoiSinh_TS == ""
                || thisinh.NoiCap_TS == ""
                || thisinh.Sdt_TS == ""
                || thisinh.Email_TS == "")
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
                return;
            }
            dangky.Cccd_TS = thisinh.Cccd_TS;
            if (new ThiSinhBUS().Exists(thisinh.Cccd_TS))
            {
                if (new DangKyBUS().Insert(dangky))
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.DialogResult = DialogResult.OK;
                    Hide();
                }
                else
                {
                    MessageBox.Show("Thí Sinh Đã đăng ký rồi");
                    this.DialogResult = DialogResult.Cancel;
                    Hide();
                }
            }
            else if (new ThiSinhBUS().Insert(thisinh))
            {
                if (new DangKyBUS().Insert(dangky))
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.DialogResult = DialogResult.OK;
                    Hide();
                }
                else
                {
                    MessageBox.Show("Thí Sinh Đã đăng ký rồi");
                    this.DialogResult = DialogResult.Cancel;
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Thí Sinh Đã đăng ký rồi");
                this.DialogResult = DialogResult.Cancel;
                Hide();
            }
        }

    }
}
