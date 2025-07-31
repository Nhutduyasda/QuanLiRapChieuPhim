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
            SetUpColors();
        }
        public void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvDanhSachPhim.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDanhSachPhim.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvDanhSachPhim.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvDanhSachPhim.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //Button colors
            this.btnThemPhim.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThemPhim.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnCapNhat.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnCapNhat.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnXoa.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnXoa.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnLamMoi.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnLamMoi.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTenPhim.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTenPhim.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTheLoai.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTheLoai.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtThoiLuong.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtThoiLuong.ForeColor = ColorTranslator.FromHtml("#000000");
            this.cboDoTuoi.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.cboDoTuoi.ForeColor = ColorTranslator.FromHtml("#000000");
            this.cbo_TinhTrang.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.cbo_TinhTrang.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTenPhim.BorderStyle = BorderStyle.FixedSingle;
            this.txtTheLoai.BorderStyle = BorderStyle.FixedSingle;
            this.txtThoiLuong.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox_anhPhim.BorderStyle = BorderStyle.FixedSingle;

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
            cboDoTuoi.Items.Add("13+");
            cboDoTuoi.Items.Add("16");
            cboDoTuoi.Items.Add("18+");
            

            cbo_TinhTrang.Items.Clear();
            cbo_TinhTrang.Items.Add("Đang Chiếu");
            cbo_TinhTrang.Items.Add("Ngừng Chiếu");

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
                // bắt lỗi chi tiết từng input
                if (string.IsNullOrWhiteSpace(txtTenPhim.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTheLoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập thể loại phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtThoiLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập thời lượng phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbo_TinhTrang.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn tình trạng phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboDoTuoi.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn độ tuổi phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(pictureBox_anhPhim.ImageLocation))
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh cho phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


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
