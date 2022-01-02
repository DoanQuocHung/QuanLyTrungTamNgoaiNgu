using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class BaiThiDTO
    {
        public BaiThiDTO() { }
        public BaiThiDTO(string Id_BaiThi, string Id_GiaoVien1, string Id_GiaoVien2, string Cccd_TS,
            string Id_PhongThi, string SoBaoDanh, string DiemNghe, string DiemNoi, string DiemDoc, 
            string DiemViet)
        {
            this.Id_BaiThi = Id_BaiThi;
            this.Id_GiaoVien1 = Id_GiaoVien1;
            this.Id_GiaoVien2 = Id_GiaoVien2;
            this.Cccd_TS = Cccd_TS;
            this.Id_PhongThi = Id_PhongThi;
            this.SoBaoDanh = SoBaoDanh;
            this.DiemNghe = DiemNghe;
            this.DiemNoi = DiemNoi;
            this.DiemDoc = DiemDoc;
            this.DiemViet = DiemViet;
        }

        public string Id_BaiThi { get; set; }
        public string Id_GiaoVien1 { get; set; }
        public string Id_GiaoVien2 { get; set; }
        public string Cccd_TS { get; set; }
        public string Id_PhongThi { get; set; }
        public string SoBaoDanh { get; set; }
        public string DiemNghe { get; set; }
        public string DiemNoi { get; set; }
        public string DiemDoc { get; set; }
        public string DiemViet { get; set; }

    }
}
