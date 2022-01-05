using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using DTO;

namespace DAO
{
    public class PhongThiDAO
    {
        public PhongThiDAO() { }
        public List<PhongThiDTO> ListAll()
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
            }catch (Exception ex)
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

        public bool Delete(string maPhong)
        {
            string query0 = "delete BaiThi where Id_PhongThi = '" + maPhong + "'"; 
            string query = "delete PhongThi where Id_PhongThi = @MAPHONG";

            object[] para = new object[]
            {
                maPhong
            };
            DataProvider dataProvider = new DataProvider();
            try
            {
                dataProvider.ExecuteQuery(query0);
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public bool Insert(PhongThiDTO phongThi)
        {
            string query = "insert PhongThi values ( @MAPHONG , @TENPHONG , @MAKHOA , @TRINHDO , @CATHI )";
            object[] para = new object[]
            {
                phongThi.Id_PhongThi,
                phongThi.Ten_PhongThi,
                phongThi.Id_KhoaThi,
                phongThi.TrinhDo,
                phongThi.CaThi
            };
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        //Tong so phong thi
        public int Count()
        {
            string query = "select count(*) from PhongThi";
            int count = 0;
            try
            {
                DataProvider dataProvider = new DataProvider();
                count = (int)dataProvider.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return count;
        }

        //Tong so phong thi trong 1 khoa, 1 trinh do
        public int Count2(string makhoa, string trinhDo)
        {
            string query = "select count(*) from PhongThi where Id_KhoaThi = '" + makhoa + "' and TrinhDo = '" + trinhDo + "'";
            int count = 0;
            try
            {
                DataProvider dataProvider = new DataProvider();
                count = (int)dataProvider.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return count;
        }

        //Tong thí sinh trong 1 khoa, trinh do
        public int CountThiSinh(string makhoa, string trinhDo)
        {
            string query = "select COUNT(*) from DangKy where Id_KhoaThi = '"+makhoa+"' and TrinhDo = '"+trinhDo+"'";
            int count = 0;
            try
            {
                DataProvider dataProvider = new DataProvider();
                count = (int)dataProvider.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return count;
        }
        
        public int Exist(string id)
        {
            string query = "select count(*) from PhongThi where Id_PhongThi = '" + id + "'";
            int count = 0;
            try
            {
                DataProvider dataProvider = new DataProvider();
                count = (int)dataProvider.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return count;
        }
        public bool Update(string caThi, string maPhong)
        {
            string query = "update PhongThi set CaThi = @CATHI " +
                "where Id_PhongThi = @MAPHONG";

            object[] para = new object[]
            {
                caThi,
                maPhong
            };
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }
        public string getTenKhoa(string maKhoa)
        {
            string s = "";
            DataProvider dataProvider = new DataProvider();
            string query = "select Ten_KhoaThi from KhoaThi where Id_KhoaThi = '" + maKhoa + "'";
            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);
                DataRow dataRow = data.Rows[0];
                s = dataRow["Ten_KhoaThi"].ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return s;
        }

        public string getMaKhoa(string tenKhoa)
        {
            string s = "";
            DataProvider dataProvider = new DataProvider();
            string query = "select Id_KhoaThi from KhoaThi where Id_KhoaThi = '" + tenKhoa + "'";
            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);
                DataRow dataRow = data.Rows[0];
                s = dataRow["Id_KhoaThi"].ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return s;
        }
    }
}
