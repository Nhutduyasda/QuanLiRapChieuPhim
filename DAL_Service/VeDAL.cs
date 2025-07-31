using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_Model;
using UTIL_Valication;

namespace DAL_Service
{
    public class VeDAL : SystemDAL<VeDTO, string>
    {
        public override List<VeDTO> selectAll()
        {
            string sql = "SELECT * FROM VE";
            return selectBySql(sql, new List<object>());
        }

        public override VeDTO selectById(string id)
        {
            string sql = "SELECT * FROM VE WHERE MaVe = @0";
            List<object> args = new List<object> { id };
            var result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }

        public override List<VeDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<VeDTO> list = new List<VeDTO>();
            SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
            while (reader.Read())
            {
                VeDTO ve = new VeDTO
                {
                    MaVe = reader["MaVe"].ToString(),
                    MaDatVe = reader["MaDatVe"].ToString(),
                    MaSuatChieu = reader["MaSuatChieu"].ToString(),
                    MaGhe = reader["MaGhe"].ToString(),
                    GiaVe = Convert.ToDecimal(reader["GiaVe"]),
                    LoaiVe = reader["LoaiVe"].ToString()
                };
                list.Add(ve);
            }
            reader.Close();
            return list;
        }

        public override void Insert(VeDTO entity)
        {
            string sql = "INSERT INTO VE (MaVe, MaDatVe, MaSuatChieu, MaGhe, GiaVe, LoaiVe) VALUES (@0, @1, @2, @3, @4, @5)";
            List<object> args = new List<object>
            {
                entity.MaVe, entity.MaDatVe, entity.MaSuatChieu, entity.MaGhe, entity.GiaVe, entity.LoaiVe
            };
            DBUTIL.Update(sql, args);
        }

        public override void Update(VeDTO entity)
        {
            string sql = "UPDATE VE SET MaDatVe = @1, MaSuatChieu = @2, MaGhe = @3, GiaVe = @4, LoaiVe = @5 WHERE MaVe = @0";
            List<object> args = new List<object>
            {
                entity.MaVe, entity.MaDatVe, entity.MaSuatChieu, entity.MaGhe, entity.GiaVe, entity.LoaiVe
            };
            DBUTIL.Update(sql, args);
        }

        public override void Delete(string id)
        {
            string sql = "DELETE FROM VE WHERE MaVe = @0";
            DBUTIL.Update(sql, new List<object> { id });
        }
    }
}
