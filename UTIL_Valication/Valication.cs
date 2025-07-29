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
        /// Kiểm tra thời gian đặt vé hợp lệ (Không được đặt vé trong quá khứ).
        /// </summary>
        /// <param name="thoiGianDatVe">Thời gian đặt vé cần kiểm tra.</param>"
        /// <returns>True nếu hợp lệ, ngược lại là false</returns>
        public static bool IsValidThoiGianDatVe(DateTime thoiGianDatVe)
        { 
            if (thoiGianDatVe < DateTime.Now)
            {
                return false; // Không được đặt vé trong quá khứ
            }
            return true; // Thời gian đặt vé hợp lệ
        }
        /// <summary>
        /// Kiểm tra mật khẩu hợp lệ (ít nhất 6 ký tự, bao gồm 1 chữ cái và 1 chữ số).
        /// </summary>
        /// <param name="matKhau">Chuỗi mật khẩu cần kiểm tra.</param>"
        /// <returns>True nếu hợp lệ, ngược lại là false</returns>
        public static bool IsValidPassword(string matKhau)
        {
            if (string.IsNullOrWhiteSpace(matKhau) || matKhau.Length < 6)
                return false;
            bool hasLetter = matKhau.Any(char.IsLetter);
            bool hasDigit = matKhau.Any(char.IsDigit);
            return hasLetter && hasDigit;
        }
        /// <summary>
        /// Kiểm tra họ tên hợp lệ (không chứa ký tự đặc biệt, chỉ cho phép chữ cái, khoảng trắng
        /// ).
    }
}
