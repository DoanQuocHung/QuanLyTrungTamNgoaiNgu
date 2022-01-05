using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Diagnostics;

namespace QuanLyTourDuLich
{
    public partial class ChiTietPhongThi : Form
    {
        public List<BaiThiDTO> list;
        public PhongThiDTO phongThiDTO = new PhongThiDTO();
        public ChiTietPhongThi(PhongThiDTO phongThiDTO)
        {
            InitializeComponent();
            this.phongThiDTO=phongThiDTO;
            list = new BaiThiBUS().ListBaiThi_MaPhong(phongThiDTO.Id_PhongThi);
            datagridview_dsTS.AutoGenerateColumns = false;
            txt1.Text = phongThiDTO.Ten_PhongThi;
            txt2.Text = phongThiDTO.Id_KhoaThi;
            txt3.Text = phongThiDTO.CaThi;

            BindGrid(list);
        }
        public void BindGrid(List<BaiThiDTO> listBaiThi)
        {
            datagridview_dsTS.Rows.Clear();
            datagridview_dsTS.Refresh();
            int i = 0;
            foreach (BaiThiDTO item in listBaiThi)
            {
                i++;
                datagridview_dsTS.Rows.Add(item.Id_BaiThi, i, item.SoBaoDanh, new BaiThiBUS().getTenThiSinh(item.Cccd_TS), item.Cccd_TS);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (datagridview_dsTS.SelectedCells.Count > 0)
            {
                int selectedrowindex = datagridview_dsTS.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datagridview_dsTS.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["IdBaiThi"].Value);

                if (new BaiThiBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                    list.RemoveAll(x => x.Id_BaiThi.Equals(cellValue));
                    BindGrid(list);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string caThi = txt3.Text;

            if (caThi.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập Ca thi");
                return;
            }

            if (new PhongThiBUS().Update(caThi, phongThiDTO.Id_PhongThi))
            {

                MessageBox.Show("Sửa thành công");
                phongThiDTO.CaThi = caThi;
            }
        }
    }
}
