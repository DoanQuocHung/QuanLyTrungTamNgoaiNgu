using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class KetQuaThiDAO
    {
        DataProvider dataProvider = new DataProvider();
        public KetQuaThiDAO() { }

        public List<KetQuaThiDTO> ListAll()
        {
            List<KetQuaThiDTO> baiThi = new List<KetQuaThiDTO>();
            try
            {
                string query = "SELECT Ten_KhoaThi, BaiThi.Cccd_TS, HoTen_TS, Sdt_TS, Id_BaiThi, SoBaoDanh, Ten_PhongThi, DiemNghe, DiemNoi, DiemDoc, DiemViet FROM BaiThi JOIN ThiSinh ON BaiThi.Cccd_TS = ThiSinh.Cccd_TS JOIN PhongThi ON BaiThi.Id_PhongThi = PhongThi.Id_PhongThi JOIN KhoaThi ON KhoaThi.Id_KhoaThi = PhongThi.Id_KhoaThi";
                DataTable data = dataProvider.ExecuteQuery(query);
                Console.WriteLine(data.Rows);
                foreach (DataRow item in data.Rows)
                {
                    string tenKhoaThi = item["Ten_KhoaThi"].ToString();
                    string cccd = item["Cccd_TS"].ToString();
                    string hoten = item["HoTen_TS"].ToString();
                    string sdt = item["Sdt_TS"].ToString();
                    string mabaithi = item["Id_BaiThi"].ToString();
                    string sobaodanh = item["SoBaoDanh"].ToString();
                    string tenphongthi = item["Ten_PhongThi"].ToString();
                    string diemnghe = item["DiemNghe"].ToString();
                    string diemnoi = item["DiemNoi"].ToString();
                    string diemdoc = item["DiemDoc"].ToString();
                    string diemviet = item["DiemViet"].ToString();
                    KetQuaThiDTO newBaiThi = new KetQuaThiDTO(tenKhoaThi, cccd, hoten, sdt, mabaithi, sobaodanh, tenphongthi, diemnghe, diemnoi, diemdoc, diemviet);

                    baiThi.Add(newBaiThi);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi DB tại ListAll " + e);
            }

            return baiThi;
        }
    }


}
