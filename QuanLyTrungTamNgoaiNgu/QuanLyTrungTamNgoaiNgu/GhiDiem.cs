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
using QuanLyTourDuLich;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class GhiDiem : Form
    {
        List<PhongThiDTO> listphongthi;
        List<ThiSinhDTO> listthisinh;
        List<KhoaThiDTO> listkhoa;
        public GhiDiem()
        {
            InitializeComponent();
            listphongthi = new PhongThiBUS().ListAll();
            listkhoa = new KhoaThiBUS().List();
            listthisinh = new ThiSinhBUS().List();
            gridGhiDiem.AutoGenerateColumns = false;

            //Lấy danh sách theo khóa và trình độ
            foreach (KhoaThiDTO item in listkhoa)
                cb_khoathi.Items.Add(item.Id_KhoaThi);
            cb_khoathi.SelectedIndex = 0;
            List<string> trinhdo = new List<string> { "A2", "B1" };
            cb_trinhdo.DataSource = trinhdo;
            cb_trinhdo.SelectedIndex = 0;
            foreach (PhongThiDTO item in listphongthi.FindAll(x=>
            x.Id_KhoaThi == cb_khoathi.SelectedItem.ToString() &&
            x.TrinhDo == cb_trinhdo.SelectedItem.ToString()))
                cb_phongthi.Items.Add(item.Ten_PhongThi);
        }
        public GhiDiem(string khoa)
        {
            InitializeComponent();
           
        }
        public void BindGrid(List<BaiThiDTO> list)
        {
            gridGhiDiem.Rows.Clear();
            gridGhiDiem.Refresh();
            foreach (BaiThiDTO item in list)
            {
                string ten = "";
                ten = listthisinh.Find(x => x.Cccd_TS == item.Cccd_TS).HoTen_TS;
                double tb = (Double.Parse(item.DiemNghe) +
                    Double.Parse(item.DiemNoi) +
                    Double.Parse(item.DiemDoc) +
                    Double.Parse(item.DiemViet)) / 4.0;
                gridGhiDiem.Rows.Add(item.Cccd_TS,ten,item.DiemNghe,item.DiemNoi,item.DiemDoc,item.DiemViet,item.Id_BaiThi,tb);

            }
        }
       /* public void Search()
        {
            string typesearch = cbSearch.SelectedItem.ToString();
            string searchkey = txtSearch.Text;
            List<PhongThiDTO> listsearch = new List<PhongThiDTO>();

            switch (typesearch)
            {
                case "Tên Phòng":
                    listsearch = list.FindAll(x => x.Ten_PhongThi.Contains(searchkey));
                    break;
                case "Ca thi":
                    listsearch = list.FindAll(x => x.CaThi.Contains(searchkey));
                    break;
                default:
                    break;
            }
            BindGrid(listsearch);
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            Search();
        }

        private void cbSearch_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Search();
        }

        private void btnTao_Click(object sender, System.EventArgs e)
        {
            string idphongthi = new PhongThiBUS().MakeID();
            string stt = "";
            if (listsearch.Count == 0)
                stt = "01";
            if (listsearch.Count < 9)
                stt = "0" + (listsearch.Count + 1);
            else stt = (listsearch.Count + 1).ToString();
            string trinhdo = cb_trinhdo.SelectedItem.ToString();
            string tenphongthi = trinhdo + "P" + stt;
            string khoathi = cb_khoathi.SelectedItem.ToString();
            PhongThiDTO phongmoi = new PhongThiDTO(idphongthi, tenphongthi, khoathi, trinhdo, " ");
            using (var form = new ThemPhongThi(list, phongmoi))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    list = form.list;
                    BindGrid(list);
                }
            }
            using (var form = new QuanLyPhongThi_Them(list,phongmoi))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    list = form.list;
                    BindGrid(list);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (datagridview_qlPhongThi.SelectedCells.Count > 0)
            {
                int selectedrowindex = datagridview_qlPhongThi.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datagridview_qlPhongThi.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["IdPhong"].Value);

                DialogResult dialogResult = MessageBox.Show("Thao tác này sẽ xóa phòng và toàn bộ thí sinh trong phòng (nếu có).", "Bạn chắc chắn muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (new PhongThiBUS().Delete(cellValue))
                    {
                        MessageBox.Show("Xóa thành công");
                        list.RemoveAll(x => x.Id_PhongThi.Equals(cellValue));
                        BindGrid(list);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }


            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (datagridview_qlPhongThi.SelectedCells.Count > 0)
            {
                int selectedrowindex = datagridview_qlPhongThi.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datagridview_qlPhongThi.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["IdPhong"].Value);
                int s = 0;

                using (var form = new ChiTietPhongThi(list.Find(x => x.Id_PhongThi.Equals(cellValue))))
                {
                    var result = form.ShowDialog();
                    BindGrid(list);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cbSearch.SelectedIndex = 1;
            BindGrid(list);
        }
        private void listbasekhoa()
        {
            try
            {
                if (cb_khoathi.SelectedItem != null && cb_trinhdo.SelectedItem != null)
                    listsearch = list.FindAll(x =>
                                x.Id_KhoaThi == cb_khoathi.SelectedItem.ToString() &&
                                x.TrinhDo == cb_trinhdo.SelectedItem.ToString());
                BindGrid(listsearch);
            }
            catch (Exception e) { }
        }*/
        private void cb_khoathi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_trinhdo.SelectedItem != null)
            {
                cb_phongthi.Items.Clear();
                foreach (PhongThiDTO item in listphongthi.FindAll(x =>
                x.Id_KhoaThi == cb_khoathi.SelectedItem.ToString() &&
                x.TrinhDo == cb_trinhdo.SelectedItem.ToString()))
                cb_phongthi.Items.Add(item.Ten_PhongThi);
            }
            //listbasekhoa();
        }

        private void cb_trinhdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_khoathi.SelectedItem != null)
            {
                cb_phongthi.Items.Clear();
                foreach (PhongThiDTO item in listphongthi.FindAll(x =>
               x.Id_KhoaThi == cb_khoathi.SelectedItem.ToString() &&
               x.TrinhDo == cb_trinhdo.SelectedItem.ToString()))
                    cb_phongthi.Items.Add(item.Ten_PhongThi);
            }
            //listbasekhoa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_phongthi.SelectedItem == null || cb_phongthi.SelectedItem == "")
            {
                MessageBox.Show("Vui Lòng chọn 1 phòng thi");
                return;
            }
            string khoa = cb_khoathi.SelectedItem.ToString();
            string trinhdo = cb_trinhdo.SelectedItem.ToString();
            string phong = listphongthi.Find(x=>x.Ten_PhongThi == cb_phongthi.SelectedItem.ToString() && x.Id_KhoaThi == khoa).Id_PhongThi;

            List<BaiThiDTO> listhien = new BaiThiBUS().ListBaiThi().FindAll(x=>x.Id_PhongThi == phong);

            BindGrid(listhien);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridGhiDiem.Rows.Count; i++)
            {
                DataGridViewRow selectedRow = gridGhiDiem.Rows[i];
                string cellValue = Convert.ToString(selectedRow.Cells["DiemNghe"].Value);
                string cellValue1 = Convert.ToString(selectedRow.Cells["DiemNoi"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["DiemDoc"].Value);
                string cellValue3 = Convert.ToString(selectedRow.Cells["DiemViet"].Value);
                string cellValue4 = Convert.ToString(selectedRow.Cells["MaBaiThi"].Value);
                new BaiThiBUS().UpdateDiemThi(cellValue,cellValue1,cellValue2,cellValue3,cellValue4);
            }
            string khoa = cb_khoathi.SelectedItem.ToString();
            string trinhdo = cb_trinhdo.SelectedItem.ToString();
                string phong = listphongthi.Find(x => x.Ten_PhongThi == cb_phongthi.SelectedItem.ToString() && x.Id_KhoaThi == khoa).Id_PhongThi;

                List<BaiThiDTO> listhien = new BaiThiBUS().ListBaiThi().FindAll(x => x.Id_PhongThi == phong);

                BindGrid(listhien);
            MessageBox.Show("Lưu thành công");

        }
    }
}
