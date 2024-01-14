using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuChiBLL
    {
        PhieuChiDAL pcDAL = new PhieuChiDAL();
        public List<PhieuChi> hienThiDSPC() //lấy ds dv 
        {
            return pcDAL.hienThiDSPC();
        }
        public PhieuChi timKiemPC(string maPC) //lấy dv theo mã
        {
            return pcDAL.timKiemPC(maPC);
        }
        public bool themPC(PhieuChi phieuChi)
        {
            return pcDAL.themPC(phieuChi);
        }
        //kiem tra mã PC
        public bool kiemTraPC(PhieuChi phieuChi, out string str)
        {
            str = "";
            if (phieuChi.MaPC.Length == 0 || phieuChi.LyDo.Length == 0 || phieuChi.MaPC.Length == 0)
                str = "Mã hoặc tên phiếu chi không được trống!";
            else if (float.Parse(phieuChi.SoTien) < 0)
                str = "Tiền chi phải lớn hơn 0!";
            else if (pcDAL.kiemTraMaPC(phieuChi.MaPC))
                str = "Mã phiếu chi đã tồn tại, vui lòng nhập mã mới!";
            else
            {
                str = "Thêm phiếu chi thành công!";
                return true;
            }
            return false;
        }
        // Cập nhật phiếu chi 
        public bool capNhatPC(PhieuChi phieuChi)
        {
            return pcDAL.capNhatPC(phieuChi);
        }

        // Xóa phiếu chi 
        public bool xoaPC(string maPC)
        {
            return pcDAL.xoaPC(maPC);
        }
        // ds pt
        public List<string> dsPhongTro()
        {
            return pcDAL.dsPhongTro();
        }
        //kiem tra max phieu chi xem da ton tai chua
        public bool kiemTraMaPC(string txtMaPC)
        {
            List<PhieuChi> ds = pcDAL.hienThiDSPC();
            foreach (PhieuChi item in ds)
            {
                if (txtMaPC.ToUpper() == item.MaPC.Trim().ToUpper())
                    return true;
            }
            return false;
        }
    }
}
