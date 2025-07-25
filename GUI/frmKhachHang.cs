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

namespace GUI
{
    public partial class frmKhachHang: Form
    {
        private KhachHangDAL khachHangDAL;
        public frmKhachHang()
        {
            InitializeComponent();
            khachHangDAL = new KhachHangDAL();
        }
        public void SetUpDataGirdView()
        {
            dgvDanhSachKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachKH.AutoGenerateColumns = true;
            dgvDanhSachKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadDSKhachHang()
        {
            khachHangDAL = new KhachHangDAL();
            List<KhachHang> list = khachHangDAL.selectAll();
            dgvDanhSachKH.DataSource = null;
            dgvDanhSachKH.DataSource = list;
            if (list.Count > 0 && list != null)
            {
                dgvDanhSachKH.DataSource = list;
                dgvDanhSachKH.Columns["MatKhau"].Visible = false;
            }
        }

    }
}
