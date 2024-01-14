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

namespace QuanLyPhongTro_10122399.Folder_PhieuChi
{
    public partial class frmPhieuChi : Form
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
        public frmPhieuChi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //show len dgv
            HienThiPC();
            //them mapt vào cmbbox
            cmbMaPT.Items.Clear();
            foreach (string item in pcBLL.dsPhongTro())
            {
                cmbMaPT.Items.Add(item.Trim());
            }
           
            //tim kiem 
            cmbTimKiem.SelectedIndex = 0;
            cmbMaPT.SelectedIndex = 0;
        }
        PhieuChiBLL pcBLL = new PhieuChiBLL();

        public void HienThiPC()
        {
            dgvDSPC.Rows.Clear();
            List<PhieuChi> ds = pcBLL.hienThiDSPC();
            foreach (PhieuChi item in ds)
            {
                dgvDSPC.Rows.Add(item.MaPC, item.MaPT, item.NgayChi, item.SoTien, item.LyDo);
            }
        }
        //xoa
        private void btnXoaPC_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDSPC.SelectedRows;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu chi này không!", "Xóa phiếu chi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in hangChon)
                {
                    // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                    string maPC = row.Cells["maPC"].Value.ToString();
                    // Thực hiện xử lý với giá trị trong hàng đã chọn
                    if (!pcBLL.xoaPC(maPC)) //xóa không thành công
                    {
                        MessageBox.Show($"xóa phiếu chi {maPC.Trim()} không thành công!", "Xóa phiếu chi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                HienThiPC();
            }

        }

        private void dgvDSPC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvDSPC.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvDSPC.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(229, 193, 195);
            //255 182 193
        }

        private void dgvDSPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDSPC.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                txtMaPC.Texts = selectedRow.Cells["MaPC"].Value.ToString().Trim();
                cmbMaPT.SelectedItem = selectedRow.Cells["MaPT"].Value.ToString().Trim();

                //ep kieu 
                DateTime NgayChi = DateTime.ParseExact(selectedRow.Cells["ngayChi"].Value.ToString().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                dtpNgayChi.Value = NgayChi;
                txtSoTien.Texts = selectedRow.Cells["soTien"].Value.ToString().Trim();
                txtLyDo.Texts = selectedRow.Cells["lyDo"].Value.ToString().Trim();
                // Hiển thị thông tin trong các TextBox đã chỉ định
            }
        }
        //kiểm tra các thông tin nhập đúng chưa trả về true false
        private bool kiemTraPC()
        {
            if (txtMaPC.Texts.Trim().Length == 0 || cmbMaPT.SelectedIndex == -1 || txtLyDo.Texts.Trim().Length == 0
                || !double.TryParse(txtSoTien.Texts.Trim(), out _))
            {
                MessageBox.Show("Vui lòng nhập đủ và đúng thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThemPC_Click(object sender, EventArgs e)
        {
            if (kiemTraPC())
            {
                PhieuChi phieuChi = new PhieuChi();
                phieuChi.MaPC = txtMaPC.Texts.Trim();
                phieuChi.MaPT = cmbMaPT.SelectedItem.ToString();
                phieuChi.NgayChi = dtpNgayChi.Value.ToString("MM/dd/yyyy").Trim();
                phieuChi.SoTien = txtSoTien.Texts.Trim();
                phieuChi.LyDo = txtLyDo.Texts.Trim();

                string str = "";
                bool kiemTra = pcBLL.kiemTraPC(phieuChi, out str); // Kiểm tra xem mã phiếu chi đã tồn tại hay chưa
                if (kiemTra)
                {
                    pcBLL.themPC(phieuChi); // Thêm phiếu chi
                    HienThiPC();
                }
                MessageBox.Show(str, "Thêm phiếu chi", MessageBoxButtons.OK);
            }
        }
      
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool ktMaPC = pcBLL.kiemTraMaPC(txtMaPC.Texts.Trim());
          
            if (kiemTraPC() && ktMaPC)
            {
                PhieuChi phieuChi = new PhieuChi();
                phieuChi.MaPC = txtMaPC.Texts.Trim();
                phieuChi.MaPT = cmbMaPT.SelectedItem.ToString();
                phieuChi.NgayChi = dtpNgayChi.Value.ToString("yyyy/MM/dd").Trim();
                phieuChi.SoTien = txtSoTien.Texts.Trim();
                phieuChi.LyDo = txtLyDo.Texts.Trim();

                pcBLL.capNhatPC(phieuChi); // Kiểm tra xem mã dịch vụ đã tồn tại hay chưa
                HienThiPC();
            }
            else
            {
                MessageBox.Show("Mã phiếu chi không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            //hiển thị phiếu chi
            if(txtTimKiem.Texts.Trim().Length==0 )
                HienThiPC();
            else if(!pcBLL.kiemTraMaPC(txtTimKiem.Texts.Trim())) //tim kiem sai ko hien gì
                dgvDSPC.Rows.Clear();
            else
            {
                dgvDSPC.Rows.Clear();//xóa các hàng trong grid view
                PhieuChi item = pcBLL.timKiemPC(txtTimKiem.Texts.Trim());
                dgvDSPC.Rows.Add(item.MaPC, item.MaPT, item.NgayChi, item.SoTien, item.LyDo);
            }
        }
    }
}
