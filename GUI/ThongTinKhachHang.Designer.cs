namespace GUI
{
    partial class ThongTinKhachHang
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
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtHoTen = new TextBox();
            txtSoDienThoai = new TextBox();
            btnLuu = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(label1);
            groupBox1.Cursor = Cursors.Cross;
            groupBox1.Location = new Point(55, 30);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(459, 352);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(164, 228);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(42, 231);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(42, 167);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 8;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(42, 107);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 7;
            label2.Text = "Tên khách hàng";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(164, 104);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(218, 23);
            txtHoTen.TabIndex = 5;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(164, 165);
            txtSoDienThoai.Margin = new Padding(3, 2, 3, 2);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(218, 23);
            txtSoDienThoai.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SeaGreen;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(201, 280);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(111, 32);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(84, 26);
            label1.Name = "label1";
            label1.Size = new Size(290, 30);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // ThongTinKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(570, 412);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongTinKhachHang";
            Text = "ThongTinKhachHang";
            Load += ThongTinKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtHoTen;
        private TextBox txtSoDienThoai;
        private Button btnLuu;
        private Label label1;
        private TextBox txtEmail;
        private Label label4;
    }
}