using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuThuBLL
    {
        PhieuThuDAL ptDAL = new PhieuThuDAL();
        public List<PhieuThu> hienThiDSPT() //lấy ds dv 
        {
            return ptDAL.hienThiDSPT();
        }
        public List<PhieuThu> hienThiDSCTPT(string MaThu) // Lấy danh sách ct phiếu chi{
        {
            return ptDAL.hienThiDSCTPT(MaThu);
        }
        //Tìm kiếm Phiêu thu
        public List<PhieuThu> timKiemPThu(string luaChon, string chuoiTimKiem)
        {
            return ptDAL.timKiemPThu(luaChon, chuoiTimKiem);
        }
        public bool themPT(PhieuThu phieuThu)
        {
            return ptDAL.themPT(phieuThu);
        }
        //kiem tra mã PT
        public bool kiemTraPT(PhieuThu phieuThu, out string str)
        {
            str = "";
            if (phieuThu.MaPT.Length == 0 || phieuThu.MaKT.Length == 0 || phieuThu.MaThu.Length == 0)
                str = "Mã không được trống!";
            else if (ptDAL.kiemTraMaPT(phieuThu.MaThu))
                str = "Mã phiếu thu đã tồn tại, vui lòng nhập mã mới!";
            else
            {
                str = "Thêm phiếu thu thành công!";
                return true;
            }
            return false;
        }
        // Cập nhật phiếu thu 
        public bool capNhatPT(PhieuThu phieuThu)
        {
            return ptDAL.capNhatPT(phieuThu);
        }

        // Xóa phiếu thu 
        public bool xoaPT(string maPT)
        {
            return ptDAL.xoaPT(maPT);
        }
        // ds pt
        public List<string> dsPhongTro()
        {
            return ptDAL.dsPhongTro();
        }
        // ds kt
        public List<string> dsKhachTro()
        {
            return ptDAL.dsKhachTro();
        }
        // ds dv
        public List<string> dsDichVu()
        {
            return ptDAL.dsDichVu();
        }
        // them ct phieu thu
        public bool themCTPT(PhieuThu phieuThu)
        {
            return ptDAL.themCTPT( phieuThu);
        }
        //xoa ct phieu thu
        public bool xoaCTPT(string maPT , string maDV)
        {
            return ptDAL.xoaCTPT(maPT, maDV);
        }
        public bool capNhatCTPT(PhieuThu ctpt)
        {
            return ptDAL.capNhatCTPT(ctpt);
        }


        //kiem tra phiếu thu - mã pt và kt phải được kí kết rồi
        public bool kiemTraHopDong(string MaPT, string MaKT)
        {
            return ptDAL.kiemTraHopDong(MaPT,MaKT);
        }
    }
}
