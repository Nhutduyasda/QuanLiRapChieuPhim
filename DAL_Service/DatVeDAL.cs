using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_Model;
using UTIL_Valication;

namespace DAL_Service
{
    public class DatVeDAL : SystemDAL<DatVeDTO, string>
    {
        public override List<DatVeDTO> selectAll()
        {
            string sql = "SELECT * FROM DAT_VE";
            return selectBySql(sql, new List<object>());
        }

        public override DatVeDTO selectById(string id)
        {
            string sql = "SELECT * FROM DAT_VE WHERE MaDatVe = @0";
            List<object> args = new List<object> { id };
            var result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }

        public override List<DatVeDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<DatVeDTO> list = new List<DatVeDTO>();
            SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
            while (reader.Read())
            {
                DatVeDTO datVe = new DatVeDTO
                {
                    MaDatVe = reader["MaDatVe"].ToString(),
                    MaKhachHang = reader["MaKhachHang"].ToString(),
                    MaNhanVien = reader["MaNhanVien"].ToString(),
                    ThoiGianDatVe = Convert.ToDateTime(reader["ThoiGianDatVe"]),
                    TongTien = Convert.ToDecimal(reader["TongTien"]),
                    TrangThaiThanhToan = reader["TrangThaiThanhToan"].ToString()
                };
                list.Add(datVe);
            }
            reader.Close();
            return list;
        }

        public override void Insert(DatVeDTO entity)
        {
            string sql = @"INSERT INTO DAT_VE 
                           (MaDatVe, MaKhachHang, MaNhanVien, ThoiGianDatVe, TongTien, TrangThaiThanhToan)
                           VALUES (@0, @1, @2, @3, @4, @5)";
            List<object> args = new List<object>
            {
                entity.MaDatVe,
                entity.MaKhachHang,
                entity.MaNhanVien,
                entity.ThoiGianDatVe,
                entity.TongTien,
                entity.TrangThaiThanhToan
            };
            DBUTIL.Update(sql, args);
        }

        public override void Update(DatVeDTO entity)
        {
            string sql = @"UPDATE DAT_VE 
                           SET MaKhachHang = @1,
                               MaNhanVien = @2,
                               ThoiGianDatVe = @3,
                               TongTien = @4,
                               TrangThaiThanhToan = @5
                           WHERE MaDatVe = @0";
            List<object> args = new List<object>
            {
                entity.MaDatVe,
                entity.MaKhachHang,
                entity.MaNhanVien,
                entity.ThoiGianDatVe,
                entity.TongTien,
                entity.TrangThaiThanhToan
            };
            DBUTIL.Update(sql, args);
        }

        public override void Delete(string id)
        {
            string sql = "DELETE FROM DAT_VE WHERE MaDatVe = @0";
            DBUTIL.Update(sql, new List<object> { id });
        }
    }
}
