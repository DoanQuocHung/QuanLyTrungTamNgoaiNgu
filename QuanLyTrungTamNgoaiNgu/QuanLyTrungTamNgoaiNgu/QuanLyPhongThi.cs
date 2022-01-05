using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using BUS;
using DTO;
using QuanLyTourDuLich;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class QuanLyPhongThi : Form
    {
        List<PhongThiDTO> list;
        List<PhongThiDTO> listsearch;
        List<KhoaThiDTO> listkhoa;
        public QuanLyPhongThi()
        {
            InitializeComponent();
            list = new PhongThiBUS().ListAll();
            listkhoa = new KhoaThiBUS().List();
            listsearch = new List<PhongThiDTO>();
            datagridview_qlPhongThi.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Tên Phòng", "Ca thi"};
            cbSearch.DataSource = listtype;
            cbSearch.SelectedIndex = 0;

            //Lấy danh sách theo khóa và trình độ
            foreach (KhoaThiDTO item in listkhoa)
                cb_khoathi.Items.Add(item.Id_KhoaThi);
            cb_khoathi.SelectedIndex = 0;
            List<string> trinhdo = new List<string> { "A2", "B1" };
            cb_trinhdo.DataSource = trinhdo;
            cb_trinhdo.SelectedIndex = 0;
            listbasekhoa();
        }
        public QuanLyPhongThi(string khoa)
        {
            InitializeComponent();
            list = new PhongThiBUS().ListAll();
            listkhoa = new KhoaThiBUS().List();
            listsearch = new List<PhongThiDTO>();
            datagridview_qlPhongThi.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Tên Phòng", "Ca thi" };
            cbSearch.DataSource = listtype;
            cbSearch.SelectedIndex = 0;

            //Lấy danh sách theo khóa và trình độ
            foreach (KhoaThiDTO item in listkhoa)
                cb_khoathi.Items.Add(item.Id_KhoaThi);
            cb_khoathi.SelectedItem = khoa;
            List<string> trinhdo = new List<string> { "A2", "B1" };
            cb_trinhdo.DataSource = trinhdo;
            cb_trinhdo.SelectedIndex = 0;
        }
        public void BindGrid(List<PhongThiDTO> list)
        {
            datagridview_qlPhongThi.Rows.Clear();
            datagridview_qlPhongThi.Refresh();
            foreach (PhongThiDTO item in list)
            {
                datagridview_qlPhongThi.Rows.Add(
                    item.Id_PhongThi, 
                    item.Ten_PhongThi, 
                    item.Id_KhoaThi, 
                    new PhongThiBUS().getTenKhoa(item.Id_KhoaThi), 
                    item.TrinhDo, 
                    item.CaThi);
            }
        }
        public void Search()
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
            if(listsearch.Count <9)
                stt = "0"+ (listsearch.Count+1);
            else stt = (listsearch.Count+1).ToString();
            string trinhdo = cb_trinhdo.SelectedItem.ToString();
            string tenphongthi = trinhdo + "P" + stt;
            string khoathi = cb_khoathi.SelectedItem.ToString();
            PhongThiDTO phongmoi = new PhongThiDTO(idphongthi,tenphongthi,khoathi,trinhdo," ");
            using (var form = new ThemPhongThi(list,phongmoi))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    list = form.list;
                    listbasekhoa();
                }
            }
            /*using (var form = new QuanLyPhongThi_Them(list,phongmoi))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    list = form.list;
                    BindGrid(list);
                }
            }*/
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (datagridview_qlPhongThi.SelectedCells.Count > 0)
            {
                int selectedrowindex = datagridview_qlPhongThi.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datagridview_qlPhongThi.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["IdPhong"].Value);

                DialogResult dialogResult = MessageBox.Show("Thao tác này sẽ xóa phòng và toàn bộ thí sinh trong phòng (nếu có).","Bạn chắc chắn muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (new PhongThiBUS().Delete(cellValue))
                    {
                        MessageBox.Show("Xóa thành công");
                        list.RemoveAll(x => x.Id_PhongThi.Equals(cellValue));
                        listbasekhoa();
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
                    listbasekhoa();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cbSearch.SelectedIndex = 1;
            listbasekhoa();
        }
        private void listbasekhoa()
        {
            try
            {
                if(cb_khoathi.SelectedItem != null && cb_trinhdo.SelectedItem != null)
                listsearch = list.FindAll(x => 
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
    }
}
