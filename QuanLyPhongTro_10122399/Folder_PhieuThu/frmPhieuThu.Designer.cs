namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    partial class frmPhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThu));
            this.grbDanhSachPT = new System.Windows.Forms.GroupBox();
            this.dgvDSPT = new System.Windows.Forms.DataGridView();
            this.maThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.cmbTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaPT = new QuanLyPhongTro_10122399.RJButton();
            this.rjButton2 = new QuanLyPhongTro_10122399.RJButton();
            this.txtTimKiem = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnThemPT = new QuanLyPhongTro_10122399.RJButton();
            this.grbDanhSachPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDanhSachPT
            // 
            this.grbDanhSachPT.Controls.Add(this.dgvDSPT);
            this.grbDanhSachPT.Location = new System.Drawing.Point(42, 235);
            this.grbDanhSachPT.Name = "grbDanhSachPT";
            this.grbDanhSachPT.Size = new System.Drawing.Size(1156, 493);
            this.grbDanhSachPT.TabIndex = 20;
            this.grbDanhSachPT.TabStop = false;
            // 
            // dgvDSPT
            // 
            this.dgvDSPT.AllowUserToAddRows = false;
            this.dgvDSPT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThu,
            this.maPT,
            this.maKT,
            this.ngayThu,
            this.tongTien});
            this.dgvDSPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPT.Location = new System.Drawing.Point(3, 28);
            this.dgvDSPT.Name = "dgvDSPT";
            this.dgvDSPT.ReadOnly = true;
            this.dgvDSPT.RowHeadersWidth = 51;
            this.dgvDSPT.RowTemplate.Height = 40;
            this.dgvDSPT.Size = new System.Drawing.Size(1150, 462);
            this.dgvDSPT.TabIndex = 0;
            this.dgvDSPT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPT_CellDoubleClick);
            this.dgvDSPT.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDSPT_RowPrePaint);
            // 
            // maThu
            // 
            this.maThu.DataPropertyName = "maThu";
            this.maThu.HeaderText = "Mã phiếu thu";
            this.maThu.MinimumWidth = 6;
            this.maThu.Name = "maThu";
            this.maThu.ReadOnly = true;
            this.maThu.Width = 250;
            // 
            // maPT
            // 
            this.maPT.DataPropertyName = "maPT";
            this.maPT.HeaderText = "Mã Phòng trọ";
            this.maPT.MinimumWidth = 6;
            this.maPT.Name = "maPT";
            this.maPT.ReadOnly = true;
            this.maPT.Width = 250;
            // 
            // maKT
            // 
            this.maKT.DataPropertyName = "maKT";
            this.maKT.HeaderText = "Mã khách trọ";
            this.maKT.MinimumWidth = 6;
            this.maKT.Name = "maKT";
            this.maKT.ReadOnly = true;
            this.maKT.Width = 200;
            // 
            // ngayThu
            // 
            this.ngayThu.DataPropertyName = "ngayThu";
            this.ngayThu.HeaderText = "Ngày thu";
            this.ngayThu.MinimumWidth = 6;
            this.ngayThu.Name = "ngayThu";
            this.ngayThu.ReadOnly = true;
            this.ngayThu.Width = 200;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            this.tongTien.Width = 150;
            // 
            // picTimKiem
            // 
            this.picTimKiem.BackColor = System.Drawing.Color.White;
            this.picTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("picTimKiem.Image")));
            this.picTimKiem.Location = new System.Drawing.Point(645, 156);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(35, 42);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiem.TabIndex = 25;
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
            "Mã HD",
            "Gần đúng"});
            this.cmbTimKiem.Location = new System.Drawing.Point(58, 155);
            this.cmbTimKiem.Name = "cmbTimKiem";
            this.cmbTimKiem.Size = new System.Drawing.Size(158, 42);
            this.cmbTimKiem.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide07 IcielCadena", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "PHIẾU THU";
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
            this.btnXoaPT.Location = new System.Drawing.Point(982, 142);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(213, 63);
            this.btnXoaPT.TabIndex = 23;
            this.btnXoaPT.Text = "Xóa phiếu thu";
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
            this.rjButton2.Location = new System.Drawing.Point(42, 121);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(188, 84);
            this.rjButton2.TabIndex = 24;
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
            this.txtTimKiem.Location = new System.Drawing.Point(293, 149);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(405, 56);
            this.txtTimKiem.TabIndex = 21;
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
            this.btnThemPT.Location = new System.Drawing.Point(741, 142);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(213, 63);
            this.btnThemPT.TabIndex = 22;
            this.btnThemPT.Text = "Thêm phiếu thu";
            this.btnThemPT.TextColor = System.Drawing.Color.White;
            this.btnThemPT.UseVisualStyleBackColor = false;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // frmPhieuThu
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
            this.Name = "frmPhieuThu";
            this.Text = "frmPhieuThu";
            this.Load += new System.EventHandler(this.frmPhieuThu_Load);
            this.grbDanhSachPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachPT;
        private System.Windows.Forms.DataGridView dgvDSPT;
        private System.Windows.Forms.PictureBox picTimKiem;
        private RJButton btnXoaPT;
        private System.Windows.Forms.ComboBox cmbTimKiem;
        private RJButton rjButton2;
        private RJControls.RJTextBox txtTimKiem;
        private RJButton btnThemPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
    }
}