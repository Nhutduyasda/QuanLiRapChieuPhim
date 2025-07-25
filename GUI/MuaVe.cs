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
        public MuaVe()
        {
            InitializeComponent();
            suatChieu = new SuatChieuDAL();
            SetUpDataGirdView();
            //LoadDataGridView();
        }
        public void SetUpDataGirdView()
        {
            dgvSuatChieuPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuatChieuPhim.AutoGenerateColumns = true;
            dgvSuatChieuPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SuatChieuDAL dal = new SuatChieuDAL();
            var danhSach = dal.SelectViewPhimSuatChieu();
            dgvSuatChieuPhim.DataSource = danhSach;
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

                FrmDatVe formDatVe = new FrmDatVe(maSuat, tenPhim);
                this.Hide();
                formDatVe.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!", "Thông báo");
            }
        }
    }
}
