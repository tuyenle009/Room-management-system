using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro_10122399
{
    public partial class frmDangNhap : Form
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
        public frmDangNhap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }

        private void llblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau quenMK = new frmQuenMatKhau();
            quenMK.ShowDialog();
        }

        private void llblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy dangKy= new frmDangKy();
            dangKy.ShowDialog();
        }
        Modify modify = new Modify();
       
        private void btnDangNhap1_Click(object sender, EventArgs e)
        {
            string tenTK = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if (tenTK.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); return; } //return ko chạy code dưới
            else if (matKhau.Trim() == "") { MessageBox.Show("Vui lòng nhập tên mật khẩu!"); return; }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan ='" + tenTK + "' and MatKhau = '" + matKhau + "'";
                if (modify.lstTaiKhoan(query).Count > 0)//kiem tra list co tk khong
                {
                    //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmGiaoDien home = new frmGiaoDien();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
