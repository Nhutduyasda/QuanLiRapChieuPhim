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
using UTIL_Valication;

namespace GUI
{
    public partial class ThongTinNhanVien : Form
    {
        private NhanVienDAL nhanVienDAL;
        public ThongTinNhanVien()
        {
            InitializeComponent();
            nhanVienDAL = new NhanVienDAL();
            SetUpDataGirdView();
            LoadComboBoxChucVu();
            LoadDSNhanVien();

        }
        public string MaNhanVien => txtMaNhanVien.Text;
        public void SetUpDataGirdView()
        {
            dgvDanhSachNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNV.AutoGenerateColumns = true;
            dgvDanhSachNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadComboBoxChucVu()
        {
            cboChucVu.Items.Clear();
            cboChucVu.Items.Add("Quản lý");
            cboChucVu.Items.Add("Nhân viên");
            cboChucVu.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LoadDSNhanVien()
        {
            nhanVienDAL = new NhanVienDAL();
            List<NhanVienDTO> list = nhanVienDAL.selectAll();
            dgvDanhSachNV.DataSource = null;
            dgvDanhSachNV.DataSource = list;

            if (list.Count > 0 && list != null)
            {
                dgvDanhSachNV.DataSource = list;
                dgvDanhSachNV.Columns["MatKhau"].Visible = false;
            }

        }


        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachNV.Rows.Count)
            {
                DataGridViewRow row = dgvDanhSachNV.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtHoTen.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cboChucVu.Text = row.Cells["ChucVu"].Value.ToString();

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string soDienThoai = txtSoDienThoai.Text;
                string email = txtEmail.Text;
                string matKhau = txtMatKhau.Text;
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(soDienThoai) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(matKhau))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Valication.IsValidPhoneNumber(soDienThoai))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Valication.IsValidGmail(email))
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Valication.IsValidPassword(matKhau))
                {
                    MessageBox.Show("Mật khẩu phải ít nhất 6 ký tự, bao gồm ít nhất 1 chữ cái và 1 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                NhanVienDTO nhanVien = new NhanVienDTO
                {
                    MaNhanVien = nhanVienDAL.generateAutoMaNhanVien("NHAN_VIEN", "MaNhanVien", "NV"),
                    TenNhanVien = txtHoTen.Text,
                    SoDienThoai = txtSoDienThoai.Text,
                    Email = txtEmail.Text,
                    ChucVu = cboChucVu.Text,
                    MatKhau = txtMatKhau.Text
                };
                nhanVienDAL.Insert(nhanVien);
                LoadDSNhanVien();
                ClearInputFields();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachNV.SelectedRows.Count > 0)
                {
                    string maNhanVien = dgvDanhSachNV.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                    nhanVienDAL.Delete(maNhanVien);
                    LoadDSNhanVien();
                    ClearInputFields();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string soDienThoai = txtSoDienThoai.Text;
                string email = txtEmail.Text;
                if (!Valication.IsValidPhoneNumber(soDienThoai))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Valication.IsValidGmail(email))
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dgvDanhSachNV.SelectedRows.Count > 0)
                {
                    string maNhanVien = dgvDanhSachNV.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                    NhanVienDTO nhanVien = new NhanVienDTO
                    {
                        MaNhanVien = maNhanVien,
                        TenNhanVien = txtHoTen.Text,
                        SoDienThoai = txtSoDienThoai.Text,
                        Email = txtEmail.Text,
                        ChucVu = cboChucVu.Text,
                        MatKhau = txtMatKhau.Text
                    };
                    nhanVienDAL.Update(nhanVien);
                    ClearInputFields();
                    LoadDSNhanVien();

                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void ClearInputFields()
        {
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            cboChucVu.SelectedIndex = -1;
            txtMatKhau.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadDSNhanVien();
            MessageBox.Show("Đã làm mới danh sách nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
