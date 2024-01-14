using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QuanLyPhongTro_10122399.Folder_TrangChu;
using QuanLyPhongTro_10122399.Folder_PhongTro;
using QuanLyPhongTro_10122399.Folder_HopDong;

namespace QuanLyPhongTro_10122399
{
    public partial class frmTrangChu : Form
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
        public frmTrangChu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            //show form trang chu
            //hien thi frm trang chu
            frmTrangChu2 frmTrangChu = new frmTrangChu2();
            frmTrangChu.TopLevel = false;
            frmTrangChu.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmTrangChu.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmTrangChu);
            frmTrangChu.Show();
            //ẩn panel chứa phiếu chi và thiết bị
            //customizeDesign();
            //------------------------------
            //panelSub.Dock = DockStyle.Top;
            //btnKhachTro.Dock = DockStyle.Top; // hoặc DockStyle.Bottom, DockStyle.Left, DockStyle.Right
            //btnHopDong.Dock = DockStyle.Top; // Thiết lập Dock cho từng button trong panel
            //btnThongKe.Dock = DockStyle.Top;

            //pnlDock.Controls.Add(panelSub); // Thêm controls vào panel theo thứ tự mong muốn
            //pnlDock.Controls.Add(btnKhachTro); // Thêm controls vào panel theo thứ tự mong muốn
            //pnlDock.Controls.Add(btnHopDong);
            //pnlDock.Controls.Add(btnThongKe);

        }
        //private void customizeDesign()
        //{
        //    panel3.Visible = false;
        //}
        //private void hideSubmenu()
        //{
        //    if (panel3.Visible == true)
        //    {
        //        panel3.Visible = false;
        //    }
        //}
        //private void showSubmenu(Panel submenu)
        //{
        //    if (submenu.Visible == false)
        //    {
        //        hideSubmenu();
        //        submenu.Visible = true;
        //    }
        //    else
        //        submenu.Visible = false;
        //}

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Button
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            panel_slide.Height = btnTrangChu.Height;

            panel_slide.Top = btnTrangChu.Top;
            //btnTrangChu.BackColor = Color.FromArgb(255, 181, 197);
            btnTrangChu.BackColor = Color.FromArgb(249, 173, 192);
            panel_main.Controls.Clear();

            //249, 173, 192
            //hien thi frm trang chu
            frmTrangChu2 frmTrangChu = new frmTrangChu2();
            frmTrangChu.TopLevel = false;
            frmTrangChu.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmTrangChu.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmTrangChu);
            frmTrangChu.Show();

        }


        private void btnPhong_Click(object sender, EventArgs e)
        {
            panel_slide.Height = btnPhong.Height;
            panel_slide.Top = btnPhong.Top;
            //btnTrangChu.BackColor = Color.FromArgb(255, 181, 197);
            btnPhong.BackColor = Color.FromArgb(249,173,192);

            panel_main.Controls.Clear();//xoa panel hien co
            frmPhongTro frmPT = new frmPhongTro();
            frmPT.TopLevel = false;
            frmPT.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmPT.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmPT);

            frmPT.Show();


            //showSubmenu(panel3);
        }

        private void btnKhachTro_Click(object sender, EventArgs e)
        {
            btnKhachTro.BackColor = Color.FromArgb(249,173,192);//doi mau cho lable

            panel_slide.Height = btnKhachTro.Height;//chuyen thanh cong cu xuong
            panel_slide.Top = btnKhachTro.Top;

            panel_main.Controls.Clear();//xoa panel hien co
            frmKhachTro1 frmKT = new frmKhachTro1();
            frmKT.TopLevel = false;
            frmKT.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmKT.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmKT);

            frmKT.Show();

        }
        private void btnHopDong_Click(object sender, EventArgs e)
        {
            btnHopDong.BackColor = Color.FromArgb(249,173,192);//doi mau cho lable

            panel_slide.Height = btnHopDong.Height;//chuyen thanh cong cu xuong
            panel_slide.Top = btnHopDong.Top;


            panel_main.Controls.Clear();//xoa panel hien co
            frmHopDong frmHD = new frmHopDong();
            frmHD.TopLevel = false;
            frmHD.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmHD.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmHD);
            frmHD.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.FromArgb(249,173,192);//doi mau cho lable

            panel_slide.Height = btnThongKe.Height;//chuyen thanh cong cu xuong
            panel_slide.Top = btnThongKe.Top;
        }

        private void firstCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            panel_slide.Height = btnDangXuat.Height;//chuyen thanh cong cu xuong
            panel_slide.Top = btnDangXuat.Top;


            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.ShowDialog();
                //btnTrangChu.BackColor = Color.FromArgb(255, 181, 197);
                //34, 34, 34
                this.Close();
            }
        }


        //Button Leave
        private void btnTrangChu_Leave(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.FromArgb(23, 24, 29);
            //34, 34, 34

        }

        private void btnPhong_Leave(object sender, EventArgs e)
        {
            btnPhong.BackColor = Color.FromArgb(23, 24, 29);
        }

        private void btnKhachTro_Leave(object sender, EventArgs e)
        {
            btnKhachTro.BackColor = Color.FromArgb(23, 24, 29);

        }

        private void btnHopDong_Leave(object sender, EventArgs e)
        {
            btnHopDong.BackColor = Color.FromArgb(23, 24, 29);

        }

        private void btnThongKe_Leave(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.FromArgb(23, 24, 29);

        }

        private void picThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {

        }
    }
}
