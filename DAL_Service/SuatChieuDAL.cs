using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_Model;
using UTIL_Valication;

namespace DAL_Service
{
    public class SuatChieuDAL : SystemDAL<SuatChieuDTO, string>
    {
        public string GenerateAutoMaSuatChieu(string tableName, string columnName, string prefix)
        {
            return DBUTIL.GenerateId(tableName, columnName, prefix);
        }

        public override List<SuatChieuDTO> selectAll()
        {
            string sql = "SELECT * FROM SUAT_CHIEU";
            return selectBySql(sql, new List<object>());
        }

        public override SuatChieuDTO selectById(string id)
        {
            string sql = "SELECT * FROM SUAT_CHIEU WHERE MaSuatChieu = @0";
            List<object> args = new List<object> { id };
            List<SuatChieuDTO> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }

        public override List<SuatChieuDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<SuatChieuDTO> list = new List<SuatChieuDTO>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    SuatChieuDTO sc = new SuatChieuDTO
                    {
                        MaSuatChieu = reader["MaSuatChieu"].ToString(),
                        MaPhim = reader["MaPhim"].ToString(),
                        MaPhongChieu = reader["MaPhongChieu"].ToString(),   
                        NgayChieu = Convert.ToDateTime(reader["NgayChieu"]),
                        GioBatDau = (TimeSpan)reader["ThoiGianBatDau"],
                        GioKetThuc = (TimeSpan)reader["ThoiGianKetThuc"],
                        GiaVe = Convert.ToDecimal(reader["GiaVe"]),
                    };
                    list.Add(sc);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting SuatChieu by SQL", ex);
            }
            return list;
        }

        public override void Insert(SuatChieuDTO entity)
        {
            string sql = @"INSERT INTO SUAT_CHIEU (MaSuatChieu, MaPhim, MaPhongChieu,NgayChieu, ThoiGianBatDau, ThoiGianKetThuc, GiaVe)
                           VALUES (@0, @1, @2, @3, @4, @5, @6)";
            List<object> parameters = new List<object>
            {
                entity.MaSuatChieu,
                entity.MaPhim,
                entity.MaPhongChieu,
                entity.NgayChieu,
                entity.GioBatDau,
                entity.GioKetThuc,
                entity.GiaVe
            };
            DBUTIL.Update(sql, parameters);
        }

        public override void Update(SuatChieuDTO entity)
        {
            string sql = @"UPDATE SUAT_CHIEU 
                           SET MaPhim = @1, MaPhongChieu = @2,
                               NgayChieu = @3, ThoiGianBatDau = @4, ThoiGianKetThuc = @5, GiaVe = @6
                           WHERE MaSuatChieu = @0";
            List<object> parameters = new List<object>
            {
                entity.MaSuatChieu,
                entity.MaPhim,
                entity.MaPhongChieu,
                entity.NgayChieu,
                entity.GioBatDau,
                entity.GioKetThuc,
                entity.GiaVe
            };
            DBUTIL.Update(sql, parameters);
        }

        public override void Delete(string id)
        {
            string sql = "DELETE FROM SUAT_CHIEU WHERE MaSuatChieu = @0";
            List<object> parameters = new List<object> { id };
            DBUTIL.Update(sql, parameters);
        }

        public List<SuatChieuView> SelectViewPhimSuatChieu()
        {
            List<SuatChieuView> list = new List<SuatChieuView>();
            string sql = @"
        SELECT 
            SC.MaSuatChieu,
            P.TenPhim,
            PC.TenPhongChieu,
            P.HinhAnh,
            SC.GiaVe
        FROM SUAT_CHIEU SC
        JOIN PHIM P ON SC.MaPhim = P.MaPhim
        JOIN PHONG_CHIEU PC ON SC.MaPhongChieu = PC.MaPhongChieu
    ";

            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, new List<object>());
                while (reader.Read())
                {
                    SuatChieuView item = new SuatChieuView
                    {
                        MaSuatChieu = reader["MaSuatChieu"].ToString(),
                        TenPhim = reader["TenPhim"].ToString(),
                        TenPhongChieu = reader["TenPhongChieu"].ToString(),
                        HinhAnh = reader["HinhAnh"].ToString(),
                        GiaVe = Convert.ToDecimal(reader["GiaVe"])
                    };
                    list.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting SuatChieuPhimViewDTO", ex);
            }

            return list;
        }



    }
}
