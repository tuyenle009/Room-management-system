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

namespace QuanLyPhongTro_10122399.Folder_BaoCao
{
    public partial class frmThongKe : Form
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
        public frmThongKe()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //chon vao vtri 1
            cmbThang.SelectedIndex = 0;
            //hien thi
            HienThiDSPT();
            ThongKePT();
            ThongKeDN();
            ThongKeTong();
        }
        ThongKeBLL tkbll = new ThongKeBLL();


        //hien thi thong ke tổng hợp trong một tháng
        public void ThongKeTong(string thang = "", string nam = "")
        {
            dgvThongKeTong.Rows.Clear();
            int tongThu = 0;
            float tongChi = tkbll.tienChiTrongThang(thang, nam);
            List<ThongKe> ds = tkbll.hienThiDSTKDV(thang, nam);
            foreach (ThongKe item in ds)
            {
                tongThu += int.Parse(item.TongTienThu);
                Console.WriteLine(tongThu);

            }
            int loiNhuan = tongThu - (int)tongChi;
            dgvThongKeTong.Rows.Add("Tổng tiền thu",tongThu.ToString());
            dgvThongKeTong.Rows.Add("Tổng tiền chi", tongChi.ToString());
            dgvThongKeTong.Rows.Add("Lợi nhuận", loiNhuan.ToString());




        }
        //hien thi thong ke so dien da su dung, so nuoc da sd

        public void ThongKeDN(string thang = "", string nam = "")
        {
            dgvSoDien.Rows.Clear();
            ThongKe tk = tkbll.thongKeDienNuoc(thang,nam);
            Console.WriteLine(thang+ " "+ nam);
            Console.WriteLine(tk.TongSoDienSD.ToString());
            dgvSoDien.Rows.Add("Điện (KW)", tk.TongSoDienSD.ToString());
            dgvSoDien.Rows.Add("Nước (M3)", tk.TongSoNuocSD.ToString());

        }
        //hien thi thong ke phong tro
        public void ThongKePT()
        {
            dgvDSPT.Rows.Clear();
            ThongKe tk = tkbll.thongKeDSPT();
            dgvDSPT.Rows.Add("Phòng đã thuê",tk.SLPhongDaThue.ToString());
            dgvDSPT.Rows.Add("Phòng chưa thuê", tk.SLPhongDaChuaThue.ToString());
            dgvDSPT.Rows.Add("Tổng phòng",tk.SLTongPhong.ToString());

        }
        //hien thi danh sach phong tro
        public void HienThiDSPT(string thang= "", string nam="")
        {
          
            dgvThongKeDV.Rows.Clear();
            List<ThongKe> ds = tkbll.hienThiDSTKDV(thang, nam);
            foreach (ThongKe item in ds)
            {
                dgvThongKeDV.Rows.Add(
                        item.MaThu, item.MaPT, item.NgayThu, item.GiaPhong, item.TongTienDN, item.TongTienDV, item.TongTienThu);
            }
        }
        //khi thay đổi trong txt box năm || tháng sẽ tự động tìm kiếm
        string thang = "";
        string nam = "";
       
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {

            if (int.TryParse(txtNam.Text, out _) && int.Parse(txtNam.Text) < 100000)
            {
                thang = cmbThang.SelectedItem.ToString();
                nam = txtNam.Text;
                ThongKeDN(thang, nam);
                HienThiDSPT(thang, nam);
                ThongKeTong(thang, nam);
            }
        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            thang = cmbThang.SelectedItem.ToString();
            nam = txtNam.Text;
            btnTimKiem.PerformClick();
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            thang = cmbThang.SelectedItem.ToString();
            nam = txtNam.Text;
            btnTimKiem.PerformClick();
        }

        //chuyen mau
        static void ChuyenMauDGV(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1) // Vẽ lại header
            {
                e.PaintBackground(e.CellBounds, true);

                using (SolidBrush brush = new SolidBrush(Color.Pink)) // Màu hồng cho header
                {
                    using (StringFormat format = new StringFormat())
                    {
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;

                        e.Graphics.FillRectangle(brush, e.CellBounds); // Tô màu cho header
                        e.Graphics.DrawString(e.Value?.ToString(), e.CellStyle.Font, Brushes.Black, e.CellBounds, format);
                    }
                }

                e.Handled = true;
            }
        }
        private void dgvDSPT_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            ChuyenMauDGV(sender, e);
        }

        private void dgvSoDien_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            ChuyenMauDGV(sender, e);

        }

        private void dgvThongKeDV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            ChuyenMauDGV(sender, e);
        }

        private void dgvThongKeTong_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            ChuyenMauDGV(sender, e);
        }
    }
}
