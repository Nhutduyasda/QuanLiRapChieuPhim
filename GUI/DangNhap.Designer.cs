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
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            label3 = new Label();
            label2 = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            chkHienThi = new CheckBox();
            btnDangNhap = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(chkHienThi);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(label1);
            groupBox1.Cursor = Cursors.Cross;
            groupBox1.Location = new Point(63, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 470);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SeaGreen;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(303, 326);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(127, 42);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(48, 199);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(48, 132);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 7;
            label2.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(181, 128);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(249, 27);
            txtTaiKhoan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(181, 195);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(249, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // chkHienThi
            // 
            chkHienThi.AutoSize = true;
            chkHienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkHienThi.Location = new Point(344, 256);
            chkHienThi.Name = "chkHienThi";
            chkHienThi.Size = new Size(86, 24);
            chkHienThi.TabIndex = 3;
            chkHienThi.Text = "Hiển thị";
            chkHienThi.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SeaGreen;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(48, 326);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(127, 42);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(181, 23);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(651, 550);
            Controls.Add(groupBox1);
            Name = "frmDangNhap";
            Text = "DangNhap";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private CheckBox chkHienThi;
        private Button btnDangNhap;
        private Label label1;
        private Button btnThoat;
    }
}