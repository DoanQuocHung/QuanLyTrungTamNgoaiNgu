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
    public partial class ThemPhongThi : Form
    {
        public List<PhongThiDTO> list { get; set; }
        public PhongThiDTO phongThi = new PhongThiDTO();
        public ThemPhongThi(List<PhongThiDTO> list, PhongThiDTO phongmoi)
        {
            InitializeComponent();
            this.list = list;
            List<string> listca = new List<string> { "Ca sáng: 7h - 10h", "Ca chiều: 1h - 4h" };
            cboCaThi.DataSource = listca;
            this.phongThi = phongmoi;
            cboCaThi.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            phongThi.CaThi = cboCaThi.SelectedItem.ToString();
            if(new PhongThiBUS().Insert(phongThi))
            {
                MessageBox.Show("Tạo phòng thành công");
                list.Add(phongThi);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
