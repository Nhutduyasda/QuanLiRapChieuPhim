using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_Model;
using UTIL_Valication;

namespace DAL_Service
{
    public class GiaoDichDAL : SystemDAL<GiaoDichViewDTO, string>
    {
        public override List<GiaoDichViewDTO> selectAll()
        {
            string sql = @"
                SELECT 
                    dv.MaDatVe AS MaGiaoDich,
                    nv.TenNhanVien,
                    kh.TenKhachHang,
                    dv.ThoiGianDatVe,
                    dv.TongTien
                FROM DAT_VE dv
                JOIN KHACH_HANG kh ON dv.MaKhachHang = kh.MaKhachHang
                JOIN NHAN_VIEN nv ON dv.MaNhanVien = nv.MaNhanVien";

            return selectBySql(sql, new List<object>());
        }

        public override GiaoDichViewDTO selectById(string id)
        {
            string sql = @"
                SELECT 
                    dv.MaDatVe AS MaGiaoDich,
                    kh.TenKhachHang,
                    nv.TenNhanVien,
                    dv.ThoiGianDatVe,
                    dv.TongTien
                FROM DAT_VE dv
                JOIN KHACH_HANG kh ON dv.MaKhachHang = kh.MaKhachHang
                JOIN NHAN_VIEN nv ON dv.MaNhanVien = nv.MaNhanVien
                WHERE dv.MaDatVe = @0";

            List<object> args = new List<object> { id };
            var list = selectBySql(sql, args);
            return list.Count > 0 ? list[0] : null;
        }

        public override List<GiaoDichViewDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<GiaoDichViewDTO> list = new List<GiaoDichViewDTO>();
            SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
            while (reader.Read())
            {
                GiaoDichViewDTO gd = new GiaoDichViewDTO
                {
                    MaGiaoDich = reader["MaGiaoDich"].ToString(),
                    TenKhachHang = reader["TenKhachHang"].ToString(),
                    TenNhanVien = reader["TenNhanVien"].ToString(),
                    ThoiGianDatVe = Convert.ToDateTime(reader["ThoiGianDatVe"]),
                    TongTien = Convert.ToDecimal(reader["TongTien"])
                };
                list.Add(gd);
            }
            reader.Close();
            return list;
        }

        // Không cần Insert/Update/Delete vì ViewDTO này chỉ dùng để hiển thị join
        public override void Insert(GiaoDichViewDTO entity) { throw new NotImplementedException(); }
        public override void Update(GiaoDichViewDTO entity) { throw new NotImplementedException(); }
        public override void Delete(string id) { throw new NotImplementedException(); }
    }
}
