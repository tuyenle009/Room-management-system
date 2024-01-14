using BLL;
using DTO;
using System;
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
    public partial class frmThemPT : Form
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
        public frmThemPT()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (txtMaPT.Texts.Trim().Length==0|| txtTenPhong.Texts.Trim().Length==0||!float.TryParse(txtGiaPhong.Texts.Trim(),out _)
                || !int.TryParse(txtSLToiDa.Texts.Trim(),out _))
                MessageBox.Show("Vui lòng nhập đủ và đúng thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                PhongTro pt = new PhongTro();
                pt.MaPT = txtMaPT.Texts.Trim();
                pt.TenPT = txtTenPhong.Texts.Trim();
                pt.GiaPhong = txtGiaPhong.Texts.Trim();
                pt.SLToiDa = txtSLToiDa.Texts.Trim();
                pt.HinhAnh = ImageToByteArray(pictureBox1.Image);
                PhongTroBLL themPT = new PhongTroBLL();

                string str = "";
                bool kiemTra = themPT.kiemTraPT(pt, out str);
                if (kiemTra)
                {
                    themPT.themPhongTro(pt);
                    MessageBox.Show("Thêm phòng trọ thành công!", "Thêm phòng trọ", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(str, "Thêm phòng trọ", MessageBoxButtons.OK);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        //chuyen sang byte
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
    }
}
