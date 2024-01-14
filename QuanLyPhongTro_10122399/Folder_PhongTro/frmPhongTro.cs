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
using QuanLyPhongTro_10122399.Folder_PhongTro;

namespace QuanLyPhongTro_10122399.Folder_PhongTro
{
    public partial class frmPhongTro : Form
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
        public frmPhongTro()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void frmPhongTro_Load(object sender, EventArgs e)
        {
            HienThiDSPT();
            dgvDSPT.ReadOnly = true;
            cmbTimKiem.SelectedIndex = 0;
        }
        PhongTroBLL ptbll = new PhongTroBLL();

        public void HienThiDSPT()
        {
            dgvDSPT.Rows.Clear();
            List<PhongTro> ds = ptbll.hienThiDSPT();
            foreach (PhongTro item in ds)
            {
                dgvDSPT.Rows.Add(item.MaPT, item.TenPT, item.GiaPhong, item.SLToiDa,item.TinhTrang);
            }
        }
        public void HienThiDSPT_DT()
        {
            string query = "select * from PhongTro";
            dgvDSPT.DataSource = ptbll.HienThiDSPT_TB(query);
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
        //tim kiem
        private void picTimKiem_Click(object sender, EventArgs e)
        {
            dgvDSPT.Rows.Clear();//xóa các hàng trong grid view

            int luaChon = 1;
            if (cmbTimKiem.Text == "Gần đúng")
                luaChon = 2;
            List<PhongTro> ds = ptbll.timKiemPT(luaChon.ToString(), txtTimKiem.Texts.Trim()); //khởi tạo ds để duyệt vào grid
            foreach (PhongTro item in ds)
            {
                dgvDSPT.Rows.Add(item.MaPT, item.TenPT, item.GiaPhong, item.SLToiDa,item.TinhTrang);
            }
        }

        public void dgvDSPT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDSPT.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string maPT = selectedRow.Cells["maPT"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string tenPhong = selectedRow.Cells["tenPhong"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string giaPhong = selectedRow.Cells["giaPhong"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string slToiDa = selectedRow.Cells["slToiDa"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi

                byte[] b = null;
                foreach (PhongTro item in ptbll.hienThiDSPT())
                {
                    if (item.MaPT.Trim() == maPT)
                    {
                        b = item.HinhAnh;
                        break;
                    }

                }
                // Đặt giá trị của TextBox trên OtherForm là giá trị của ô được chọn
                frmSuaPT suaPT = new frmSuaPT();
                suaPT.capNhatGiaTriTextBox(maPT, tenPhong, giaPhong, slToiDa, b);
                suaPT.ShowDialog();
                HienThiDSPT();

                // Hiển thị thông tin trong các TextBox đã chỉ định
            }
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            frmThemPT themPT = new frmThemPT();
            themPT.ShowDialog();
            dgvDSPT.Rows.Clear();
            HienThiDSPT();
        }
        //xoa 1 hàng trong phòng trọ
        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDSPT.SelectedRows;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này.", "Xóa phiếu thu", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (result == DialogResult.Yes)
                foreach (DataGridViewRow row in hangChon)
                {
                    // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                    string maPT = row.Cells["maPT"].Value.ToString().Trim();
                    // Thực hiện xử lý với giá trị trong hàng đã chọn
                    if (!ptbll.xoaPhongTro(maPT)) //xóa không thành công
                    {
                        MessageBox.Show($"Phòng trọ {maPT} đã ký hợp đồng nên không thể xóa!", "Xóa khách trọ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            HienThiDSPT();
        }

        private void dgvDSPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
