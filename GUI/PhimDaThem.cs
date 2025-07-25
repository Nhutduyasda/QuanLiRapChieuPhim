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

namespace GUI
{
    public partial class PhimDaThem : Form
    {

        public PhimDaThem()
        {
            InitializeComponent();
            SetUpComponent();

        }
        private void SetUpComponent()
        {
            StartPosition = FormStartPosition.CenterScreen;
            dgvDSPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhim.AutoGenerateColumns = true;
            dgvDSPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void PhimDaThem_Load(object sender, EventArgs e)
        {
            LoadDSPhim();
        }
        public void LoadDSPhim()
        {
            PhimDAL phimDAL = new PhimDAL();
            List<DTO_Model.PhimDTO> list = phimDAL.selectAll();
            dgvDSPhim.DataSource = null;
            dgvDSPhim.DataSource = list;
            if (list.Count > 0 && list != null)
            {
                dgvDSPhim.DataSource = list;
                dgvDSPhim.Columns["HinhAnh"].Visible = false; // Ẩn cột Hình Ảnh
            }
        }

        private void PhimDaThem_Load_1(object sender, EventArgs e)
        {
            LoadDSPhim();
        }
    }
}
