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
using BLL;
using DTO;
using System.Data.SqlClient;
using QuanLyPhongTro_10122399.Folder_KhachTro;

namespace QuanLyPhongTro_10122399
{
    public partial class frmKhachTro1 : Form
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
        public frmKhachTro1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            cmbTimKiem.SelectedIndex = 0; 
           
        }

        private void frmKhachTro1_Load(object sender, EventArgs e)
        {
            HienThiDSKT();
            dgvDSKT.ReadOnly = true;


        }
        public void HienThiDSKT()
        {
            KhachTroBLL vtbll = new KhachTroBLL();
            dgvDSKT.Rows.Clear();
            List<KhachTro> ds = vtbll.hienThiDSVT();
            foreach (KhachTro item in ds)
            {
                //ListViewItem lvi = new ListViewItem(item.MaKT);
                //lvi.SubItems.Add(item.HoTen);
                //lvi.SubItems.Add(item.CMND);
                //lvi.SubItems.Add(item.GioiTinh);
                //lvi.SubItems.Add(item.DiaChi);
                //lvi.SubItems.Add(item.SDT);
                //lvi.SubItems.Add(item.NgheNghiep);
                dgvDSKT.Rows.Add(item.MaKT, item.HoTen, item.CMND, item.GioiTinh, item.DiaChi, item.SDT, item.NgheNghiep);
            }
        }

        private void dgvDSKT_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
            {
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvDSKT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvDSKT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(229, 193, 195);
                //255 182 193
            }
        }
        //Hien thi frm them kt
        private void btnThemKT_Click(object sender, EventArgs e)
        {
            frmThemKT themKT = new frmThemKT();
            themKT.ShowDialog();
            dgvDSKT.Rows.Clear();
            HienThiDSKT();
        }

        private void dgvDSKT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDSKT.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string makt = selectedRow.Cells["maKT"].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string hoTen = selectedRow.Cells["hoTen"].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string cmnd = selectedRow.Cells["cmnd"].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string gioiTinh = selectedRow.Cells["gioiTinh"].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string diaChi = selectedRow.Cells["diaChi"].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string sdt = selectedRow.Cells["sdt"].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string ngheNghiep = selectedRow.Cells["ngheNghiep"].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi

               
                // Đặt giá trị của TextBox trên OtherForm là giá trị của ô được chọn
                frmSuaKT suaKT = new frmSuaKT();
                suaKT.capNhatGiaTriTextBox(makt, hoTen, cmnd,gioiTinh,diaChi,sdt,ngheNghiep);

                suaKT.ShowDialog();
                HienThiDSKT();

                // Hiển thị thông tin trong các TextBox đã chỉ định
            }
        }
        //Tim kiem khach tro
        private void picTimKiem_Click(object sender, EventArgs e)
        {
            KhachTroBLL vtbll = new KhachTroBLL();
            dgvDSKT.Rows.Clear();//xóa các hàng trong grid view

            int luaChon = 1;
            if (cmbTimKiem.Text == "Gần đúng")
                luaChon = 2;
            List<KhachTro> ds = vtbll.timKiemKT(luaChon.ToString(), txtTimKiem.Texts.Trim()); //khởi tạo ds để duyệt vào grid
            foreach (KhachTro item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.MaKT);
                lvi.SubItems.Add(item.HoTen);
                lvi.SubItems.Add(item.CMND);
                lvi.SubItems.Add(item.GioiTinh);
                lvi.SubItems.Add(item.DiaChi);
                lvi.SubItems.Add(item.SDT);
                lvi.SubItems.Add(item.NgheNghiep);
                dgvDSKT.Rows.Add(item.MaKT, item.HoTen, item.CMND, item.GioiTinh, item.DiaChi, item.SDT, item.NgheNghiep);
            }
        }

        //Xóa khách trọ
        private void btnXoaKT_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDSKT.SelectedRows;
            KhachTroBLL vtbll = new KhachTroBLL();

            foreach (DataGridViewRow row in hangChon)
            {
                // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                string maKT = row.Cells["maKT"].Value.ToString();
                // Thực hiện xử lý với giá trị trong hàng đã chọn
                if (!vtbll.xoaKhachTro(maKT)) //xóa không thành công
                {
                    MessageBox.Show($"Khách trọ {maKT.Trim()} đã ký hợp đồng nên không thể xóa!", "Xóa khách trọ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            HienThiDSKT();
        }

        private void cmbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
