namespace GUI
{
    partial class MuaVe
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
            dgvSuatChieuPhim = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            btnChonPhim = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuatChieuPhim).BeginInit();
            SuspendLayout();
            // 
            // dgvSuatChieuPhim
            // 
            dgvSuatChieuPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuatChieuPhim.Location = new Point(12, 124);
            dgvSuatChieuPhim.Name = "dgvSuatChieuPhim";
            dgvSuatChieuPhim.RowHeadersWidth = 51;
            dgvSuatChieuPhim.Size = new Size(1141, 330);
            dgvSuatChieuPhim.TabIndex = 5;
            dgvSuatChieuPhim.CellContentClick += dgvSuatChieuPhim_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 4;
            label2.Text = "Phim đang chiếu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(594, 62);
            label1.TabIndex = 3;
            label1.Text = "Cinema - Suất Chiếu Phim";
            // 
            // btnChonPhim
            // 
            btnChonPhim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnChonPhim.Location = new Point(282, 531);
            btnChonPhim.Name = "btnChonPhim";
            btnChonPhim.Size = new Size(152, 50);
            btnChonPhim.TabIndex = 6;
            btnChonPhim.Text = "Chọn Phim";
            btnChonPhim.UseVisualStyleBackColor = true;
            btnChonPhim.Click += btnChonPhim_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.Location = new Point(627, 531);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(152, 50);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // MuaVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 716);
            Controls.Add(btnHuy);
            Controls.Add(btnChonPhim);
            Controls.Add(dgvSuatChieuPhim);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MuaVe";
            Text = "MuaVe";
            ((System.ComponentModel.ISupportInitialize)dgvSuatChieuPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSuatChieuPhim;
        private Label label2;
        private Label label1;
        private Button btnChonPhim;
        private Button btnHuy;
    }
}