using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKyDTO
    {
        public DangKyDTO() { }
        public DangKyDTO(string Cccd_TS, string Id_KhoaThi, string TrinhDo, string LePhiThi)
        {
            this.Cccd_TS = Cccd_TS;
            this.Id_KhoaThi = Id_KhoaThi;
            this.TrinhDo = TrinhDo;
            this.LePhiThi = LePhiThi;
        }

        public string Cccd_TS { get; set; }
        public string Id_KhoaThi { get; set; }
        public string TrinhDo { get; set; }
        public string LePhiThi { get; set; }
    }
}
