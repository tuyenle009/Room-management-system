using QuanLyPhongTro_10122399.Folder_BaoCao;
using QuanLyPhongTro_10122399.Folder_DichVu;
using QuanLyPhongTro_10122399.Folder_HopDong;
using QuanLyPhongTro_10122399.Folder_PhieuChi;
using QuanLyPhongTro_10122399.Folder_PhieuThu;
using QuanLyPhongTro_10122399.Folder_PhongTro;
using QuanLyPhongTro_10122399.Folder_TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro_10122399
{
    public partial class frmGiaoDien : Form
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
        public frmGiaoDien()
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
            //____________________
            customizeDesign();
        }
        private void customizeDesign()
        {
            pnlSub1.Visible = false;
        }
        private void hideSubmenu()
        {
            if (pnlSub1.Visible == true)
            {
                pnlSub1.Visible = false;
            }
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        //trang chu
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
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

        //btn phong tro
        private void btnPhong_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSub1);
            //btnTrangChu.BackColor = Color.FromArgb(255, 181, 197);
            btnPhong.BackColor = Color.FromArgb(249, 173, 192);

            panel_main.Controls.Clear();//xoa panel hien co
            frmPhongTro frmPT = new frmPhongTro();
            frmPT.TopLevel = false;
            frmPT.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmPT.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmPT);

            frmPT.Show();
        }
        //btn phieu thu
        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();//xoa panel hien co
            frmPhieuThu frmPT = new frmPhieuThu();
            frmPT.TopLevel = false;
            frmPT.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmPT.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmPT);
            frmPT.Show();
        }
        //btn phieu chi
        private void btnPhieuChi_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();//xoa panel hien co
            frmPhieuChi frmPC = new frmPhieuChi();
            frmPC.TopLevel = false;
            frmPC.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmPC.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmPC);
            frmPC.Show();
        }
        //Dich vu
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();//xoa panel hien co
            frmDichVu frmDV = new frmDichVu();
            frmDV.TopLevel = false;
            frmDV.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmDV.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmDV);
            frmDV.Show();
        }
        //btn khach tro
        private void btnKhachTro_Click(object sender, EventArgs e)
        {
            btnKhachTro.BackColor = Color.FromArgb(249, 173, 192);//doi mau cho lable
            panel_main.Controls.Clear();//xoa panel hien co
            frmKhachTro1 frmKT = new frmKhachTro1();
            frmKT.TopLevel = false;
            frmKT.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmKT.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmKT);

            frmKT.Show();
        }
        //btn hop dong
        private void btnHopDong_Click(object sender, EventArgs e)
        {
            btnHopDong.BackColor = Color.FromArgb(249, 173, 192);//doi mau cho lable

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
            btnThongKe.BackColor = Color.FromArgb(249, 173, 192);//doi mau cho lable

            panel_main.Controls.Clear();//xoa panel hien co
            frmThongKe frmTK = new frmThongKe();
            frmTK.TopLevel = false;
            frmTK.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmTK.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frmTK);
            frmTK.Show();
        }
        //dang xuat
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
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
       
        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void picThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //leave
        private void btnTrangChu_Leave(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.FromArgb(23, 24, 29);

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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pnlSub1_Paint(object sender, PaintEventArgs e)
        {

        }
      
       

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
