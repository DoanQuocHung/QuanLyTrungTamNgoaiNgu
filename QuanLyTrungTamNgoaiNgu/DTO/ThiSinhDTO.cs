using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThiSinhDTO
    {
        public ThiSinhDTO() { }
        public ThiSinhDTO(string Cccd_TS, string HoTen_TS, string GioiTinh_TS, string NgaySinh_TS, 
            string NoiSinh_TS, string NgayCap_TS, string NoiCap_TS, string Sdt_TS, string Email_TS)
        {
            this.Cccd_TS = Cccd_TS;
            this.HoTen_TS = HoTen_TS;
            this.GioiTinh_TS = GioiTinh_TS;
            this.NgaySinh_TS = NgaySinh_TS;
            this.NoiSinh_TS = NoiSinh_TS;
            this.NgayCap_TS = NgayCap_TS;
            this.NoiCap_TS = NoiCap_TS;
            this.Sdt_TS = Sdt_TS;
            this.Email_TS = Email_TS;
        }

        public string Cccd_TS { get; set; }
        public string HoTen_TS { get; set; }
        public string GioiTinh_TS { get; set; }
        public string NgaySinh_TS { get; set; }
        public string NoiSinh_TS { get; set; }
        public string NgayCap_TS { get; set; }
        public string NoiCap_TS { get; set; }
        public string Sdt_TS { get; set; }
        public string Email_TS { get; set; }

    }
}
