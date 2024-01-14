using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HopDongBLL
    {
        HopDongDAL hdDAL = new HopDongDAL();
        public List<HopDong> hienThiDSHD()
        {
            return hdDAL.HienThiDSHD();

        }
        //Ham them 
        public bool themHopDong(HopDong hd)
        {
            return hdDAL.themHopDong(hd);
        }
        //kiem tra ma hd
        public bool kiemTraHD(HopDong hd,out string str)
        {
            return hdDAL.kiemTraHD(hd,out str);
        }
        //Cập nhật Hợp đồng
        public bool capNhatHD(HopDong hd)
        {
            return hdDAL.capNhatHD(hd);
        }
        //Tìm kiếm Hợp đồng
        public List<HopDong> timKiemHD(string luaChon, string chuoiTimKiem)
        {
            return hdDAL.timKiemHD(luaChon, chuoiTimKiem);
        }
        //Xóa Hợp đồng
        public bool xoaHopDong(string maHD)
        {
            return hdDAL.xoaHopDong(maHD);
        }
        //DS khach tro
        public List<string> dsKhachTro()
        {
            return hdDAL.dsKhachTro();
        }
        //DS PhongTro
        public List<string> dsPhongTro()
        {
            return hdDAL.dsPhongTro();
        }
        //Thong tin khách trọ
        public List<string> dsTTKT(string maKT)
        {
            return hdDAL.dsTTKT(maKT);
        }
    }
}
