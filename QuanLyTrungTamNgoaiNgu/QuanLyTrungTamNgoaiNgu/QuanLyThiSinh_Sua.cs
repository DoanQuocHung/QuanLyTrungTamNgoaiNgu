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
        public List<ThiSinhDTO> list { get; set; }
        public QuanLyThiSinh_Sua(List<ThiSinhDTO> list, string id)
        {
            InitializeComponent();
            this.list = list;
            ThiSinhDTO edit = list.Find(x => x.Cccd_TS.Equals(id));

            textBox1.Text = id;
            textBox2.Text = edit.HoTen_TS;
            textBox2.Text = edit.GioiTinh_TS;
            textBox2.Text = edit.NgaySinh_TS;
            textBox2.Text = edit.NoiSinh_TS;
            textBox2.Text = edit.NgayCap_TS;
            textBox2.Text = edit.NoiCap_TS;
            textBox2.Text = edit.Sdt_TS;
            textBox2.Text = edit.Email_TS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cccd_ts = textBox1.Text;
            string hoten_ts = textBox2.Text;
            string gioitinh_ts = textBox3.Text;
            string ngaysinh_ts = textBox4.Text;
            string noisinh_ts = textBox5.Text;
            string ngaycap_ts = textBox6.Text;
            string noicap_ts = textBox7.Text;
            string sdt_ts = textBox8.Text;
            string email_ts = textBox9.Text;
            if (hoten_ts.Equals(""))
            {
                MessageBox.Show("Xin hãy nhập tên địa điểm");
                return;
            }
            if (new ThiSinhBUS().Update(new ThiSinhDTO(cccd_ts, hoten_ts, gioitinh_ts, ngaysinh_ts, noisinh_ts, ngaycap_ts,
                noicap_ts, sdt_ts, email_ts)))
            {
                MessageBox.Show("Sửa thành công");
                //list.Find(x => x.Cccd_TS.Equals(cccd_ts)).HoTen_TS = hoten_ts;
                //    .Gioi = gioitinh_ts
                //    .HoTen_TS = ngaysinh_ts
                //    .HoTen_TS = noisinh_ts
                //    .HoTen_TS = ngaycap_ts
                //    .HoTen_TS = noicap_ts
                //    .HoTen_TS = sdt_ts
                //    .HoTen_TS = email_ts;
                //this.DialogResult = DialogResult.OK;
                Hide();
            }
        }

    }
}
