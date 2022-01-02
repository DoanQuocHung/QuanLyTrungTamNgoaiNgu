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

        public List<BaiThiDTO> ListAll()
        {
            List<BaiThiDTO> baiThi = new List<BaiThiDTO>();
            try
            {
                string query = "select * from BaiThi";
                DataTable data = dataProvider.ExecuteQuery(query);
                Console.WriteLine(data.Rows);
                foreach (DataRow item in data.Rows)
                {
                    string maBaiThi = item["Id_BaiThi"].ToString();
                    string maGV1 = item["Id_GiaoVien1"].ToString();
                    string maGV2 = item["Id_GiaoVien2"].ToString();
                    string cccd = item["Cccd_TS"].ToString();
                    string maPhongThi = item["Id_PhongThi"].ToString();
                    string sobaodanh = item["SoBaoDanh"].ToString();
                    string diemnghe = item["DiemNghe"].ToString();
                    string diemnoi = item["DiemNoi"].ToString();
                    string diemdoc = item["DiemDoc"].ToString();
                    string diemviet = item["DiemViet"].ToString();
                    BaiThiDTO newBaiThi = new BaiThiDTO(maBaiThi, maGV1, maGV2, cccd, maPhongThi, sobaodanh, diemnghe, diemnoi, diemdoc, diemviet);

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
