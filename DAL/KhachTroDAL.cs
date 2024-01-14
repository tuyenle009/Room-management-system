using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;



namespace DAL
{
    public class KhachTroDAL:Database
    {

        //Ham hien thi danh sach khachtro
        public List<DTO.KhachTro> HienThiDSKT()
        {
            MoKetNoi();
            List<DTO.KhachTro> dsVT = new List<DTO.KhachTro>();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from KhachTro";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string makt = reader.GetString(0).Trim();
                string tenkt = reader.GetString(1).Trim();
                string cmnd = reader.GetString(2).Trim();
                string gioiTinh = reader.GetString(3).Trim();
                string diaChi = reader.GetString(4).Trim();
                string sdt = reader.GetString(5).Trim();
                string ngheNghiep = reader.GetString(6).Trim();

                KhachTro kt = new KhachTro();
                kt.MaKT = makt;
                kt.HoTen = tenkt;
                kt.CMND = cmnd;
                kt.GioiTinh = gioiTinh;
                kt.DiaChi = diaChi;
                kt.SDT = sdt;
                kt.NgheNghiep = ngheNghiep;

                dsVT.Add(kt);
            }
            reader.Close();
            DongKetNoi();
            return dsVT;
        }
        //Ham them khachtro
        public bool themKhachTro(KhachTro kt)
        {
            string makt = kt.MaKT;
            string tenkt = kt.HoTen;
            string cmnd = kt.CMND;
            string gioiTinh = kt.GioiTinh;
            string diaChi = kt.DiaChi;
            string sdt = kt.SDT;
            string ngheNghiep = kt.NgheNghiep;

            string query = "INSERT INTO khachtro VALUES ('" + makt + "',N'" + tenkt + "','" + cmnd + "',N'" + gioiTinh + "',N'" + diaChi + "','" + sdt + "',N'" + ngheNghiep + "')";
            return thucThiSQL(query);
        }
        public bool kiemTraMaKT(KhachTro kt) //kiem tra ma kt co bi trung hay khong
        {
            MoKetNoi();
            string makt = kt.MaKT;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT COUNT(*) FROM dbo.KhachTro WHERE MaKT = '"+makt+"'";
            sqlCmd.Connection = sqlCon;

            int k = (int)sqlCmd.ExecuteScalar();
            DongKetNoi();

            if (k > 0)
            {
                return false; //neu ton tai tra ve false
            }
            else
                return true;
        }
        //Cập nhật khách trọ
        public bool capNhatKT(KhachTro kt)
        {
            string makt = kt.MaKT;
            string tenkt = kt.HoTen;
            string cmnd = kt.CMND;
            string gioiTinh = kt.GioiTinh;
            string diaChi = kt.DiaChi;
            string sdt = kt.SDT;
            string ngheNghiep = kt.NgheNghiep;
            
            string query = "UPDATE dbo.KhachTro SET HoTen =N'" + tenkt + "', CMND ='" + cmnd + "',GioiTinh =N'" + gioiTinh + "', DiaChi=N'" + diaChi + "',SDT='" + sdt + "',NgheNghiep =N'" + ngheNghiep + "' WHERE MaKT='" + makt + "'";
            return thucThiSQL(query);

        }
        //Tìm kiếm khách trọ
        public List<DTO.KhachTro> timKiemKT(string luaChon, string chuoiTimKiem)
        {
            MoKetNoi();
            List<DTO.KhachTro> dsVT = new List<DTO.KhachTro>();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM dbo.TimKiemKhachTro("+luaChon+",N'"+chuoiTimKiem+"')";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string makt = reader.GetString(0);
                string tenkt = reader.GetString(1);
                string cmnd = reader.GetString(2);
                string gioiTinh = reader.GetString(3);
                string diaChi = reader.GetString(4);
                string sdt = reader.GetString(5);
                string ngheNghiep = reader.GetString(6);

                KhachTro kt = new KhachTro();
                kt.MaKT = makt;
                kt.HoTen = tenkt;
                kt.CMND = cmnd;
                kt.GioiTinh = gioiTinh;
                kt.DiaChi = diaChi;
                kt.SDT = sdt;
                kt.NgheNghiep = ngheNghiep;

                dsVT.Add(kt);
            }
            reader.Close();
            DongKetNoi();
            return dsVT;
           
        }
        //Xóa khách trọ
        public bool xoaKhachTro(string makt)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            //kiểm tra xem kt đã ký hợp đồng hay chưa
            sqlCmd.CommandText = "SELECT COUNT(*) FROM dbo.KhachTro AS kt JOIN dbo.HopDong AS hd ON hd.MaKT = kt.MaKT AND kt.MaKT = '" + makt+"'";
            sqlCmd.Connection = sqlCon;
            int k = (int)sqlCmd.ExecuteScalar();
            if (k == 0) //kt chưa ký hợp đồng nào 
            {
                sqlCmd.CommandText = "DELETE FROM dbo.KhachTro WHERE MaKT = '" + makt + "'";
                if (sqlCmd.ExecuteNonQuery() > 0) //xóa thành công
                {
                    DongKetNoi();
                    return true;
                }
            }
            DongKetNoi();
            return false;

        }

    }
}
