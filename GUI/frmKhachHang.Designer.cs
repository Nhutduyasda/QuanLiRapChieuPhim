namespace GUI
{
    partial class frmKhachHang
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
            txtEmail = new TextBox();
            label7 = new Label();
            txtMaKhachHang = new TextBox();
            label6 = new Label();
            dgvDanhSachKH = new DataGridView();
            label5 = new Label();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            btnLamMoi = new Button();
            lblEmail = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKH).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(45, 432);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(44, 306);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 35;
            label7.Text = "Số điện thoại";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(45, 136);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.ReadOnly = true;
            txtMaKhachHang.Size = new Size(241, 27);
            txtMaKhachHang.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(44, 110);
            label6.Name = "label6";
            label6.Size = new Size(136, 23);
            label6.TabIndex = 32;
            label6.Text = "Mã Khách Hàng";
            // 
            // dgvDanhSachKH
            // 
            dgvDanhSachKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachKH.Location = new Point(357, 83);
            dgvDanhSachKH.Name = "dgvDanhSachKH";
            dgvDanhSachKH.RowHeadersWidth = 51;
            dgvDanhSachKH.Size = new Size(763, 565);
            dgvDanhSachKH.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(357, 47);
            label5.Name = "label5";
            label5.Size = new Size(232, 28);
            label5.TabIndex = 30;
            label5.Text = "Danh Sách Khách Hàng";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(45, 332);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.ReadOnly = true;
            txtSoDienThoai.Size = new Size(241, 27);
            txtSoDienThoai.TabIndex = 29;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(45, 220);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(241, 27);
            txtHoTen.TabIndex = 28;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(0, 192, 0);
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(71, 567);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(169, 37);
            btnLamMoi.TabIndex = 25;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(45, 406);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(45, 194);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 21;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 20;
            label1.Text = "Thông Tin Khách Hàng";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 716);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtMaKhachHang);
            Controls.Add(label6);
            Controls.Add(dgvDanhSachKH);
            Controls.Add(label5);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtHoTen);
            Controls.Add(btnLamMoi);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtMaKhachHang;
        private Label label6;
        private DataGridView dgvDanhSachKH;
        private Label label5;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private Button btnLamMoi;
        private Label lblEmail;
        private Label label2;
        private Label label1;
    }
}