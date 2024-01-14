using QuanLyPhongTro_10122399.Folder_BaoCao;
using QuanLyPhongTro_10122399.Folder_DichVu;
using QuanLyPhongTro_10122399.Folder_HopDong;
using QuanLyPhongTro_10122399.Folder_KhachTro;
using QuanLyPhongTro_10122399.Folder_PhieuChi;
using QuanLyPhongTro_10122399.Folder_PhieuThu;
using QuanLyPhongTro_10122399.Folder_PhongTro;
using QuanLyPhongTro_10122399.Folder_TrangChu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro_10122399
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ***this line is added***
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGiaoDien());
        }

        // ***also dllimport of that function***
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
