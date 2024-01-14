using BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Security.Policy;
using DTO;

namespace QuanLyPhongTro_10122399.Folder_HopDong
{
    public partial class frmSuaHD : Form
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
        public frmSuaHD()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        HopDongBLL hdbll = new HopDongBLL();
        //khi mở form update hợp đồng thì các giá trị sẽ được upd
        public void capNhatGiaTriTextBox(string maHD, string maKT, string maPT, string ngayThue, string ngayTra, string tienCoc, string tinhTrang)
        {
            lblMaHD.Text = maHD;
            dtpNgayThue.Value = DateTime.ParseExact(ngayThue, "dd/MM/yyyy", CultureInfo.InvariantCulture); // Giả sử DateTimePicker của bạn có tên là dateTimePicker1
            dtpNgayTra.Value = DateTime.ParseExact(ngayTra, "dd/MM/yyyy", CultureInfo.InvariantCulture); ; // Giả sử DateTimePicker của bạn có tên là dateTimePicker1
            txtTienCoc.Texts = tienCoc;
            //thêm giá trị vào cmb khách trọ 
            cmbMaKT.Items.Clear();
            foreach (string item in hdbll.dsKhachTro())
            {
                cmbMaKT.Items.Add(item.Trim());
            }
            cmbMaKT.SelectedItem = maKT.Trim(); //lựa chọn item ban đầu

            //thêm giá trị vào cmb phòng trọ 
            cmbMaPT.Items.Clear();
            foreach (string item in hdbll.dsPhongTro())
            {
                cmbMaPT.Items.Add(item.Trim());
            }
            cmbMaPT.SelectedItem = maPT.Trim();
            cmbTinhTrang.SelectedItem= tinhTrang.Trim().ToUpper(); //lựa chọn tình trạn cũ

        }
        private void llbXuatHD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<string> lstTTKT = hdbll.dsTTKT(cmbMaKT.SelectedItem.ToString()); //đưa vào mã kt đang đc chọn trong cmb
            //List<string> lstTTKT = hdbll.dsTTKT("KT001"); //đưa vào mã kt đang đc chọn trong cmb
            using (FileStream fs = new FileStream("HopDong.pdf", FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(@"                                                                        CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM");
                sw.WriteLine(@"                                                                           Độc Lập - Tự Do - Hạnh Phúc");
                sw.WriteLine(@"                                                                             -------Ꝏ○Ꝏ-------");
                sw.WriteLine(@"");
                sw.WriteLine(@"			                                 HỢP ĐỒNG CHO THUÊ PHÒNG TRỌ");
                sw.WriteLine(@"");
                sw.WriteLine(@"                                           Hôm nay ngày " + $"{dtpNgayThue.Value.ToString("dd")}" + " tháng" + $" {dtpNgayThue.Value.ToString("MM")}" + $"  năm {dtpNgayThue.Value.ToString("yyyy")}. Tại số nhà 101 Giai Phạm, Hưng Yên.");
                sw.WriteLine(@"");
                sw.WriteLine(@"                                           BÊN CHO THUÊ             : (Bên A)");
                sw.WriteLine(@"                                           - Do ông                 : LÊ ĐỨC TUYỂN");
                sw.WriteLine(@"                                           - Chức vụ                : GIÁM ĐỐC");
                sw.WriteLine(@"                                           - Trụ sở chính           : 101 GIAI PHẠM YÊN MỸ HƯNG YÊN");
                sw.WriteLine(@"                                           - Điện thoại             : 0344001111 - tuyenle@gmai.com");
                sw.WriteLine(@"                                           - Tài khoản              : 0344001111 MB ");
                sw.WriteLine(@"                                           BÊN THUÊ                 : (Bên B)");
                sw.WriteLine(@"                                           - Do ông(bà)             : " + $"{lstTTKT[0]}");
                sw.WriteLine(@"                                           - Cmnd                   : " + $"{lstTTKT[1]}");
                sw.WriteLine(@"                                           - Sđt                    : " + $"{lstTTKT[3]}");
                sw.WriteLine(@"                                           - Hktt                   : " + $"{lstTTKT[2]}");
                sw.WriteLine(@"		                            Hai bên cùng nhất trí thống nhất kỹ hợp đồng với các điều khoản sau:");
                sw.WriteLine(@"");
                sw.WriteLine(@"                                           ĐIỀU 1: NỘI DUNG HỢP ĐỒNG");
                sw.WriteLine(@"                                                       * Bên A đồng ý. Bên B nhất trí thuê 01 mặt bằng số    : " + $"{cmbMaPT.SelectedItem.ToString()}");
                sw.WriteLine(@"                                                       * Kể từ ngày                                          : " + $"{dtpNgayThue.Value.ToString("dd/MM/yyyy")}");
                sw.WriteLine(@"                                                       * Đến ngày                                            : " + $"{dtpNgayTra.Value.ToString("dd/MM/yyyy")}");
                sw.WriteLine(@"                                           ĐIỀU 2: TIỀN ĐẶT CỌC");
                sw.WriteLine(@"                                                       * Tiền thuê nhà bên B thanh toán cho bên A mùng 1 mỗi đầu tháng");
                sw.WriteLine(@"                                                       * Bên B đặt cọc trước:     " + $"{txtTienCoc.Texts}" + " VNĐ");
                sw.WriteLine(@"                                                          cho bên A. tiền cọc sẽ trả lại đầy đủ cho bên thuê khi hết hợp đồng thuê");
                sw.WriteLine(@"                                                          và thanh toán đầy đủ tiền điện nước. Phí dịch vụ và khoản khác liên quan");
                sw.WriteLine(@"                                                       * Bên B ngừng hợp đồng trước sẽ bị mất tiền cọc.Ngược lại nếu bên A");
                sw.WriteLine(@"                                                          ngừng hợp đồng trước thì phải bồi thường gấp đôi cho bên B");
                sw.WriteLine(@"");
                sw.WriteLine(@"                                                 ĐẠI DIỆN BÊN B                                                           ĐẠI DIỆN BÊN A");
                sw.Flush();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn chắc chắn muốn cập nhật?", "Cập nhật khách trọ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                HopDong hd = new HopDong();
                hd.MaHD = lblMaHD.Text;
                hd.MaKT = cmbMaKT.Text;
                hd.MaPT = cmbMaPT.Text;
                
                hd.NgayThue = dtpNgayThue.Value.ToString("yyyy/MM/dd");
                hd.NgayTra = dtpNgayTra.Value.ToString("yyyy/MM/dd");
                hd.TienCoc = txtTienCoc.Texts;
                hd.TinhTrang = cmbTinhTrang.Text.Trim();

                //nếu ngày trả < ngày hiện tại ==> false
                //if (dtpNgayTra.Value < DateTime.Now)
                //    hd.TinhTrang = "FALSE";
                hdbll.capNhatHD(hd);
            }
            
        }
    }
}
