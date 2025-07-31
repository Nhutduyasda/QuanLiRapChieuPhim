using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class GiaoDichViewDTO
    {
        public string MaGiaoDich { get; set; } 
        public string TenKhachHang { get; set; } 
        public string TenNhanVien { get; set; } 
        public DateTime ThoiGianDatVe { get; set; }
        public decimal TongTien { get; set; }
    }
}
