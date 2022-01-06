using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DangKyDAO
    {
        public DangKyDAO() { }
        public List<DangKyDTO> ListAll()
        {
            DataProvider datapro = new DataProvider();
            List<DangKyDTO> thisinhs = new List<DangKyDTO>();

            string query = "Select * from DangKy";
            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string cccd_ts = item["Cccd_TS"].ToString();
                string Id_KhoaThi = item["Id_KhoaThi"].ToString();
                string trinhdo = item["TrinhDo"].ToString();
                string lephithi = item["LePhiThi"].ToString();

                DangKyDTO newThiSinh = new DangKyDTO(cccd_ts,Id_KhoaThi,trinhdo,lephithi);

                thisinhs.Add(newThiSinh);
            }
            return thisinhs;
        }

        public bool Update(DangKyDTO thisinh)
        {
            string query = "update DangKy set " +
                "TrinhDo = @trinhdo , " +
                "LePhiThi = @lephithi  " +
                "where Cccd_TS = @oldCCCDTS " +
                "AND Id_KhoaThi = @khoathi ";

            object[] para = new object[]
            {
                thisinh.TrinhDo,
                thisinh.LePhiThi,
                thisinh.Cccd_TS,
                thisinh.Id_KhoaThi
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

        public bool Insert(DangKyDTO thisinh)
        {
            string query = "insert into DangKy " +
                "values( @CCCD , @KHOATHI , @TRINHDO , @LEPHITHI )";

            object[] para = new object[]
            {
                thisinh.Cccd_TS,
                thisinh.Id_KhoaThi,
                thisinh.TrinhDo,
                thisinh.LePhiThi
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

        public bool Delete(string id,string idkhoa)
        {
            string query = "delete from DangKy where Cccd_TS = @CCCDTS " +
                "AND Id_KhoaThi = @khoathi ";
            object[] para = new object[]
            {
                id,
                idkhoa
            };
            DataProvider datapro = new DataProvider();
            try
            {
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e) { return false; }
            return false;
        }

        //===============
        public int Count()
        {
            string query = "select count(*) from DangKy";
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
        //public String MakeID()
        //{
        //    String id = "";
        //    int count = Count();
        //    while (true)
        //    {
        //        if (count < 10)
        //            id = "TS0" + count;
        //        else id = "TS" + count;
        //        if (Exist(id) == 0)
        //            break;
        //        else count++;
        //    }
        //    return id;
        //}
    }
}
