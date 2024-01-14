using BLL;
using DTO;
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

namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    public partial class frmThemPTu : Form
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
        public frmThemPTu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            //an capNhatGiaTriTextBox
            capNhatGiaTriTextBox();
            //lựa chọn index đầu trong combobox
            cmbMaDV.SelectedIndex = 0;
            cmbMaKT.SelectedIndex = 0;
            cmbMaPT.SelectedIndex = 0;

        }
        PhieuThuBLL ptbll = new PhieuThuBLL();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //lấy ra danh sách phiếu chi có mã giống với mã phiếu thu
        private void themChiTietPhieuThu(string txtMaThu)
        {
            foreach (DataGridViewRow row in dgvCTDV.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không duyệt qua hàng mới
                {
                    // Lấy giá trị từ cột đầu tiên của mỗi hàng
                    PhieuThu ctpt = new PhieuThu(txtMaThu, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                    ptbll.themCTPT(ctpt);
                    // làm điều gì đó với giá trị cellValue ở đây
                }
            }

        }
        private void btnThemPThu_Click(object sender, EventArgs e)
        {
            //kiem tra xem có điền mã thu chưa
            //if (txtMaThu.Texts.Trim().Length == 0)
            //    MessageBox.Show("Vui lòng nhập mã thu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (!ptbll.kiemTraHopDong(cmbMaPT.SelectedItem.ToString(), cmbMaKT.SelectedItem.ToString()))
                MessageBox.Show("Khách trọ chưa thuê phòng, hãy kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                PhieuThu pt = new PhieuThu(txtMaThu.Texts, cmbMaPT.SelectedItem.ToString(), cmbMaKT.SelectedItem.ToString(), dtpNgayThu.Value.ToString("yyyy/MM/dd"), "0");
                string str = "";
                bool kiemTra = ptbll.kiemTraPT(pt, out str);
                if (kiemTra)
                {
                    ptbll.themPT(pt);
                    themChiTietPhieuThu(txtMaThu.Texts);
                    MessageBox.Show("Thêm phiếu thu thành công!", "Thêm phiếu thu", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(str, "Thêm phiếu thu", MessageBoxButtons.OK);
            }
        }
    
        private void lblChiTiet_Click(object sender, EventArgs e)
        {

        }
        //update combobox
        public void capNhatGiaTriTextBox()
        {
            //thêm giá trị vào cmb khách trọ 
            cmbMaKT.Items.Clear();
            foreach (string item in ptbll.dsKhachTro())
            {
                cmbMaKT.Items.Add(item.Trim());
            }
            //thêm giá trị vào cmb phòng trọ 
            cmbMaPT.Items.Clear();
            foreach (string item in ptbll.dsPhongTro())
            {
                cmbMaPT.Items.Add(item.Trim());
            }
            //them giatri vao cmb dich vu
            cmbMaDV.Items.Clear();
            foreach (string item in ptbll.dsDichVu())
            {
                cmbMaDV.Items.Add(item.Trim());
            }

        }
        //them dich vu- nếu trùng sẽ update số lượng
        private void btnThemCTPT_Click(object sender, EventArgs e)
        {
            //kiem tra neu dung thi them vào dgv
            if(!int.TryParse(txtSoLuong.Texts.Trim(), out _)  ||  int.Parse(txtSoLuong.Texts.Trim())<0)
                MessageBox.Show("Vui lòng nhập đúng số lượng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string dichVuMoi = cmbMaDV.SelectedItem.ToString();
                int soLuong = int.Parse(txtSoLuong.Texts);

                bool found = false;

                // Duyệt qua từng dòng trong dgvCTDV để kiểm tra mã sản phẩm
                foreach (DataGridViewRow row in dgvCTDV.Rows)
                {
                    if (row.Cells["maDV"].Value != null && row.Cells["maDV"].Value.ToString() == dichVuMoi)
                    {
                        // Mã sản phẩm đã tồn tại, cộng thêm vào lượng sản phẩm
                        int slHienTai = int.Parse(row.Cells["soLuong"].Value.ToString());
                        row.Cells["soLuong"].Value = (slHienTai + soLuong).ToString();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    // Nếu mã sản phẩm chưa tồn tại, thêm vào dgvCTDV
                    dgvCTDV.Rows.Add(cmbMaDV.SelectedItem, txtSoLuong.Texts);
                }
            }
               

        }
        //đổi màu gridview

        private void dgvCTDV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
            {
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvCTDV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvCTDV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(229, 193, 195);
                //255 182 193
            }
        }
        //Xóa hàng trong dgv

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        //khi nhấn chuột phải vào hàng dgv sẽ hiển thị ra context
        private void dgvCTDV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvCTDV.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {
                    dgvCTDV.CurrentCell = dgvCTDV[hitTest.ColumnIndex, hitTest.RowIndex];
                    contextMenuStrip1.Show(dgvCTDV, e.Location);
                }
            }
        }
        //xóa hàng trong cột dịch vụ
        private void xoaHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvCTDV.Rows[this.rowIndex].IsNewRow)
            {
                this.dgvCTDV.Rows.RemoveAt(this.rowIndex); //xoa tai bang dgv
            }

        }
        //lấy ra vị trí cột được chọn
        private int rowIndex = 0;
        private void dgvCTDV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                this.dgvCTDV.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvCTDV.CurrentCell = this.dgvCTDV.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgvCTDV,e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void txtNgayThu__TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong__TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayThu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCMND_Click(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void cmbMaPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblThongTinPT_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPT__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaThu__TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMaKT_Click(object sender, EventArgs e)
        {

        }

        private void pnlCTPhieuThu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaKT__TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void cmbMaKT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlPhieuThu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
