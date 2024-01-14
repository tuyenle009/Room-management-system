using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro_10122399.Folder_HopDong
{
    public partial class frmThemHD : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );
        public frmThemHD()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            cmbTinhTrang.SelectedIndex = 0; //chọn mặc định item đầu tiên

        }
        HopDongBLL hdbll = new HopDongBLL();
        public void capNhatGiaTriTextBox()
        {
            //thêm giá trị vào cmb khách trọ 
            cmbMaKT.Items.Clear();
            foreach (string item in hdbll.dsKhachTro())
            {
                cmbMaKT.Items.Add(item.Trim());
            }
            //thêm giá trị vào cmb phòng trọ 
            cmbMaPT.Items.Clear();
            foreach (string item in hdbll.dsPhongTro())
            {
                cmbMaPT.Items.Add(item.Trim());
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            HopDong hd = new HopDong();
            if (txtMaHD.Texts.Trim().Length == 0 || cmbMaKT.SelectedIndex == -1 || cmbMaPT.SelectedIndex == -1
                            || !float.TryParse(txtTienCoc.Texts, out _) 
                            || cmbTinhTrang.SelectedIndex == -1)
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                hd.MaHD = txtMaHD.Texts.Trim();
                hd.MaKT = cmbMaKT.SelectedItem.ToString().Trim();
                hd.MaPT = cmbMaPT.SelectedItem.ToString().Trim();
                hd.NgayThue = dtpNgayThue.Value.ToString("yyyy/MM/dd").Trim();
                hd.NgayTra = dtpNgayTra.Value.ToString("yyyy/MM/dd").Trim();
                hd.TienCoc = txtTienCoc.Texts.Trim();
                hd.TinhTrang = cmbTinhTrang.SelectedItem.ToString().Trim();
                //nếu ngày trả < ngày hiện tại ==> false
                if (dtpNgayTra.Value < DateTime.Now)
                    hd.TinhTrang = "FALSE";
                HopDongBLL themHD = new HopDongBLL();
                string str = "";
                bool kiemTra = themHD.kiemTraHD(hd,out str);
                if (kiemTra)
                {
                    themHD.themHopDong(hd);
                    str = "Thêm hợp đồng thành công!";
                }
                MessageBox.Show(str, "Thêm hợp đồng", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
