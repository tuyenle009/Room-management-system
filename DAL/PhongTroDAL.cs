using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DTO;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;

namespace DAL
{
    public class PhongTroDAL : Database
    {

        //Ham hien thi danh sach phongtro
        public List<DTO.PhongTro> HienThiDSPT()
        {
            MoKetNoi();
            List<DTO.PhongTro> dsPT = new List<DTO.PhongTro>();
            SqlCommand sqlCmd = new SqlCommand("select * from PhongTro", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string maPT = reader.GetString(0).Trim();
                string tenPT = reader.GetString(1).Trim();
                string giaPhong = reader.GetDouble(2).ToString().Trim();
                string slToiDa = reader.GetInt32(3).ToString().Trim();
                byte[] hinhAnh = reader.GetSqlBytes(4).Value;
                string tinhTrang = reader.GetBoolean(5).ToString().Trim();

                PhongTro pt = new PhongTro();
                pt.MaPT = maPT;
                pt.TenPT = tenPT;
                pt.GiaPhong = giaPhong;
                pt.SLToiDa = slToiDa;
                pt.HinhAnh = hinhAnh;
                pt.TinhTrang = tinhTrang;

                dsPT.Add(pt);
            }
            reader.Close();
            DongKetNoi();
            return dsPT;
        }

        public DataTable HienThiDSPT_TB(string query)
        {
            return dsDuLieu(query);
        }

        //Ham them phongtro
        public bool themPhongTro(PhongTro pt )
        {
            //chuyen doi hinh anh
            string maPT = pt.MaPT;
            string tenPT = pt.TenPT;
            string giaPhong = pt.GiaPhong;
            string slToiDa = pt.SLToiDa;
            string query = "INSERT INTO PhongTro VALUES ('" + maPT + "',N'" + tenPT + "'," + giaPhong + "," + slToiDa + ",@hinhanh,"+0+")";

            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.Parameters.Add("@hinhanh", pt.HinhAnh);
            int k = (int)sqlCmd.ExecuteNonQuery();
            DongKetNoi();
            return (k > 0);
        }
        public bool kiemTraPT(PhongTro pt,out string str) //kiem tra ma pt co bi trung hay khong
        {
            MoKetNoi();
            str = "";
            string mapt = pt.MaPT;
            string tenPT = pt.TenPT.Trim();
            string giaPhong = pt.GiaPhong;
            string slToiDa = pt.SLToiDa;

            if (float.Parse(giaPhong) < 0 || int.Parse(slToiDa) < 0)
            {
                // Kiểm tra tienCoc >= 0 và ngayTra sau ngayThue
                str = "Giá phòng hoặc số lượng khách không được nhỏ hơn 0.";
                return false;
            }
            else if(tenPT.Length==0 )
            {
                str = "Tên phòng không được để rỗng.";
                return false;
            }
            else
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM dbo.PhongTro WHERE MaPT = '" + mapt + "'",sqlCon);
                int k = (int)sqlCmd.ExecuteScalar();
                if (k > 0)
                {
                    str = "Mã phòng đã tồn tại, vui lòng kiểm tra lại!";
                    return false; //neu ton tai tra ve false
                }
                else
                    return true;
            }
        }
        //Cập nhật khách trọ
        public bool capNhatPT(PhongTro pt)
        {
            string maPT = pt.MaPT;
            string tenPT = pt.TenPT;
            string giaPhong = pt.GiaPhong;
            string slToiDa = pt.SLToiDa;
            byte[] hinhAnh = pt.HinhAnh;

            string query = "UPDATE dbo.PhongTro SET TenPhong=N'" + tenPT + "',GiaPhong=" + giaPhong + ",SLToiDa=" + slToiDa + ",anhPhong = @hinhanh WHERE MaPT = '" + maPT + "'";
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.Parameters.Add("@hinhanh", hinhAnh);
            int k = (int)sqlCmd.ExecuteNonQuery();
            DongKetNoi();
            return (k > 0);
        }
        //Tìm kiếm khách trọ
        public List<DTO.PhongTro> timKiemPT(string luaChon, string chuoiTimKiem)
        {
            MoKetNoi();
            List<DTO.PhongTro> dsPT = new List<DTO.PhongTro>();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM dbo.TimKiemPhongTro(" + luaChon + ",N'" + chuoiTimKiem + "')";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string maPT = reader.GetString(0);
                string tenPT = reader.GetString(1);
                string giaPhong = reader.GetDouble(2).ToString();
                string slToiDa = reader.GetInt32(3).ToString();

                PhongTro pt = new PhongTro();
                pt.MaPT = maPT;
                pt.TenPT = tenPT;
                pt.GiaPhong = giaPhong;
                pt.SLToiDa = slToiDa;

                dsPT.Add(pt);
            }
            reader.Close();
            DongKetNoi();
            return dsPT;

        }
        //Xóa khách trọ
        public bool xoaPhongTro(string mapt)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            //kiểm tra xem pt đã ký hợp đồng hay chưa
            sqlCmd.CommandText = "SELECT COUNT(*) FROM dbo.PhongTro AS pt JOIN dbo.HopDong AS hd ON hd.MaPT = pt.MaPT AND pt.MaPT = '" + mapt + "'";
            sqlCmd.Connection = sqlCon;
            int k = (int)sqlCmd.ExecuteScalar();
            if (k == 0) //pt chưa ký hợp đồng nào 
            {
                sqlCmd.CommandText = "DELETE FROM dbo.PhongTro WHERE MaPT = '" + mapt + "'";
                if (sqlCmd.ExecuteNonQuery() > 0) //xóa thành công
                {
                    DongKetNoi();
                    return true;
                }
            }
            DongKetNoi();
            return false;

        }
        //Lấy hình ảnh ra
        
    
    }
}
