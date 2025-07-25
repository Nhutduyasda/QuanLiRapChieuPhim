namespace GUI
{
    partial class FrmDatVe
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
            lblTieuDe = new Label();
            label11 = new Label();
            label10 = new Label();
            button50 = new Button();
            button51 = new Button();
            button52 = new Button();
            panel1 = new Panel();
            txtGheDaChon = new TextBox();
            label2 = new Label();
            txtTongTienVe = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.DarkGreen;
            lblTieuDe.Location = new Point(399, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(154, 50);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "Tiêu Đề";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(34, 34);
            label11.Name = "label11";
            label11.Size = new Size(331, 60);
            label11.TabIndex = 0;
            label11.Text = "THANH TOÁN ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(34, 235);
            label10.Name = "label10";
            label10.Size = new Size(123, 31);
            label10.TabIndex = 2;
            label10.Text = "Tổng tiền:";
            // 
            // button50
            // 
            button50.BackColor = Color.DarkGreen;
            button50.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button50.ForeColor = Color.White;
            button50.Location = new Point(83, 580);
            button50.Name = "button50";
            button50.Size = new Size(247, 51);
            button50.TabIndex = 55;
            button50.Text = "Xóa";
            button50.UseVisualStyleBackColor = false;
            // 
            // button51
            // 
            button51.BackColor = Color.DarkGreen;
            button51.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button51.ForeColor = Color.White;
            button51.Location = new Point(83, 503);
            button51.Name = "button51";
            button51.Size = new Size(247, 51);
            button51.TabIndex = 56;
            button51.Text = "Mua";
            button51.UseVisualStyleBackColor = false;
            button51.Click += button51_Click;
            // 
            // button52
            // 
            button52.BackColor = Color.DarkGreen;
            button52.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button52.ForeColor = Color.White;
            button52.Location = new Point(83, 424);
            button52.Name = "button52";
            button52.Size = new Size(247, 51);
            button52.TabIndex = 57;
            button52.Text = "Tạm tính ";
            button52.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtGheDaChon);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTongTienVe);
            panel1.Controls.Add(button50);
            panel1.Controls.Add(button51);
            panel1.Controls.Add(button52);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(974, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 690);
            panel1.TabIndex = 53;
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtGheDaChon.Location = new Point(163, 122);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.Size = new Size(202, 38);
            txtGheDaChon.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(21, 127);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 59;
            label2.Text = "Ghế đã chọn:";
            // 
            // txtTongTienVe
            // 
            txtTongTienVe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTongTienVe.Location = new Point(163, 228);
            txtTongTienVe.Name = "txtTongTienVe";
            txtTongTienVe.Size = new Size(202, 38);
            txtTongTienVe.TabIndex = 58;
            // 
            // FrmDatVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 777);
            Controls.Add(panel1);
            Controls.Add(lblTieuDe);
            Name = "FrmDatVe";
            Text = "FrmDatVe";
            Load += FrmDatVe_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label label11;
        private Label label10;
        private Button button50;
        private Button button51;
        private Button button52;
        private Panel panel1;
        private TextBox txtGheDaChon;
        private Label label2;
        private TextBox txtTongTienVe;
    }
}