using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class DatVeDTO
    {
        public string? MaDatVe { get; set; } // Mã đặt vé
        public string? MaKhachHang { get; set; } // Mã khách hàng
        public string? MaNhanVien { get; set; } // Mã nhân viên thực hiện đặt vé
        public DateTime ThoiGianDatVe { get; set; } // Thời gian đặt vé
        public decimal TongTien { get; set; } // Tổng tiền vé
        public string? TrangThaiThanhToan { get; set; } // Trạng thái thanh toán (VD: 'Chờ xử lý', 'Đã thanh toán')
    }
}

