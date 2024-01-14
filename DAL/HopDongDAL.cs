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
    public class HopDongDAL : Database
    {
        //Ham hien thi danh sach vat tu
        public List<DTO.HopDong> HienThiDSHD()
        {
            MoKetNoi();
            List<DTO.HopDong> dsHD = new List<DTO.HopDong>();
            SqlCommand sqlCmd = new SqlCommand("select * from HopDong",sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string mahd = reader.GetString(0).Trim();
                string makt = reader.GetString(1).Trim();
                string maPT = reader.GetString(2).Trim();
                string ngayThue = reader.GetDateTime(3).ToString("dd/MM/yyyy").Trim();
                string ngayTra = reader.GetDateTime(4).ToString("dd/MM/yyyy").Trim();
                string tienCoc = reader.GetDouble(5).ToString().Trim();
                string tinhTrang = reader.GetBoolean(6).ToString().Trim();

                HopDong hd = new HopDong();
                hd.MaHD = mahd;
                hd.MaKT = makt;
                hd.MaPT = maPT;
                hd.NgayThue = ngayThue;
                hd.NgayTra = ngayTra;
                hd.TienCoc = tienCoc;
                hd.TinhTrang = tinhTrang;

                dsHD.Add(hd);
            }
            reader.Close();
            DongKetNoi();
            return dsHD;
        }
        //Ham them hop dong
        public bool themHopDong(HopDong hd)
        {
            string tinhTrang = hd.TinhTrang.Trim();
            if (tinhTrang == "TRUE") tinhTrang = "1";
            else if (tinhTrang == "FALSE") tinhTrang = "0";

            string query= ("INSERT INTO HopDong VALUES ('" + hd.MaHD + "', '" + hd.MaKT + "', '" + hd.MaPT + "', '" + hd.NgayThue 
                + "', '" + hd.NgayTra + "', " + hd.TienCoc + ", " + tinhTrang + ")");
            return thucThiSQL(query);

        }
        public bool kiemTraHD(HopDong hd, out string str) //kiem tra ma hd co bi trung hay khong
        {
            MoKetNoi();
            str = "";
            string mahd = hd.MaHD;
            string tienCoc = hd.TienCoc;
            string ngayThue = hd.NgayThue;
            string ngayTra = hd.NgayTra;
            int ketQua = 0;
            if ( float.Parse(tienCoc) < 0)
            {
                // Kiểm tra tienCoc >= 0 và ngayTra sau ngayThue
                str = "Tiền cọc không được nhỏ hơn 0.";
                ketQua= 1;
            }
            else if (DateTime.Parse(ngayTra) < DateTime.Parse(ngayThue))
            {
                // Kiểm tra tiền cọc và ngày
                str = "Ngày trả phải sau ngày thuê.";
                ketQua = 1;
            }
            else
            {
                //kiem tra ma hop dong
                SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM dbo.HopDong WHERE MaHD = '" + mahd + "'", sqlCon);
                int k = (int)sqlCmd.ExecuteScalar();
                if (k > 0)
                {
                    str = "Mã hợp đồng không được trùng";
                    ketQua = 1;
                }
            }
            DongKetNoi();
            return ketQua == 0;
        }
        //Cập nhật khách trọ
        public bool capNhatHD(HopDong hd)
        {
            string mahd = hd.MaHD;
            string makt = hd.MaKT;
            string maPT = hd.MaPT;
            string ngayThue = hd.NgayThue;
            string ngayTra = hd.NgayTra;
            string tienCoc = hd.TienCoc;
            string tinhTrang = hd.TinhTrang.Trim();
            if (tinhTrang == "TRUE") tinhTrang = "1";
            else if (tinhTrang == "FALSE") tinhTrang = "0";

            string query = ("UPDATE dbo.HopDong SET maKT ='" + makt + "',MaPT ='" + maPT + "',NgayThue ='" + ngayThue + "',NgayTra='" + ngayTra + "',TienCoc=" + tienCoc + ",TinhTrang ='" + tinhTrang + "' WHERE MaHD='" + mahd + "'");
            return thucThiSQL(query);
        }
        //Tìm kiếm khách trọ
        public List<DTO.HopDong> timKiemHD(string luaChon, string chuoiTimKiem)
        {
            MoKetNoi();
            List<DTO.HopDong> dsHD = new List<DTO.HopDong>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.TimKiemHopDong(" + luaChon + ",N'" + chuoiTimKiem + "')",sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                //gán vào class hop dong
                HopDong hd = new HopDong();
                hd.MaHD = reader.GetString(0);
                hd.MaKT = reader.GetString(1);
                hd.MaPT = reader.GetString(2);
                hd.NgayThue = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                hd.NgayTra = reader.GetDateTime(4).ToString("dd/MM/yyyy");
                hd.TienCoc = reader.GetDouble(5).ToString();
                hd.TinhTrang = reader.GetBoolean(6).ToString();

                dsHD.Add(hd);
            }
            reader.Close();
            DongKetNoi();
            return dsHD;

        }
        //Xóa khách trọ
        public bool xoaHopDong(string mahd)
        {
            string query = ("DELETE FROM dbo.HopDong WHERE MaHD = '" + mahd + "'");
            return thucThiSQL(query);
        }
      
        //nhận vào mã khách trọ và trả về thông tin khách trọ
        public List<string> dsTTKT(string maKT)
        {
            MoKetNoi();
            List<string> dsTTKT = new List<string>(); //khoi tao ds chua makt
            SqlCommand sqlCmd = new SqlCommand("select HoTen, CMND, SDT, DiaChi from KhachTro where MaKT ='" + maKT + "'",sqlCon);
           
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string tenkt = reader.GetString(0);
                string cmnd = reader.GetString(1);
                string diaChi = reader.GetString(3);
                string sdt = reader.GetString(2);
                dsTTKT.Add(tenkt);
                dsTTKT.Add(cmnd);
                dsTTKT.Add(diaChi);
                dsTTKT.Add(sdt);
            }
            reader.Close();
            DongKetNoi();
            return dsTTKT;
        }
    }
}
