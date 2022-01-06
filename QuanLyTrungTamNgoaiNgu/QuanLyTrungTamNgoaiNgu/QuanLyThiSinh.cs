using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class QuanLyThiSinh : Form
    {
        List<ThiSinhDTO> list;
        List<DangKyDTO> listdangky;
        List<DangKyDTO> listsearch;
        List<KhoaThiDTO> listkhoathi;
        List<PhongThiDTO> listphongthi;
        public QuanLyThiSinh()
        {
            InitializeComponent();
            list = new ThiSinhBUS().List();
            listdangky = new DangKyBUS().List();
            listsearch = new List<DangKyDTO>();
            listkhoathi = new KhoaThiBUS().List();
            Grid_Danhsachthisinh.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "CMND", "Tên" , "SDT" };
            SearchBox_cb.DataSource = listtype;
            BindGrid(listdangky);

            //Lấy danh sách theo khóa và trình độ
            foreach (KhoaThiDTO item in listkhoathi)
                cb_khoathi.Items.Add(item.Id_KhoaThi);
            cb_khoathi.SelectedIndex = 0;
            List<string> trinhdo = new List<string> { "A2", "B1" };
            cb_trinhdo.DataSource = trinhdo;
            cb_trinhdo.SelectedIndex = 0;
        }

        //Hàm lấy danh sách
        public void BindGrid(List<DangKyDTO> list)
        {
            Grid_Danhsachthisinh.Rows.Clear();
            Grid_Danhsachthisinh.Refresh();
            foreach (DangKyDTO item in list)
            {
                ThiSinhDTO thisinh = this.list.Find(x=>x.Cccd_TS == item.Cccd_TS);
                Grid_Danhsachthisinh.Rows.Add(
                    item.Cccd_TS, 
                    thisinh.HoTen_TS, 
                    thisinh.GioiTinh_TS, 
                    thisinh.NgaySinh_TS, 
                    thisinh.NoiSinh_TS, 
                    thisinh.NgayCap_TS, 
                    thisinh.NoiCap_TS, 
                    thisinh.Sdt_TS, 
                    thisinh.Email_TS,
                    item.LePhiThi,
                    item.Id_KhoaThi,
                    item.TrinhDo);
            }
        }
        //Button thêm 
        private void button7_Click(object sender, EventArgs e)
        {
            string trinhdo = cb_trinhdo.SelectedItem.ToString();
            string khoathi = cb_khoathi.SelectedItem.ToString();
            using (var form = new QuanLyThiSinh_Them(khoathi,trinhdo))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    listdangky.Add(form.dangky);
                    if(!list.Exists(x=>x.Cccd_TS == form.thisinh.Cccd_TS))
                    list.Add(form.thisinh);
                    listbasekhoa();
                }
            }
        }
        //Button Sửa 
        private void button8_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachthisinh.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachthisinh.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachthisinh.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Cccd_TS"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["KhoaThi"].Value);
                ThiSinhDTO thisinh = list.Find(x=>x.Cccd_TS==cellValue);
                DangKyDTO dangky = listdangky.Find(x => x.Cccd_TS == cellValue && x.Id_KhoaThi == cellValue2);
                using (var form = new QuanLyThiSinh_Sua(thisinh, dangky))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        listdangky.Find(x => x.Id_KhoaThi == cellValue2 && x.Cccd_TS == cellValue).LePhiThi = form.dangky.LePhiThi;
                        listdangky.Find(x => x.Id_KhoaThi == cellValue2 && x.Cccd_TS == cellValue).TrinhDo = form.dangky.TrinhDo;

                        list.Find(x => x.Cccd_TS == cellValue).GioiTinh_TS = form.thisinh.GioiTinh_TS;
                        list.Find(x => x.Cccd_TS == cellValue).HoTen_TS = form.thisinh.HoTen_TS;
                        list.Find(x => x.Cccd_TS == cellValue).NgayCap_TS = form.thisinh.NgayCap_TS;
                        list.Find(x => x.Cccd_TS == cellValue).NgaySinh_TS = form.thisinh.NgaySinh_TS;
                        list.Find(x => x.Cccd_TS == cellValue).NoiCap_TS = form.thisinh.NoiCap_TS;
                        list.Find(x => x.Cccd_TS == cellValue).NoiSinh_TS = form.thisinh.NoiSinh_TS;
                        list.Find(x => x.Cccd_TS == cellValue).Sdt_TS = form.thisinh.Sdt_TS;
                        list.Find(x => x.Cccd_TS == cellValue).Email_TS = form.thisinh.Email_TS;
                        listbasekhoa();
                    }
                }
            }
        }
        //Button Xóa 
        private void button9_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachthisinh.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachthisinh.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Cccd_TS"].Value);
            string cellValue2 = Convert.ToString(selectedRow.Cells["KhoaThi"].Value);
            string cellValue3 = Convert.ToString(selectedRow.Cells["TrinhDo"].Value);
            List<BaiThiDTO> listbaithi = new BaiThiBUS().ListBaiThi();
            if (listbaithi.FindAll(x=>x.Cccd_TS == cellValue).Count == 0)
            {
                    if (new DangKyBUS().Delete(cellValue, cellValue2, cellValue3))
                    {
                        if (new ThiSinhBUS().Delete(cellValue))
                        {
                            MessageBox.Show("Xóa thành công");
                            list.RemoveAll(x => x.Cccd_TS.Equals(cellValue));
                            listdangky.RemoveAll(x => x.Cccd_TS.Equals(cellValue));
                            listbasekhoa();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thí sinh do đã đăng ký thi rồi !");
                        return;
                    }
            }
            else
            {
                MessageBox.Show("Không thể xóa thí sinh do đã đăng ký thi rồi !");
                return;
            }
        }
        //Button Kết quả thi
        private void button11_Click(object sender, EventArgs e)
        {

        }
        ////Button Reload 
        private void button10_Click(object sender, EventArgs e)
        {
            listbasekhoa();
        }

        /*private void SearchDiadiem_txt_TextChanged(object sender, EventArgs e)
        {
            string search = SearchDiadiem_txt.Text;
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            List<ThiSinhDTO> listsearch = new List<ThiSinhDTO>();
            switch (typesearch)
            {
                case "CCCD TS":
                    listsearch = list.FindAll(x => x.Cccd_TS.Contains(search));
                    break;
                case "Họ tên":
                    listsearch = list.FindAll(x => x.HoTen_TS.Contains(search));
                    break;
                default:
                    break;
            }
            BindGrid(listdangky);
        }*/
        private void listbasekhoa()
        {
            try
            {
                if (cb_khoathi.SelectedItem != null && cb_trinhdo.SelectedItem != null)
                    listsearch = listdangky.FindAll(x =>
                                x.Id_KhoaThi == cb_khoathi.SelectedItem.ToString() &&
                                x.TrinhDo == cb_trinhdo.SelectedItem.ToString());
                BindGrid(listsearch);
            }
            catch (Exception e) { }
        }
        private void cb_khoathi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbasekhoa();
        }

        private void cb_trinhdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbasekhoa();
        }

        //Hàm xử lý chuyển trang ==========================================================================================================
        //private Form activeForm = null;
        //private void OpenChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panelChildForm.Controls.Add(childForm);
        //    panelChildForm.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
    }
}
