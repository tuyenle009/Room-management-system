using BLL;
using DTO;
using QuanLyPhongTro_10122399.Folder_PhongTro;
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

namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    public partial class frmPhieuThu : Form
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
        public frmPhieuThu()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            //hien thi tren gridview
            cmbTimKiem.SelectedIndex = 0;
        }
        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            HienThiDSPThu();
        }
        PhieuThuBLL ptbll = new PhieuThuBLL();
        //hien thi ds phieu thu
       public void HienThiDSPThu()
       {

            dgvDSPT.Rows.Clear();
            List<PhieuThu> ds = ptbll.hienThiDSPT();
            foreach (PhieuThu item in ds)
            {
                dgvDSPT.Rows.Add(item.MaThu, item.MaPT, item.MaKT, item.NgayThu,item.TongTien);
            }
        }
      
        private void dgvDSPT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDSPT.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string maThu = selectedRow.Cells["maThu"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string MaPT = selectedRow.Cells["MaPT"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string MaKT = selectedRow.Cells["MaKT"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string NgayThu = selectedRow.Cells["NgayThu"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi

             
                // Đặt giá trị của TextBox trên OtherForm là giá trị của ô được chọn
                frmSuaPThu suaPT = new frmSuaPThu();
                suaPT.capNhatGiaTriTextBox(maThu, MaPT, MaKT, NgayThu);
                suaPT.ShowDialog();
                HienThiDSPThu();

                // Hiển thị thông tin trong các TextBox đã chỉ định
            }
        }

        private void dgvDSPT_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
            {
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvDSPT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvDSPT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(229, 193, 195);
                //255 182 193
            }
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            frmThemPTu themPThu = new frmThemPTu();
            themPThu.ShowDialog();
            HienThiDSPThu();

        }

        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDSPT.SelectedRows;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này.","Xóa phiếu thu", MessageBoxButtons.YesNo,MessageBoxIcon.Question); ;
            if(result== DialogResult.Yes)
            foreach (DataGridViewRow row in hangChon)
            {
                // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                string maThu = row.Cells["maThu"].Value.ToString().Trim();
                // Thực hiện xử lý với giá trị trong hàng đã chọn
                ptbll.xoaPT(maThu);

            }
            HienThiDSPThu();
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            dgvDSPT.Rows.Clear();//xóa các hàng trong grid view

            int luaChon = 1;
            if (cmbTimKiem.Text == "Gần đúng")
                luaChon = 2;
            List<PhieuThu> ds = ptbll.timKiemPThu(luaChon.ToString(), txtTimKiem.Texts.Trim()); //khởi tạo ds để duyệt vào grid
            foreach (PhieuThu item in ds)
            {
                dgvDSPT.Rows.Add(item.MaThu, item.MaKT, item.MaPT, item.NgayThu,item.TongTien);
            }
        }
    }
}
