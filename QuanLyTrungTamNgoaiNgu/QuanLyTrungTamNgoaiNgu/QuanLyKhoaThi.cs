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
    public partial class QuanLyKhoaThi : Form
    {
        List<KhoaThiDTO> list;
        public QuanLyKhoaThi()
        {
            InitializeComponent();
            list = new KhoaThiBUS().List();
        }
        public void BindGrid(List<KhoaThiDTO> list)
        {
            datagridview_qlkhoathi.Rows.Clear();
            datagridview_qlkhoathi.Refresh();
            foreach (KhoaThiDTO item in list)
            {

                datagridview_qlkhoathi.Rows.Add(item.Id_KhoaThi,item.Ten_KhoaThi,item.NgayThi);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
