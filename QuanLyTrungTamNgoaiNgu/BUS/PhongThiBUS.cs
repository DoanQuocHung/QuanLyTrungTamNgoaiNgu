using System;
using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class PhongThiBUS
    {
        public PhongThiBUS() { }
        PhongThiDAO phongThiDAO = new PhongThiDAO();
        public List<PhongThiDTO> ListAll()
        {
            return phongThiDAO.ListAll();
        }
        public List<string> Khoa()
        {
            return phongThiDAO.Khoa();
        }
        public bool Insert(PhongThiDTO phongThi)
        {
            return phongThiDAO.Insert(phongThi);
        }
        public bool Delete(string maPhong)
        {
            return phongThiDAO.Delete(maPhong);
        }
        public string MakeID()
        {
            int count = phongThiDAO.Count() + 1;
            string id;
            while (true)
            {
                id = "PT" + count;
                if (phongThiDAO.Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
        public string TenPhong(string maKhoa, string trinhDo)
        {
            string ten;
            int count = phongThiDAO.Count2(maKhoa, trinhDo) + 1;
            ten = trinhDo + "P0" + count.ToString();
            return ten;
        }
        public int CountThiSinh(string makhoa, string trinhDo)
        {
            return phongThiDAO.CountThiSinh(makhoa, trinhDo);
        }
        public bool Update(string caThi, string maPhong)
        {
            return phongThiDAO.Update(caThi, maPhong);
        }
        
    }
}
