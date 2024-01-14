using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DichVuDAL: Database
    {
        //dịch vụ điện nước
        // Lấy danh sách dịch vụ điện nước
        public List<DichVuDienNuoc> hienThiDSDienNuoc() //lấy ds dv điện nước
        {
            MoKetNoi();
            List<DichVuDienNuoc> dsDichVu = new List<DichVuDienNuoc>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM DienNuoc",sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                DichVuDienNuoc dichVu = new DichVuDienNuoc(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2).ToString("dd/MM/yyyy")
                    , reader.GetDateTime(3).ToString("dd/MM/yyyy"), reader.GetInt32(4).ToString(), reader.GetInt32(5).ToString()
                    , reader.GetDouble(6).ToString(), reader.GetDouble(7).ToString());
                dsDichVu.Add(dichVu);
            }
            reader.Close();
            DongKetNoi();
            return dsDichVu;
        }  // Thêm dịch vụ điện nước
        public bool themDienNuoc(DichVuDienNuoc dichVu)
        {
            string query = "INSERT INTO DienNuoc VALUES ('" + dichVu.MaDN + "', '" + dichVu.MaPT + "', '" + dichVu.TuNgay + "', '" + dichVu.ToiNgay + "', '" + dichVu.ChiSoCu + "', '" + dichVu.ChiSoMoi + "', '" + dichVu.DonGia + "', '" + dichVu.ThanhTien + "')";
            return thucThiSQL(query);
        }
        // Kiểm tra mã dịch vụ đã tồn tại hay chưa
        public bool kiemTraDVDN(DichVuDienNuoc dichVu, out string str)
        {
            MoKetNoi();
            str = "";
            string tuNgay = dichVu.TuNgay.Trim() ;
            string toiNgay = dichVu.ToiNgay.Trim();
            string chiSoCu = dichVu.ChiSoCu.Trim();
            string chiSoMoi = dichVu.ChiSoMoi.Trim();
            string donGia = dichVu.DonGia.Trim();

            if ( float.Parse(donGia) < 0)
            {
                // Kiểm tra tienCoc >= 0 và ngayTra sau ngayThue
                str = "Đơn giá không được nhỏ hơn 0";
                return false;
            }
           
            //else if(DateTime.Parse(tuNgay) > DateTime.Parse(toiNgay))
            //{
            //    str = "Ngày bắt đầu không được nhỏ hơn ngày kết thúc";
            //    return false;
            //}
            else
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM DienNuoc WHERE MaDN = '" + dichVu.MaDN + "'", sqlCon);
                int k = (int)sqlCmd.ExecuteScalar();
                if (k > 0)
                {
                    str = "Mã điện nước đã tồn tại, vùi lòng nhập mã khác!";
                    return false; // Mã dịch vụ chưa tồn tại

                }
                    return true; // Mã dịch vụ đã tồn tại
            }
        }
        // Cập nhật dịch vụ điện nước
        public bool capNhatDienNuoc(DichVuDienNuoc dichVu)
        {
            string query = "UPDATE DienNuoc SET MaPT = '" + dichVu.MaPT + "', TuNgay = '" + dichVu.TuNgay + "', ToiNgay = '" + dichVu.ToiNgay + "', ChiSoCu = " + dichVu.ChiSoCu + ", ChiSoMoi = " + dichVu.ChiSoMoi + ", DonGia = " + dichVu.DonGia + ", ThanhTien = 0 WHERE MaDN = '" + dichVu.MaDN + "'";
            return thucThiSQL(query);
        }
        // Xóa dịch vụ điện nước
        public bool xoaDienNuoc(string maDN)
        {
            string query = "DELETE FROM DienNuoc WHERE MaDN = '" + maDN + "'";
            return thucThiSQL(query);
        }
        //ds phong tro
      

        //lay du lieu
        public bool layDLThangTruoc(int thang, int nam)
        {
            
            string query = "EXEC SP_LayDLThangTruoc @thang ="+thang+" , @nam = "+nam+";";
            return thucThiSQL(query);
        }
        //_________________________________________________


        //Dịch vụ khác
        public List<DichVu> hienThiDSDV() //lấy ds dv 
        {
            MoKetNoi();
            List<DichVu> dsDichVu = new List<DichVu>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM DichVu", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                DichVu dichVu = new DichVu(reader.GetString(0), reader.GetString(1), reader.GetDouble(2).ToString(), reader.GetString(3));
                dsDichVu.Add(dichVu);
            }
            reader.Close();
            DongKetNoi();
            return dsDichVu;
        }
        public bool themDV(DichVu dichVu)
        {
            string query = "INSERT INTO DichVu VALUES ('" + dichVu.MaDV + "', N'" + dichVu.TenDV + "', " + dichVu.DonGia + ", N'" + dichVu.DonViTinh +"')";
            return thucThiSQL(query);
        }
        //kiem tra mã dich vu
        public bool kiemTraMaDV(string maDV)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM DichVu WHERE MaDV = '" + maDV + "'", sqlCon);
            int k = (int)sqlCmd.ExecuteScalar();
            DongKetNoi();
            return (k > 0); //k>0 có nghĩa là mã tồn tại

        }
        // Cập nhật dịch vụ 
        public bool capNhatDV(DichVu dichVu)
        {
            string query = "UPDATE DichVu SET  TenDV = N'" + dichVu.TenDV + "', DonGia = " + dichVu.DonGia + ", DonViTinh = N'" + dichVu.DonViTinh + "' WHERE MaDV = '" + dichVu.MaDV + "'";
            return thucThiSQL(query);
        }

        // Xóa dịch vụ
        public bool xoaDV(string maDV)
        {
            string query = "DELETE FROM DichVu WHERE MaDV = '" + maDV + "'";
            return thucThiSQL(query);
        }
    }
}
