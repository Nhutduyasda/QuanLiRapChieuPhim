using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Service;
using DTO_Model;

namespace GUI
{
    public partial class PhimDaThem : Form
    {

        PhimDAL phimDAL;

        public PhimDaThem()
        {
            InitializeComponent();
            SetUpComponent();
            phimDAL = new PhimDAL();
            SetUpColors();
            LoadDanhSachPhim();
            SetUpDataGirdView();

        }
        private void SetUpDataGirdView()
        {
            dgvDSPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhim.AutoGenerateColumns = true;
            dgvDSPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDSPhim.Columns["MaPhim"].HeaderText = "Mã Phim";
            dgvDSPhim.Columns["TenPhim"].HeaderText = "Tên Phim";
            dgvDSPhim.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvDSPhim.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            dgvDSPhim.Columns["ThoiLuong"].HeaderText = "Thời Lượng (phút)";
            dgvDSPhim.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
        }
        private void LoadDanhSachPhim()
        {

            phimDAL = new PhimDAL();
            List<DTO_Model.PhimDTO> list = phimDAL.selectAll();
            dgvDSPhim.DataSource = list;
            DemSoPhimDangChieu();
            ShowDateTime();
            DemSoNhanVien();
        }
        private void DemSoNhanVien()
        {

            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            int count = nhanVienDAL.selectAll().Count;
            lblEmp.Text = count.ToString();
            // Đặt định dạng cho nhãn
            lblEmp.Font = new Font("Arial", 12, FontStyle.Bold);
            lblEmp.ForeColor = Color.Black;
            lblNV.Font = new Font("Arial", 12, FontStyle.Bold);
            lblNV.ForeColor = Color.Black;

        }
        private void ShowDateTime()
        {
            // Hiển thị ngày giờ hiện tại

            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            // Đặt định dạng cho nhãn
            lblDateTime.Font = new Font("Arial", 12, FontStyle.Bold);
            lblDateTime.ForeColor = Color.Black;
            lblNgay.Font = new Font("Arial", 12, FontStyle.Bold);
            lblNgay.ForeColor = Color.Black;
;

        }

        private void DemSoPhimDangChieu()
        {

            int count = dgvDSPhim.Rows
                .Cast<DataGridViewRow>()
                .Count(row => row.Cells["TinhTrang"].Value?.ToString() == "Đang chiếu");

            lblNumber.Text = count.ToString();
            // Đặt định dạng cho nhãn
            lblNumber.Font = new Font("Arial", 12, FontStyle.Bold);
            lblNumber.ForeColor = Color.Black;
            lblName.Font = new Font("Arial", 12, FontStyle.Bold);
            lblName.ForeColor = Color.Black;

        }

        private void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvDSPhim.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDSPhim.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDSPhim.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvDSPhim.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.panel1.BackColor = ColorTranslator.FromHtml("#81C784");
            this.panel2.BackColor = ColorTranslator.FromHtml("#81C784");
            this.panel3.BackColor = ColorTranslator.FromHtml("#81C784");
        }
        private void SetUpComponent()
        {
            StartPosition = FormStartPosition.CenterScreen;
            dgvDSPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhim.AutoGenerateColumns = true;
            dgvDSPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void PhimDaThem_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhim();
        }


        private void PhimDaThem_Load_1(object sender, EventArgs e)
        {
            LoadDanhSachPhim();
        }
    }
}
