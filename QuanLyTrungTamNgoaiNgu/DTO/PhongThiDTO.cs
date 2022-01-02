using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PhongThiDTO
    {
        public PhongThiDTO() { }
        public PhongThiDTO(string Id_PhongThi, string Ten_PhongThi, string Id_KhoaThi, string TrinhDo, string CaThi)
        {
            this.Id_PhongThi = Id_PhongThi;
            this.Ten_PhongThi = Ten_PhongThi;
            this.Id_KhoaThi = Id_KhoaThi;
            this.TrinhDo = TrinhDo;
            this.CaThi = CaThi;
        }

        public string Id_PhongThi { get; set; }
        public string Ten_PhongThi { get; set; }
        public string Id_KhoaThi { get; set; }
        public string TrinhDo { get; set; }
        public string CaThi { get; set; }
    }
}
