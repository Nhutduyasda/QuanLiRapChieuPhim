using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class HoaDon
    {
        public string? MaHoaDon { get; set; } // Mã hóa đơn
        public string? MaDatVe { get; set; } // Mã đặt vé liên kết với hóa đơn
        public string? NgayLapHoaDon { get; set; } // Ngày lập hóa đơn
        public decimal TongTien { get; set; } // Tổng tiền hóa đơn
        public string? TrangThaiThanhToan { get; set; } // Trạng thái thanh toán (VD: 'Chưa thanh toán', 'Đã thanh toán', 'Đã hủy')
                                                        
    }
}
