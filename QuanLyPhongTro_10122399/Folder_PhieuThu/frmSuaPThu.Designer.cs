namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    partial class frmSuaPThu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaPThu));
            this.maDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMaKT = new System.Windows.Forms.ComboBox();
            this.cmbMaPT = new System.Windows.Forms.ComboBox();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoaHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCMND = new System.Windows.Forms.Label();
            this.cmbMaDV = new System.Windows.Forms.ComboBox();
            this.pnlCTPhieuThu = new System.Windows.Forms.Panel();
            this.btnThemCTPT = new QuanLyPhongTro_10122399.RJButton();
            this.dgvCTDV = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSoLuong = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.rjTextBox2 = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.lblMaKT = new System.Windows.Forms.Label();
            this.lblThongTinPT = new System.Windows.Forms.Label();
            this.pnlPhieuThu = new System.Windows.Forms.Panel();
            this.lblMaPThu = new System.Windows.Forms.Label();
            this.txtMaKT = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtNgayThu = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnCapNhatPThu = new QuanLyPhongTro_10122399.RJButton();
            this.txtMaThu = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnThoat = new QuanLyPhongTro_10122399.RJButton();
            this.txtMaPT = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.pnlCTPhieuThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlPhieuThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // maDV
            // 
            this.maDV.DataPropertyName = "maDV";
            this.maDV.HeaderText = "Mã dịch vụ";
            this.maDV.MinimumWidth = 6;
            this.maDV.Name = "maDV";
            this.maDV.ReadOnly = true;
            this.maDV.Width = 210;
            // 
            // cmbMaKT
            // 
            this.cmbMaKT.BackColor = System.Drawing.Color.White;
            this.cmbMaKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaKT.Font = new System.Drawing.Font("Quicksand Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaKT.FormattingEnabled = true;
            this.cmbMaKT.Location = new System.Drawing.Point(445, 265);
            this.cmbMaKT.Name = "cmbMaKT";
            this.cmbMaKT.Size = new System.Drawing.Size(161, 34);
            this.cmbMaKT.TabIndex = 138;
            // 
            // cmbMaPT
            // 
            this.cmbMaPT.BackColor = System.Drawing.Color.White;
            this.cmbMaPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaPT.Font = new System.Drawing.Font("Quicksand Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPT.FormattingEnabled = true;
            this.cmbMaPT.Location = new System.Drawing.Point(179, 265);
            this.cmbMaPT.Name = "cmbMaPT";
            this.cmbMaPT.Size = new System.Drawing.Size(161, 34);
            this.cmbMaPT.TabIndex = 137;
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThu.Location = new System.Drawing.Point(443, 148);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(182, 32);
            this.dtpNgayThu.TabIndex = 131;
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTiet.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTiet.ForeColor = System.Drawing.Color.White;
            this.lblChiTiet.Location = new System.Drawing.Point(-4, 451);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(123, 34);
            this.lblChiTiet.TabIndex = 130;
            this.lblChiTiet.Text = "Chi tiết:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(440, 225);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(163, 30);
            this.lblHoTen.TabIndex = 127;
            this.lblHoTen.Text = "MÃ KHÁCH TRỌ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 134;
            this.label3.Text = "SỐ LƯỢNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 132;
            this.label2.Text = "Mã Dịch vụ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(440, 107);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(114, 30);
            this.lblGioiTinh.TabIndex = 125;
            this.lblGioiTinh.Text = "NGÀY THU";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 240;
            // 
            // xoaHangToolStripMenuItem
            // 
            this.xoaHangToolStripMenuItem.Name = "xoaHangToolStripMenuItem";
            this.xoaHangToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.xoaHangToolStripMenuItem.Text = "Xóa hàng";
            this.xoaHangToolStripMenuItem.Click += new System.EventHandler(this.xoaHangToolStripMenuItem_Click);
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.BackColor = System.Drawing.Color.Transparent;
            this.lblCMND.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(175, 225);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(166, 30);
            this.lblCMND.TabIndex = 124;
            this.lblCMND.Text = "MÃ PHÒNG TRỌ";
            // 
            // cmbMaDV
            // 
            this.cmbMaDV.BackColor = System.Drawing.Color.White;
            this.cmbMaDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaDV.Font = new System.Drawing.Font("Quicksand Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaDV.FormattingEnabled = true;
            this.cmbMaDV.Location = new System.Drawing.Point(62, 70);
            this.cmbMaDV.Name = "cmbMaDV";
            this.cmbMaDV.Size = new System.Drawing.Size(145, 34);
            this.cmbMaDV.TabIndex = 136;
            // 
            // pnlCTPhieuThu
            // 
            this.pnlCTPhieuThu.BackColor = System.Drawing.Color.White;
            this.pnlCTPhieuThu.Controls.Add(this.cmbMaDV);
            this.pnlCTPhieuThu.Controls.Add(this.btnThemCTPT);
            this.pnlCTPhieuThu.Controls.Add(this.dgvCTDV);
            this.pnlCTPhieuThu.Controls.Add(this.txtSoLuong);
            this.pnlCTPhieuThu.Controls.Add(this.label3);
            this.pnlCTPhieuThu.Controls.Add(this.rjTextBox2);
            this.pnlCTPhieuThu.Controls.Add(this.label2);
            this.pnlCTPhieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCTPhieuThu.Location = new System.Drawing.Point(0, 478);
            this.pnlCTPhieuThu.Name = "pnlCTPhieuThu";
            this.pnlCTPhieuThu.Size = new System.Drawing.Size(796, 310);
            this.pnlCTPhieuThu.TabIndex = 3;
            // 
            // btnThemCTPT
            // 
            this.btnThemCTPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnThemCTPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnThemCTPT.BorderColor = System.Drawing.Color.White;
            this.btnThemCTPT.BorderRadius = 20;
            this.btnThemCTPT.BorderSize = 1;
            this.btnThemCTPT.FlatAppearance.BorderSize = 0;
            this.btnThemCTPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCTPT.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTPT.ForeColor = System.Drawing.Color.White;
            this.btnThemCTPT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCTPT.Image")));
            this.btnThemCTPT.Location = new System.Drawing.Point(57, 234);
            this.btnThemCTPT.Name = "btnThemCTPT";
            this.btnThemCTPT.Size = new System.Drawing.Size(160, 58);
            this.btnThemCTPT.TabIndex = 131;
            this.btnThemCTPT.Text = "THÊM";
            this.btnThemCTPT.TextColor = System.Drawing.Color.White;
            this.btnThemCTPT.UseVisualStyleBackColor = false;
            this.btnThemCTPT.Click += new System.EventHandler(this.btnThemCTPT_Click);
            // 
            // dgvCTDV
            // 
            this.dgvCTDV.AllowUserToAddRows = false;
            this.dgvCTDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDV,
            this.soLuong});
            this.dgvCTDV.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCTDV.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvCTDV.Location = new System.Drawing.Point(289, 0);
            this.dgvCTDV.Name = "dgvCTDV";
            this.dgvCTDV.ReadOnly = true;
            this.dgvCTDV.RowHeadersWidth = 51;
            this.dgvCTDV.RowTemplate.Height = 24;
            this.dgvCTDV.Size = new System.Drawing.Size(507, 310);
            this.dgvCTDV.TabIndex = 135;
            this.dgvCTDV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCTDV_CellMouseUp);
            this.dgvCTDV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCTDV_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaHangToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 28);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtSoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoLuong.BorderRadius = 20;
            this.txtSoLuong.BorderSize = 2;
            this.txtSoLuong.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(47, 162);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(179, 45);
            this.txtSoLuong.TabIndex = 133;
            this.txtSoLuong.Texts = "0";
            this.txtSoLuong.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderColor = System.Drawing.Color.SaddleBrown;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 20;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.White;
            this.rjTextBox2.Location = new System.Drawing.Point(47, 63);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(179, 45);
            this.rjTextBox2.TabIndex = 131;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // lblMaKT
            // 
            this.lblMaKT.AutoSize = true;
            this.lblMaKT.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKT.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKT.Location = new System.Drawing.Point(175, 107);
            this.lblMaKT.Name = "lblMaKT";
            this.lblMaKT.Size = new System.Drawing.Size(152, 30);
            this.lblMaKT.TabIndex = 122;
            this.lblMaKT.Text = "MÃ PHIẾU THU";
            // 
            // lblThongTinPT
            // 
            this.lblThongTinPT.AutoSize = true;
            this.lblThongTinPT.BackColor = System.Drawing.Color.Transparent;
            this.lblThongTinPT.Font = new System.Drawing.Font("#9Slide07 IcielCadena", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPT.Location = new System.Drawing.Point(202, 28);
            this.lblThongTinPT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTinPT.Name = "lblThongTinPT";
            this.lblThongTinPT.Size = new System.Drawing.Size(391, 43);
            this.lblThongTinPT.TabIndex = 121;
            this.lblThongTinPT.Text = "THÔNG TIN PHIẾU THU";
            // 
            // pnlPhieuThu
            // 
            this.pnlPhieuThu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPhieuThu.BackgroundImage")));
            this.pnlPhieuThu.Controls.Add(this.lblMaPThu);
            this.pnlPhieuThu.Controls.Add(this.cmbMaKT);
            this.pnlPhieuThu.Controls.Add(this.cmbMaPT);
            this.pnlPhieuThu.Controls.Add(this.dtpNgayThu);
            this.pnlPhieuThu.Controls.Add(this.lblChiTiet);
            this.pnlPhieuThu.Controls.Add(this.txtMaKT);
            this.pnlPhieuThu.Controls.Add(this.lblHoTen);
            this.pnlPhieuThu.Controls.Add(this.txtNgayThu);
            this.pnlPhieuThu.Controls.Add(this.btnCapNhatPThu);
            this.pnlPhieuThu.Controls.Add(this.txtMaThu);
            this.pnlPhieuThu.Controls.Add(this.btnThoat);
            this.pnlPhieuThu.Controls.Add(this.lblGioiTinh);
            this.pnlPhieuThu.Controls.Add(this.txtMaPT);
            this.pnlPhieuThu.Controls.Add(this.lblCMND);
            this.pnlPhieuThu.Controls.Add(this.lblMaKT);
            this.pnlPhieuThu.Controls.Add(this.lblThongTinPT);
            this.pnlPhieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPhieuThu.Location = new System.Drawing.Point(0, 0);
            this.pnlPhieuThu.Name = "pnlPhieuThu";
            this.pnlPhieuThu.Size = new System.Drawing.Size(796, 478);
            this.pnlPhieuThu.TabIndex = 2;
            // 
            // lblMaPThu
            // 
            this.lblMaPThu.AutoSize = true;
            this.lblMaPThu.BackColor = System.Drawing.Color.White;
            this.lblMaPThu.Font = new System.Drawing.Font("Quicksand Light", 13F);
            this.lblMaPThu.Location = new System.Drawing.Point(183, 148);
            this.lblMaPThu.Name = "lblMaPThu";
            this.lblMaPThu.Size = new System.Drawing.Size(72, 33);
            this.lblMaPThu.TabIndex = 139;
            this.lblMaPThu.Text = "MaPT";
            this.lblMaPThu.Click += new System.EventHandler(this.lblMaPTro_Click);
            // 
            // txtMaKT
            // 
            this.txtMaKT.BackColor = System.Drawing.Color.White;
            this.txtMaKT.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtMaKT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaKT.BorderRadius = 20;
            this.txtMaKT.BorderSize = 2;
            this.txtMaKT.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKT.ForeColor = System.Drawing.Color.White;
            this.txtMaKT.Location = new System.Drawing.Point(430, 259);
            this.txtMaKT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKT.Multiline = false;
            this.txtMaKT.Name = "txtMaKT";
            this.txtMaKT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaKT.PasswordChar = false;
            this.txtMaKT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKT.PlaceholderText = "";
            this.txtMaKT.Size = new System.Drawing.Size(210, 45);
            this.txtMaKT.TabIndex = 126;
            this.txtMaKT.Texts = "";
            this.txtMaKT.UnderlinedStyle = false;
            // 
            // txtNgayThu
            // 
            this.txtNgayThu.BackColor = System.Drawing.Color.White;
            this.txtNgayThu.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtNgayThu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNgayThu.BorderRadius = 20;
            this.txtNgayThu.BorderSize = 2;
            this.txtNgayThu.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayThu.ForeColor = System.Drawing.Color.White;
            this.txtNgayThu.Location = new System.Drawing.Point(430, 141);
            this.txtNgayThu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayThu.Multiline = false;
            this.txtNgayThu.Name = "txtNgayThu";
            this.txtNgayThu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNgayThu.PasswordChar = false;
            this.txtNgayThu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNgayThu.PlaceholderText = "";
            this.txtNgayThu.Size = new System.Drawing.Size(210, 45);
            this.txtNgayThu.TabIndex = 118;
            this.txtNgayThu.Texts = "";
            this.txtNgayThu.UnderlinedStyle = false;
            // 
            // btnCapNhatPThu
            // 
            this.btnCapNhatPThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnCapNhatPThu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnCapNhatPThu.BorderColor = System.Drawing.Color.White;
            this.btnCapNhatPThu.BorderRadius = 20;
            this.btnCapNhatPThu.BorderSize = 1;
            this.btnCapNhatPThu.FlatAppearance.BorderSize = 0;
            this.btnCapNhatPThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatPThu.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatPThu.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatPThu.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatPThu.Image")));
            this.btnCapNhatPThu.Location = new System.Drawing.Point(197, 345);
            this.btnCapNhatPThu.Name = "btnCapNhatPThu";
            this.btnCapNhatPThu.Size = new System.Drawing.Size(178, 58);
            this.btnCapNhatPThu.TabIndex = 119;
            this.btnCapNhatPThu.Text = "CẬP NHẬT";
            this.btnCapNhatPThu.TextColor = System.Drawing.Color.White;
            this.btnCapNhatPThu.UseVisualStyleBackColor = false;
            this.btnCapNhatPThu.Click += new System.EventHandler(this.btnCapNhatPThu_Click);
            // 
            // txtMaThu
            // 
            this.txtMaThu.BackColor = System.Drawing.Color.White;
            this.txtMaThu.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtMaThu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaThu.BorderRadius = 20;
            this.txtMaThu.BorderSize = 2;
            this.txtMaThu.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThu.ForeColor = System.Drawing.Color.White;
            this.txtMaThu.Location = new System.Drawing.Point(162, 141);
            this.txtMaThu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThu.Multiline = false;
            this.txtMaThu.Name = "txtMaThu";
            this.txtMaThu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaThu.PasswordChar = false;
            this.txtMaThu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaThu.PlaceholderText = "";
            this.txtMaThu.Size = new System.Drawing.Size(210, 45);
            this.txtMaThu.TabIndex = 115;
            this.txtMaThu.Texts = "";
            this.txtMaThu.UnderlinedStyle = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnThoat.BorderColor = System.Drawing.Color.White;
            this.btnThoat.BorderRadius = 20;
            this.btnThoat.BorderSize = 1;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(430, 345);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(178, 58);
            this.btnThoat.TabIndex = 120;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaPT
            // 
            this.txtMaPT.BackColor = System.Drawing.Color.White;
            this.txtMaPT.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtMaPT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaPT.BorderRadius = 20;
            this.txtMaPT.BorderSize = 2;
            this.txtMaPT.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.ForeColor = System.Drawing.Color.White;
            this.txtMaPT.Location = new System.Drawing.Point(161, 259);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPT.Multiline = false;
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaPT.PasswordChar = false;
            this.txtMaPT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaPT.PlaceholderText = "";
            this.txtMaPT.Size = new System.Drawing.Size(210, 45);
            this.txtMaPT.TabIndex = 117;
            this.txtMaPT.Texts = "";
            this.txtMaPT.UnderlinedStyle = false;
            // 
            // frmSuaPThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 810);
            this.Controls.Add(this.pnlCTPhieuThu);
            this.Controls.Add(this.pnlPhieuThu);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuaPThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaPThu";
            this.pnlCTPhieuThu.ResumeLayout(false);
            this.pnlCTPhieuThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlPhieuThu.ResumeLayout(false);
            this.pnlPhieuThu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn maDV;
        private System.Windows.Forms.ComboBox cmbMaKT;
        private System.Windows.Forms.ComboBox cmbMaPT;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.Label lblChiTiet;
        private RJControls.RJTextBox txtMaKT;
        private System.Windows.Forms.Label lblHoTen;
        private RJControls.RJTextBox txtNgayThu;
        private RJButton btnCapNhatPThu;
        private RJControls.RJTextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private RJControls.RJTextBox rjTextBox2;
        private System.Windows.Forms.Label label2;
        private RJControls.RJTextBox txtMaThu;
        private RJButton btnThoat;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private RJControls.RJTextBox txtMaPT;
        private System.Windows.Forms.ToolStripMenuItem xoaHangToolStripMenuItem;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.ComboBox cmbMaDV;
        private RJButton btnThemCTPT;
        private System.Windows.Forms.Panel pnlCTPhieuThu;
        private System.Windows.Forms.DataGridView dgvCTDV;
        private System.Windows.Forms.Label lblMaKT;
        private System.Windows.Forms.Label lblThongTinPT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlPhieuThu;
        private System.Windows.Forms.Label lblMaPThu;
    }
}