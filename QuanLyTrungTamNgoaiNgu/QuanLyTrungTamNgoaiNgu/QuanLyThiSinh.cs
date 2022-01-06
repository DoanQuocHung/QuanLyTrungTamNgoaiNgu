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
        public QuanLyThiSinh()
        {
            InitializeComponent();
            list = new ThiSinhBUS().List();
            Grid_Danhsachthisinh.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã Địa điểm", "Tên Địa điểm" };
            SearchBox_cb.DataSource = listtype;
            BindGrid(list);
        }

        //Hàm lấy danh sách
        public void BindGrid(List<ThiSinhDTO> list)
        {
            Grid_Danhsachthisinh.Rows.Clear();
            Grid_Danhsachthisinh.Refresh();
            foreach (ThiSinhDTO item in list)
            {
                Grid_Danhsachthisinh.Rows.Add(item.Cccd_TS, item.HoTen_TS, item.GioiTinh_TS, item.NgaySinh_TS, item.NoiSinh_TS, 
                    item.NgayCap_TS, item.NoiCap_TS, item.Sdt_TS, item.Email_TS);
            }
        }
        //Button thêm 
        private void button7_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyThiSinh_Them(list))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
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
                using (var form = new QuanLyThiSinh_Sua(list, cellValue))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.list = form.list;
                        BindGrid(list);
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
            try
            {
                if (new ThiSinhBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                    list.RemoveAll(x => x.Cccd_TS.Equals(cellValue));
                    BindGrid(list);
                }
            }
            catch (SqlException e1) when (e1.Number == 547)
            {
                MessageBox.Show("Không thể xóa địa điểm !");
                return;
            }
        }
        //Button Kết quả thi
        private void button11_Click(object sender, EventArgs e)
        {

        }
        ////Button Reload 
        //private void button10_Click(object sender, EventArgs e)
        //{
        //    BindGrid(list);
        //}

        private void SearchDiadiem_txt_TextChanged(object sender, EventArgs e)
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
            BindGrid(listsearch);
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
