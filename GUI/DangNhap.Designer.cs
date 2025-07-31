namespace GUI
{
    partial class frmDangNhap
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
            panel1 = new Panel();
            btnThoat = new Button();
            label3 = new Label();
            label2 = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            chkHienThi = new CheckBox();
            btnDangNhap = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(chkHienThi);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(63, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 470);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SeaGreen;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(326, 366);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(127, 42);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(71, 239);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 16;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(71, 172);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 15;
            label2.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(204, 168);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(249, 27);
            txtTaiKhoan.TabIndex = 14;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(204, 235);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(249, 27);
            txtMatKhau.TabIndex = 13;
            // 
            // chkHienThi
            // 
            chkHienThi.AutoSize = true;
            chkHienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkHienThi.Location = new Point(367, 296);
            chkHienThi.Name = "chkHienThi";
            chkHienThi.Size = new Size(86, 24);
            chkHienThi.TabIndex = 12;
            chkHienThi.Text = "Hiển thị";
            chkHienThi.UseVisualStyleBackColor = true;
            chkHienThi.CheckedChanged += chkHienThi_CheckedChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SeaGreen;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(71, 366);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(127, 42);
            btnDangNhap.TabIndex = 11;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(204, 63);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 10;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(651, 550);
            Controls.Add(panel1);
            Name = "frmDangNhap";
            Text = "DangNhap";
            FormClosing += frmDangNhap_FormClosing_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThoat;
        private Label label3;
        private Label label2;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private CheckBox chkHienThi;
        private Button btnDangNhap;
        private Label label1;
    }
}