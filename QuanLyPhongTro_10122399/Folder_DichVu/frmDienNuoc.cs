using BLL;
using DTO;
using QuanLyPhongTro_10122399.Folder_HopDong;
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
    public partial class frmDienNuoc : Form
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
        DichVuBLL dvBLL = new DichVuBLL();

        public frmDienNuoc()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //hien thi
            HienThiDVDN();

            //them mapt vào cmbbox
            cmbMaPT.Items.Clear();
            foreach (string item in dvBLL.dsPhongTro())
            {
                cmbMaPT.Items.Add(item.Trim());
            }

        }

        public void HienThiDVDN()
        {
            dgvDVDN.Rows.Clear();
            List<DichVuDienNuoc> ds = dvBLL.hienThiDSDienNuoc();
            foreach (DichVuDienNuoc item in ds)
            {
                dgvDVDN.Rows.Add(item.MaDN, item.MaPT, item.TuNgay, item.ToiNgay, item.ChiSoCu, item.ChiSoMoi, item.DonGia,item.ThanhTien);
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDVDN.SelectedRows;
            //HopDongBLL hdbll = new HopDongBLL();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không!", "Xóa dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in hangChon)
                {
                    // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                    string maDV = row.Cells["maDN"].Value.ToString();
                    // Thực hiện xử lý với giá trị trong hàng đã chọn
                    if (!dvBLL.xoaDienNuoc(maDV)) //xóa không thành công
                    {
                        MessageBox.Show($"xóa dịch vụ {maDV.Trim()} không thành công!", "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                hienThiDLTgian();
            }
        }

        private void dgvDVDN_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvDVDN.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvDVDN.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(229, 193, 195);
                //255 182 193
        }

        private void dgvDVDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDVDN.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                txtMaDV.Texts = selectedRow.Cells["MaDN"].Value.ToString().Trim();
                cmbMaPT.SelectedItem = selectedRow.Cells["MaPT"].Value.ToString().Trim();

                //ep kieu 
                DateTime TuNgay = DateTime.ParseExact(selectedRow.Cells["TuNgay"].Value.ToString().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime ToiNgay = DateTime.ParseExact(selectedRow.Cells["ToiNgay"].Value.ToString().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                
                dtpTuNgay.Value = TuNgay;
                dtpToiNgay.Value = ToiNgay;
                txtChiSoCu.Texts= selectedRow.Cells["ChiSoCu"].Value.ToString().Trim();
                txtChiSoMoi.Texts = selectedRow.Cells["ChiSoMoi"].Value.ToString().Trim();
                txtDonGia.Texts = selectedRow.Cells["DonGia"].Value.ToString().Trim();
                
                // Hiển thị thông tin trong các TextBox đã chỉ định
            }
        }
        //kiểm tra các thông tin nhập đúng chưa trả về true false
        private bool kiemTraDVDN()
        {
            if (txtMaDV.Texts.Trim().Length == 0 || cmbMaPT.SelectedIndex == -1 || !double.TryParse(txtDonGia.Texts.Trim(), out _)
                || !int.TryParse(txtChiSoMoi.Texts.Trim(), out _) || !int.TryParse(txtChiSoCu.Texts.Trim(), out _))
            {
                MessageBox.Show("Vui lòng nhập đủ và đúng thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (int.Parse(txtChiSoCu.Texts) > int.Parse(txtChiSoMoi.Texts))
            {
                MessageBox.Show("Chỉ số cũ không được lớn hơn chỉ số mới", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(dtpTuNgay.Value> dtpToiNgay.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        //them dv
        private void btnThemDV_Click(object sender, EventArgs e)
        {

           
            if(kiemTraDVDN())
            {
                DichVuDienNuoc dichVu = new DichVuDienNuoc();
                dichVu.MaDN = txtMaDV.Texts.Trim();
                dichVu.MaPT = cmbMaPT.SelectedItem.ToString();
                dichVu.TuNgay = dtpTuNgay.Value.ToString("MM/dd/yyyy").Trim();
                dichVu.ToiNgay = dtpToiNgay.Value.ToString("MM/dd/yyyy").Trim();
                dichVu.ChiSoCu = txtChiSoCu.Texts.Trim();
                dichVu.ChiSoMoi = txtChiSoMoi.Texts.Trim();
                dichVu.DonGia = txtDonGia.Texts.Trim();

                string str = "";
                bool kiemTra = dvBLL.kiemTraDVDN(dichVu,out str); // Kiểm tra xem mã dịch vụ đã tồn tại hay chưa
                if (kiemTra)
                {
                    dvBLL.themDienNuoc(dichVu); // Thêm dịch vụ điện nước
                    str = "Thêm dịch vụ điện nước thành công!";
                    hienThiDLTgian();
                }
                MessageBox.Show(str, "Thêm dịch vụ điện nước", MessageBoxButtons.OK);
            }
        }
        public void hienThiDLTgian()
        {
            dgvDVDN.Rows.Clear();
            List<DichVuDienNuoc> ds = dvBLL.DSDienNuocThang(int.Parse(dtpThangNam.Text.Split('/')[0]), int.Parse(dtpThangNam.Text.Split('/')[1]));
            foreach (DichVuDienNuoc item in ds)
            {
                dgvDVDN.Rows.Add(item.MaDN, item.MaPT, item.TuNgay, item.ToiNgay, item.ChiSoCu, item.ChiSoMoi, item.DonGia, item.ThanhTien);
            }
        }
        //cap nhat dv
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (kiemTraDVDN())
            {
                DichVuDienNuoc dichVu = new DichVuDienNuoc();
                dichVu.MaDN = txtMaDV.Texts.Trim(); //khong duoc cap nhat
                dichVu.MaPT = cmbMaPT.SelectedItem.ToString();
                dichVu.TuNgay = dtpTuNgay.Value.ToString("MM/dd/yyyy").Trim();
                dichVu.ToiNgay = dtpToiNgay.Value.ToString("MM/dd/yyyy").Trim();
                dichVu.ChiSoCu = txtChiSoCu.Texts.Trim();
                dichVu.ChiSoMoi = txtChiSoMoi.Texts.Trim();
                dichVu.DonGia = txtDonGia.Texts.Trim();

                //string str = "";

                dvBLL.capNhatDienNuoc(dichVu); // Thêm dịch vụ điện nước
                //str = "cập nhật dịch vụ điện nước thành công!";
                //MessageBox.Show(str, "cập nhật dịch vụ điện nước", MessageBoxButtons.OK);
                hienThiDLTgian();

            }
        }
        
      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            hienThiDLTgian();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            dgvDVDN.Rows.Clear();
            HienThiDVDN();
        }

        private void btnLayDL_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dtpThangNam.Text.Split('/')[0].ToString() + dtpThangNam.Text.Split('/')[01].ToString());
            dvBLL.layDLThangTruoc(int.Parse(dtpThangNam.Text.Split('/')[0]), int.Parse(dtpThangNam.Text.Split('/')[01]));
            hienThiDLTgian();
        }
    }
}
