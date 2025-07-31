using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Service;
using DTO_Model;

namespace GUI
{
    public partial class frmLSGD : Form
    {
        public frmLSGD()
        {
            InitializeComponent();
            GiaoDichDAL dal = new GiaoDichDAL();
            dgvLichSuGiaoDich.DataSource = dal.selectAll();
            SetUpDataGirdView();
            SetUpColors();
        }

        public void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvLichSuGiaoDich.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvLichSuGiaoDich.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvLichSuGiaoDich.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvLichSuGiaoDich.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //Button colors
            this.btnLamMoi.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnLamMoi.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtKhachHang.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtKhachHang.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTenNhanVien.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTenNhanVien.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTongTien.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTongTien.ForeColor = ColorTranslator.FromHtml("#000000");
        }
        public void SetUpDataGirdView()
        {
            dgvLichSuGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSuGiaoDich.AutoGenerateColumns = true;
            dgvLichSuGiaoDich.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvLichSuGiaoDich.Columns["MaGiaoDich"].HeaderText = "Mã Giao Dịch";
            dgvLichSuGiaoDich.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvLichSuGiaoDich.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
            dgvLichSuGiaoDich.Columns["ThoiGianDatVe"].HeaderText = "Thời Gian Đặt Vé";
            dgvLichSuGiaoDich.Columns["TongTien"].HeaderText = "Tổng Tiền";

        }


        private void dgvDanhSachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLichSuGiaoDich.Rows.Count)
            {
                DataGridViewRow row = dgvLichSuGiaoDich.Rows[e.RowIndex];
                txtMaGD.Text = row.Cells["MaGiaoDich"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtThoiGianDatVe.Text = Convert.ToDateTime(row.Cells["ThoiGianDatVe"].Value).ToString("dd/MM/yyyy HH:mm:ss");
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();

            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            GiaoDichDAL dal = new GiaoDichDAL();
            dgvLichSuGiaoDich.DataSource = dal.selectAll();

            txtMaGD.Clear();
            txtKhachHang.Clear();
            txtTenNhanVien.Clear();
            txtThoiGianDatVe.Clear();
            txtTongTien.Clear();

            if (dgvLichSuGiaoDich.Rows.Count > 0)
            {
                dgvLichSuGiaoDich.ClearSelection();
            }


        }

        private void dgvLichSuGiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLichSuGiaoDich.Rows.Count)
            {
                DataGridViewRow row = dgvLichSuGiaoDich.Rows[e.RowIndex];
                txtMaGD.Text = row.Cells["MaGiaoDich"].Value.ToString();
                txtKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtThoiGianDatVe.Text = Convert.ToDateTime(row.Cells["ThoiGianDatVe"].Value).ToString("dd/MM/yyyy HH:mm:ss");
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();

            }
        }
    }
}
