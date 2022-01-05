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
        public QuanLyPhongThi()
        {
            InitializeComponent();
            list = new PhongThiBUS().ListAll();
            datagridview_qlPhongThi.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Tên Phòng", "Mã Khóa thi", "Trình độ", "Ca thi"};
            cbSearch.DataSource = listtype;
            cbSearch.SelectedIndex = 1;
            BindGrid(list);
        }
        public void BindGrid(List<PhongThiDTO> list)
        {
            datagridview_qlPhongThi.Rows.Clear();
            datagridview_qlPhongThi.Refresh();
            foreach (PhongThiDTO item in list)
            {
                datagridview_qlPhongThi.Rows.Add(item.Id_PhongThi, item.Ten_PhongThi, item.Id_KhoaThi, item.TrinhDo, item.CaThi);
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
                case "Mã Khóa thi":
                    listsearch = list.FindAll(x => x.Id_KhoaThi.Contains(searchkey));
                    break;
                case "Trình độ":
                    listsearch = list.FindAll(x => x.TrinhDo.Contains(searchkey));
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
            using (var form = new QuanLyPhongThi_Them(list))
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

                DialogResult dialogResult = MessageBox.Show("Thao tác này sẽ xóa phòng và toàn bộ thí sinh trong phòng (nếu có).","Bạn chắc chắn muốn xóa?", MessageBoxButtons.YesNo);
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
    }
}
