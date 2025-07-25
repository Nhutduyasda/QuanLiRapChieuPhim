using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Model;
using Microsoft.Data.SqlClient;
using UTIL_Valication;

namespace DAL_Service
{
    public class PhongChieuDAL
    {
        public List<PhongChieuDTO> selectAll()
        {
            string sql = "SELECT * FROM PHONG_CHIEU";
            return selectBySql(sql, new List<object>());
        }
        public PhongChieuDTO selectById(string id)
        {
            string sql = "SELECT * FROM PHONG_CHIEU WHERE MaPhongChieu = @0";
            List<object> args = new List<object> { id };
            List<PhongChieuDTO> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }
        public List<PhongChieuDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhongChieuDTO> list = new List<PhongChieuDTO>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    PhongChieuDTO phongChieu = new PhongChieuDTO
                    {
                        MaPhongChieu = reader["MaPhongChieu"].ToString(),
                        MaRapChieu = reader["MaRapChieu"].ToString(),
                        TenPhongChieu = reader["TenPhongChieu"].ToString(),
                        SucChua = Convert.ToInt32(reader["SucChua"]),
                    };
                    list.Add(phongChieu);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting PhongChieu by SQL", ex);
            }
            return list;
        }
    }
}
