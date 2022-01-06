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
        public List<ThiSinhDTO> list { get; set; }
        public QuanLyThiSinh_Them(List<ThiSinhDTO> list)
        {
            InitializeComponent();
            this.list = list;
            //textBox1.Text = new ThiSinhBUS().MakeID();
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
            if (cccd_ts.Equals(""))
            {
                MessageBox.Show("Xin hãy nhập CCCD");
                return;
            }
            if (new ThiSinhBUS().Insert(new ThiSinhDTO(cccd_ts, hoten_ts, gioitinh_ts, ngaysinh_ts, noisinh_ts, ngaycap_ts,
                noicap_ts, sdt_ts, email_ts)))
            {
                MessageBox.Show("Thêm thành công");
                this.list.Add(new ThiSinhDTO(cccd_ts, hoten_ts, gioitinh_ts, ngaysinh_ts, noisinh_ts, ngaycap_ts,
                noicap_ts, sdt_ts, email_ts));
                this.DialogResult = DialogResult.OK;
                Hide();
            }
        }

    }
}
