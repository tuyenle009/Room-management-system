using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyPhongTro_10122399.Folder_KhachTro
{
    public partial class frmSuaKT : Form
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
        public frmSuaKT()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }
        KhachTroBLL ktBLL = new KhachTroBLL();

        public void capNhatGiaTriTextBox(string makt, string hoTen, string cmnd, string gioiTinh, string diaChi, string sdt, string ngheNghiep)
        {
            lblMaKTro.Text = makt;
            txtHoTen.Texts =hoTen;
            txtCMND.Texts =cmnd;
            cmbGioiTinh.SelectedIndex = 1; //mặc định là nữ
            cmbGioiTinh.Text = gioiTinh;
            txtDiaChi.Texts =diaChi;
            txtSDT.Texts =sdt;
            txtNgheNghiep.Texts =ngheNghiep;

        }

        private void txtMaKT__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn chắc chắn muốn cập nhật?","Cập nhật khách trọ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(re == DialogResult.Yes)
            {
                KhachTro kt = new KhachTro();
                kt.MaKT = lblMaKTro.Text;
                kt.HoTen = txtHoTen.Texts;
                kt.CMND = txtCMND.Texts;
                kt.GioiTinh = cmbGioiTinh.Text;
                kt.DiaChi = txtDiaChi.Texts;
                kt.SDT = txtSDT.Texts;
                kt.NgheNghiep = txtNgheNghiep.Texts;
                ktBLL.capNhatKT(kt);
                this.Close();
            }
        }
    }
}
