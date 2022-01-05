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
    public partial class QuanLyKhoaThi : Form
    {
        List<KhoaThiDTO> list;
        public QuanLyKhoaThi()
        {
            InitializeComponent();
            list = new KhoaThiBUS().List();
            BindGrid(list);
        }
        public void BindGrid(List<KhoaThiDTO> list)
        {
            datagridview_qlkhoathi.Rows.Clear();
            datagridview_qlkhoathi.Refresh();
            foreach (KhoaThiDTO item in list)
            {
                datagridview_qlkhoathi.Rows.Add(item.Id_KhoaThi,item.Ten_KhoaThi,item.NgayThi);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            using (var form = new ThemKhoaThi(list))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (datagridview_qlkhoathi.RowCount != 0)
            {
                int selectedrowindex = datagridview_qlkhoathi.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datagridview_qlkhoathi.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_KhoaThi"].Value);
                using (var form = new SuaKhoaThi(list, cellValue))
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (datagridview_qlkhoathi.RowCount != 0)
            {
                int selectedrowindex = datagridview_qlkhoathi.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datagridview_qlkhoathi.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_KhoaThi"].Value);
                if (new KhoaThiBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                    list.RemoveAll(x => x.Id_KhoaThi.Equals(cellValue));
                    BindGrid(list);
                }
                else
                {
                    MessageBox.Show("Khóa thi có người đăng ký học rồi");
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            if (frm != null)
                
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
