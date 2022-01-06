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
    public partial class QuanLyThiSinh_Sua : Form
    {
        public ThiSinhDTO thisinh { get; set; }
        public DangKyDTO dangky { get; set; }
        public QuanLyThiSinh_Sua(ThiSinhDTO thisinh, DangKyDTO dangky)
        {
            InitializeComponent();
            this.thisinh = thisinh;
            this.dangky = dangky;
            List<string> trinhdocb = new List<string> { "A2", "B1" };
            List<string> gioi = new List<string> { "Nam", "Nữ" };
            cb_gioitinh.DataSource = gioi;
            cbTrinhDo.DataSource = trinhdocb;
            txtCCCD.Text = thisinh.Cccd_TS;
            txtHoTen.Text = thisinh.HoTen_TS;
            txtEmail.Text = thisinh.Email_TS;
            txtNoiCap.Text = thisinh.NoiCap_TS;
            txtNoiSinh.Text = thisinh.NoiSinh_TS;
            txtSDT.Text = thisinh.Sdt_TS;
            cbTrinhDo.SelectedItem = dangky.TrinhDo;
            cb_gioitinh.SelectedItem = thisinh.GioiTinh_TS;
            dtNgayCap.Value = DateTime.ParseExact(thisinh.NgayCap_TS, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dtNgaySinh.Value = DateTime.ParseExact(thisinh.NgaySinh_TS, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            if (new ThiSinhBUS().Update(thisinh))
            {
                if (new DangKyBUS().Update(dangky))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    this.DialogResult = DialogResult.OK;
                    Hide();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại");
                    this.DialogResult = DialogResult.Cancel;
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");
                this.DialogResult = DialogResult.Cancel;
                Hide();
            }
        }
    }
}
