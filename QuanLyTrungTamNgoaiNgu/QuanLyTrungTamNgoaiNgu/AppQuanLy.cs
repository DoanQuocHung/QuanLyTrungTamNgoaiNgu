using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class AppQuanLy : Form
    {
        public AppQuanLy()
        {
            InitializeComponent();
        }

        //Quản lý Thí sinh ==============================================================================================================
        //Hàm lấy danh sách
        public void BindGrid()
        {

        }
        ////Button thêm 
        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
        ////Button Sửa 
        //private void button2_Click(object sender, EventArgs e)
        //{

        //}
        ////Button Xóa 
        //private void button3_Click(object sender, EventArgs e)
        //{
        //}
        ////Button Chi tiết 

        ////Button Reload 
        //private void button5_Click(object sender, EventArgs e)
        //{

        //}

        //LEFT MENU BAR ===================================================================================================================
        //Button chuyển trang Quản Lý Thí sinh  
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyThiSinh());
        }

        //Button chuyển trang Quản Lý Phòng Thi
        public void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhongThi());
        }
        public void quanlyphongthi()
        {
            OpenChildForm(new QuanLyPhongThi());
        }

        //Button chuyển trang Quản Lý Khoa Thi
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhoaThi());
        }

        //Button chuyển trang Quản Lý Kết quả thi
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKetQuaThi());
        }

        //Button chuyển trang Ghi Điểm
        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GhiDiem());
        }

        //Hàm xử lý chuyển trang ==========================================================================================================
        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
