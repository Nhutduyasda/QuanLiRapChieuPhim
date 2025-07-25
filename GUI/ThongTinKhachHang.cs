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
    public partial class ThongTinKhachHang : Form
    {
        private KhachHangDAL khachHangDAL;
        public ThongTinKhachHang()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            khachHangDAL = new KhachHangDAL();
        }
        public string MaKhachHang => txtMaKhachHang.Text;
        public string HoTen => txtHoTen.Text;
        public string SoDienThoai => txtSoDienThoai.Text;
        public string Email => txtEmail.Text;
        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra số điện thoại
            if (!Valication.IsValidPhoneNumber(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email
            if (!Valication.IsValidGmail(txtEmail.Text))
            {
                MessageBox.Show("Email phải là Gmail hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KhachHang khachHang = new KhachHang
                {
                    MaKhachHang = txtMaKhachHang.Text,
                    TenKhachHang = txtHoTen.Text,
                    Email = txtEmail.Text,
                    SoDienThoai = txtSoDienThoai.Text

                };
                khachHangDAL.Insert(khachHang);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra số điện thoại
            if (!Valication.IsValidPhoneNumber(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email
            if (!Valication.IsValidGmail(txtEmail.Text))
            {
                MessageBox.Show("Email phải là Gmail hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KhachHang khachHang = new KhachHang
                {
                    MaKhachHang = khachHangDAL.generateAutoMaKhachHang("KHACH_HANG", "MaKhachHang", "KH"),
                    TenKhachHang = txtHoTen.Text,
                    Email = txtEmail.Text,
                    SoDienThoai = txtSoDienThoai.Text

                };
                khachHangDAL.Insert(khachHang);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

