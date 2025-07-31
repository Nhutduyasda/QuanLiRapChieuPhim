using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_Valication;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Init();
            CheckRole();
            SetUpComponent();
            SetUpColors();
        }
        private void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.button6.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.button7.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnBangDieuKhien.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnBaoCaoDoanhThu.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnMuaVe.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThemNhanVien.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnThemSanPham.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.button6.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.button7.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnBangDieuKhien.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnBaoCaoDoanhThu.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnMuaVe.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnThemNhanVien.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnThemSanPham.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void CheckRole()
        {
            if (!AuthUtil.IsLogin())
            {
                MessageBox.Show("Bạn chưa đăng nhập!");
                return;
            }

            // Các nút chung vẫn hiện
            btnMuaVe.Visible = true;
            btnBangDieuKhien.Visible = true;
            button6.Visible = true;

            if (AuthUtil.IsManager())
            {
                // Quản lý được quyền nhìn thấy và thao tác
                btnThemNhanVien.Visible = true;
                btnThemSanPham.Visible = true;
                btnBaoCaoDoanhThu.Visible = true;

                btnThemNhanVien.Enabled = true;
                btnThemSanPham.Enabled = true;
                btnBaoCaoDoanhThu.Enabled = true;
            }
            else
            {
                // Nhân viên không được nhìn thấy các chức năng quản lý
                btnThemNhanVien.Visible = false;
                btnThemSanPham.Visible = false;
                btnBaoCaoDoanhThu.Visible = false;
            }
        }
        private void Init()
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            var result = frmDangNhap.ShowDialog();

            if (result != DialogResult.OK || !AuthUtil.IsLogin())
            {
                MessageBox.Show("Bạn phải đăng nhập để sử dụng ứng dụng.");
                Application.Exit();
            }
            CheckRole();

        }

        private void SetUpComponent()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ShowFormInPanel(Form form)
        {
            pnl_Main.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(form);
            form.Show();

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ThongTinNhanVien());

        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ThemPhim());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form Main hiện tại

            frmDangNhap frmDangNhap = new frmDangNhap();
            var result = frmDangNhap.ShowDialog();

            if (result == DialogResult.OK && AuthUtil.IsLogin())
            {
                // Đăng nhập lại thành công → hiện lại Main
                this.Show();
                CheckRole(); // Cập nhật quyền theo tài khoản mới
            }
            else
            {
                // Đăng nhập thất bại hoặc bị đóng → thoát chương trình
                Application.Exit();
            }
        }

        private void btnBangDieuKhien_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PhimDaThem());
        }

        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new MuaVe());
        }

        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmTaoSuatChieu());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmLSGD());
        }
    }
}
