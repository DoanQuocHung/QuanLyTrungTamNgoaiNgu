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
        public List<BaiThiDTO> list ;
        public List<DangKyDTO> listdangky;
        public string cathi;
        public ChiTietPhongThi(string idphong, string khoa, string cathi)
        {
            InitializeComponent();
            txtPhong.Text = idphong;
            txtKhoa.Text = khoa;
            this.cathi = cathi;
            List<string> listtype = new List<string> { "Ca sáng: 7h - 10h", "Ca chiều: 1h - 4h" };
            cbCaThi.DataSource = listtype;
            cbCaThi.SelectedItem = cathi;

            list = new BaiThiBUS().ListBaiThi_MaPhong(idphong);
            listdangky = new DangKyBUS().List().FindAll(x => x.Id_KhoaThi == txtKhoa.Text);
            lblSoLuong.Text = list.Count + "/30";
            BindGrid(list);
            BindGrid2(listdangky);
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
        public void BindGrid2(List<DangKyDTO> listdangky)
        {
            griddangky.Rows.Clear();
            griddangky.Refresh();
            List<ThiSinhDTO> list = new ThiSinhBUS().List();
            foreach (DangKyDTO item in listdangky)
            {
                if (this.list.Exists(x => x.Cccd_TS == item.Cccd_TS))
                { }
                else
                {
                    ThiSinhDTO thisinh = list.Find(x => x.Cccd_TS == item.Cccd_TS);
                    griddangky.Rows.Add(thisinh.Cccd_TS, thisinh.HoTen_TS, item.TrinhDo);
                }
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
                    listdangky = new DangKyBUS().List().FindAll(x => x.Id_KhoaThi == txtKhoa.Text);
                    BindGrid(list);
                    BindGrid2(listdangky);
                    lblSoLuong.Text = list.Count + "/30";
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.cathi = cbCaThi.SelectedItem.ToString();

            if (new PhongThiBUS().Update(cathi, txtPhong.Text))
            {
                MessageBox.Show("Sửa thành công");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (list.Count != 30)
            {
                string idbaithi = new BaiThiBUS().MakeID();
                if (griddangky.SelectedCells.Count > 0)
                {
                    int selectedrowindex = griddangky.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = griddangky.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["CMND"].Value);
                    string cellValue2 = Convert.ToString(selectedRow.Cells["trinhdo"].Value);
                    string idGV1 = "GV0001";
                    string idGV2 = "GV0002";
                    string cccd = cellValue;
                    string phongthi = txtPhong.Text;
                    int i = list.Count + 1;
                    string sobaodanh = "00";
                    if (i < 9)
                        sobaodanh = cellValue2 + "00" + i;
                    else if (i < 99)
                        sobaodanh = cellValue2 + "0" + i;
                    else
                        sobaodanh = cellValue2 + i;
                    string dnghe = "0";
                    string dnoi = "0";
                    string ddoc = "0";
                    string dviet = "0";
                    BaiThiDTO baithi = new BaiThiDTO(idbaithi, idGV1, idGV2, cccd, phongthi, sobaodanh, dnghe, dnoi, ddoc, dviet);
                    if (new BaiThiBUS().Insert(baithi))
                    {
                        MessageBox.Show("Xếp phòng thành công");
                        list.Add(baithi);
                        listdangky.RemoveAll(x=>x.Cccd_TS == cccd);
                        BindGrid(list);
                        BindGrid2(listdangky);
                        lblSoLuong.Text = list.Count + "/30";

                    }
                }
            }
            else
            {
                MessageBox.Show("Phòng đã đủ 30 thí sinh");
            }
        }
    }
}
