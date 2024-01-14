using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace QuanLyPhongTro_10122399
{
    public partial class frmDangKy : Form
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
        public frmDangKy()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }
        public bool checkAccount(string ac) //check mk va ten tk
        {
            return Regex.IsMatch(ac,"^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)//check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com$");
        }
        Modify modify = new Modify();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
                //nút đki bị ẩn mất nên không dùng
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string tenTk = txtTenTK.Text;
            string matKhau = txtMK.Text;
            string xacNhanMk = txtXacNhanMK.Text;
            string email = txtEmail.Text;
            if (!checkAccount(tenTk))
            { MessageBox.Show("Vui lòng nhập tên tài khoản 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (!checkAccount(matKhau))
            { MessageBox.Show("Vui lòng nhập tên mật khẩu 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (xacNhanMk != matKhau)
            { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if (!checkEmail(email))
            { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }

            if (modify.lstTaiKhoan("select * from TaiKhoan where Email ='" + email + "'").Count != 0)
            { MessageBox.Show("Email này được đăng kí, vui lòng đăng kí email khác"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tenTk + "','" + matKhau + "','" + email + "')";
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
                modify.Command(query);

            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, Vui lòng đăng ký tên tài khoản khác!");
            }
        }
    }
}
