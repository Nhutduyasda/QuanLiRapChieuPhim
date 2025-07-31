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
        public string MaKhachHang;
        public string HoTen;
        public string SoDienThoai;
        public string Email;

        public ThongTinKhachHang()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            khachHangDAL = new KhachHangDAL();
            SetUpColors();
        }


        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {

        }
        private void SetUpColors()
        {
            BackColor = ColorTranslator.FromHtml("#ace3de");
            this.btnLuu.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnLuu.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            this.txtHoTen.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtHoTen.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtSoDienThoai.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtSoDienThoai.ForeColor = ColorTranslator.FromHtml("#000000");
            this.txtEmail.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.txtEmail.ForeColor = ColorTranslator.FromHtml("#000000");
            this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
            this.label2.ForeColor = ColorTranslator.FromHtml("#000000");
            this.label3.ForeColor = ColorTranslator.FromHtml("#000000");
            this.label4.ForeColor = ColorTranslator.FromHtml("#000000");


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //// Kiểm tra số điện thoại
            //if (!Valication.IsValidPhoneNumber(txtSoDienThoai.Text))
            //{
            //    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Kiểm tra email
            //if (!Valication.IsValidGmail(txtEmail.Text))
            //{
            //    MessageBox.Show("Email phải là Gmail hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
            //    KhachHang khachHang = new KhachHang
            //    {
            //        MaKhachHang = khachHangDAL.generateAutoMaKhachHang("KHACH_HANG", "MaKhachHang", "KH") ,
            //        TenKhachHang = txtHoTen.Text,
            //        Email = txtEmail.Text,
            //        SoDienThoai = txtSoDienThoai.Text

            //    };
            //    khachHangDAL.Insert(khachHang);
            //    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

                this.MaKhachHang = khachHang.MaKhachHang;
                this.HoTen = khachHang.TenKhachHang;
                this.SoDienThoai = khachHang.SoDienThoai;
                this.Email = khachHang.Email;
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

