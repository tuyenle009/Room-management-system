namespace QuanLyPhongTro_10122399.Folder_DichVu
{
    partial class frmDienNuoc
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
            this.grbDanhSachKT = new System.Windows.Forms.GroupBox();
            this.dgvDVDN = new System.Windows.Forms.DataGridView();
            this.maDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toiNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpToiNgay = new System.Windows.Forms.DateTimePicker();
            this.cmbMaPT = new System.Windows.Forms.ComboBox();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.btnMoi = new QuanLyPhongTro_10122399.RJButton();
            this.rjButton3 = new QuanLyPhongTro_10122399.RJButton();
            this.btnLayDL = new QuanLyPhongTro_10122399.RJButton();
            this.btnCapNhat = new QuanLyPhongTro_10122399.RJButton();
            this.btnXoaDV = new QuanLyPhongTro_10122399.RJButton();
            this.btnThemDV = new QuanLyPhongTro_10122399.RJButton();
            this.txtDonGia = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtChiSoMoi = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtChiSoCu = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.rjTextBox2 = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtMaDV = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.rjTextBox1 = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtNgayTra = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.grbDanhSachKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVDN)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDanhSachKT
            // 
            this.grbDanhSachKT.Controls.Add(this.dgvDVDN);
            this.grbDanhSachKT.Location = new System.Drawing.Point(29, 104);
            this.grbDanhSachKT.Name = "grbDanhSachKT";
            this.grbDanhSachKT.Size = new System.Drawing.Size(1156, 358);
            this.grbDanhSachKT.TabIndex = 24;
            this.grbDanhSachKT.TabStop = false;
            // 
            // dgvDVDN
            // 
            this.dgvDVDN.AllowUserToAddRows = false;
            this.dgvDVDN.BackgroundColor = System.Drawing.Color.White;
            this.dgvDVDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDVDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDN,
            this.maPT,
            this.tuNgay,
            this.toiNgay,
            this.chiSoCu,
            this.chiSoMoi,
            this.donGia,
            this.thanhTien});
            this.dgvDVDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDVDN.Location = new System.Drawing.Point(3, 28);
            this.dgvDVDN.Name = "dgvDVDN";
            this.dgvDVDN.ReadOnly = true;
            this.dgvDVDN.RowHeadersWidth = 51;
            this.dgvDVDN.RowTemplate.Height = 40;
            this.dgvDVDN.Size = new System.Drawing.Size(1150, 327);
            this.dgvDVDN.TabIndex = 1;
            this.dgvDVDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVDN_CellClick);
            this.dgvDVDN.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDVDN_RowPrePaint);
            // 
            // maDN
            // 
            this.maDN.DataPropertyName = "maDN";
            this.maDN.HeaderText = "Mã dịch vụ";
            this.maDN.MinimumWidth = 6;
            this.maDN.Name = "maDN";
            this.maDN.ReadOnly = true;
            this.maDN.Width = 140;
            // 
            // maPT
            // 
            this.maPT.DataPropertyName = "maPT";
            this.maPT.HeaderText = "Mã phòng trọ";
            this.maPT.MinimumWidth = 6;
            this.maPT.Name = "maPT";
            this.maPT.ReadOnly = true;
            this.maPT.Width = 160;
            // 
            // tuNgay
            // 
            this.tuNgay.DataPropertyName = "tuNgay";
            this.tuNgay.HeaderText = "Từ ngày";
            this.tuNgay.MinimumWidth = 6;
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.ReadOnly = true;
            this.tuNgay.Width = 160;
            // 
            // toiNgay
            // 
            this.toiNgay.DataPropertyName = "toiNgay";
            this.toiNgay.HeaderText = "Tới ngày";
            this.toiNgay.MinimumWidth = 6;
            this.toiNgay.Name = "toiNgay";
            this.toiNgay.ReadOnly = true;
            this.toiNgay.Width = 150;
            // 
            // chiSoCu
            // 
            this.chiSoCu.DataPropertyName = "chiSoCu";
            this.chiSoCu.HeaderText = "Chỉ số cũ";
            this.chiSoCu.MinimumWidth = 6;
            this.chiSoCu.Name = "chiSoCu";
            this.chiSoCu.ReadOnly = true;
            this.chiSoCu.Width = 130;
            // 
            // chiSoMoi
            // 
            this.chiSoMoi.DataPropertyName = "chiSoMoi";
            this.chiSoMoi.HeaderText = "Chỉ số mới";
            this.chiSoMoi.MinimumWidth = 6;
            this.chiSoMoi.Name = "chiSoMoi";
            this.chiSoMoi.ReadOnly = true;
            this.chiSoMoi.Width = 135;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            this.donGia.Width = 80;
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "thanhTien";
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            this.thanhTien.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã DV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã PT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(272, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Từ ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(272, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tới ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(621, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Chỉ số cũ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(620, 580);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Chỉ số mới";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(915, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Đơn giá:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Quicksand Light", 12F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(388, 493);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(182, 32);
            this.dtpTuNgay.TabIndex = 74;
            // 
            // dtpToiNgay
            // 
            this.dtpToiNgay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpToiNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpToiNgay.Font = new System.Drawing.Font("Quicksand Light", 12F);
            this.dtpToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToiNgay.Location = new System.Drawing.Point(388, 572);
            this.dtpToiNgay.Name = "dtpToiNgay";
            this.dtpToiNgay.Size = new System.Drawing.Size(182, 32);
            this.dtpToiNgay.TabIndex = 76;
            // 
            // cmbMaPT
            // 
            this.cmbMaPT.BackColor = System.Drawing.Color.White;
            this.cmbMaPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaPT.Font = new System.Drawing.Font("Quicksand Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPT.FormattingEnabled = true;
            this.cmbMaPT.Location = new System.Drawing.Point(107, 572);
            this.cmbMaPT.Name = "cmbMaPT";
            this.cmbMaPT.Size = new System.Drawing.Size(128, 34);
            this.cmbMaPT.TabIndex = 90;
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Font = new System.Drawing.Font("Quicksand Light", 16F);
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(71, 54);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(132, 41);
            this.dtpThangNam.TabIndex = 100;
            this.dtpThangNam.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnMoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnMoi.BorderRadius = 30;
            this.btnMoi.BorderSize = 1;
            this.btnMoi.FlatAppearance.BorderSize = 0;
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoi.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMoi.ForeColor = System.Drawing.Color.White;
            this.btnMoi.Location = new System.Drawing.Point(630, 35);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(114, 63);
            this.btnMoi.TabIndex = 101;
            this.btnMoi.Text = "Mới";
            this.btnMoi.TextColor = System.Drawing.Color.White;
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.White;
            this.rjButton3.BackgroundColor = System.Drawing.Color.White;
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rjButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.Silver;
            this.rjButton3.Location = new System.Drawing.Point(32, 14);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(203, 81);
            this.rjButton3.TabIndex = 99;
            this.rjButton3.Text = "THÁNG/NĂM";
            this.rjButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton3.TextColor = System.Drawing.Color.Silver;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // btnLayDL
            // 
            this.btnLayDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnLayDL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnLayDL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnLayDL.BorderRadius = 20;
            this.btnLayDL.BorderSize = 1;
            this.btnLayDL.FlatAppearance.BorderSize = 0;
            this.btnLayDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLayDL.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLayDL.ForeColor = System.Drawing.Color.White;
            this.btnLayDL.Location = new System.Drawing.Point(919, 558);
            this.btnLayDL.Name = "btnLayDL";
            this.btnLayDL.Size = new System.Drawing.Size(245, 63);
            this.btnLayDL.TabIndex = 95;
            this.btnLayDL.Text = "Lấy dữ liệu trước";
            this.btnLayDL.TextColor = System.Drawing.Color.White;
            this.btnLayDL.UseVisualStyleBackColor = false;
            this.btnLayDL.Click += new System.EventHandler(this.btnLayDL_Click);
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
            this.btnCapNhat.Location = new System.Drawing.Point(750, 35);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(192, 63);
            this.btnCapNhat.TabIndex = 94;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.btnXoaDV.Location = new System.Drawing.Point(1068, 35);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(114, 63);
            this.btnXoaDV.TabIndex = 93;
            this.btnXoaDV.Text = "Xóa";
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
            this.btnThemDV.Location = new System.Drawing.Point(948, 35);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(114, 63);
            this.btnThemDV.TabIndex = 92;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.TextColor = System.Drawing.Color.White;
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDonGia.BorderRadius = 15;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(1009, 486);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Multiline = false;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.Size = new System.Drawing.Size(153, 45);
            this.txtDonGia.TabIndex = 88;
            this.txtDonGia.Texts = "";
            this.txtDonGia.UnderlinedStyle = false;
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.BackColor = System.Drawing.Color.White;
            this.txtChiSoMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtChiSoMoi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtChiSoMoi.BorderRadius = 15;
            this.txtChiSoMoi.BorderSize = 2;
            this.txtChiSoMoi.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoMoi.Location = new System.Drawing.Point(735, 566);
            this.txtChiSoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtChiSoMoi.Multiline = false;
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtChiSoMoi.PasswordChar = false;
            this.txtChiSoMoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChiSoMoi.PlaceholderText = "";
            this.txtChiSoMoi.Size = new System.Drawing.Size(153, 45);
            this.txtChiSoMoi.TabIndex = 87;
            this.txtChiSoMoi.Texts = "";
            this.txtChiSoMoi.UnderlinedStyle = false;
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.BackColor = System.Drawing.Color.White;
            this.txtChiSoCu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtChiSoCu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtChiSoCu.BorderRadius = 15;
            this.txtChiSoCu.BorderSize = 2;
            this.txtChiSoCu.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoCu.Location = new System.Drawing.Point(735, 486);
            this.txtChiSoCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChiSoCu.Multiline = false;
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtChiSoCu.PasswordChar = false;
            this.txtChiSoCu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChiSoCu.PlaceholderText = "";
            this.txtChiSoCu.Size = new System.Drawing.Size(153, 45);
            this.txtChiSoCu.TabIndex = 86;
            this.txtChiSoCu.Texts = "";
            this.txtChiSoCu.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 15;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.White;
            this.rjTextBox2.Location = new System.Drawing.Point(92, 566);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(153, 45);
            this.rjTextBox2.TabIndex = 85;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // txtMaDV
            // 
            this.txtMaDV.BackColor = System.Drawing.Color.White;
            this.txtMaDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtMaDV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaDV.BorderRadius = 15;
            this.txtMaDV.BorderSize = 2;
            this.txtMaDV.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(92, 486);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDV.Multiline = false;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaDV.PasswordChar = false;
            this.txtMaDV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaDV.PlaceholderText = "";
            this.txtMaDV.Size = new System.Drawing.Size(153, 45);
            this.txtMaDV.TabIndex = 84;
            this.txtMaDV.Texts = "";
            this.txtMaDV.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(375, 565);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(210, 45);
            this.rjTextBox1.TabIndex = 77;
            this.rjTextBox1.Texts = "01/01/2222";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.BackColor = System.Drawing.Color.White;
            this.txtNgayTra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtNgayTra.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNgayTra.BorderRadius = 15;
            this.txtNgayTra.BorderSize = 2;
            this.txtNgayTra.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTra.ForeColor = System.Drawing.Color.White;
            this.txtNgayTra.Location = new System.Drawing.Point(375, 485);
            this.txtNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayTra.Multiline = false;
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNgayTra.PasswordChar = false;
            this.txtNgayTra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNgayTra.PlaceholderText = "";
            this.txtNgayTra.Size = new System.Drawing.Size(210, 45);
            this.txtNgayTra.TabIndex = 75;
            this.txtNgayTra.Texts = "01/01/2222";
            this.txtNgayTra.UnderlinedStyle = false;
            // 
            // frmDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1205, 647);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.dtpThangNam);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.btnLayDL);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.cmbMaPT);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtChiSoMoi);
            this.Controls.Add(this.txtChiSoCu);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.dtpToiNgay);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.txtNgayTra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbDanhSachKT);
            this.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDienNuoc";
            this.grbDanhSachKT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachKT;
        private System.Windows.Forms.DataGridView dgvDVDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private RJControls.RJTextBox txtNgayTra;
        private System.Windows.Forms.DateTimePicker dtpToiNgay;
        private RJControls.RJTextBox rjTextBox1;
        private RJControls.RJTextBox txtMaDV;
        private RJControls.RJTextBox rjTextBox2;
        private RJControls.RJTextBox txtChiSoCu;
        private RJControls.RJTextBox txtChiSoMoi;
        private RJControls.RJTextBox txtDonGia;
        private System.Windows.Forms.ComboBox cmbMaPT;
        private RJButton btnXoaDV;
        private RJButton btnThemDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn toiNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private RJButton btnCapNhat;
        private RJButton btnLayDL;
        private RJButton rjButton3;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private RJButton btnMoi;
    }
}