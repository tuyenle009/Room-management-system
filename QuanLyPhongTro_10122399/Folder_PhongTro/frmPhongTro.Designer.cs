namespace QuanLyPhongTro_10122399.Folder_PhongTro
{
    partial class frmPhongTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongTro));
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachPT = new System.Windows.Forms.GroupBox();
            this.dgvDSPT = new System.Windows.Forms.DataGridView();
            this.maPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.cmbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnXoaPT = new QuanLyPhongTro_10122399.RJButton();
            this.rjButton2 = new QuanLyPhongTro_10122399.RJButton();
            this.txtTimKiem = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnThemPT = new QuanLyPhongTro_10122399.RJButton();
            this.grbDanhSachPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide07 IcielCadena", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHÒNG TRỌ";
            // 
            // grbDanhSachPT
            // 
            this.grbDanhSachPT.Controls.Add(this.dgvDSPT);
            this.grbDanhSachPT.Location = new System.Drawing.Point(40, 235);
            this.grbDanhSachPT.Name = "grbDanhSachPT";
            this.grbDanhSachPT.Size = new System.Drawing.Size(1156, 493);
            this.grbDanhSachPT.TabIndex = 12;
            this.grbDanhSachPT.TabStop = false;
            // 
            // dgvDSPT
            // 
            this.dgvDSPT.AllowUserToAddRows = false;
            this.dgvDSPT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPT,
            this.tenPhong,
            this.giaPhong,
            this.slToiDa,
            this.tinhTrang});
            this.dgvDSPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPT.Location = new System.Drawing.Point(3, 28);
            this.dgvDSPT.Name = "dgvDSPT";
            this.dgvDSPT.ReadOnly = true;
            this.dgvDSPT.RowHeadersWidth = 51;
            this.dgvDSPT.RowTemplate.Height = 40;
            this.dgvDSPT.Size = new System.Drawing.Size(1150, 462);
            this.dgvDSPT.TabIndex = 0;
            this.dgvDSPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPT_CellContentClick);
            this.dgvDSPT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPT_CellDoubleClick);
            this.dgvDSPT.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDSPT_RowPrePaint);
            // 
            // maPT
            // 
            this.maPT.DataPropertyName = "maPT";
            this.maPT.HeaderText = "Mã phòng trọ";
            this.maPT.MinimumWidth = 6;
            this.maPT.Name = "maPT";
            this.maPT.ReadOnly = true;
            this.maPT.Width = 250;
            // 
            // tenPhong
            // 
            this.tenPhong.DataPropertyName = "tenPhong";
            this.tenPhong.HeaderText = "Tên phòng";
            this.tenPhong.MinimumWidth = 6;
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.ReadOnly = true;
            this.tenPhong.Width = 250;
            // 
            // giaPhong
            // 
            this.giaPhong.DataPropertyName = "giaPhong";
            this.giaPhong.HeaderText = "Giá Phòng";
            this.giaPhong.MinimumWidth = 6;
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.ReadOnly = true;
            this.giaPhong.Width = 250;
            // 
            // slToiDa
            // 
            this.slToiDa.DataPropertyName = "slToiDa";
            this.slToiDa.HeaderText = "Số lượng tối đa";
            this.slToiDa.MinimumWidth = 6;
            this.slToiDa.Name = "slToiDa";
            this.slToiDa.ReadOnly = true;
            this.slToiDa.Width = 200;
            // 
            // tinhTrang
            // 
            this.tinhTrang.DataPropertyName = "tinhTrang";
            this.tinhTrang.HeaderText = "Tình Trạng";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.ReadOnly = true;
            this.tinhTrang.Width = 150;
            // 
            // picTimKiem
            // 
            this.picTimKiem.BackColor = System.Drawing.Color.White;
            this.picTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("picTimKiem.Image")));
            this.picTimKiem.Location = new System.Drawing.Point(643, 156);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(35, 42);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiem.TabIndex = 17;
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
            "Mã PT",
            "Gần đúng"});
            this.cmbTimKiem.Location = new System.Drawing.Point(56, 155);
            this.cmbTimKiem.Name = "cmbTimKiem";
            this.cmbTimKiem.Size = new System.Drawing.Size(158, 42);
            this.cmbTimKiem.TabIndex = 11;
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaPT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaPT.BorderRadius = 30;
            this.btnXoaPT.BorderSize = 1;
            this.btnXoaPT.FlatAppearance.BorderSize = 0;
            this.btnXoaPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPT.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnXoaPT.ForeColor = System.Drawing.Color.White;
            this.btnXoaPT.Location = new System.Drawing.Point(980, 142);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(213, 63);
            this.btnXoaPT.TabIndex = 15;
            this.btnXoaPT.Text = "Xóa phòng trọ";
            this.btnXoaPT.TextColor = System.Drawing.Color.White;
            this.btnXoaPT.UseVisualStyleBackColor = false;
            this.btnXoaPT.Click += new System.EventHandler(this.btnXoaPT_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.White;
            this.rjButton2.BackgroundColor = System.Drawing.Color.White;
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Silver;
            this.rjButton2.Location = new System.Drawing.Point(40, 121);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(188, 84);
            this.rjButton2.TabIndex = 16;
            this.rjButton2.Text = "Tìm kiếm";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton2.TextColor = System.Drawing.Color.Silver;
            this.rjButton2.UseVisualStyleBackColor = false;
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
            this.txtTimKiem.Location = new System.Drawing.Point(291, 149);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(405, 56);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            // 
            // btnThemPT
            // 
            this.btnThemPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemPT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemPT.BorderRadius = 30;
            this.btnThemPT.BorderSize = 1;
            this.btnThemPT.FlatAppearance.BorderSize = 0;
            this.btnThemPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPT.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThemPT.ForeColor = System.Drawing.Color.White;
            this.btnThemPT.Location = new System.Drawing.Point(739, 142);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(213, 63);
            this.btnThemPT.TabIndex = 14;
            this.btnThemPT.Text = "Thêm phòng trọ";
            this.btnThemPT.TextColor = System.Drawing.Color.White;
            this.btnThemPT.UseVisualStyleBackColor = false;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // frmPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1229, 757);
            this.Controls.Add(this.grbDanhSachPT);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.btnXoaPT);
            this.Controls.Add(this.cmbTimKiem);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThemPT);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhongTro";
            this.Text = "frmPhongTro";
            this.Load += new System.EventHandler(this.frmPhongTro_Load);
            this.grbDanhSachPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDanhSachPT;
        private System.Windows.Forms.DataGridView dgvDSPT;
        private System.Windows.Forms.PictureBox picTimKiem;
        private RJButton btnXoaPT;
        private System.Windows.Forms.ComboBox cmbTimKiem;
        private RJButton rjButton2;
        private RJControls.RJTextBox txtTimKiem;
        private RJButton btnThemPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn slToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
    }
}