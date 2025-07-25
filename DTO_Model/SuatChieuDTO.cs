using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class SuatChieuDTO
    {
        public string? MaSuatChieu { get; set; }
        public string? MaPhim { get; set; }
        public string? MaPhongChieu { get; set; }
        public DateTime NgayChieu { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }
        public decimal GiaVe { get; set; }

    }
}
