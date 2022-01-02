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
                string query = "SELECT BaiThi.Cccd_TS, HoTen_TS, Sdt_TS, Id_BaiThi, SoBaoDanh, Ten_PhongThi, DiemNghe, DiemNoi, DiemDoc, DiemViet FROM BaiThi JOIN ThiSinh ON BaiThi.Cccd_TS = ThiSinh.Cccd_TS JOIN PhongThi ON BaiThi.Id_PhongThi = PhongThi.Id_PhongThi";
                DataTable data = dataProvider.ExecuteQuery(query);
                Console.WriteLine(data.Rows);
                foreach (DataRow item in data.Rows)
                {
                    string maBaiThi = item["Cccd_TS"].ToString();
                    string maGV1 = item["HoTen_TS"].ToString();
                    string maGV2 = item["Sdt_TS"].ToString();
                    string cccd = item["Id_BaiThi"].ToString();
                    string maPhongThi = item["SoBaoDanh"].ToString();
                    string sobaodanh = item["Ten_PhongThi"].ToString();
                    string diemnghe = item["DiemNghe"].ToString();
                    string diemnoi = item["DiemNoi"].ToString();
                    string diemdoc = item["DiemDoc"].ToString();
                    string diemviet = item["DiemViet"].ToString();
                    KetQuaThiDTO newBaiThi = new KetQuaThiDTO(maBaiThi, maGV1, maGV2, cccd, maPhongThi, sobaodanh, diemnghe, diemnoi, diemdoc, diemviet);

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
