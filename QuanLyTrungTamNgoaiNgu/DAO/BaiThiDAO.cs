using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using DTO;

namespace DAO
{
    public class BaiThiDAO
    {
        public BaiThiDAO() { }
        public List<BaiThiDTO> ListBaiThi_MaPhong(string maPhong)
        {
            DataProvider dataProvider = new DataProvider();

            List<BaiThiDTO> list = new List<BaiThiDTO>();
            string query = "select * from BaiThi where Id_PhongThi = (select Id_PhongThi from PhongThi where Id_PhongThi = '" + maPhong + "') order by SoBaoDanh";

            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    string maBaiThi = item["Id_BaiThi"].ToString();
                    string maGV1 = item["Id_GiaoVien1"].ToString();
                    string maGV2 = item["Id_GiaoVien2"].ToString();
                    string cccdTS = item["Cccd_TS"].ToString();
                    string sbd = item["SoBaoDanh"].ToString();
                    string diemNghe = item["DiemNghe"].ToString();
                    string diemNoi = item["DiemNoi"].ToString();
                    string diemDoc = item["DiemDoc"].ToString();
                    string diemViet = item["DiemViet"].ToString();

                    BaiThiDTO baiThiDTO = new BaiThiDTO(maBaiThi, maGV1, maGV2, cccdTS, maPhong, sbd, diemNghe, diemNoi, diemDoc, diemViet);

                    list.Add(baiThiDTO);
                }
            }
            catch (Exception ex)
            {
                //Hiển thị lỗi trong Immediate Window
                Debug.WriteLine(ex.Message);
            }

            return list;
        }
        public List<BaiThiDTO> ListBaiThi()
        {
            DataProvider dataProvider = new DataProvider();

            List<BaiThiDTO> list = new List<BaiThiDTO>();
            string query = "select * from BaiThi";

            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    string maBaiThi = item["Id_BaiThi"].ToString();
                    string maGV1 = item["Id_GiaoVien1"].ToString();
                    string maGV2 = item["Id_GiaoVien2"].ToString();
                    string cccdTS = item["Cccd_TS"].ToString();
                    string sbd = item["SoBaoDanh"].ToString();
                    string maPhong = item["Id_PhongThi"].ToString();
                    string diemNghe = item["DiemNghe"].ToString();
                    string diemNoi = item["DiemNoi"].ToString();
                    string diemDoc = item["DiemDoc"].ToString();
                    string diemViet = item["DiemViet"].ToString();

                    BaiThiDTO baiThiDTO = new BaiThiDTO(maBaiThi, maGV1, maGV2, cccdTS, maPhong, sbd, diemNghe, diemNoi, diemDoc, diemViet);

                    list.Add(baiThiDTO);
                }
            }
            catch (Exception ex)
            {
                //Hiển thị lỗi trong Immediate Window
                Debug.WriteLine(ex.Message);
            }

            return list;
        }
        public bool Delete(string maBaiThi)
        {
            string query = "delete BaiThi where Id_BaiThi = @MABAITHI";

            object[] para = new object[]
            {
                maBaiThi
            };
            DataProvider dataProvider = new DataProvider();
            try
            {
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public bool Insert(BaiThiDTO baiThiDTO)
        {
            string query = "insert BaiThi values ( @MABAITHI , @GV1 , @GV2 , @CCCD , @MAPHONG , @SBD , @DIEMNGHE , @DIEMNOI , @DIEMDOC , @DIEMVIET )";
            object[] para = new object[]
            {
                baiThiDTO.Id_BaiThi,
                DBNull.Value,
                DBNull.Value,
                baiThiDTO.Cccd_TS,
                baiThiDTO.Id_PhongThi,
                baiThiDTO.SoBaoDanh,
                DBNull.Value,
                DBNull.Value,
                DBNull.Value,
                DBNull.Value
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
        public string getTenThiSinh(string cccd)
        {
            string s = "";
            DataProvider dataProvider = new DataProvider();
            string query = "select HoTen_TS from ThiSinh where Cccd_TS = '" + cccd + "'";
            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);
                DataRow dataRow = data.Rows[0];
                s = dataRow["HoTen_TS"].ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return s;
        }
        public int Count()
        {
            string query = "select count(*) from BaiThi";
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
            string query = "select count(*) from BaiThi where Id_BaiThi = '" + id + "'";
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
        
        public List<string> ListCCCD(string maKhoa)
        {
            List<string> list = new List<string>();
            DataProvider dataProvider = new DataProvider();
            string query = "select * from DangKy where Id_KhoaThi = '" + maKhoa + "'";
            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    string sbd = row["Cccd_TS"].ToString();

                    list.Add(sbd);
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
