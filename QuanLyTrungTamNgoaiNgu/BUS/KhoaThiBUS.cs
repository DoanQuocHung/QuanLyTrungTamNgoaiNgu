using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class KhoaThiBUS
    {
        public KhoaThiBUS() { }

        public List<KhoaThiDTO> List()
        {
            return new KhoaThiDAO().ListAll();
        }
        public bool Update(KhoaThiDTO KhoaThi)
        {
            return new KhoaThiDAO().Update(KhoaThi);
        }

        public bool Insert(KhoaThiDTO KhoaThi)
        {
            return new KhoaThiDAO().Insert(KhoaThi);
        }
        public bool Delete(string maKhoaThi)
        {
            return new KhoaThiDAO().Delete(maKhoaThi);
        }
        public String MakeID()
        {
            return new KhoaThiDAO().MakeID();
        }
        public int Count()
        {
            return new KhoaThiDAO().Count();
        }
    }
}
