namespace QuanLyPhongTro_10122399.Folder_PhieuChi
{
    partial class frmPhieuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuChi));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaPT = new System.Windows.Forms.ComboBox();
            this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grbDanhSachKT = new System.Windows.Forms.GroupBox();
            this.dgvDSPC = new System.Windows.Forms.DataGridView();
            this.maPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.cmbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new QuanLyPhongTro_10122399.RJButton();
            this.btnXoaPC = new QuanLyPhongTro_10122399.RJButton();
            this.btnThemPC = new QuanLyPhongTro_10122399.RJButton();
            this.txtSoTien = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtLyDo = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.rjTextBox2 = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtMaPC = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtNgayTra = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.rjButton3 = new QuanLyPhongTro_10122399.RJButton();
            this.txtTimKiem = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.grbDanhSachKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide07 IcielCadena", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHIẾU CHI";
            // 
            // cmbMaPT
            // 
            this.cmbMaPT.BackColor = System.Drawing.Color.White;
            this.cmbMaPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaPT.Font = new System.Drawing.Font("Quicksand Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPT.FormattingEnabled = true;
            this.cmbMaPT.Location = new System.Drawing.Point(126, 677);
            this.cmbMaPT.Name = "cmbMaPT";
            this.cmbMaPT.Size = new System.Drawing.Size(128, 34);
            this.cmbMaPT.TabIndex = 115;
            // 
            // dtpNgayChi
            // 
            this.dtpNgayChi.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayChi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChi.Font = new System.Drawing.Font("Quicksand Light", 12F);
            this.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChi.Location = new System.Drawing.Point(423, 605);
            this.dtpNgayChi.Name = "dtpNgayChi";
            this.dtpNgayChi.Size = new System.Drawing.Size(182, 32);
            this.dtpNgayChi.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(311, 682);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 104;
            this.label6.Text = "Số tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(659, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 103;
            this.label5.Text = "Lý do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 101;
            this.label3.Text = "Ngày chi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 685);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 100;
            this.label2.Text = "Mã PT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 611);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 99;
            this.label8.Text = "Mã PC:";
            // 
            // grbDanhSachKT
            // 
            this.grbDanhSachKT.Controls.Add(this.dgvDSPC);
            this.grbDanhSachKT.Location = new System.Drawing.Point(42, 209);
            this.grbDanhSachKT.Name = "grbDanhSachKT";
            this.grbDanhSachKT.Size = new System.Drawing.Size(1156, 358);
            this.grbDanhSachKT.TabIndex = 94;
            this.grbDanhSachKT.TabStop = false;
            // 
            // dgvDSPC
            // 
            this.dgvDSPC.AllowUserToAddRows = false;
            this.dgvDSPC.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPC,
            this.maPT,
            this.ngayChi,
            this.soTien,
            this.lyDo});
            this.dgvDSPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPC.Location = new System.Drawing.Point(3, 28);
            this.dgvDSPC.Name = "dgvDSPC";
            this.dgvDSPC.ReadOnly = true;
            this.dgvDSPC.RowHeadersWidth = 51;
            this.dgvDSPC.RowTemplate.Height = 40;
            this.dgvDSPC.Size = new System.Drawing.Size(1150, 327);
            this.dgvDSPC.TabIndex = 1;
            this.dgvDSPC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPC_CellClick);
            this.dgvDSPC.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDSPC_RowPrePaint);
            // 
            // maPC
            // 
            this.maPC.DataPropertyName = "maPC";
            this.maPC.HeaderText = "Mã phiếu chi";
            this.maPC.MinimumWidth = 6;
            this.maPC.Name = "maPC";
            this.maPC.ReadOnly = true;
            this.maPC.Width = 180;
            // 
            // maPT
            // 
            this.maPT.DataPropertyName = "maPT";
            this.maPT.HeaderText = "Mã phòng trọ";
            this.maPT.MinimumWidth = 6;
            this.maPT.Name = "maPT";
            this.maPT.ReadOnly = true;
            this.maPT.Width = 180;
            // 
            // ngayChi
            // 
            this.ngayChi.DataPropertyName = "ngayChi";
            this.ngayChi.HeaderText = "Ngày chi";
            this.ngayChi.MinimumWidth = 6;
            this.ngayChi.Name = "ngayChi";
            this.ngayChi.ReadOnly = true;
            this.ngayChi.Width = 200;
            // 
            // soTien
            // 
            this.soTien.DataPropertyName = "soTien";
            this.soTien.HeaderText = "Số tiền";
            this.soTien.MinimumWidth = 6;
            this.soTien.Name = "soTien";
            this.soTien.ReadOnly = true;
            this.soTien.Width = 150;
            // 
            // lyDo
            // 
            this.lyDo.DataPropertyName = "lyDo";
            this.lyDo.HeaderText = "Lý do chi";
            this.lyDo.MinimumWidth = 6;
            this.lyDo.Name = "lyDo";
            this.lyDo.ReadOnly = true;
            this.lyDo.Width = 280;
            // 
            // picTimKiem
            // 
            this.picTimKiem.BackColor = System.Drawing.Color.White;
            this.picTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("picTimKiem.Image")));
            this.picTimKiem.Location = new System.Drawing.Point(567, 154);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(35, 42);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiem.TabIndex = 98;
            this.picTimKiem.TabStop = false;
            this.picTimKiem.Click += new System.EventHandler(this.picTimKiem_Click);
            // 
            // cmbTimKiem
            // 
            this.cmbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTimKiem.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimKiem.FormattingEnabled = true;
            this.cmbTimKiem.Items.AddRange(new object[] {
            "Mã PC"});
            this.cmbTimKiem.Location = new System.Drawing.Point(58, 152);
            this.cmbTimKiem.Name = "cmbTimKiem";
            this.cmbTimKiem.Size = new System.Drawing.Size(158, 42);
            this.cmbTimKiem.TabIndex = 95;
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
            this.btnCapNhat.Location = new System.Drawing.Point(735, 139);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(184, 63);
            this.btnCapNhat.TabIndex = 118;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaPC
            // 
            this.btnXoaPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaPC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaPC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaPC.BorderRadius = 30;
            this.btnXoaPC.BorderSize = 1;
            this.btnXoaPC.FlatAppearance.BorderSize = 0;
            this.btnXoaPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPC.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnXoaPC.ForeColor = System.Drawing.Color.White;
            this.btnXoaPC.Location = new System.Drawing.Point(1060, 140);
            this.btnXoaPC.Name = "btnXoaPC";
            this.btnXoaPC.Size = new System.Drawing.Size(129, 63);
            this.btnXoaPC.TabIndex = 117;
            this.btnXoaPC.Text = "Xóa";
            this.btnXoaPC.TextColor = System.Drawing.Color.White;
            this.btnXoaPC.UseVisualStyleBackColor = false;
            this.btnXoaPC.Click += new System.EventHandler(this.btnXoaPC_Click);
            // 
            // btnThemPC
            // 
            this.btnThemPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemPC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemPC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemPC.BorderRadius = 30;
            this.btnThemPC.BorderSize = 1;
            this.btnThemPC.FlatAppearance.BorderSize = 0;
            this.btnThemPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPC.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThemPC.ForeColor = System.Drawing.Color.White;
            this.btnThemPC.Location = new System.Drawing.Point(925, 139);
            this.btnThemPC.Name = "btnThemPC";
            this.btnThemPC.Size = new System.Drawing.Size(129, 63);
            this.btnThemPC.TabIndex = 116;
            this.btnThemPC.Text = "Thêm";
            this.btnThemPC.TextColor = System.Drawing.Color.White;
            this.btnThemPC.UseVisualStyleBackColor = false;
            this.btnThemPC.Click += new System.EventHandler(this.btnThemPC_Click);
            // 
            // txtSoTien
            // 
            this.txtSoTien.BackColor = System.Drawing.Color.White;
            this.txtSoTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtSoTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoTien.BorderRadius = 15;
            this.txtSoTien.BorderSize = 2;
            this.txtSoTien.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(410, 666);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Multiline = false;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSoTien.PasswordChar = false;
            this.txtSoTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoTien.PlaceholderText = "";
            this.txtSoTien.Size = new System.Drawing.Size(210, 45);
            this.txtSoTien.TabIndex = 113;
            this.txtSoTien.Texts = "0";
            this.txtSoTien.UnderlinedStyle = false;
            // 
            // txtLyDo
            // 
            this.txtLyDo.BackColor = System.Drawing.Color.White;
            this.txtLyDo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtLyDo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLyDo.BorderRadius = 15;
            this.txtLyDo.BorderSize = 2;
            this.txtLyDo.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(735, 597);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLyDo.PasswordChar = false;
            this.txtLyDo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLyDo.PlaceholderText = "";
            this.txtLyDo.Size = new System.Drawing.Size(441, 114);
            this.txtLyDo.TabIndex = 112;
            this.txtLyDo.Texts = "";
            this.txtLyDo.UnderlinedStyle = false;
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
            this.rjTextBox2.Location = new System.Drawing.Point(111, 671);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(153, 45);
            this.rjTextBox2.TabIndex = 111;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // txtMaPC
            // 
            this.txtMaPC.BackColor = System.Drawing.Color.White;
            this.txtMaPC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtMaPC.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaPC.BorderRadius = 15;
            this.txtMaPC.BorderSize = 2;
            this.txtMaPC.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPC.Location = new System.Drawing.Point(111, 598);
            this.txtMaPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPC.Multiline = false;
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaPC.PasswordChar = false;
            this.txtMaPC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaPC.PlaceholderText = "";
            this.txtMaPC.Size = new System.Drawing.Size(153, 45);
            this.txtMaPC.TabIndex = 110;
            this.txtMaPC.Texts = "";
            this.txtMaPC.UnderlinedStyle = false;
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
            this.txtNgayTra.Location = new System.Drawing.Point(410, 597);
            this.txtNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayTra.Multiline = false;
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNgayTra.PasswordChar = false;
            this.txtNgayTra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNgayTra.PlaceholderText = "";
            this.txtNgayTra.Size = new System.Drawing.Size(210, 45);
            this.txtNgayTra.TabIndex = 107;
            this.txtNgayTra.Texts = "01/01/2222";
            this.txtNgayTra.UnderlinedStyle = false;
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
            this.rjButton3.Location = new System.Drawing.Point(42, 118);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(188, 84);
            this.rjButton3.TabIndex = 97;
            this.rjButton3.Text = "Tìm kiếm";
            this.rjButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton3.TextColor = System.Drawing.Color.Silver;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.BorderRadius = 20;
            this.txtTimKiem.BorderSize = 3;
            this.txtTimKiem.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.txtTimKiem.Location = new System.Drawing.Point(280, 147);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(340, 56);
            this.txtTimKiem.TabIndex = 96;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            // 
            // frmPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1229, 757);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoaPC);
            this.Controls.Add(this.btnThemPC);
            this.Controls.Add(this.cmbMaPT);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.txtMaPC);
            this.Controls.Add(this.dtpNgayChi);
            this.Controls.Add(this.txtNgayTra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grbDanhSachKT);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.cmbTimKiem);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuChi";
            this.Text = "frmPhieuChi";
            this.grbDanhSachKT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJButton btnXoaPC;
        private RJButton btnThemPC;
        private System.Windows.Forms.ComboBox cmbMaPT;
        private RJControls.RJTextBox txtSoTien;
        private RJControls.RJTextBox txtLyDo;
        private RJControls.RJTextBox rjTextBox2;
        private RJControls.RJTextBox txtMaPC;
        private System.Windows.Forms.DateTimePicker dtpNgayChi;
        private RJControls.RJTextBox txtNgayTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbDanhSachKT;
        private System.Windows.Forms.DataGridView dgvDSPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDo;
        private System.Windows.Forms.PictureBox picTimKiem;
        private System.Windows.Forms.ComboBox cmbTimKiem;
        private RJButton rjButton3;
        private RJControls.RJTextBox txtTimKiem;
        private RJButton btnCapNhat;
    }
}