﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KetQuaThiDTO
    {
        public KetQuaThiDTO() { }
        public KetQuaThiDTO(string Cccd_TS, string HoTen_TS, string Sdt_TS, string Id_BaiThi, string SoBaoDanh, string Ten_PhongThi, string DiemNghe, string DiemNoi, string DiemDoc,
            string DiemViet) 
        {
            this.Cccd_TS = Cccd_TS;
            this.HoTen_TS = HoTen_TS;
            this.Sdt_TS = Sdt_TS;
            this.Id_BaiThi = Id_BaiThi;
            this.SoBaoDanh = SoBaoDanh;
            this.Ten_PhongThi = Ten_PhongThi;
            this.DiemNghe = DiemNghe;
            this.DiemNoi = DiemNoi;
            this.DiemDoc = DiemDoc;
            this.DiemViet = DiemViet;
        }

        public string Cccd_TS { get; set; }
        public string HoTen_TS { get; set; }
        public string Sdt_TS { get; set; }
        public string Id_BaiThi { get; set; }
        public string SoBaoDanh { get; set; }
        public string Ten_PhongThi { get; set; }
        public string DiemNghe { get; set; }
        public string DiemNoi { get; set; }
        public string DiemDoc { get; set; }
        public string DiemViet { get; set; }
    }
}