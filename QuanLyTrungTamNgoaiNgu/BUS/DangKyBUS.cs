using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class DangKyBUS
    {
        public DangKyBUS() { }

        public List<DangKyDTO> List()
        {
            return new DangKyDAO().ListAll();
        }
        public bool Insert(DangKyDTO thisinh)
        {
            return new DangKyDAO().Insert(thisinh);
        }

        public bool Update(DangKyDTO thisinh)
        {
            return new DangKyDAO().Update(thisinh);
        }

        public bool Delete(string cccdts,string khoathi, string trinhdo)
        {
            return new DangKyDAO().Delete(cccdts,khoathi);
        }
        //public String MakeID()
        //{
        //    return new DangKyDAO().MakeID();
        //}
    }
}
