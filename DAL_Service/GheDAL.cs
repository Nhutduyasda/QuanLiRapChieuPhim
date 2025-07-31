using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_Model;
using UTIL_Valication;

namespace DAL_Service
{
    public class GheDAL : SystemDAL<GheDTO, string>
    {
        public override List<GheDTO> selectAll()
        {
            string sql = "SELECT * FROM GHE";
            return selectBySql(sql, new List<object>());
        }
        public void UpdateTrangThai(GheDTO ghe)
        {
            string sql = "UPDATE GHE SET TrangThai = @0 WHERE MaGhe = @1";
            List<object> args = new List<object> { ghe.TrangThai, ghe.MaGhe };
            DBUTIL.Update(sql, args);
        }

        public override GheDTO selectById(string id)
        {
            string sql = "SELECT * FROM GHE WHERE MaGhe = @0";
            List<object> args = new List<object> { id };
            var result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }

        public override List<GheDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<GheDTO> list = new List<GheDTO>();
            SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
            while (reader.Read())
            {
                GheDTO ghe = new GheDTO
                {
                    MaGhe = reader["MaGhe"].ToString(),
                    MaPhongChieu = reader["MaPhongChieu"].ToString(),
                    SoGhe = reader["SoGhe"].ToString(),
                    HangGhe = reader["HangGhe"].ToString(),
                    TrangThai = reader["TrangThai"].ToString()
                };
                list.Add(ghe);
            }
            reader.Close();
            return list;
        }

        public override void Insert(GheDTO entity)
        {
            string sql = "INSERT INTO GHE (MaGhe, MaPhongChieu, SoGhe, HangGhe, TrangThai) VALUES (@0, @1, @2, @3, @4)";
            List<object> args = new List<object>
            {
                entity.MaGhe, entity.MaPhongChieu, entity.SoGhe, entity.HangGhe, entity.TrangThai
            };
            DBUTIL.Update(sql, args);
        }

        public override void Update(GheDTO entity)
        {
            string sql = "UPDATE GHE SET MaPhongChieu = @1, SoGhe = @2, HangGhe = @3, TrangThai = @4 WHERE MaGhe = @0";
            List<object> args = new List<object>
            {
                entity.MaGhe, entity.MaPhongChieu, entity.SoGhe, entity.HangGhe, entity.TrangThai
            };
            DBUTIL.Update(sql, args);
        }

        public override void Delete(string id)
        {
            string sql = "DELETE FROM GHE WHERE MaGhe = @0";
            DBUTIL.Update(sql, new List<object> { id });
        }
    }
}
