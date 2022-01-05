using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhoaThiDAO
    {
        DataProvider datapro = new DataProvider();
        public KhoaThiDAO() { }

        public List<KhoaThiDTO> ListAll()
        {
            List<KhoaThiDTO> khoas = new List<KhoaThiDTO>();
            try
            {
                string query = "Select * from KhoaThi";

                DataTable data = datapro.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    string matour = item["Id_KhoaThi"].ToString();
                    string tentour = item["Ten_KhoaThi"].ToString();
                    string dacdiem = item["NgayThi"].ToString();
                    KhoaThiDTO newKhoa = new KhoaThiDTO();

                    khoas.Add(newKhoa);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi DB tại ListAll " + e);
            }
            return khoas;
        }
        public bool Update(KhoaThiDTO khoa)
        {
            try
            {
                string query = "update KhoaThi set " +
                    "NgayThi = @NGAYTHI " +
                    "where Id_KhoaThi = @KHOATHI";

                object[] para = new object[]
                {
                    khoa.NgayThi,
                    khoa.Id_KhoaThi
                };
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }

        public bool Insert(KhoaThiDTO khoa)
        {
            try
            {
                string query = "insert into KhoaThi" +
                    "values( @MAKHOA , @TENKHOA , @NGAYTHI )";

                object[] para = new object[]
                {
                    khoa.Id_KhoaThi,
                    khoa.Ten_KhoaThi,
                    khoa.NgayThi
                };
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }

        public bool Delete(string id)
        {
            try
            {
                string query = "delete from KhoaThi " +
                    "where Id_KhoaThi = @MAKHOA ";

                object[] para = new object[]
                {
                    id
                };
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }
        public int Count()
        {
            string query = "select count(*) from KhoaThi";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from KhoaThi where Id_KhoaThi = '" + id + "'";
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
                    id = "KHOA" + count;
                else
                    id = "KHOA" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
