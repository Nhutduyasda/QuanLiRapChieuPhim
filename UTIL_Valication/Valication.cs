using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UTIL_Valication
{
    public class Valication
    {
        /// <summary>
        /// Kiểm tra số điện thoại hợp lệ (bắt đầu bằng 0, gồm 10 hoặc 11 chữ số).
        /// </summary>
        /// <param name="soDienThoai">Chuỗi số điện thoại cần kiểm tra.</param>
        /// <returns>True nếu hợp lệ, ngược lại False.</returns>
        public static bool IsValidPhoneNumber(string soDienThoai)
        {
            if (string.IsNullOrWhiteSpace(soDienThoai))
                return false;

            return Regex.IsMatch(soDienThoai, @"^0\d{9,10}$");
        }
        public static bool IsValidPassword(string matKhau)
        {
            if (string.IsNullOrWhiteSpace(matKhau) || matKhau.Length < 6)
                return false;
            bool hasLetter = matKhau.Any(char.IsLetter);
            bool hasDigit = matKhau.Any(char.IsDigit);
            return hasLetter && hasDigit;
        }

        /// <summary>
        /// Kiểm tra email hợp lệ (đúng định dạng Gmail).
        /// </summary>
        /// <param name="email">Chuỗi email cần kiểm tra.</param>
        /// <returns>True nếu là Gmail hợp lệ, ngược lại False.</returns>
        public static bool IsValidGmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$");
        }

        /// <summary>
        /// Kiểm tra chuỗi có bị bỏ trống (null, rỗng hoặc chỉ chứa khoảng trắng).
        /// </summary>
        /// <param name="input">Chuỗi cần kiểm tra.</param>
        /// <returns>True nếu chuỗi bị bỏ trống, ngược lại False.</returns>
        public static bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Kiểm tra ngày giờ có phải là quá khứ hay không (không cho phép thêm ngày giờ ở quá khứ).
        /// </summary>
        /// <param name="dateTime">Ngày giờ cần kiểm tra.</param>
        /// <returns>True nếu ngày giờ hợp lệ (không phải quá khứ), ngược lại False.</returns>
        public static bool IsValidFutureDate(DateTime dateTime)
        {
            return dateTime >= DateTime.Now;
        }

        /// <summary>
        /// Kiểm tra giờ bắt đầu phải nhỏ hơn giờ kết thúc.
        /// </summary>
        /// <param name="start">Giờ bắt đầu.</param>
        /// <param name="end">Giờ kết thúc.</param>
        /// <returns>True nếu giờ bắt đầu nhỏ hơn giờ kết thúc, ngược lại False.</returns>
        public static bool IsStartTimeBeforeEndTime(TimeSpan start, TimeSpan end)
        {
            return start < end;
        }

        /// <summary>
        /// Kiểm tra phòng chiếu có bị trùng suất chiếu trong khoảng thời gian (cùng ngày, cùng phòng, giao nhau giờ).
        /// </summary>
        /// <param name="maPhongChieu">Mã phòng chiếu cần kiểm tra.</param>
        /// <param name="ngayChieu">Ngày chiếu.</param>
        /// <param name="gioBatDauMoi">Giờ bắt đầu suất chiếu mới.</param>
        /// <param name="gioKetThucMoi">Giờ kết thúc suất chiếu mới.</param>
        /// <param name="danhSachSuatChieu">Danh sách các suất chiếu đã có (List&lt;SuatChieuDTO&gt;).</param>
        /// <returns>True nếu phòng chiếu còn trống, False nếu bị trùng giờ.</returns>
        public static bool IsRoomAvailableForTime(
            string maPhongChieu,
            DateTime ngayChieu,
            TimeSpan gioBatDauMoi,
            TimeSpan gioKetThucMoi,
            IEnumerable<dynamic> danhSachSuatChieu)
        {
            foreach (var suatChieu in danhSachSuatChieu)
            {
                // Kiểm tra cùng phòng chiếu và cùng ngày
                if (suatChieu.MaPhongChieu == maPhongChieu && suatChieu.NgayChieu.Date == ngayChieu.Date)
                {
                    TimeSpan gioBatDauCu = suatChieu.GioBatDau;
                    TimeSpan gioKetThucCu = suatChieu.GioKetThuc;
                    // Kiểm tra giao nhau thời gian
                    if (gioBatDauMoi < gioKetThucCu && gioKetThucMoi > gioBatDauCu)
                    {
                        // Có giao nhau, không được thêm
                        return false;
                    }
                }
            }
            // Không bị trùng, có thể thêm
            return true;
        }
    }
}
