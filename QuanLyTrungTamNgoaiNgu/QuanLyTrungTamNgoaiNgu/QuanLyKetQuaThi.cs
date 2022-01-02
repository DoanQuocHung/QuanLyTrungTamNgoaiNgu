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
    public partial class QuanLyKetQuaThi : Form
    {
        
        List<KetQuaThiDTO> listKetQuaThi;
        public QuanLyKetQuaThi()
        {
            InitializeComponent();
            listKetQuaThi = new KetQuaThiBUS().List();
            datagridview_qlketquathi.AutoGenerateColumns = false;
            BindGrid(listKetQuaThi);
        }

        public void BindGrid(List<KetQuaThiDTO> list)
        {
            datagridview_qlketquathi.Rows.Clear();
            datagridview_qlketquathi.Refresh();
            foreach (KetQuaThiDTO item in list)
            {
                
                datagridview_qlketquathi.Rows.Add(item.Cccd_TS,
                    item.Cccd_TS,
                    item.HoTen_TS,
                    item.Sdt_TS,
                    item.Id_BaiThi,
                    item.SoBaoDanh,
                    item.Ten_PhongThi,
                    item.DiemNghe,
                    item.DiemNoi, 
                    item.DiemDoc,
                    item.DiemViet);
            }
        }


        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindGrid(listKetQuaThi);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string search = txtCCCD.Text;
            List<KetQuaThiDTO> listsearch = new List<KetQuaThiDTO>();
            listsearch = listKetQuaThi.FindAll(x => x.Cccd_TS.Contains(search));
            BindGrid(listsearch);
        }

        private void btnTim2_Click(object sender, EventArgs e)
        {

        }
    }
}
