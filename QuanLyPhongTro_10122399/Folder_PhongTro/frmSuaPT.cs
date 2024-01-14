using BLL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro_10122399.Folder_PhongTro
{
    public partial class frmSuaPT : Form
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
        public frmSuaPT()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }
        PhongTroBLL ptBLL = new PhongTroBLL();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtSLToiDa.Texts,out _) || !float.TryParse(txtGiaPhong.Texts, out _))
                MessageBox.Show("Vui lòng nhập đúng thông tin yêu cầu!", "Cập nhật phòng trọ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult re = MessageBox.Show("Bạn chắc chắn muốn cập nhật?", "Cập nhật phòng trọ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    PhongTro pt = new PhongTro();
                    pt.MaPT = lblMaPTro.Text;
                    pt.TenPT = txtTenPhong.Texts;
                    pt.GiaPhong = txtGiaPhong.Texts;
                    pt.SLToiDa = txtSLToiDa.Texts;
                    byte[] b = ImageToByteArray(pictureBox1.Image);
                    pt.HinhAnh = b;
                    ptBLL.capNhatPT(pt);
                }
            }
           
        }
        //chuyen sang byte
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        public void capNhatGiaTriTextBox(string maPT, string tenPT, string giaPhong, string slToiDa, byte[] b)
        {
            lblMaPTro.Text = maPT;
            txtTenPhong.Texts = tenPT;
            txtGiaPhong.Texts = giaPhong;
            txtSLToiDa.Texts = slToiDa;
            // Hiển thị hình ảnh trên PictureBox
            pictureBox1.Image = ByteArrayToImage(b);
            //hien thi ds phiếu chi của phòng đó

        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
    }
}
