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
    public partial class SuaKhoaThi : Form
    {
        public List<KhoaThiDTO> list { set; get; }
        KhoaThiDTO obj;
        public SuaKhoaThi(List<KhoaThiDTO> list, string id)
        {
            InitializeComponent();
            this.list = list;
            obj = list.Find(x => x.Id_KhoaThi == id);
            dateKhoaThi.Value = DateTime.ParseExact(
                                            obj.NgayThi , 
                                            "dd/MM/yyyy",
                                            System.Globalization.CultureInfo.InvariantCulture
                                            );
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string ma = obj.Id_KhoaThi;
            string ten = obj.Ten_KhoaThi;
            string ngay = dateKhoaThi.Text;

            if (new KhoaThiBUS().Update(new KhoaThiDTO(ma, ten, ngay)))
            {
                MessageBox.Show("Sửa ngày Khóa thi thành công");
                this.list.Find(x => x.Id_KhoaThi == obj.Id_KhoaThi).NgayThi = ngay;
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
