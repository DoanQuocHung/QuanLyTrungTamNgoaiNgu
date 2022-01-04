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
        /*
        public List<ThiSinhDTO> ListSearch(string text)
        {
            return new ThiSinhDAO().ListSearch(text);
        }
        
        public ThiSinhDTO getDiaDiem(string id)
        {
            return new ThiSinhDAO().getDiaDiem(id);
        }
        public bool Insert(ThiSinhDTO diadiem)
        {
            return new ThiSinhDAO().Insert(diadiem);
        }

        public bool Update(ThiSinhDTO diadiem)
        {
            return new ThiSinhDAO().Update(diadiem);
        }

        public bool Delete(string madiadiem)
        {
            return new ThiSinhDAO().Delete(madiadiem);
        }
        public String MakeID()
        {
            return new ThiSinhDAO().MakeID();
        }
        */
    }
}
