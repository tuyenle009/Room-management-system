using QuanLyPhongTro_10122399.Folder_PhongTro;
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

namespace QuanLyPhongTro_10122399.Folder_DichVu
{
    public partial class frmDichVu : Form
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
        public frmDichVu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btnDVDienNuoc_Click(object sender, EventArgs e)
        {
            pnlDSDV.Controls.Clear();//xoa panel hien co
            frmDienNuoc frmDN = new frmDienNuoc();
            frmDN.TopLevel = false;
            frmDN.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmDN.FormBorderStyle = FormBorderStyle.None;
            pnlDSDV.Controls.Add(frmDN);

            frmDN.Show();
        }

        private void btnDVKhac_Click(object sender, EventArgs e)
        {
            pnlDSDV.Controls.Clear();//xoa panel hien co
            frmDichVuKhac frmDV = new frmDichVuKhac();
            frmDV.TopLevel = false;
            frmDV.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmDV.FormBorderStyle = FormBorderStyle.None;
            pnlDSDV.Controls.Add(frmDV);

            frmDV.Show();
        }
    }
}
