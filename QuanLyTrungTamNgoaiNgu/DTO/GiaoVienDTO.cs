using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVienDTO
    {
        public GiaoVienDTO() { }
        public GiaoVienDTO(string Id_GV, string HoTen_GV, string GioiTinh_GV, string NgaySinh_GV,
            string Cccd_GV, string Sdt_GV, string Email_GV)
        {
            this.Id_GV = Id_GV;
            this.HoTen_GV = HoTen_GV;
            this.GioiTinh_GV = GioiTinh_GV;
            this.NgaySinh_GV = NgaySinh_GV;
            this.Sdt_GV = Sdt_GV;
            this.Email_GV = Email_GV;
        }

        public string Id_GV { get; set; }
        public string HoTen_GV { get; set; }
        public string GioiTinh_GV { get; set; }
        public string NgaySinh_GV { get; set; }
        public string Cccd_GV { get; set; }
        public string Sdt_GV { get; set; }
        public string Email_GV { get; set; }
    }
}
