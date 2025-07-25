namespace GUI
{
    partial class ThongTinNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblEmail = new Label();
            label4 = new Label();
            btnThem = new Button();
            btnLamMoi = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            txtHoTen = new TextBox();
            txtSoDienThoai = new TextBox();
            label5 = new Label();
            dgvDanhSachNV = new DataGridView();
            label6 = new Label();
            txtMaNhanVien = new TextBox();
            cboChucVu = new ComboBox();
            label7 = new Label();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 72);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin các nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(41, 200);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(41, 419);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(42, 498);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 3;
            label4.Text = "Chức vụ";
            label4.Click += label4_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 192, 0);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(41, 578);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 37);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(0, 192, 0);
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(216, 657);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 37);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(0, 192, 0);
            btnCapNhat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(41, 657);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(106, 37);
            btnCapNhat.TabIndex = 6;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 192, 0);
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(216, 578);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 37);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(41, 226);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(241, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(42, 298);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(241, 27);
            txtSoDienThoai.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(354, 72);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 11;
            label5.Text = "Tất cả nhân viên";
            // 
            // dgvDanhSachNV
            // 
            dgvDanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNV.Location = new Point(354, 108);
            dgvDanhSachNV.Name = "dgvDanhSachNV";
            dgvDanhSachNV.RowHeadersWidth = 51;
            dgvDanhSachNV.Size = new Size(763, 565);
            dgvDanhSachNV.TabIndex = 12;
            dgvDanhSachNV.CellClick += dgvDanhSachNV_CellClick;
            dgvDanhSachNV.CellContentClick += dgvDanhSachNV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(41, 126);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 13;
            label6.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(42, 152);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(241, 27);
            txtMaNhanVien.TabIndex = 14;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(41, 524);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(241, 28);
            cboChucVu.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(41, 272);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 16;
            label7.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 445);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(42, 373);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(241, 27);
            txtMatKhau.TabIndex = 19;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblMatKhau.Location = new Point(42, 347);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 18;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // ThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 716);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(cboChucVu);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label6);
            Controls.Add(dgvDanhSachNV);
            Controls.Add(label5);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtHoTen);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(label4);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThongTinNhanVien";
            Text = "NhanVien";
            Load += ThongTinNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblEmail;
        private Label label4;
        private Button btnThem;
        private Button btnLamMoi;
        private Button btnCapNhat;
        private Button btnXoa;
        private TextBox txtHoTen;
        private TextBox txtSoDienThoai;
        private Label label5;
        private DataGridView dgvDanhSachNV;
        private Label label6;
        private TextBox txtMaNhanVien;
        private ComboBox cboChucVu;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
    }
}