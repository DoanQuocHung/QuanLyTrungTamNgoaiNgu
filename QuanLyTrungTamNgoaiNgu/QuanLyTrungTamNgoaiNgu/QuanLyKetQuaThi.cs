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
        List<ThiSinhDTO> listThiSinh;
        List<BaiThiDTO> listBaiThi;
        List<PhongThiDTO> listPhongThi;
        public QuanLyKetQuaThi()
        {
            InitializeComponent();
            listBaiThi = new KetQuaThiBUS().List();
            datagridview_qlketquathi.AutoGenerateColumns = false;
            BindGrid(listBaiThi);
        }

        public void BindGrid(List<BaiThiDTO> list)
        {
            datagridview_qlketquathi.Rows.Clear();
            datagridview_qlketquathi.Refresh();
            foreach (BaiThiDTO item in list)
            {
                
                datagridview_qlketquathi.Rows.Add(item.Cccd_TS,
                    item.Id_BaiThi,
                    item.Id_GiaoVien1,
                    item.Id_GiaoVien2,
                    item.Id_PhongThi,
                    item.SoBaoDanh,
                    item.DiemNghe,
                    item.DiemNoi, 
                    item.DiemDoc,
                    item.DiemViet);
            }
        }

    }
}
