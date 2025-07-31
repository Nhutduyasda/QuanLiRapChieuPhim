namespace GUI
{
    partial class frmLSGD
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
            txtTongTien = new TextBox();
            label7 = new Label();
            txtMaGD = new TextBox();
            label6 = new Label();
            dgvLichSuGiaoDich = new DataGridView();
            label5 = new Label();
            txtTenNhanVien = new TextBox();
            txtKhachHang = new TextBox();
            btnLamMoi = new Button();
            lblEmail = new Label();
            label2 = new Label();
            label1 = new Label();
            txtThoiGianDatVe = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGiaoDich).BeginInit();
            SuspendLayout();
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(44, 406);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(241, 27);
            txtTongTien.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(44, 287);
            label7.Name = "label7";
            label7.Size = new Size(124, 23);
            label7.TabIndex = 35;
            label7.Text = "Tên Nhân Viên";
            // 
            // txtMaGD
            // 
            txtMaGD.Location = new Point(45, 123);
            txtMaGD.Name = "txtMaGD";
            txtMaGD.ReadOnly = true;
            txtMaGD.Size = new Size(241, 27);
            txtMaGD.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(44, 97);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 32;
            label6.Text = "Mã Giao Dịch";
            // 
            // dgvLichSuGiaoDich
            // 
            dgvLichSuGiaoDich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSuGiaoDich.Location = new Point(357, 83);
            dgvLichSuGiaoDich.Name = "dgvLichSuGiaoDich";
            dgvLichSuGiaoDich.RowHeadersWidth = 51;
            dgvLichSuGiaoDich.Size = new Size(763, 565);
            dgvLichSuGiaoDich.TabIndex = 31;
            dgvLichSuGiaoDich.CellClick += dgvLichSuGiaoDich_CellClick;
            dgvLichSuGiaoDich.CellContentClick += dgvDanhSachKH_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(357, 47);
            label5.Name = "label5";
            label5.Size = new Size(178, 28);
            label5.TabIndex = 30;
            label5.Text = "Lịch Sử Giao Dịch";
            label5.Click += label5_Click;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(45, 313);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new Size(241, 27);
            txtTenNhanVien.TabIndex = 29;
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(45, 217);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.ReadOnly = true;
            txtKhachHang.Size = new Size(241, 27);
            txtKhachHang.TabIndex = 28;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(0, 192, 0);
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(70, 583);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(172, 44);
            btnLamMoi.TabIndex = 25;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(44, 380);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(90, 23);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Tổng TIền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(45, 191);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 21;
            label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(45, 26);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 20;
            label1.Text = "Thông Tin ";
            // 
            // txtThoiGianDatVe
            // 
            txtThoiGianDatVe.Location = new Point(45, 506);
            txtThoiGianDatVe.Name = "txtThoiGianDatVe";
            txtThoiGianDatVe.ReadOnly = true;
            txtThoiGianDatVe.Size = new Size(241, 27);
            txtThoiGianDatVe.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(45, 480);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 37;
            label3.Text = "Thời Gian Đặt Vé";
            // 
            // frmLSGD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 716);
            Controls.Add(txtThoiGianDatVe);
            Controls.Add(label3);
            Controls.Add(txtTongTien);
            Controls.Add(label7);
            Controls.Add(txtMaGD);
            Controls.Add(label6);
            Controls.Add(dgvLichSuGiaoDich);
            Controls.Add(label5);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtKhachHang);
            Controls.Add(btnLamMoi);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLSGD";
            Text = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGiaoDich).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTongTien;
        private Label label7;
        private TextBox txtMaGD;
        private Label label6;
        private DataGridView dgvLichSuGiaoDich;
        private Label label5;
        private TextBox txtTenNhanVien;
        private TextBox txtKhachHang;
        private Button btnLamMoi;
        private Label lblEmail;
        private Label label2;
        private Label label1;
        private TextBox txtThoiGianDatVe;
        private Label label3;
    }
}