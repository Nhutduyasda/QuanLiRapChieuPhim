namespace GUI
{
    partial class frmTaoSuatChieu
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
            dgvSuatChieuPhim = new DataGridView();
            txtMaSuatChieu = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            btnXoa = new Button();
            txtGiaVe = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker_NgayChieu = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            cboPhim = new ComboBox();
            cboPhongChieu = new ComboBox();
            txtBatDau = new TextBox();
            txtKetThuc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSuatChieuPhim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(594, 62);
            label1.TabIndex = 0;
            label1.Text = "Cinema - Suất Chiếu Phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 1;
            label2.Text = "Phim đang chiếu";
            // 
            // dgvSuatChieuPhim
            // 
            dgvSuatChieuPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuatChieuPhim.Location = new Point(12, 124);
            dgvSuatChieuPhim.Name = "dgvSuatChieuPhim";
            dgvSuatChieuPhim.RowHeadersWidth = 51;
            dgvSuatChieuPhim.Size = new Size(1141, 263);
            dgvSuatChieuPhim.TabIndex = 2;
            dgvSuatChieuPhim.CellClick += dgvSuatChieuPhim_CellClick;
            dgvSuatChieuPhim.CellContentClick += dgvSuatChieuPhim_CellContentClick;
            // 
            // txtMaSuatChieu
            // 
            txtMaSuatChieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaSuatChieu.Location = new Point(159, 418);
            txtMaSuatChieu.Name = "txtMaSuatChieu";
            txtMaSuatChieu.ReadOnly = true;
            txtMaSuatChieu.Size = new Size(198, 34);
            txtMaSuatChieu.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(402, 427);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 6;
            label4.Text = "Tên phim:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(398, 502);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 8;
            label5.Text = "Bắt Đầu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(756, 498);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 14;
            label8.Text = "Kết Thúc:";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.Location = new Point(657, 652);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 38);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtGiaVe.Location = new Point(527, 557);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(198, 34);
            txtGiaVe.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(402, 563);
            label9.Name = "label9";
            label9.Size = new Size(77, 28);
            label9.TabIndex = 24;
            label9.Text = "Giá Vé:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label10.Location = new Point(756, 422);
            label10.Name = "label10";
            label10.Size = new Size(175, 28);
            label10.TabIndex = 22;
            label10.Text = "Tên Phòng Chiếu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(30, 498);
            label6.Name = "label6";
            label6.Size = new Size(126, 28);
            label6.TabIndex = 28;
            label6.Text = "Ngày Chiếu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(30, 418);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 27;
            label7.Text = "Mã SC:";
            // 
            // dateTimePicker_NgayChieu
            // 
            dateTimePicker_NgayChieu.Location = new Point(159, 503);
            dateTimePicker_NgayChieu.Name = "dateTimePicker_NgayChieu";
            dateTimePicker_NgayChieu.Size = new Size(198, 27);
            dateTimePicker_NgayChieu.TabIndex = 31;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThem.Location = new Point(120, 652);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 38);
            btnThem.TabIndex = 32;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.Location = new Point(393, 652);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(153, 38);
            btnSua.TabIndex = 33;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button1_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLamMoi.Location = new Point(918, 652);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(153, 38);
            btnLamMoi.TabIndex = 34;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(527, 427);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(198, 28);
            cboPhim.TabIndex = 35;
            // 
            // cboPhongChieu
            // 
            cboPhongChieu.FormattingEnabled = true;
            cboPhongChieu.Location = new Point(937, 422);
            cboPhongChieu.Name = "cboPhongChieu";
            cboPhongChieu.Size = new Size(198, 28);
            cboPhongChieu.TabIndex = 36;
            // 
            // txtBatDau
            // 
            txtBatDau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBatDau.Location = new Point(527, 498);
            txtBatDau.Name = "txtBatDau";
            txtBatDau.Size = new Size(198, 34);
            txtBatDau.TabIndex = 37;
            // 
            // txtKetThuc
            // 
            txtKetThuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtKetThuc.Location = new Point(937, 492);
            txtKetThuc.Name = "txtKetThuc";
            txtKetThuc.Size = new Size(198, 34);
            txtKetThuc.TabIndex = 38;
            // 
            // frmTaoSuatChieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 716);
            Controls.Add(txtKetThuc);
            Controls.Add(txtBatDau);
            Controls.Add(cboPhongChieu);
            Controls.Add(cboPhim);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dateTimePicker_NgayChieu);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtGiaVe);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnXoa);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMaSuatChieu);
            Controls.Add(dgvSuatChieuPhim);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTaoSuatChieu";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)dgvSuatChieuPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvSuatChieuPhim;
        private TextBox txtMaSuatChieu;
        private TextBox txtTenSuatChieu;
        private Label label4;
        private Label label5;
        private TextBox txtDoTuoi;
        private Label label8;
        private Button btnXoa;
        private TextBox txtGiaVe;
        private Label label9;
        private Label label10;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker_NgayChieu;
        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private ComboBox cboPhim;
        private ComboBox cboPhongChieu;
        private TextBox txtBatDau;
        private TextBox txtKetThuc;
    }
}