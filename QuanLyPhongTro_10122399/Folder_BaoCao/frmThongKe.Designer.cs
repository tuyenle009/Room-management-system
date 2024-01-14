namespace QuanLyPhongTro_10122399.Folder_BaoCao
{
    partial class frmThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSPT = new System.Windows.Forms.DataGridView();
            this.thongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoDien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongKeDV = new System.Windows.Forms.DataGridView();
            this.maThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienDN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienDV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienThu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvThongKeTong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSuDung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.rjButton3 = new QuanLyPhongTro_10122399.RJButton();
            this.btnTimKiem = new QuanLyPhongTro_10122399.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoDien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeTong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide07 IcielCadena", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÁO CÁO TỔNG HỢP";
            // 
            // dgvDSPT
            // 
            this.dgvDSPT.AllowUserToAddRows = false;
            this.dgvDSPT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thongTin,
            this.soLuong});
            this.dgvDSPT.Location = new System.Drawing.Point(21, 85);
            this.dgvDSPT.Name = "dgvDSPT";
            this.dgvDSPT.ReadOnly = true;
            this.dgvDSPT.RowHeadersWidth = 51;
            this.dgvDSPT.RowTemplate.Height = 40;
            this.dgvDSPT.Size = new System.Drawing.Size(367, 177);
            this.dgvDSPT.TabIndex = 105;
            this.dgvDSPT.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDSPT_CellPainting);
            // 
            // thongTin
            // 
            this.thongTin.DataPropertyName = "thongTin";
            this.thongTin.HeaderText = "Thông tin";
            this.thongTin.MinimumWidth = 6;
            this.thongTin.Name = "thongTin";
            this.thongTin.ReadOnly = true;
            this.thongTin.Width = 175;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 130;
            // 
            // dgvSoDien
            // 
            this.dgvSoDien.AllowUserToAddRows = false;
            this.dgvSoDien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoDien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSoDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.luongTieuThu});
            this.dgvSoDien.Location = new System.Drawing.Point(394, 85);
            this.dgvSoDien.Name = "dgvSoDien";
            this.dgvSoDien.ReadOnly = true;
            this.dgvSoDien.RowHeadersWidth = 51;
            this.dgvSoDien.RowTemplate.Height = 40;
            this.dgvSoDien.Size = new System.Drawing.Size(443, 177);
            this.dgvSoDien.TabIndex = 112;
            this.dgvSoDien.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSoDien_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "thongTin";
            this.dataGridViewTextBoxColumn1.HeaderText = "Thông tin";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // luongTieuThu
            // 
            this.luongTieuThu.DataPropertyName = "luongTieuThu";
            this.luongTieuThu.HeaderText = "Lượng tiêu thụ";
            this.luongTieuThu.MinimumWidth = 6;
            this.luongTieuThu.Name = "luongTieuThu";
            this.luongTieuThu.ReadOnly = true;
            this.luongTieuThu.Width = 190;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThongKeDV);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 454);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            // 
            // dgvThongKeDV
            // 
            this.dgvThongKeDV.AllowUserToAddRows = false;
            this.dgvThongKeDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThongKeDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThu,
            this.MaPT2,
            this.NgayThu,
            this.GiaPhong2,
            this.TongTienDN2,
            this.TongTienDV2,
            this.TongTienThu2});
            this.dgvThongKeDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeDV.Location = new System.Drawing.Point(3, 28);
            this.dgvThongKeDV.Name = "dgvThongKeDV";
            this.dgvThongKeDV.ReadOnly = true;
            this.dgvThongKeDV.RowHeadersWidth = 51;
            this.dgvThongKeDV.RowTemplate.Height = 40;
            this.dgvThongKeDV.Size = new System.Drawing.Size(858, 423);
            this.dgvThongKeDV.TabIndex = 115;
            this.dgvThongKeDV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvThongKeDV_CellPainting);
            // 
            // maThu
            // 
            this.maThu.DataPropertyName = "maThu";
            this.maThu.HeaderText = "Mã thu";
            this.maThu.MinimumWidth = 6;
            this.maThu.Name = "maThu";
            this.maThu.ReadOnly = true;
            this.maThu.Width = 90;
            // 
            // MaPT2
            // 
            this.MaPT2.DataPropertyName = "MaPT2";
            this.MaPT2.HeaderText = "Mã phòng trọ";
            this.MaPT2.MinimumWidth = 6;
            this.MaPT2.Name = "MaPT2";
            this.MaPT2.ReadOnly = true;
            this.MaPT2.Width = 125;
            // 
            // NgayThu
            // 
            this.NgayThu.DataPropertyName = "NgayThu ";
            this.NgayThu.HeaderText = "Ngày thu";
            this.NgayThu.MinimumWidth = 6;
            this.NgayThu.Name = "NgayThu";
            this.NgayThu.ReadOnly = true;
            this.NgayThu.Width = 125;
            // 
            // GiaPhong2
            // 
            this.GiaPhong2.DataPropertyName = "GiaPhong2";
            this.GiaPhong2.HeaderText = "Giá phòng";
            this.GiaPhong2.MinimumWidth = 6;
            this.GiaPhong2.Name = "GiaPhong2";
            this.GiaPhong2.ReadOnly = true;
            this.GiaPhong2.Width = 125;
            // 
            // TongTienDN2
            // 
            this.TongTienDN2.DataPropertyName = "TongTienDN2";
            this.TongTienDN2.HeaderText = "Tổng tiền điện nước";
            this.TongTienDN2.MinimumWidth = 6;
            this.TongTienDN2.Name = "TongTienDN2";
            this.TongTienDN2.ReadOnly = true;
            this.TongTienDN2.Width = 125;
            // 
            // TongTienDV2
            // 
            this.TongTienDV2.DataPropertyName = "TongTienDV2";
            this.TongTienDV2.HeaderText = "Tổng tiền dịch vụ";
            this.TongTienDV2.MinimumWidth = 6;
            this.TongTienDV2.Name = "TongTienDV2";
            this.TongTienDV2.ReadOnly = true;
            this.TongTienDV2.Width = 125;
            // 
            // TongTienThu2
            // 
            this.TongTienThu2.DataPropertyName = "TongTienThu2";
            this.TongTienThu2.HeaderText = "Tổng tiền thu";
            this.TongTienThu2.MinimumWidth = 6;
            this.TongTienThu2.Name = "TongTienThu2";
            this.TongTienThu2.ReadOnly = true;
            this.TongTienThu2.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvThongKeTong);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(891, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 454);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            // 
            // dgvThongKeTong
            // 
            this.dgvThongKeTong.AllowUserToAddRows = false;
            this.dgvThongKeTong.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeTong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThongKeTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeTong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.giaSuDung2});
            this.dgvThongKeTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeTong.Location = new System.Drawing.Point(3, 28);
            this.dgvThongKeTong.Name = "dgvThongKeTong";
            this.dgvThongKeTong.ReadOnly = true;
            this.dgvThongKeTong.RowHeadersWidth = 51;
            this.dgvThongKeTong.RowTemplate.Height = 40;
            this.dgvThongKeTong.Size = new System.Drawing.Size(320, 423);
            this.dgvThongKeTong.TabIndex = 116;
            this.dgvThongKeTong.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvThongKeTong_CellPainting);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "thongTin";
            this.dataGridViewTextBoxColumn4.HeaderText = "Thông tin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // giaSuDung2
            // 
            this.giaSuDung2.DataPropertyName = "giaSuDung2";
            this.giaSuDung2.HeaderText = "Giá sử dụng";
            this.giaSuDung2.MinimumWidth = 6;
            this.giaSuDung2.Name = "giaSuDung2";
            this.giaSuDung2.ReadOnly = true;
            this.giaSuDung2.Width = 150;
            // 
            // cmbThang
            // 
            this.cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(1003, 138);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(156, 32);
            this.cmbThang.TabIndex = 120;
            this.cmbThang.SelectedIndexChanged += new System.EventHandler(this.cmbThang_SelectedIndexChanged);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(1003, 188);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(156, 32);
            this.txtNam.TabIndex = 119;
            this.txtNam.Text = "2024";
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Inter Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(895, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 118;
            this.label3.Text = "Năm:";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.BackColor = System.Drawing.Color.White;
            this.lblThang.Font = new System.Drawing.Font("Inter Medium", 14F, System.Drawing.FontStyle.Bold);
            this.lblThang.Location = new System.Drawing.Point(892, 141);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(93, 29);
            this.lblThang.TabIndex = 117;
            this.lblThang.Text = "Tháng:";
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
            this.rjButton3.Location = new System.Drawing.Point(862, 99);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(330, 153);
            this.rjButton3.TabIndex = 116;
            this.rjButton3.Text = "THÁNG/NĂM";
            this.rjButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton3.TextColor = System.Drawing.Color.Silver;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnTimKiem.BorderRadius = 30;
            this.btnTimKiem.BorderSize = 1;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(847, 86);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(362, 177);
            this.btnTimKiem.TabIndex = 115;
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1229, 757);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSoDien);
            this.Controls.Add(this.dgvDSPT);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoDien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeTong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSPT;
        private System.Windows.Forms.DataGridView dgvSoDien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvThongKeTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSuDung2;
        private System.Windows.Forms.DataGridView dgvThongKeDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienDN2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienDV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienThu2;
        private RJButton btnTimKiem;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblThang;
        private RJButton rjButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn thongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTieuThu;
    }
}