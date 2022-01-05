using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using DTO;
using BUS;

namespace QuanLyTourDuLich
{
    public partial class QuanLyPhongThi_Them : Form
    {
        int thiSinhToiThieu = 12;
        int thiSinhToiDa = 15;
        public List<PhongThiDTO> list { get; set; }
        public PhongThiBUS phongThiBUS = new PhongThiBUS();
        public BaiThiBUS baiThiBUS = new BaiThiBUS();

        public QuanLyPhongThi_Them(List<PhongThiDTO> list,PhongThiDTO phongmoi)
        {
            InitializeComponent();
            this.list = list;
            foreach (string d in phongThiBUS.Khoa())
            {
                cboKhoaThi.Items.Add(d);
            }
            cboKhoaThi.SelectedIndex = 0;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            PhongThiDTO phongThiDTO1;
            int f = 0;
            int t = 0;
            
            string maKhoa = new PhongThiBUS().getMaKhoa(cboKhoaThi.Text);
            int thisinhA2 = phongThiBUS.CountThiSinh(maKhoa, "A2");
            int thisinhB1 = phongThiBUS.CountThiSinh(maKhoa, "B1");
            if (thisinhA2 < thiSinhToiThieu && thisinhB1 < thiSinhToiThieu)
            {
                MessageBox.Show("Số Thí sinh đăng kí không đủ để tạo phòng.");
                return;
            }

            List<int> lA2 = baiThiBUS.soTS(thiSinhToiDa, thiSinhToiThieu,thisinhA2);
            List<int> lB1 = baiThiBUS.soTS(thiSinhToiDa, thiSinhToiThieu, thisinhB1);
            List<string> lCCCD = baiThiBUS.ListCCCD(maKhoa);


            for (int i = 1; i <= thisinhA2 / thiSinhToiThieu; i++)
            {
                string idPhongA2 = phongThiBUS.MakeID();
                phongThiDTO1 = new PhongThiDTO(idPhongA2, phongThiBUS.TenPhong(maKhoa, "A2"), maKhoa, "A2", "Ca 1");
                f = 0;
                if (phongThiBUS.Insert(phongThiDTO1))
                {
                    for (int j = 0; j < lA2[i - 1]; j++)
                    {
                        t++;
                        if (baiThiBUS.Insert(new BaiThiDTO(baiThiBUS.MakeID(), null, null, lCCCD[j], idPhongA2, baiThiBUS.MakeSBD("A2", t), null, null, null, null)))
                            f = 1;
                    }
                    f = 1;
                    this.list.Add(phongThiDTO1);
                }
            }

            int t2=0;
            

            for (int i = 1; i <= thisinhB1 / thiSinhToiThieu; i++)
            {
                string idPhongB1 = phongThiBUS.MakeID();
                phongThiDTO1 = new PhongThiDTO(idPhongB1, phongThiBUS.TenPhong(maKhoa, "B1"), maKhoa, "B1", "Ca 2");
                
                f = 0;
                if (phongThiBUS.Insert(phongThiDTO1))
                {
                    for (int j = 0; j < lB1[i - 1]; j++)
                    {
                        t2++;

                        if (baiThiBUS.Insert(new BaiThiDTO(baiThiBUS.MakeID(), null, null, lCCCD[j], idPhongB1, baiThiBUS.MakeSBD("B1", t2), null, null, null, null)))
                            f = 1;
                    }
                    f = 1;
                    this.list.Add(phongThiDTO1);
                }
            }



            if (f == 1)
            {
                MessageBox.Show("Thêm thành công");
                this.DialogResult = DialogResult.OK;
                Hide();
            }
            else
                return;
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
