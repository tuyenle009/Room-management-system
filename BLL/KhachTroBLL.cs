using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;




namespace BLL
{
    public class KhachTroBLL
    {
        KhachTroDAL ktDAL = new KhachTroDAL();
        public List<KhachTro> hienThiDSVT()
        {
            return ktDAL.HienThiDSKT();

        }
        //Ham them 
        public bool themKhachTro(KhachTro kt)
        {
            return ktDAL.themKhachTro(kt);
        }
        //kiem tra ma kt
        public bool kiemTraMaKT(KhachTro kt)
        {
            return ktDAL.kiemTraMaKT(kt);
        }
        //Cập nhật khách trọ
        public bool capNhatKT(KhachTro kt)
        {
            return ktDAL.capNhatKT(kt);
        }
        //Tìm kiếm khách trọ
        public List<KhachTro> timKiemKT(string luaChon, string chuoiTimKiem)
        {
            return ktDAL.timKiemKT(luaChon,chuoiTimKiem);
        }
        //Xóa khách trọ
        public bool xoaKhachTro(string maKT)
        {
            return ktDAL.xoaKhachTro(maKT);
        }
    }
}
