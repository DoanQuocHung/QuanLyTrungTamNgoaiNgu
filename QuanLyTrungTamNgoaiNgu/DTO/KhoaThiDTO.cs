using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KhoaThiDTO
    {
        public KhoaThiDTO() { }
        public KhoaThiDTO(string Id_KhoaThi, string Ten_KhoaThi, string NgayThi)
        {
            this.Id_KhoaThi = Id_KhoaThi;
            this.Ten_KhoaThi = Ten_KhoaThi;
            this.NgayThi = NgayThi;
        }

        public string Id_KhoaThi { get; set; }
        public string Ten_KhoaThi { get; set; }
        public string NgayThi { get; set; }
    }
}
