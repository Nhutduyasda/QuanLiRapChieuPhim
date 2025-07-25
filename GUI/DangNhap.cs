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
    public partial class frmDangNhap : Form
    {
        NhanVienDAL nvDAL = new NhanVienDAL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string MaNhanVien = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            NhanVienDTO nhanVien = nvDAL.selectById(MaNhanVien);
            if (nhanVien == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!");

            }
            else if (!nhanVien.MatKhau.Equals(password))
            {
                MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuthUtil.user = nhanVien;
                this.Dispose();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienThi.Checked ? '\0' : '*';
        }

    }
}
