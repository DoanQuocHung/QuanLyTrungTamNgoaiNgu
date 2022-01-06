using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKeDAO
    {
        public ThongKeDAO() { }
        public string ListAll()
        {
            DataProvider dataProvider = new DataProvider();

            List<PhongThiDTO> listPhongThi = new List<PhongThiDTO>();
            string query = "select * from PhongThi order by Id_KhoaThi desc, Ten_PhongThi";

            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    string maPhong = row["Id_PhongThi"].ToString();
                    string tenPhong = row["Ten_PhongThi"].ToString();
                    string maKhoa = row["Id_KhoaThi"].ToString();
                    string trinhDo = row["TrinhDo"].ToString();
                    string caThi = row["CaThi"].ToString();

                    PhongThiDTO phongThi = new PhongThiDTO(maPhong, tenPhong, maKhoa, trinhDo, caThi);

                    listPhongThi.Add(phongThi);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return listPhongThi;
        }
        public List<string> Khoa()
        {
            List<string> list = new List<string>();
            DataProvider dataProvider = new DataProvider();
            string query = "select * from KhoaThi where Id_KhoaThi not in (select Id_KhoaThi from PhongThi)";
            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    string maPhong = row["Ten_KhoaThi"].ToString();

                    list.Add(maPhong);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return list;
        }
    }
}
