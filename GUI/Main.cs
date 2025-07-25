using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SetUpComponent();

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
            ShowFormInPanel(new frmDangNhap());
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
            ShowFormInPanel(new frmKhachHang());
        }
    }
}
