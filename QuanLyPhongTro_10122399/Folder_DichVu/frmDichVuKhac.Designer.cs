namespace QuanLyPhongTro_10122399.Folder_DichVu
{
    partial class frmDichVuKhac
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachKT = new System.Windows.Forms.GroupBox();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.maDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDonViTinh = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtDonViTinh = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtTenDV = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtMaDV = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnXoaDV = new QuanLyPhongTro_10122399.RJButton();
            this.btnThemDV = new QuanLyPhongTro_10122399.RJButton();
            this.btnCapNhat = new QuanLyPhongTro_10122399.RJButton();
            this.grbDanhSachKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(583, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 105;
            this.label7.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(878, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 104;
            this.label6.Text = "Đơn vị tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(303, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 103;
            this.label5.Text = "Tên DV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "Mã DV:";
            // 
            // grbDanhSachKT
            // 
            this.grbDanhSachKT.Controls.Add(this.dgvDV);
            this.grbDanhSachKT.Location = new System.Drawing.Point(33, 111);
            this.grbDanhSachKT.Name = "grbDanhSachKT";
            this.grbDanhSachKT.Size = new System.Drawing.Size(1156, 358);
            this.grbDanhSachKT.TabIndex = 94;
            this.grbDanhSachKT.TabStop = false;
            // 
            // dgvDV
            // 
            this.dgvDV.AllowUserToAddRows = false;
            this.dgvDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDV,
            this.tenDV,
            this.donGia,
            this.donViTinh});
            this.dgvDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDV.Location = new System.Drawing.Point(3, 28);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.RowTemplate.Height = 40;
            this.dgvDV.Size = new System.Drawing.Size(1150, 327);
            this.dgvDV.TabIndex = 1;
            this.dgvDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDV_CellClick);
            this.dgvDV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDV_RowPrePaint);
            // 
            // maDV
            // 
            this.maDV.DataPropertyName = "maDV";
            this.maDV.HeaderText = "Mã dịch vụ";
            this.maDV.MinimumWidth = 6;
            this.maDV.Name = "maDV";
            this.maDV.ReadOnly = true;
            this.maDV.Width = 250;
            // 
            // tenDV
            // 
            this.tenDV.DataPropertyName = "tenDV";
            this.tenDV.HeaderText = "Tên dịch vụ";
            this.tenDV.MinimumWidth = 6;
            this.tenDV.Name = "tenDV";
            this.tenDV.ReadOnly = true;
            this.tenDV.Width = 300;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            this.donGia.Width = 250;
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "donViTinh";
            this.donViTinh.HeaderText = "Đơn vị tính";
            this.donViTinh.MinimumWidth = 6;
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.ReadOnly = true;
            this.donViTinh.Width = 300;
            // 
            // cmbDonViTinh
            // 
            this.cmbDonViTinh.BackColor = System.Drawing.Color.White;
            this.cmbDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonViTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDonViTinh.Font = new System.Drawing.Font("Quicksand Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDonViTinh.FormattingEnabled = true;
            this.cmbDonViTinh.Items.AddRange(new object[] {
            "tháng",
            "M3",
            "KWh",
            "túi",
            "gói",
            "g",
            "kg"});
            this.cmbDonViTinh.Location = new System.Drawing.Point(1007, 539);
            this.cmbDonViTinh.Name = "cmbDonViTinh";
            this.cmbDonViTinh.Size = new System.Drawing.Size(128, 34);
            this.cmbDonViTinh.TabIndex = 118;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDonGia.BorderRadius = 15;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(677, 533);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Multiline = false;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.Size = new System.Drawing.Size(153, 45);
            this.txtDonGia.TabIndex = 114;
            this.txtDonGia.Texts = "0";
            this.txtDonGia.UnderlinedStyle = false;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.White;
            this.txtDonViTinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtDonViTinh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDonViTinh.BorderRadius = 15;
            this.txtDonViTinh.BorderSize = 2;
            this.txtDonViTinh.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.ForeColor = System.Drawing.Color.White;
            this.txtDonViTinh.Location = new System.Drawing.Point(993, 533);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonViTinh.Multiline = false;
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonViTinh.PasswordChar = false;
            this.txtDonViTinh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonViTinh.PlaceholderText = "";
            this.txtDonViTinh.Size = new System.Drawing.Size(153, 45);
            this.txtDonViTinh.TabIndex = 113;
            this.txtDonViTinh.Texts = "";
            this.txtDonViTinh.UnderlinedStyle = false;
            // 
            // txtTenDV
            // 
            this.txtTenDV.BackColor = System.Drawing.Color.White;
            this.txtTenDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtTenDV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenDV.BorderRadius = 15;
            this.txtTenDV.BorderSize = 2;
            this.txtTenDV.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(392, 533);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDV.Multiline = false;
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenDV.PasswordChar = false;
            this.txtTenDV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenDV.PlaceholderText = "";
            this.txtTenDV.Size = new System.Drawing.Size(153, 45);
            this.txtTenDV.TabIndex = 112;
            this.txtTenDV.Texts = "";
            this.txtTenDV.UnderlinedStyle = false;
            // 
            // txtMaDV
            // 
            this.txtMaDV.BackColor = System.Drawing.Color.White;
            this.txtMaDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtMaDV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaDV.BorderRadius = 15;
            this.txtMaDV.BorderSize = 2;
            this.txtMaDV.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(122, 533);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDV.Multiline = false;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaDV.PasswordChar = false;
            this.txtMaDV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaDV.PlaceholderText = "";
            this.txtMaDV.Size = new System.Drawing.Size(153, 45);
            this.txtMaDV.TabIndex = 110;
            this.txtMaDV.Texts = "";
            this.txtMaDV.UnderlinedStyle = false;
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaDV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaDV.BorderRadius = 30;
            this.btnXoaDV.BorderSize = 1;
            this.btnXoaDV.FlatAppearance.BorderSize = 0;
            this.btnXoaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDV.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnXoaDV.ForeColor = System.Drawing.Color.White;
            this.btnXoaDV.Location = new System.Drawing.Point(1052, 36);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(125, 63);
            this.btnXoaDV.TabIndex = 117;
            this.btnXoaDV.Text = "Xóa ";
            this.btnXoaDV.TextColor = System.Drawing.Color.White;
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemDV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemDV.BorderRadius = 30;
            this.btnThemDV.BorderSize = 1;
            this.btnThemDV.FlatAppearance.BorderSize = 0;
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(921, 36);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(125, 63);
            this.btnThemDV.TabIndex = 116;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.TextColor = System.Drawing.Color.White;
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnCapNhat.BorderRadius = 30;
            this.btnCapNhat.BorderSize = 1;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(723, 36);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(192, 63);
            this.btnCapNhat.TabIndex = 119;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmDichVuKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1205, 647);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cmbDonViTinh);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbDanhSachKT);
            this.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDichVuKhac";
            this.Text = "frmDichVuKhac";
            this.Load += new System.EventHandler(this.frmDichVuKhac_Load);
            this.grbDanhSachKT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJControls.RJTextBox txtDonGia;
        private RJControls.RJTextBox txtDonViTinh;
        private RJControls.RJTextBox txtTenDV;
        private RJControls.RJTextBox txtMaDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDanhSachKT;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.ComboBox cmbDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private RJButton btnXoaDV;
        private RJButton btnThemDV;
        private RJButton btnCapNhat;
    }
}