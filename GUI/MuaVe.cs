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

namespace GUI
{
    public partial class MuaVe : Form
    {
        private SuatChieuDAL suatChieu;
        public string SelectedMaSuat { get; private set; }
        public string SelectedTenPhim { get; private set; }
        public MuaVe()
        {
            InitializeComponent();
            suatChieu = new SuatChieuDAL();
            SetUpDataGirdView();
            //LoadDataGridView();
            SetUpColors();

        }
        private void SetUpColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#ace3de");
            this.dgvSuatChieuPhim.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvSuatChieuPhim.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dgvSuatChieuPhim.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            this.dgvSuatChieuPhim.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnChonPhim.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnChonPhim.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            this.btnHuy.BackColor = ColorTranslator.FromHtml("#FF7043");
            this.btnHuy.ForeColor = ColorTranslator.FromHtml("#FFFFFF");


        }
        private void SetUpDataGirdView()
        {
            dgvSuatChieuPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuatChieuPhim.AutoGenerateColumns = true;
            dgvSuatChieuPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SuatChieuDAL dal = new SuatChieuDAL();
            var danhSach = dal.SelectViewPhimSuatChieu();
            var list = dal.SelectViewThayDoiTrangThaiPhim();
           
            foreach (var suat in list)
            {
                DateTime ngayChieu;
                TimeSpan thoiGianKetThuc;

                if (DateTime.TryParse(suat.NgayChieu, out ngayChieu) && TimeSpan.TryParse(suat.ThoiGianKetThuc, out thoiGianKetThuc))
                {
                    DateTime gioKetThuc = ngayChieu.Date + thoiGianKetThuc;
                    if (DateTime.Now > gioKetThuc && suat.TinhTrang != "Ngừng chiếu")
                    {
                        suat.TinhTrang = "Ngừng chiếu";
                        dal.UpdateTinhTrang(suat.MaSuatChieu, "Ngừng chiếu");
                    }
                }
            }

            //Lọc ra những phim không bị "ngưng chiếu"
            var danhSachKhongNgungChieu = danhSach.Where(s => s.TinhTrang != "Ngừng chiếu").ToList();
            dgvSuatChieuPhim.DataSource = danhSachKhongNgungChieu;



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

        private void dgvSuatChieuPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChonPhim_Click(object sender, EventArgs e)
        {
            if (dgvSuatChieuPhim.CurrentRow != null)
            {
                string maSuat = dgvSuatChieuPhim.CurrentRow.Cells["MaSuatChieu"].Value.ToString();
                string tenPhim = dgvSuatChieuPhim.CurrentRow.Cells["TenPhim"].Value.ToString();

                // Lấy form Main (cha chứa panel)
                Main mainForm = (Main)(this.MdiParent ?? this.TopLevelControl);

                // Ẩn form Main
                mainForm.Hide();

                // Mở form DatVe
                FrmDatVe frm = new FrmDatVe(maSuat, tenPhim);

                frm.StartPosition = FormStartPosition.CenterScreen;

                // Khi FrmDatVe đóng thì hiện lại form Main và load lại MuaVe
                frm.FormClosed += (s, args) =>
                {
                    mainForm.Show();

                    // Gọi hàm load lại MuaVe nếu cần (tùy bạn)
                    // ((Main)mainForm).LoadMuaVe(); 
                };

                frm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!", "Thông báo");
            }
        }
    }
}
