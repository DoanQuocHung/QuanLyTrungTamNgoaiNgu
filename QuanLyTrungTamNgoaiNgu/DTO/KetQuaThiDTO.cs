using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KetQuaThiDTO
    {
        public KetQuaThiDTO() { }
        public KetQuaThiDTO(string Id_KhoaThi, string Ten_KhoaThi, string NgayThi, string TrinhDo, string Cccd_TS, string HoTen_TS, string Sdt_TS, string NgaySinh_TS, string Id_BaiThi, string SoBaoDanh, string Ten_PhongThi, string DiemNghe, string DiemNoi, string DiemDoc,
            string DiemViet) 
        {
            this.Id_KhoaThi = Id_KhoaThi;
            this.Ten_KhoaThi = Ten_KhoaThi;
            this.NgayThi = NgayThi;
            this.TrinhDo = TrinhDo;
            this.Cccd_TS = Cccd_TS;
            this.HoTen_TS = HoTen_TS;
            this.Sdt_TS = Sdt_TS;
            this.NgaySinh_TS = NgaySinh_TS;
            this.Id_BaiThi = Id_BaiThi;
            this.SoBaoDanh = SoBaoDanh;
            this.Ten_PhongThi = Ten_PhongThi;
            this.DiemNghe = DiemNghe;
            this.DiemNoi = DiemNoi;
            this.DiemDoc = DiemDoc;
            this.DiemViet = DiemViet;
        }
        public string Id_KhoaThi { get; set; }
        public string Ten_KhoaThi { get; set; }
        public string NgayThi { get; set; }
        public string TrinhDo { get; set; }
        public string Cccd_TS { get; set; }
        public string HoTen_TS { get; set; }
        public string Sdt_TS { get; set; }
        public string NgaySinh_TS { get; set; }
        public string Id_BaiThi { get; set; }
        public string SoBaoDanh { get; set; }
        public string Ten_PhongThi { get; set; }
        public string DiemNghe { get; set; }
        public string DiemNoi { get; set; }
        public string DiemDoc { get; set; }
        public string DiemViet { get; set; }
    }
}
