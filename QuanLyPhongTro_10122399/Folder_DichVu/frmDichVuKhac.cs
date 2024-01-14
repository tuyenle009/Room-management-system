using BLL;
using DTO;
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

namespace QuanLyPhongTro_10122399.Folder_DichVu
{
    public partial class frmDichVuKhac : Form
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
        public frmDichVuKhac()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //hien thi
            HienThiDV();
            //
        }
        DichVuBLL dvBLL = new DichVuBLL();

        public void HienThiDV()
        {
            dgvDV.Rows.Clear();
            List<DichVu> ds = dvBLL.hienThiDSDV();
            foreach (DichVu item in ds)
            {
                dgvDV.Rows.Add(item.MaDV, item.TenDV, item.DonGia, item.DonViTinh);
            }
            //mac dinh la thang
            cmbDonViTinh.SelectedIndex= 0;
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDV.SelectedRows;
            //HopDongBLL hdbll = new HopDongBLL();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không!", "Xóa dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in hangChon)
                {
                    // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                    string maDV = row.Cells["maDV"].Value.ToString();
                    // Thực hiện xử lý với giá trị trong hàng đã chọn
                    if (!dvBLL.xoaDV(maDV)) //xóa không thành công
                    {
                        MessageBox.Show($"xóa dịch vụ {maDV.Trim()} không thành công!", "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                HienThiDV();
            }
        }

        private void dgvDV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvDV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvDV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(229, 193, 195);
            //255 182 193
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDV.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                txtMaDV.Texts = selectedRow.Cells["MaDV"].Value.ToString().Trim();
                txtTenDV.Texts = selectedRow.Cells["tenDV"].Value.ToString().Trim();
                txtDonGia.Texts = selectedRow.Cells["DonGia"].Value.ToString().Trim();
                cmbDonViTinh.SelectedItem = selectedRow.Cells["donViTinh"].Value.ToString().Trim();
            }
        }

        //kiểm tra dịch vụ đã chuẩn định dạng có thể thêm chưa
        private bool kiemTraDV()
        {
            if (txtMaDV.Texts.Trim().Length == 0 || txtTenDV.Texts.Trim().Length == 0 || !float.TryParse(txtDonGia.Texts, out _)
                )
            {
                MessageBox.Show("Vui lòng nhập đủ và đúng thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if(kiemTraDV())
            {
                DichVu dichVu = new DichVu(txtMaDV.Texts, txtTenDV.Texts, txtDonGia.Texts, cmbDonViTinh.SelectedItem.ToString());

                string str = "";
                bool kiemTra = dvBLL.kiemTraDV(dichVu, out str); // Kiểm tra xem mã dịch vụ đã tồn tại hay chưa
                if (kiemTra)
                {
                    dvBLL.themDV(dichVu); // Thêm dịch vụ điện nước
                    HienThiDV();
                }
                MessageBox.Show(str, "Thêm dịch vụ", MessageBoxButtons.OK);
            }
            
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kiemTraDV())
            {
                DichVu dichVu = new DichVu(txtMaDV.Texts, txtTenDV.Texts, txtDonGia.Texts, cmbDonViTinh.SelectedItem.ToString());
                dvBLL.capNhatDV(dichVu); // Kiểm tra xem mã dịch vụ đã tồn tại hay chưa
                HienThiDV();

            }
        }
        private void frmDichVuKhac_Load(object sender, EventArgs e)
        {
            
        }


     
       
    }
}
