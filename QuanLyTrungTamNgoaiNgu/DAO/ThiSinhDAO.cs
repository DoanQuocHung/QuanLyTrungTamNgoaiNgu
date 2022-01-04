using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ThiSinhDAO
    {
        public ThiSinhDAO() { }
        public List<ThiSinhDTO> ListAll()
        {
            DataProvider datapro = new DataProvider();
            List<ThiSinhDTO> thisinhs = new List<ThiSinhDTO>();

            string query = "Select * from ThiSinh";
            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string cccd_ts = item["Cccd_TS"].ToString();
                string hoten_ts = item["HoTen_TS"].ToString();
                string gioitinh_ts = item["GioiTinh_TS"].ToString();
                string ngaysinh_ts = item["NgaySinh_TS"].ToString();
                string noisinh_ts = item["NoiSinh_TS"].ToString();
                string ngaycap_ts = item["NgayCap_TS"].ToString();
                string noicap_ts = item["NoiCap_TS"].ToString();
                string sdt_ts = item["Sdt_TS"].ToString();
                string email_ts = item["Email_TS"].ToString();

                ThiSinhDTO newThiSinh = new ThiSinhDTO(cccd_ts, hoten_ts, gioitinh_ts, ngaysinh_ts, noisinh_ts, ngaycap_ts
                    , noicap_ts, sdt_ts, email_ts);

                thisinhs.Add(newThiSinh);
            }
            return thisinhs;
        }

        public List<ThiSinhDTO> List(string search)
        {
            DataProvider datapro = new DataProvider();
            List<ThiSinhDTO> thisinhs = new List<ThiSinhDTO>();

            string query = "Select * from ThiSinh where Cccd_TS LIKE '%" + search + "%'";
            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string cccd_ts = item["Cccd_TS"].ToString();
                string hoten_ts = item["HoTen_TS"].ToString();
                string gioitinh_ts = item["GioiTinh_TS"].ToString();
                string ngaysinh_ts = item["NgaySinh_TS"].ToString();
                string noisinh_ts = item["NoiSinh_TS"].ToString();
                string ngaycap_ts = item["NgayCap_TS"].ToString();
                string noicap_ts = item["NoiCap_TS"].ToString();
                string sdt_ts = item["Sdt_TS"].ToString();
                string email_ts = item["Email_TS"].ToString();

                ThiSinhDTO newThiSinh = new ThiSinhDTO(cccd_ts, hoten_ts, gioitinh_ts, ngaysinh_ts, noisinh_ts, ngaycap_ts
                    , noicap_ts, sdt_ts, email_ts);

                thisinhs.Add(newThiSinh);
            }
            return thisinhs;
        }
        /*
        public List<ThiSinhDTO> ListSearch(string search)
        {
            DataProvider datapro = new DataProvider();

            List<ThiSinhDTO> diadiems = new List<ThiSinhDTO>();
            string query = "Select * from DIADIEM where Id_DiaDiem = " + search;
            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string cccd_ts = item["Cccd_TS"].ToString();
                string hoten_ts = item["HoTen_TS"].ToString();
                string gioitinh_ts = item["GioiTinh_TS"].ToString();
                string ngaysinh_ts = item["NgaySinh_TS"].ToString();
                string noisinh_ts = item["NoiSinh_TS"].ToString();
                string ngaycap_ts = item["NgayCap_TS"].ToString();
                string noicap_ts = item["NoiCap_TS"].ToString();
                string sdt_ts = item["Sdt_TS"].ToString();
                string email_ts = item["Email_TS"].ToString();

                ThiSinhDTO newThiSinh = new ThiSinhDTO(cccd_ts, hoten_ts, gioitinh_ts, ngaysinh_ts, noisinh_ts, ngaycap_ts
                    , noicap_ts, sdt_ts, email_ts);

                diadiems.Add(newThiSinh);
            }
            return diadiems;
        }

        public ThiSinhDTO getDiaDiem(string search)
        {
            DataProvider datapro = new DataProvider();

            List<ThiSinhDTO> tours = new List<ThiSinhDTO>();
            string query = "Select * from DIADIEM where Id_DiaDiem = " + search;
            DataTable data = datapro.ExecuteQuery(query);
            ThiSinhDTO newThiSinh = new ThiSinhDTO();
            foreach (DataRow item in data.Rows)
            {
                string cccd_ts = item["Cccd_TS"].ToString();
                string hoten_ts = item["HoTen_TS"].ToString();
                string gioitinh_ts = item["GioiTinh_TS"].ToString();
                string ngaysinh_ts = item["NgaySinh_TS"].ToString();
                string noisinh_ts = item["NoiSinh_TS"].ToString();
                string ngaycap_ts = item["NgayCap_TS"].ToString();
                string noicap_ts = item["NoiCap_TS"].ToString();
                string sdt_ts = item["Sdt_TS"].ToString();
                string email_ts = item["Email_TS"].ToString();

                newThiSinh = new ThiSinhDTO(cccd_ts, hoten_ts, gioitinh_ts, ngaysinh_ts, noisinh_ts, ngaycap_ts
                    , noicap_ts, sdt_ts, email_ts);
            }
            return newThiSinh;
        }

        public ThiSinhDTO get(string id)
        {
            DataProvider datapro = new DataProvider();
            ThiSinhDTO newThiSinh = new ThiSinhDTO();
            string query = "Select * from DIADIEM where Id_DiaDiem = @id";
            object[] para = new object[]
            {
               id
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string cccd_ts = item["Cccd_TS"].ToString();
                string hoten_ts = item["HoTen_TS"].ToString();
                string gioitinh_ts = item["GioiTinh_TS"].ToString();
                string ngaysinh_ts = item["NgaySinh_TS"].ToString();
                string noisinh_ts = item["NoiSinh_TS"].ToString();
                string ngaycap_ts = item["NgayCap_TS"].ToString();
                string noicap_ts = item["NoiCap_TS"].ToString();
                string sdt_ts = item["Sdt_TS"].ToString();
                string email_ts = item["Email_TS"].ToString();

                newThiSinh = new ThiSinhDTO(cccd_ts, hoten_ts, gioitinh_ts, ngaysinh_ts, noisinh_ts, ngaycap_ts
                    , noicap_ts, sdt_ts, email_ts);
            }
            return newThiSinh;
        }

        public bool Update(ThiSinhDTO diadiem)
        {
            string query = "update dbo.DIADIEM set " +
                "Ten_DiaDiem = @TENDIADIEM  " +
                "where Id_DiaDiem = @oldMADIADIEM ";

            object[] para = new object[]
            {
                diadiem.Ten_DiaDiem,
                diadiem.Id_DiaDiem
            };
            try
            {
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e) { }
            return false;
        }

        public bool Insert(ThiSinhDTO diadiem)
        {
            string query = "insert into DIADIEM " +
                "values( @MADIADIEM , @TENDIADIEM )";

            object[] para = new object[]
            {
                diadiem.Id_DiaDiem,
                diadiem.Ten_DiaDiem
            };
            try
            {
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e) { }
            return false;
        }

        public bool Delete(string id)
        {
            string query = "delete from DIADIEM where Id_DiaDiem = @MADIADIEM ";
            //string query2 = "delete from CHITIETDIADIEM where Id_DiaDiem = @MADIADIEM";
            object[] para = new object[]
            {
                id
            };
            DataProvider datapro = new DataProvider();
            //datapro.ExecuteNonQuery(query2, para);
            try
            {
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e) { }
            return false;
        }
        */
        //===============
        public int Count()
        {
            string query = "select count(*) from ThiSinh";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from ThiSinh where Cccd_TS = '" + id + "'";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public String MakeID()
        {
            String id = "";
            int count = Count();
            while (true)
            {
                if (count < 10)
                    id = "TS0" + count;
                else id = "TS" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
