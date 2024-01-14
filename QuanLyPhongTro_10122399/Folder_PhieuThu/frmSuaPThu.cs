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

namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    public partial class frmSuaPThu : Form
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
        public frmSuaPThu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            
            //cập nhật gia trị text box
            capNhatGiaTriTextBox();
            //lựa chọn index đầu trong combobox
            cmbMaDV.SelectedIndex = 0;

        }
        PhieuThuBLL ptbll = new PhieuThuBLL();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //cap nhat gia tri vào text box
        public void capNhatGiaTriTextBox(string maThu, string maPT, string maKT, string ngayThu)
        {
            lblMaPThu.Text = maThu;
            cmbMaPT.SelectedItem = maPT;
            cmbMaKT.SelectedItem = maKT;
            dtpNgayThu.Value = DateTime.ParseExact(ngayThu, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            capNhatGtriDGV(maThu);
        }
        // cập nhật gtri vào grid view
        List<string> ds_maDVBanDau = new List<string>();
        List<string> ds_maDVMoi = new List<string>();
        public void capNhatGtriDGV(string maThu)
        {

            dgvCTDV.Rows.Clear();
            List<PhieuThu> ds  = ptbll.hienThiDSCTPT(maThu);
            foreach (PhieuThu item in ds)
            {
                dgvCTDV.Rows.Add(item.MaDV,item.SoLuong);
                ds_maDVBanDau.Add(item.MaDV);
            }
        }
        private void dgvDSHD_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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

        private void lblMaPTro_Click(object sender, EventArgs e)
        {

        }
        //them dich vu- nếu trùng sẽ update số lượng

        private void btnThemCTPT_Click(object sender, EventArgs e)
        {
            //kiem tra neu dung thi them vào dgv
            if (!int.TryParse(txtSoLuong.Texts.Trim(), out _) || int.Parse(txtSoLuong.Texts.Trim()) < 0)
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
                //xóa trong chi tiết phiếu thu
                if (!ptbll.kiemTraHopDong(cmbMaPT.SelectedItem.ToString(), cmbMaKT.SelectedItem.ToString()))
                    MessageBox.Show("Khách trọ chưa thuê phòng, hãy kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    //ma thu va ma dv
                    //ptbll.xoaCTPT(lblMaPThu.Text, dgvCTDV.Rows[rowIndex].Cells[0].Value.ToString());
                    this.dgvCTDV.Rows.RemoveAt(this.rowIndex);
                }
               
            }

        }
        //lấy ra vị trí cột được chọn

        private int rowIndex = 0;
        private void dgvCTDV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvCTDV.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvCTDV.CurrentCell = this.dgvCTDV.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgvCTDV, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }


        //cập nhật danh sách phiếu chi có mã giống với mã phiếu thu
        // kiểm tra xem 
        private void themChiTietPhieuThu(string txtMaThu)
        {
            //duyệt lẩy ds mã mới được thêm
            foreach (DataGridViewRow row in dgvCTDV.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không duyệt qua hàng mới
                {
                    ds_maDVMoi.Add(row.Cells[0].Value.ToString());
                }
            }
            //TH1: cũ ko nằm trong mới -> xóa cũ
            foreach (string item in ds_maDVBanDau)
            {
                if (!ds_maDVMoi.Contains(item))
                    ptbll.xoaCTPT(lblMaPThu.Text, item);
            }
            foreach (DataGridViewRow row in dgvCTDV.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không duyệt qua hàng mới
                {
                    // Lấy giá trị từ cột đầu tiên của mỗi hàng
                    PhieuThu ctpt = new PhieuThu(txtMaThu, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());

                    //nếu nằm trong list thì cập nhật, nếu không nằm trong list thì thêm vào 
                   
                    if (ds_maDVBanDau.Contains(row.Cells[0].Value.ToString()))
                    {
                        //cap nhạt
                        ptbll.capNhatCTPT(ctpt);
                    }
                    else
                    {
                        ptbll.themCTPT(ctpt);
                    }
                    // làm điều gì đó với giá trị cellValue ở đây
                }
            }

        }

        private void btnCapNhatPThu_Click(object sender, EventArgs e)
        {
            //kiem tra xem Khách trọ chưa thuê phòng chua
            if (!ptbll.kiemTraHopDong(cmbMaPT.SelectedItem.ToString(), cmbMaKT.SelectedItem.ToString()))
                MessageBox.Show("Khách trọ chưa thuê phòng, hãy kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                PhieuThu pt = new PhieuThu(lblMaPThu.Text, cmbMaPT.SelectedItem.ToString(), cmbMaKT.SelectedItem.ToString(), dtpNgayThu.Value.ToString("yyyy/MM/dd"), "0");
                ptbll.capNhatPT(pt);
                themChiTietPhieuThu(lblMaPThu.Text);
                MessageBox.Show("cập nhật phiếu thu thành công!", "cập nhật phiếu thu", MessageBoxButtons.OK);
            }
        }

       
    }
}
