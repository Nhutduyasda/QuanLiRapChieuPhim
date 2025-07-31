namespace GUI
{
    partial class PhimDaThem
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
            lblNumber = new Label();
            lblName = new Label();
            panel2 = new Panel();
            lblEmp = new Label();
            lblNV = new Label();
            panel3 = new Panel();
            lblDateTime = new Label();
            lblNgay = new Label();
            dgvDSPhim = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhim).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(lblNumber);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(99, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNumber.Location = new Point(143, 27);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(55, 29);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "text";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblName.Location = new Point(36, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(162, 29);
            lblName.TabIndex = 0;
            lblName.Text = "Phim Có Sẵn";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(lblEmp);
            panel2.Controls.Add(lblNV);
            panel2.Location = new Point(439, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 1;
            // 
            // lblEmp
            // 
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblEmp.Location = new Point(151, 27);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(55, 29);
            lblEmp.TabIndex = 2;
            lblEmp.Text = "text";
            lblEmp.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNV
            // 
            lblNV.AutoSize = true;
            lblNV.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNV.Location = new Point(75, 83);
            lblNV.Name = "lblNV";
            lblNV.Size = new Size(131, 29);
            lblNV.TabIndex = 1;
            lblNV.Text = "Nhân Viên";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Controls.Add(lblDateTime);
            panel3.Controls.Add(lblNgay);
            panel3.Location = new Point(785, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDateTime.Location = new Point(25, 27);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(55, 29);
            lblDateTime.TabIndex = 2;
            lblDateTime.Text = "text";
            lblDateTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNgay.Location = new Point(93, 83);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(71, 29);
            lblNgay.TabIndex = 1;
            lblNgay.Text = "Ngày";
            // 
            // dgvDSPhim
            // 
            dgvDSPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhim.Location = new Point(57, 317);
            dgvDSPhim.Name = "dgvDSPhim";
            dgvDSPhim.RowHeadersWidth = 51;
            dgvDSPhim.Size = new Size(1049, 341);
            dgvDSPhim.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(57, 263);
            label1.Name = "label1";
            label1.Size = new Size(175, 38);
            label1.TabIndex = 3;
            label1.Text = "Phim có sẵn";
            // 
            // PhimDaThem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 716);
            Controls.Add(label1);
            Controls.Add(dgvDSPhim);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "PhimDaThem";
            Text = "PhimDaThem";
            Load += PhimDaThem_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvDSPhim;
        private Label label1;
        private Label lblName;
        private Label lblNV;
        private Label lblNgay;
        private Label lblNumber;
        private Label lblDateTime;
        private Label lblEmp;
    }
}