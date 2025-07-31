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
            SetUpColors();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.panel1.BackColor = ColorTranslator.FromHtml("#e8ebeb");
            this.btnDangNhap.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnDangNhap.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnThoat.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThoat.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.chkHienThi.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTaiKhoan.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtTaiKhoan.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtMatKhau.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtMatKhau.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            this.txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new Font("Arial", 12);
            this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
            this.label2.ForeColor = ColorTranslator.FromHtml("#000000");
            this.chkHienThi.Font = new Font("Arial", 10);

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNhanVien = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            NhanVienDTO nhanVien = nvDAL.selectById(maNhanVien);

            if (nhanVien == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nhanVien.MatKhauHash != matKhau)
            {
                MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuthUtil.user = nhanVien;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkHienThi_CheckedChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienThi.Checked ? '\0' : '*';
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.DialogResult != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.DialogResult != DialogResult.OK)
            {
                e.Cancel = true;
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
            txtMatKhau.PasswordChar = chkHienThi.Checked ? '\0' : '●';
        }
    }
}
