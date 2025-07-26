using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
     public class VeDTO
    {
        public string? MaVe { get; set; } // Mã vé
        public string? MaDatVe { get; set; } // Mã đặt vé
        public string? MaSuatChieu { get; set; } // Mã suất chiếu
        public string? MaGhe { get; set; } // Mã ghế
        public decimal GiaVe { get; set; } // Giá vé
        public string? LoaiVe { get; set; } // Loại vé: 'Người lớn', 'Trẻ em', 'Người cao tuổi'
    }
}
