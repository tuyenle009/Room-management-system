using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhongTroBLL
    {
        PhongTroDAL ptDAL = new PhongTroDAL();
        public List<PhongTro> hienThiDSPT()
        {
            return ptDAL.HienThiDSPT();

        }
        public DataTable HienThiDSPT_TB(string query)
        {
            return ptDAL.HienThiDSPT_TB(query);
        }
        //Ham them 
        public bool themPhongTro(PhongTro pt)
        {
            return ptDAL.themPhongTro(pt);
        }
        //kiem tra ma pt
        public bool kiemTraPT(PhongTro pt,out string str)
        {
            return ptDAL.kiemTraPT(pt, out str);
        }
        //Cập nhật khách trọ
        public bool capNhatPT(PhongTro pt)
        {
            return ptDAL.capNhatPT(pt);
        }
        //Tìm kiếm khách trọ
        public List<PhongTro> timKiemPT(string luaChon, string chuoiTimKiem)
        {
            return ptDAL.timKiemPT(luaChon, chuoiTimKiem);
        }
        //Xóa khách trọ
        public bool xoaPhongTro(string maPT)
        {
            return ptDAL.xoaPhongTro(maPT);
        }

    }
}
