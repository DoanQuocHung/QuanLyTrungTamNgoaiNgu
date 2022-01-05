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
        List<KhoaThiDTO> listKhoaThi;
        public QuanLyKetQuaThi()
        {
            InitializeComponent();
            listKetQuaThi = new KetQuaThiBUS().List();
            listKhoaThi = new KhoaThiBUS().List();
            cbKhoaThi.Items.Clear();
            
            foreach (KhoaThiDTO item in listKhoaThi)
            {
                cbKhoaThi.Items.Add(item.Ten_KhoaThi);
            }
            cbKhoaThi.SelectedItem = listKhoaThi[0].Ten_KhoaThi;
            datagridview_qlketquathi.AutoGenerateColumns = false;
            BindGrid(listKetQuaThi);
        }

        public void BindGrid(List<KetQuaThiDTO> list)
        {
            datagridview_qlketquathi.Rows.Clear();
            datagridview_qlketquathi.Refresh();
            foreach (KetQuaThiDTO item in list)
            {
                
                datagridview_qlketquathi.Rows.Add(
                    item.Ten_KhoaThi,
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
            string cccd = txtCCCD.Text;
            string khoathi = cbKhoaThi.SelectedItem.ToString();
            List<KetQuaThiDTO> listsearchKhoaThi = new List<KetQuaThiDTO>();
            listsearchKhoaThi = listKetQuaThi.FindAll(x => x.Ten_KhoaThi.Contains(khoathi));
            List<KetQuaThiDTO> listResultSearch = new List<KetQuaThiDTO>();
            listResultSearch = listsearchKhoaThi.FindAll(x => x.Cccd_TS.Contains(cccd));
            BindGrid(listResultSearch);
        }

        private void btnTim2_Click(object sender, EventArgs e)
        {
            string ten = txtTenThiSinh.Text.ToLower();
            string sdt = txtSDT.Text;
            List<KetQuaThiDTO> listsearchTenTS = new List<KetQuaThiDTO>();
            listsearchTenTS = listKetQuaThi.FindAll(x => x.HoTen_TS.ToLower().Contains(ten));
            List<KetQuaThiDTO> listResultSearch = new List<KetQuaThiDTO>();
            listResultSearch = listsearchTenTS.FindAll(x => x.Sdt_TS.Contains(sdt));
            BindGrid(listResultSearch);
        }
    }
}
