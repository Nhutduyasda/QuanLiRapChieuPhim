using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Service;
using DTO_Model;

namespace GUI
{
    public partial class FrmDatVe : Form
    {
        private List<string> gheDaChon = new List<string>();
        private string maSuatChieu;
        private string tenPhim;
        private KhachHangDAL khachHangDAL;
        public FrmDatVe(string maSuatChieu, string tenPhim)
        {
            InitializeComponent();
            this.maSuatChieu = maSuatChieu;
            this.tenPhim = tenPhim;
            khachHangDAL = new KhachHangDAL();

            lblTieuDe.Text = $"Màn hình chiếu – {tenPhim}";
        }

        private List<Button> danhSachGheDaChon = new List<Button>();
        private void FrmDatVe_Load(object sender, EventArgs e)
        {
            
            foreach (Control dieuKhien in this.Controls)
            {
                if (dieuKhien is Button && dieuKhien.Name.StartsWith("btnGhe"))
                {
                    dieuKhien.Click += SuKienChonGhe;
                }
            }

        }

        private void SuKienChonGhe(object sender, EventArgs e)
        {
            Button ghe = sender as Button;

            if (danhSachGheDaChon.Contains(ghe))
            {
                ghe.BackColor = SystemColors.Control;
                danhSachGheDaChon.Remove(ghe);
            }
            else
            {
                ghe.BackColor = ColorTranslator.FromHtml("#4CAF50");
                danhSachGheDaChon.Add(ghe);
            }

            CapNhatThongTinGheVaTien();
        }
        private void CapNhatThongTinGheVaTien()
        {
            // Hiển thị danh sách số ghế đã chọn
            var danhSachSoGhe = danhSachGheDaChon
                .Select(ghe => ghe.Text)
                .OrderBy(so => int.Parse(so))
                .ToList();

            txtGheDaChon.Text = string.Join(", ", danhSachSoGhe);

            // Tính tổng tiền
            int giaVe = 75000;
            int tongTien = danhSachGheDaChon.Count * giaVe;

            txtTongTienVe.Text = tongTien.ToString("N0") + " VNĐ"; 
        }

        private void TaoGheTuDong()
        {
            int soLuongGhe = 50;
            int soCot = 10;
            int soHang = soLuongGhe / soCot;

            int leTrai = 20;
            int leTren = 100;
            int khoangCach = 10;

            int chieuRongPanel = 920;
            int chieuCaoPanel = 600;

            int chieuRongGhe = (chieuRongPanel - (soCot - 1) * khoangCach) / soCot;
            int chieuCaoGhe = (chieuCaoPanel - (soHang - 1) * khoangCach) / soHang;

            for (int i = 0; i < soLuongGhe; i++)
            {
                Button ghe = new Button();
                ghe.Name = "btnGhe" + (i + 1);
                ghe.Text = (i + 1).ToString();
                ghe.Width = chieuRongGhe;
                ghe.Height = chieuCaoGhe;

                int cot = i % soCot;
                int hang = i / soCot;

                ghe.Left = leTrai + cot * (chieuRongGhe + khoangCach);
                ghe.Top = leTren + hang * (chieuCaoGhe + khoangCach);

                ghe.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                ghe.BackColor = SystemColors.Control;

                // ✅ Gán đúng MaGhe theo format đã lưu trong database: "btnGhe1", "btnGhe2", ...
                ghe.Tag = "btnGhe" + (i + 1);

                ghe.Click += SuKienChonGhe;

                this.Controls.Add(ghe);
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmDatVe_Load_1(object sender, EventArgs e)
        {
            foreach (Control dieuKhien in this.Controls)
            {
                if (dieuKhien is Button && dieuKhien.Name.StartsWith("btnGhe"))
                {
                    dieuKhien.Click += SuKienChonGhe;
                }
            }
            TaoGheTuDong();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (danhSachGheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form nhập thông tin khách hàng
            ThongTinKhachHang formKH = new ThongTinKhachHang();
            ThongTinNhanVien formNV = new ThongTinNhanVien();

            if (formKH.ShowDialog() == DialogResult.OK)
            {
                // 1. Lấy thông tin khách hàng từ form
                // Kiểm tra thông tin khách hàng
                if (string.IsNullOrWhiteSpace(formKH.MaKhachHang) ||
                    string.IsNullOrWhiteSpace(formKH.HoTen) ||
                    string.IsNullOrWhiteSpace(formKH.SoDienThoai) ||
                    string.IsNullOrWhiteSpace(formKH.Email))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maKH = formKH.MaKhachHang;
                string tenKH = formKH.HoTen;
                string sdt = formKH.SoDienThoai;
                string email = formKH.Email;
                string gheDaChon = txtGheDaChon.Text;
                string tongTien = txtTongTienVe.Text;




                // 2. Tạo mã đặt vé & đối tượng DatVe
                string maDatVe = "DV" + Guid.NewGuid().ToString("N").Substring(0, 8);

                DatVeDTO datVe = new DatVeDTO
                {
                    MaDatVe = maDatVe,
                    MaKhachHang = maKH, 
                    MaNhanVien = "NV003",
                    ThoiGianDatVe = DateTime.Now,
                    TongTien = decimal.Parse(tongTien.Replace(" VNĐ", "").Replace(",", "")),
                    TrangThaiThanhToan = "Chờ xử lý"
                };

                DatVeDAL datVeDAL = new DatVeDAL();
                datVeDAL.Insert(datVe);

                VeDAL veDAL = new VeDAL();
                GheDAL gheDAL = new GheDAL();

                foreach (Button btn in danhSachGheDaChon)
                {
                    // MaGhe được lưu trong Tag của button
                    string maGhe = btn.Tag.ToString();

                    VeDTO ve = new VeDTO
                    {
                        MaVe = "VE" + Guid.NewGuid().ToString("N").Substring(0, 6),
                        MaDatVe = maDatVe,
                        MaSuatChieu = this.maSuatChieu, 
                        MaGhe = maGhe,
                        GiaVe = 75000,
                        LoaiVe = "Người lớn"
                    };

                    veDAL.Insert(ve);


                    GheDTO ghe = new GheDTO
                    {
                        MaGhe = maGhe,
                        TrangThai = "Đã đặt"
                    };
                    gheDAL.UpdateTrangThai(ghe);
                }

                // 4. Xuất hóa đơn
                XuatHoaDon(tenKH, sdt, email, gheDaChon, tongTien);

                // 5. Reset
                foreach (Button ghe in danhSachGheDaChon)
                {
                    ghe.Visible = false;
                }

                danhSachGheDaChon.Clear();
                txtGheDaChon.Clear();
                txtTongTienVe.Clear();

                MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void XuatHoaDon(string hoTen, string sdt, string email, string ghe, string tongTien)
        {
            string hoaDon = "===== HÓA ĐƠN =====\n";
            hoaDon += $"Họ tên: {hoTen}\n";
            hoaDon += $"SĐT: {sdt}\n";
            hoaDon += $"Email: {email}\n";
            hoaDon += $"Ghế đã chọn: {ghe}\n";
            hoaDon += $"Tổng tiền: {tongTien}\n";
            hoaDon += "----------------------\n";
            hoaDon += "Cảm ơn quý khách!";

            MessageBox.Show(hoaDon, "HÓA ĐƠN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
