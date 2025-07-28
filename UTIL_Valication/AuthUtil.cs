using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Model;

namespace UTIL_Valication
{
    public class AuthUtil
    {
        public static NhanVienDTO? user = null;



        //Kiểm tra trạng thái đăng nhập
        public static Boolean IsLogin()
        {
            return user != null;
        }

        //kiểm tra quyền quản lý của tài khoản   

        public static Boolean IsManager()
        {
            return user != null && user.ChucVu == true;

        }


    }
}
