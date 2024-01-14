using BLL;
using DTO;
using QuanLyPhongTro_10122399.Folder_KhachTro;
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

namespace QuanLyPhongTro_10122399.Folder_HopDong
{
    public partial class frmHopDong : Form
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
        public frmHopDong()
        {
             InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //hien thi
            HienThiDSHD();
            dgvDSHD.ReadOnly = true;
            cmbTimKiem.SelectedIndex = 0;
        }
        HopDongBLL hdbll = new HopDongBLL();
        public void HienThiDSHD()
        {
            //HopDongBLL hdbll = new HopDongBLL();
            dgvDSHD.Rows.Clear();
            List<HopDong> ds = hdbll.hienThiDSHD();
            foreach (HopDong item in ds)
            {
                dgvDSHD.Rows.Add(item.MaHD, item.MaKT, item.MaPT, item.NgayThue, item.NgayTra, item.TienCoc, item.TinhTrang);
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDSHD.SelectedRows;
            //HopDongBLL hdbll = new HopDongBLL();

            if(MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này không!","Xóa hợp đồng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in hangChon)
                {
                    // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                    string maHD = row.Cells["maHD"].Value.ToString();
                    // Thực hiện xử lý với giá trị trong hàng đã chọn
                    if (!hdbll.xoaHopDong(maHD)) //xóa không thành công
                    {
                        MessageBox.Show($"xóa hợp đồng {maHD.Trim()} không thành công!", "Xóa hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                HienThiDSHD();
            }
            
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {

        }

        private void dgvDSHD_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
            {
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvDSHD.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvDSHD.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(229, 193, 195);
                //255 182 193
            }
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            dgvDSHD.Rows.Clear();//xóa các hàng trong grid view

            int luaChon = 1;
            if (cmbTimKiem.Text == "Gần đúng")
                luaChon = 2;
            List<HopDong> ds = hdbll.timKiemHD(luaChon.ToString(), txtTimKiem.Texts.Trim()); //khởi tạo ds để duyệt vào grid
            foreach (HopDong item in ds)
            {
                dgvDSHD.Rows.Add(item.MaHD, item.MaKT, item.MaPT, item.NgayThue, item.NgayTra, item.TienCoc, item.TinhTrang);
            }
        }

        private void dgvDSHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDSHD.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string maHD = selectedRow.Cells["maHD"].Value.ToString().Trim(); 
                string maKT = selectedRow.Cells["maKT"].Value.ToString().Trim(); 
                string maPT = selectedRow.Cells["maPT"].Value.ToString().Trim(); 
                string ngayThue = selectedRow.Cells["ngayThue"].Value.ToString().Trim(); 
                string ngayTra = selectedRow.Cells["ngayTra"].Value.ToString().Trim(); 
                string tienCoc = selectedRow.Cells["tienCoc"].Value.ToString().Trim(); 
                string tinhTrang = selectedRow.Cells["tinhTrang"].Value.ToString().Trim();


                // Đặt giá trị của TextBox trên OtherForm là giá trị của ô được chọn
                frmSuaHD suaHT = new frmSuaHD();
                suaHT.capNhatGiaTriTextBox(maHD, maKT, maPT, ngayThue, ngayTra, tienCoc, tinhTrang);
                suaHT.ShowDialog();
                HienThiDSHD();

                // Hiển thị thông tin trong các TextBox đã chỉ định
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            frmThemHD themHD = new frmThemHD();
            themHD.capNhatGiaTriTextBox();
            themHD.ShowDialog();
            dgvDSHD.Rows.Clear();
            HienThiDSHD();
        }

        private void cmbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
