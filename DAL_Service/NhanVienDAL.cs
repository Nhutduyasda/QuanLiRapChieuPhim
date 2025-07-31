using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIL_Valication;
using DTO_Model;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL_Service
{
    public class NhanVienDAL : SystemDAL<NhanVienDTO, string>
    {

        public string generateAutoMaNhanVien(string NHAN_VIEN, string MaNhanVien, string NV)
        {
            return DBUTIL.GenerateId(NHAN_VIEN, MaNhanVien, NV);
        }
        public override List<NhanVienDTO> selectAll()
        {
            string sql = "SELECT * FROM NHAN_VIEN";
            return selectBySql(sql, new List<object>());
        }
        public override NhanVienDTO selectById(string id)
        {
            string sql = "SELECT * FROM NHAN_VIEN WHERE MaNhanVien = @0";
            List<object> args = new List<object> { id };
            List<NhanVienDTO> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }
        public override List<NhanVienDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    NhanVienDTO nhanVien = new NhanVienDTO
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        TenNhanVien = reader["TenNhanVien"].ToString(),
                        ChucVu = reader["ChucVu"] != DBNull.Value ? (bool)reader["ChucVu"] : false,
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        Email = reader["Email"].ToString(),
                        MatKhauHash = reader["MatKhauHash"].ToString(),
                    };
                    list.Add(nhanVien);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting NhanVien by SQL", ex);
            }
            return list;
        }
        public override void Insert(NhanVienDTO entity)
        {
            string sql = "INSERT INTO NHAN_VIEN (MaNhanVien, TenNhanVien, ChucVu, SoDienThoai, Email, MatKhauHash) VALUES (@0, @1, @2, @3, @4, @5)";
            List<object> parameters = new List<object>
            {
                entity.MaNhanVien,
                entity.TenNhanVien,
                entity.ChucVu,
                entity.SoDienThoai,
                entity.Email,
                entity.MatKhauHash
            };
            DBUTIL.Update(sql, parameters);
        }

        public override void Update(NhanVienDTO entity)
        {
            string sql = "UPDATE NHAN_VIEN SET TenNhanVien = @1, ChucVu = @2, SoDienThoai = @3, Email = @4, MatKhauHash = @5 WHERE MaNhanVien = @0";
            List<object> parameters = new List<object>
            {
                entity.MaNhanVien,
                entity.TenNhanVien,
                entity.ChucVu,
                entity.SoDienThoai,
                entity.Email,
                entity.MatKhauHash
            };
            DBUTIL.Update(sql, parameters);
        }
        public override void Delete(string id)
        {
            string sql = "DELETE FROM NHAN_VIEN WHERE MaNhanVien = @0";
            List<object> args = new List<object> { id };
            DBUTIL.Update(sql, args);

        }
    }
}
