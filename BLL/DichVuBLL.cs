using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DichVuBLL
    {
        //DienNuoc
        DichVuDAL dvDAL = new DichVuDAL();
        public List<DichVuDienNuoc> hienThiDSDienNuoc()
        {
            return dvDAL.hienThiDSDienNuoc();

        }
        //Ham them 
        public bool themDienNuoc(DichVuDienNuoc dv)
        {
            return dvDAL.themDienNuoc(dv);
        }
        //kiem tra ma hd
        public bool kiemTraDVDN(DichVuDienNuoc dv, out string str)
        {
            return dvDAL.kiemTraDVDN(dv, out str);
        }
        //Cập nhật Hợp đồng
        public bool capNhatDienNuoc(DichVuDienNuoc dv)
        {
            return dvDAL.capNhatDienNuoc(dv);
        }
       
        public bool xoaDienNuoc(string maDV)
        {
            return dvDAL.xoaDienNuoc(maDV);
        }
        //DS PhongTro
        public List<string> dsPhongTro()
        {
            return dvDAL.dsPhongTro();
        }


        //DS Phong tro theo thang
        public List<DichVuDienNuoc> DSDienNuocThang(int thang, int nam)
        {
            List < DichVuDienNuoc > lstDN = new List<DichVuDienNuoc>();
            foreach(DichVuDienNuoc dv in dvDAL.hienThiDSDienNuoc())
            {
                //kiểm tra xem có đúng tháng năm hay không
                if (int.Parse(dv.ToiNgay.Split('/')[1]) == thang && int.Parse(dv.ToiNgay.Split('/')[2]) == nam)
                {
                    lstDN.Add(dv);
                }
            }

            return lstDN;
        }
        public bool layDLThangTruoc(int thang, int nam)
        {
            return dvDAL.layDLThangTruoc(thang, nam);
        }
        //______________________________________________________________
        //DichVuKhac

        public List<DichVu> hienThiDSDV() //lấy ds dv 
        {
            return dvDAL.hienThiDSDV();
        }
        public bool themDV(DichVu dichVu)
        {
           return dvDAL.themDV(dichVu);
        }
        //kiem tra mã dich vu
        public bool kiemTraDV(DichVu dichVu, out string str)
        {
            str = "";
            if (dichVu.TenDV.Length == 0 || dichVu.MaDV.Length == 0)
                str = "Mã hoặc tên dịch vụ không được trống!";
            else if (float.Parse(dichVu.DonGia) < 0)
                str = "Giá dịch vụ phải lớn hơn 0!";
            else if (dvDAL.kiemTraMaDV(dichVu.MaDV))
                str = "Mã dịch vụ đã tồn tại, vui lòng nhập mã mới!";
            else
            {
                str = "Thêm dịch vụ thành công!";
                return true;
            }
            return false;
        }
        // Cập nhật dịch vụ 
        public bool capNhatDV(DichVu dichVu)
        {
            return dvDAL.capNhatDV(dichVu);
        }

        // Xóa dịch vụ
        public bool xoaDV(string maDV)
        {
            return dvDAL.xoaDV(maDV);
        }

    }
}
