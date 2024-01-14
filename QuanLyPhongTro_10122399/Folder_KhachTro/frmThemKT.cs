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
using BLL;
using DTO;
using System.Data.SqlClient;




namespace QuanLyPhongTro_10122399
{
    public partial class frmThemKT : Form
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
        public frmThemKT()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            cmbGioiTinh.SelectedIndex = 0; //chọn mặc định item đầu tiên
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void txtMaKT__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachTro kt = new KhachTro();
            kt.MaKT = txtMaKT.Texts.Trim();
            kt.HoTen = txtHoTen.Texts.Trim();
            kt.CMND = txtCMND.Texts.Trim();
            kt.GioiTinh = cmbGioiTinh.Text.Trim();
            kt.DiaChi = txtDiaChi.Texts.Trim();
            kt.SDT = txtSDT.Texts.Trim();
            kt.NgheNghiep = txtNgheNghiep.Texts.Trim();
            KhachTroBLL themKT = new KhachTroBLL();
            bool kiemTra = themKT.kiemTraMaKT(kt);
            if (kiemTra)
            {
                themKT.themKhachTro(kt);
                MessageBox.Show("Thêm khách trọ thành công!","Thêm khách trọ",MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Mã khách trọ "+kt.MaKT+" đã tồn tại, vui lòng kiểm tra lại!", "Thêm khách trọ", MessageBoxButtons.OK);
            }
        }

        private void cmbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmThemKT_Load(object sender, EventArgs e)
        {

        }
    }
}
