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
    public partial class ThemKhoaThi : Form
    {
        public List<KhoaThiDTO> list { set; get; }
        public ThemKhoaThi(List<KhoaThiDTO> list)
        {
            InitializeComponent();
            this.list = list;
            dateKhoaThi.MinDate = DateTime.Now;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string ma = new KhoaThiBUS().MakeID();
            string ten = "Khóa " + ma;
            string ngay = dateKhoaThi.Text;

            if (new KhoaThiBUS().Insert(new KhoaThiDTO(ma,ten,ngay)))
            {
                MessageBox.Show("Tạo Khóa thi thành công");
                this.list.Add(new KhoaThiDTO(ma, ten, ngay));
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Lỗi tạo khóa");
                Close();
            }
        }
    }
}
