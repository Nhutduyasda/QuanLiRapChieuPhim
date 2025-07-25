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
    public partial class ThemPhim : Form
    {
        PhimDAL phim;
        public ThemPhim()
        {
            InitializeComponent();
            phim = new PhimDAL();
            SetUpDataGirdView();
            LoadCombox();
            LoadDSPhim();
        }
        public void SetUpDataGirdView()
        {
            dgvDanhSachPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachPhim.AutoGenerateColumns = true;
            dgvDanhSachPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void LoadCombox()
        {
            cboDoTuoi.Items.Clear();
            cboDoTuoi.Items.Add(">18");
            cboDoTuoi.Items.Add("tất cả đều xem được");

            cbo_TinhTrang.Items.Clear();
            cbo_TinhTrang.Items.Add("Đang Chiếu");
            cbo_TinhTrang.Items.Add("Ngưng Chiếu");

        }
        public void LoadDSPhim()
        {
            phim = new PhimDAL();
            List<DTO_Model.PhimDTO> list = phim.selectAll();
            dgvDanhSachPhim.DataSource = null;
            dgvDanhSachPhim.DataSource = list;
            if (list.Count > 0 && list != null)
            {
                dgvDanhSachPhim.DataSource = list;
                dgvDanhSachPhim.Columns["HinhAnh"].Visible = false; // Ẩn cột Hình Ảnh
            }
        }
        private void ThemPhim_Load(object sender, EventArgs e)
        {


        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            try
            {
                PhimDTO phimDTO = new PhimDTO
                {
                    MaPhim = phim.generateAutoMaPhim("PHIM", "MaPhim", "PHIM"),
                    TenPhim = txtTenPhim.Text,
                    TheLoai = txtTheLoai.Text,
                    TinhTrang = cbo_TinhTrang.Text,
                    ThoiLuong = txtThoiLuong.Text,
                    HinhAnh = pictureBox_anhPhim.ImageLocation,
                    DoTuoi = cboDoTuoi.Text

                };
                phim.Insert(phimDTO);
                LoadDSPhim();
                ClearInputFields();
                MessageBox.Show("Thêm phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phim: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_anhPhim.ImageLocation = openFileDialog.FileName;
            }


        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachPhim.SelectedRows.Count > 0)
                {
                    PhimDTO phimDTO = new PhimDTO
                    {
                        MaPhim = dgvDanhSachPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString(),
                        TenPhim = txtTenPhim.Text,
                        TheLoai = txtTheLoai.Text,
                        TinhTrang = cbo_TinhTrang.Text,
                        ThoiLuong = txtThoiLuong.Text,
                        HinhAnh = pictureBox_anhPhim.ImageLocation,
                        DoTuoi = cboDoTuoi.Text
                    };
                    phim.Update(phimDTO);
                    LoadDSPhim();
                    ClearInputFields();
                    MessageBox.Show("Cập nhật phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phim để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phim: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachPhim.SelectedRows.Count > 0)
                {
                    string maPhim = dgvDanhSachPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString();
                    phim.Delete(maPhim);
                    LoadDSPhim();
                    ClearInputFields();
                    MessageBox.Show("Xóa phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phim để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phim: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void ClearInputFields()
        {
            txtTenPhim.Clear();
            txtTheLoai.Clear();
            cbo_TinhTrang.SelectedIndex = -1;
            txtThoiLuong.Clear();
            pictureBox_anhPhim.ImageLocation = null;
            cboDoTuoi.SelectedIndex = -1;
        }
        private void dgvDanhSachPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachPhim.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSachPhim.Rows[e.RowIndex];
                txtTenPhim.Text = selectedRow.Cells["TenPhim"].Value.ToString();
                txtTheLoai.Text = selectedRow.Cells["TheLoai"].Value.ToString();
                cbo_TinhTrang.Text = selectedRow.Cells["TinhTrang"].Value.ToString();
                txtThoiLuong.Text = selectedRow.Cells["ThoiLuong"].Value.ToString();
                pictureBox_anhPhim.ImageLocation = selectedRow.Cells["HinhAnh"].Value.ToString();
                cboDoTuoi.Text = selectedRow.Cells["DoTuoi"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadDSPhim();

        }
    }
}
