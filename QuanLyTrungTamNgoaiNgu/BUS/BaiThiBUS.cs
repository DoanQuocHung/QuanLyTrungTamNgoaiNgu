using System.Collections.Generic;
using DTO;
using DAO;
using System.Diagnostics;

namespace BUS
{
    public class BaiThiBUS
    {
        public BaiThiBUS() { }
        BaiThiDAO baiThiDAO = new BaiThiDAO();
        public List<BaiThiDTO> ListBaiThi_MaPhong(string maPhong)
        {
            return baiThiDAO.ListBaiThi_MaPhong(maPhong);
        }
        public bool Delete(string maBaiThi)
        {
            return baiThiDAO.Delete(maBaiThi);
        }
        public bool Insert(BaiThiDTO baiThiDTO)
        {
            return baiThiDAO.Insert(baiThiDTO);
        }
        public string getTenThiSinh(string cccd)
        {
            return baiThiDAO.getTenThiSinh(cccd);
        }
        public List<int> soTS(int tsToiDa, int tsToiThieu, int tongts)
        {
            int sophong = tongts / tsToiThieu;
            int tongts2 = tongts - sophong * tsToiThieu;
            //so phong de xep thi sinh lan 2
            float fsophong2 = tongts2 / (tsToiDa - tsToiThieu);
            List<int> l = new List<int>();

            if (fsophong2 >= sophong)
            {
                for (int i = 0; i < sophong; i++)
                {
                    l.Add(tsToiDa);
                }
            }
            else
            {
                int sophong2 = (int)fsophong2;
                int d = sophong2 * (tsToiDa - tsToiThieu);
                int e = tongts2 - d;
                for (int i = 0; i < sophong2; i++)
                {
                    l.Add(tsToiDa);
                }
                for (int i = 0; i < sophong - sophong2; i++)
                    if (i == 0)
                        l.Add(tsToiThieu + e);
                    else l.Add(tsToiThieu);
            }

            return l;
        }
        public string MakeID()
        {
            int count = baiThiDAO.Count() + 1;
            string id;
            while (true)
            {
                id = "PT" + count;
                if (baiThiDAO.Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }

        public string MakeSBD(string trinhDo, int soTT)
        {
            string sbd = "";
            if (soTT < 10)
                sbd = trinhDo + "00" + soTT;
            else if (soTT < 100)
                sbd = trinhDo + "0" + soTT;
            else
                sbd = trinhDo + soTT;
            return sbd;
        }


        public List<string> ListCCCD(string maKhoa)
        {
            return baiThiDAO.ListCCCD(maKhoa);
        }
    }
}
