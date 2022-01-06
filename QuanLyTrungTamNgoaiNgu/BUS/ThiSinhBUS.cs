using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ThiSinhBUS
    {
        public ThiSinhBUS() { }

        public List<ThiSinhDTO> List()
        {
            return new ThiSinhDAO().ListAll();
        }
        
        public List<ThiSinhDTO> ListSearch(string text)
        {
            return new ThiSinhDAO().ListSearch(text);
        }
        
        public ThiSinhDTO getDiaDiem(string id)
        {
            return new ThiSinhDAO().getDiaDiem(id);
        }
        public bool Insert(ThiSinhDTO thisinh)
        {
            return new ThiSinhDAO().Insert(thisinh);
        }

        public bool Update(ThiSinhDTO thisinh)
        {
            return new ThiSinhDAO().Update(thisinh);
        }

        public bool Delete(string cccdts)
        {
            return new ThiSinhDAO().Delete(cccdts);
        }
        //public String MakeID()
        //{
        //    return new ThiSinhDAO().MakeID();
        //}
        
    }
}
