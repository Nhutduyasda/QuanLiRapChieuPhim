namespace GUI
{
    partial class ThemPhim
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnThemPhim = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThemAnh = new Button();
            txtTenPhim = new TextBox();
            txtMaPhim = new TextBox();
            txtTheLoai = new TextBox();
            txtThoiLuong = new TextBox();
            dgvDanhSachPhim = new DataGridView();
            pictureBox_anhPhim = new PictureBox();
            cbo_TinhTrang = new ComboBox();
            cboDoTuoi = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_anhPhim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(203, 38);
            label1.TabIndex = 0;
            label1.Text = "Phim đã thêm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(70, 438);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(70, 491);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 2;
            label3.Text = "Tên phim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(70, 545);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 3;
            label4.Text = "Thể loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(526, 491);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 4;
            label5.Text = "Thời lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(522, 438);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 5;
            label6.Text = "Tình trạng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(522, 545);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 7;
            label8.Text = "Độ Tuổi";
            // 
            // btnThemPhim
            // 
            btnThemPhim.BackColor = Color.FromArgb(0, 192, 0);
            btnThemPhim.ForeColor = SystemColors.ButtonHighlight;
            btnThemPhim.Location = new Point(198, 622);
            btnThemPhim.Name = "btnThemPhim";
            btnThemPhim.Size = new Size(131, 44);
            btnThemPhim.TabIndex = 8;
            btnThemPhim.Text = "Thêm";
            btnThemPhim.UseVisualStyleBackColor = false;
            btnThemPhim.Click += btnThemPhim_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(0, 192, 0);
            btnLamMoi.ForeColor = SystemColors.ButtonHighlight;
            btnLamMoi.Location = new Point(694, 622);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(133, 44);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 192, 0);
            btnXoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoa.Location = new Point(535, 622);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 44);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(0, 192, 0);
            btnCapNhat.ForeColor = SystemColors.ButtonHighlight;
            btnCapNhat.Location = new Point(372, 622);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(133, 44);
            btnCapNhat.TabIndex = 11;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThemAnh
            // 
            btnThemAnh.BackColor = Color.FromArgb(0, 192, 0);
            btnThemAnh.ForeColor = SystemColors.ButtonHighlight;
            btnThemAnh.Location = new Point(981, 646);
            btnThemAnh.Name = "btnThemAnh";
            btnThemAnh.Size = new Size(121, 44);
            btnThemAnh.TabIndex = 12;
            btnThemAnh.Text = "Thêm Ảnh";
            btnThemAnh.UseVisualStyleBackColor = false;
            btnThemAnh.Click += btnThemAnh_Click;
            // 
            // txtTenPhim
            // 
            txtTenPhim.Font = new Font("Segoe UI", 10.2F);
            txtTenPhim.Location = new Point(193, 484);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(264, 30);
            txtTenPhim.TabIndex = 13;
            // 
            // txtMaPhim
            // 
            txtMaPhim.Font = new Font("Segoe UI", 10.2F);
            txtMaPhim.Location = new Point(194, 431);
            txtMaPhim.Name = "txtMaPhim";
            txtMaPhim.ReadOnly = true;
            txtMaPhim.Size = new Size(264, 30);
            txtMaPhim.TabIndex = 14;
            // 
            // txtTheLoai
            // 
            txtTheLoai.Font = new Font("Segoe UI", 10.2F);
            txtTheLoai.Location = new Point(193, 538);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(264, 30);
            txtTheLoai.TabIndex = 15;
            // 
            // txtThoiLuong
            // 
            txtThoiLuong.Font = new Font("Segoe UI", 10.2F);
            txtThoiLuong.Location = new Point(650, 484);
            txtThoiLuong.Name = "txtThoiLuong";
            txtThoiLuong.Size = new Size(263, 30);
            txtThoiLuong.TabIndex = 16;
            // 
            // dgvDanhSachPhim
            // 
            dgvDanhSachPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhim.Location = new Point(32, 66);
            dgvDanhSachPhim.Name = "dgvDanhSachPhim";
            dgvDanhSachPhim.RowHeadersWidth = 51;
            dgvDanhSachPhim.Size = new Size(1121, 340);
            dgvDanhSachPhim.TabIndex = 20;
            dgvDanhSachPhim.CellClick += dgvDanhSachPhim_CellClick;
            // 
            // pictureBox_anhPhim
            // 
            pictureBox_anhPhim.Location = new Point(964, 438);
            pictureBox_anhPhim.Name = "pictureBox_anhPhim";
            pictureBox_anhPhim.Size = new Size(169, 177);
            pictureBox_anhPhim.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_anhPhim.TabIndex = 21;
            pictureBox_anhPhim.TabStop = false;
            // 
            // cbo_TinhTrang
            // 
            cbo_TinhTrang.FormattingEnabled = true;
            cbo_TinhTrang.Location = new Point(650, 433);
            cbo_TinhTrang.Name = "cbo_TinhTrang";
            cbo_TinhTrang.Size = new Size(264, 28);
            cbo_TinhTrang.TabIndex = 22;
            // 
            // cboDoTuoi
            // 
            cboDoTuoi.FormattingEnabled = true;
            cboDoTuoi.Location = new Point(650, 545);
            cboDoTuoi.Name = "cboDoTuoi";
            cboDoTuoi.Size = new Size(264, 28);
            cboDoTuoi.TabIndex = 23;
            // 
            // ThemPhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 716);
            Controls.Add(cboDoTuoi);
            Controls.Add(cbo_TinhTrang);
            Controls.Add(pictureBox_anhPhim);
            Controls.Add(dgvDanhSachPhim);
            Controls.Add(txtThoiLuong);
            Controls.Add(txtTheLoai);
            Controls.Add(txtMaPhim);
            Controls.Add(txtTenPhim);
            Controls.Add(btnThemAnh);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThemPhim);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemPhim";
            Text = "ThemPhim";
            Load += ThemPhim_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_anhPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button btnThemPhim;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThemAnh;
        private TextBox txtTenPhim;
        private TextBox txtMaPhim;
        private TextBox txtTheLoai;
        private TextBox txtThoiLuong;
        private DataGridView dgvDanhSachPhim;
        private PictureBox pictureBox_anhPhim;
        private ComboBox cbo_TinhTrang;
        private ComboBox cboDoTuoi;
    }
}