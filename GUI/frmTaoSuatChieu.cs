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
using UTIL_Valication;

namespace GUI
{
    public partial class frmTaoSuatChieu : Form
    {
        SuatChieuDAL suatChieu;
        public frmTaoSuatChieu()
        {
            InitializeComponent();
            SetUpDataGirdView();
            LoadDataGridView();
            LoadComboBoxPhim();
            LoadComBoxPhongChieu();
            SetUpColors();

        }
        public void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvSuatChieuPhim.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvSuatChieuPhim.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvSuatChieuPhim.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvSuatChieuPhim.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            //Button colors
            this.btnThem.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThem.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnXoa.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnXoa.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnSua.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnSua.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnLamMoi.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnLamMoi.ForeColor = ColorTranslator.FromHtml("#FFFFFF");


        }
        public string MaSuatChieu => txtMaSuatChieu.Text.Trim();

        public void SetUpDataGirdView()
        {
            dgvSuatChieuPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuatChieuPhim.AutoGenerateColumns = true;
            dgvSuatChieuPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



        }
        public void LoadDataGridView()
        {
            suatChieu = new SuatChieuDAL();
            List<DTO_Model.SuatChieuDTO> list = suatChieu.selectAll();
            dgvSuatChieuPhim.DataSource = null;
            dgvSuatChieuPhim.DataSource = list;
            if (list.Count > 0 && list != null)
            {
                dgvSuatChieuPhim.DataSource = list;

            }
        }
        public void LoadComboBoxPhim()
        {
            PhimDAL phimDAL = new PhimDAL();
            List<PhimDTO> listPhim = phimDAL.selectAll();
            cboPhim.DataSource = listPhim;
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.ValueMember = "MaPhim";
        }
        public void LoadComBoxPhongChieu()
        {
            PhongChieuDAL phongChieuDAL = new PhongChieuDAL();
            List<PhongChieuDTO> listPhongChieu = phongChieuDAL.selectAll();
            cboPhongChieu.DataSource = listPhongChieu;
            cboPhongChieu.DisplayMember = "TenPhongChieu";
            cboPhongChieu.ValueMember = "MaPhongChieu";

        }
        public void NextForm(Form nextForm)
        {
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
        private void btnChonPhim_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra ngày chiếu không ở quá khứ
            if (!Valication.IsValidFutureDate(dateTimePicker_NgayChieu.Value.Date))
            {
                MessageBox.Show("Ngày chiếu không được ở quá khứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giờ bắt đầu < giờ kết thúc
            TimeSpan gioBatDau, gioKetThuc;
            if (!TimeSpan.TryParse(txtBatDau.Text, out gioBatDau) || !TimeSpan.TryParse(txtKetThuc.Text, out gioKetThuc))
            {
                MessageBox.Show("Định dạng giờ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Valication.IsStartTimeBeforeEndTime(gioBatDau, gioKetThuc))
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra suất chiếu có chưa
            if (!Valication.IsRoomAvailableForTime(
                cboPhongChieu.SelectedValue.ToString(),
                dateTimePicker_NgayChieu.Value.Date,
                gioBatDau,
                gioKetThuc,
                suatChieu.selectAll()))
            {
                MessageBox.Show("Phòng chiếu đã có suất chiếu trong khoảng thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBatDau.Text) ||
                string.IsNullOrWhiteSpace(txtKetThuc.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrWhiteSpace(txtGiaVe.Text) || !decimal.TryParse(txtGiaVe.Text, out decimal giaVe) || giaVe <= 0)
            {
                MessageBox.Show("Giá vé phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (dgvSuatChieuPhim.SelectedRows.Count > 0)
                {
                    SuatChieuDTO suatChieuDTO = new SuatChieuDTO
                    {
                        MaSuatChieu = dgvSuatChieuPhim.SelectedRows[0].Cells["MaSuatChieu"].Value.ToString(),
                        MaPhim = cboPhim.SelectedValue.ToString(),
                        MaPhongChieu = cboPhongChieu.SelectedValue.ToString(),
                        NgayChieu = dateTimePicker_NgayChieu.Value.Date,
                        GioBatDau = TimeSpan.Parse(txtBatDau.Text),
                        GioKetThuc = TimeSpan.Parse(txtKetThuc.Text),
                        GiaVe = decimal.Parse(txtGiaVe.Text)
                    };
                    suatChieu.Update(suatChieuDTO);
                    ClearInputFields();
                    LoadDataGridView();
                    MessageBox.Show("Cập nhật suất chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một suất chiếu để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật suất chiếu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            // Kiểm tra ngày chiếu không ở quá khứ
            if (!Valication.IsValidFutureDate(dateTimePicker_NgayChieu.Value.Date))
            {
                MessageBox.Show("Ngày chiếu không được ở quá khứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giờ bắt đầu < giờ kết thúc
            TimeSpan gioBatDau, gioKetThuc;
            if (!TimeSpan.TryParse(txtBatDau.Text, out gioBatDau) || !TimeSpan.TryParse(txtKetThuc.Text, out gioKetThuc))
            {
                MessageBox.Show("Định dạng giờ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Valication.IsStartTimeBeforeEndTime(gioBatDau, gioKetThuc))
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra suất chiếu có chưa
            if (!Valication.IsRoomAvailableForTime(
                cboPhongChieu.SelectedValue.ToString(),
                dateTimePicker_NgayChieu.Value.Date,
                gioBatDau,
                gioKetThuc,
                suatChieu.selectAll()))
            {
                MessageBox.Show("Phòng chiếu đã có suất chiếu trong khoảng thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SuatChieuDTO suatChieuDTO = new SuatChieuDTO
                {
                    MaSuatChieu = suatChieu.GenerateAutoMaSuatChieu("SUAT_CHIEU", "MaSuatChieu", "SC"),
                    MaPhim = cboPhim.SelectedValue.ToString(),
                    MaPhongChieu = cboPhongChieu.SelectedValue.ToString(),
                    NgayChieu = dateTimePicker_NgayChieu.Value.Date,
                    GioBatDau = TimeSpan.Parse(txtBatDau.Text),
                    GioKetThuc = TimeSpan.Parse(txtKetThuc.Text),
                    GiaVe = decimal.Parse(txtGiaVe.Text)


                };
                suatChieu.Insert(suatChieuDTO);
                ClearInputFields();
                LoadDataGridView();
                MessageBox.Show("Thêm suất chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm suất chiếu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSuatChieuPhim.SelectedRows.Count > 0)
                {
                    // Lấy mã suất chiếu từ dòng được chọn
                    string maSuatChieu = dgvSuatChieuPhim.SelectedRows[0].Cells["MaSuatChieu"].Value.ToString();
                    suatChieu.Delete(maSuatChieu);
                    ClearInputFields();
                    LoadDataGridView();
                    MessageBox.Show("Xóa suất chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một suất chiếu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa suất chiếu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearInputFields()
        {
            txtMaSuatChieu.Clear();
            cboPhim.SelectedIndex = -1;
            cboPhongChieu.SelectedIndex = -1;
            dateTimePicker_NgayChieu.Value = DateTime.Now;
            txtBatDau.Clear();
            txtKetThuc.Clear();
            txtGiaVe.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadDataGridView();
            MessageBox.Show("Làm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvSuatChieuPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSuatChieuPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSuatChieuPhim.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvSuatChieuPhim.Rows[e.RowIndex];
                txtMaSuatChieu.Text = selectedRow.Cells["MaSuatChieu"].Value.ToString();
                cboPhim.SelectedValue = selectedRow.Cells["MaPhim"].Value;
                cboPhongChieu.SelectedValue = selectedRow.Cells["MaPhongChieu"].Value;
                dateTimePicker_NgayChieu.Value = Convert.ToDateTime(selectedRow.Cells["NgayChieu"].Value);
                txtBatDau.Text = selectedRow.Cells["GioBatDau"].Value.ToString();
                txtKetThuc.Text = selectedRow.Cells["GioKetThuc"].Value.ToString();
                txtGiaVe.Text = selectedRow.Cells["GiaVe"].Value.ToString();
            }

        }
    }
}
