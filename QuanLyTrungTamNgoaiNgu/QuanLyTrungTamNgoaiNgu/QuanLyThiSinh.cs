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
    public partial class QuanLyThiSinh : Form
    {
        List<ThiSinhDTO> list;
        public QuanLyThiSinh()
        {
            InitializeComponent();
            list = new ThiSinhBUS().List();
            Grid_Danhsachthisinh.AutoGenerateColumns = false;
            //List<string> listtype = new List<string> { "Mã Địa điểm", "Tên Địa điểm" };
            //SearchBox_cb.DataSource = listtype;
            BindGrid(list);
        }

        //Hàm lấy danh sách
        public void BindGrid(List<ThiSinhDTO> list)
        {
            Grid_Danhsachthisinh.Rows.Clear();
            Grid_Danhsachthisinh.Refresh();
            foreach (ThiSinhDTO item in list)
            {
                Grid_Danhsachthisinh.Rows.Add(item.Cccd_TS, item.HoTen_TS, item.GioiTinh_TS, item.NgaySinh_TS, item.NoiSinh_TS, 
                    item.NgayCap_TS, item.NoiCap_TS, item.Sdt_TS, item.Email_TS);
            }
        }
        //Button thêm 
        private void button7_Click(object sender, EventArgs e)
        {

        }
        //Button Sửa 
        private void button8_Click(object sender, EventArgs e)
        {

        }
        //Button Xóa 
        private void button9_Click(object sender, EventArgs e)
        {
        }
        //Button Kết quả thi
        private void button11_Click(object sender, EventArgs e)
        {

        }
        //Button Reload 
        private void button10_Click(object sender, EventArgs e)
        {

        }

        //Hàm xử lý chuyển trang ==========================================================================================================
        //private Form activeForm = null;
        //private void OpenChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panelChildForm.Controls.Add(childForm);
        //    panelChildForm.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
    }
}
