using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuThuDAL:Database
    {
        public List<PhieuThu> hienThiDSPT() // Lấy danh sách phiếu chi
        {
            MoKetNoi();
            List<PhieuThu> dsPhieuThu = new List<PhieuThu>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Quanlythutien", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                PhieuThu PhieuThu = new PhieuThu(
                    reader.GetString(0).Trim(), // MaThu NgayChi SoTien LyDo
                    reader.GetString(1).Trim(), // MaThu NgayChi SoTien LyDo
                    reader.GetString(2).Trim(), // MaThu NgayChi SoTien LyDo
                    reader.GetDateTime(3).ToString("dd/MM/yyyy").Trim(), // NgayChi (assumed as DateTime in the database)
                    reader.GetDouble(4).ToString().Trim() // SoTien (assumed as Double/Float in the database)
                );
                dsPhieuThu.Add(PhieuThu);
            }
            reader.Close();
            DongKetNoi();
            return dsPhieuThu;
        }
        //lấy ds ct phiếu chi
        public List<PhieuThu> hienThiDSCTPT(string MaThu) // Lấy danh sách ct phiếu chi
        {
            MoKetNoi();
            List<PhieuThu> dsCTPhieuThu = new List<PhieuThu>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM ChiTietQuanlythutien where MaThu ='"+MaThu+"'", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                PhieuThu PhieuThu = new PhieuThu(
                    reader.GetString(0).Trim(), // MaThu NgayChi SoTien LyDo
                    reader.GetString(1).Trim(), // MaDV NgayChi SoTien LyDo
                    reader.GetInt32(2).ToString()// SoLuong NgayChi SoTien LyDo
                );
                dsCTPhieuThu.Add(PhieuThu);
            }
            reader.Close();
            DongKetNoi();
            return dsCTPhieuThu;
        }
        //Tìm kiếm phieu thu
        public List<DTO.PhieuThu> timKiemPThu(string luaChon, string chuoiTimKiem)
        {
            MoKetNoi();
            List<DTO.PhieuThu> dsPT = new List<DTO.PhieuThu>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.TimKiemPhieuThu(" + luaChon + ",N'" + chuoiTimKiem + "')", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                //gán vào class hop dong
                PhieuThu pt = new PhieuThu();
                pt.MaThu = reader.GetString(0);
                pt.MaPT = reader.GetString(1);
                pt.MaKT = reader.GetString(2);
                pt.NgayThu = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                pt.TongTien = reader.GetDouble(4).ToString();
                dsPT.Add(pt);
            }
            reader.Close();
            DongKetNoi();
            return dsPT;
        }
        public bool themPT(PhieuThu PhieuThu)
        {
            string query = "INSERT INTO QuanLyThuTien VALUES ('" + PhieuThu.MaThu + "', '" + PhieuThu.MaPT + "', '" + PhieuThu.MaKT + "', '" + PhieuThu.NgayThu + "'," + PhieuThu.TongTien + ")";
            return thucThiSQL(query);
        }
        //kiem tra mã dich vu
        public bool kiemTraMaPT(string MaThu)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM QuanLyThuTien WHERE MaThu = '" + MaThu + "'", sqlCon);
            int k = (int)sqlCmd.ExecuteScalar();
            DongKetNoi();
            return (k > 0); //k>0 có nghĩa là mã tồn tại
        }
        // Cập nhật phiếu thu
        public bool capNhatPT(PhieuThu phieuThu)
        {
            string query = "UPDATE QuanLyThuTien SET  MaPT = '" + phieuThu.MaPT + "', MaKT = '" + phieuThu.MaKT + "', NgayThu = '" + phieuThu.NgayThu + "',TongTien = " + phieuThu.TongTien + " WHERE MaThu = '" + phieuThu.MaThu + "'";
            return thucThiSQL(query);
        }
        // Xóa phiếu thu
        public bool xoaPT(string MaThu)
        {
            string query = "DELETE FROM QuanLyThuTien WHERE MaThu = '" + MaThu + "'";
            return thucThiSQL(query);
        }
        //them chi tiet pthu
        public bool themCTPT(PhieuThu PhieuThu)
        {
            string query = "INSERT INTO ChiTietQuanLyThuTien VALUES ('" + PhieuThu.MaThu + "', '" + PhieuThu.MaDV + "', " + PhieuThu.SoLuong +")";
            return thucThiSQL(query);
        }
        // Xóa chi tiet phiếu thu
        public bool xoaCTPT(string MaThu, string MaDV)
        {
           
            string query = "DELETE FROM ChiTietQuanLyThuTien WHERE MaThu = '" + MaThu + "' AND MaDV = '"+ MaDV+"'";
            return thucThiSQL(query);
        }
        //cập nhật chi tiết phiếu cthu
        public bool capNhatCTPT(PhieuThu ctpt)
        {

            string query = "Update ChiTietQuanLyThuTien Set soLuong = " + ctpt.SoLuong + " WHERE MaThu = '" + ctpt.MaThu + "' AND MaDV = '" + ctpt.MaDV + "' ";
            return thucThiSQL(query);
        }
        //kiem tra phiếu thu - mã pt và kt phải được kí kết rồi
        public bool kiemTraHopDong(string MaPT , string MaKT) 
        {
            //lấy ra hợp động đã được thuê
            string query = "SELECT COUNT(*) FROM HopDong WHERE mapt = '"+MaPT+"'AND MaKT = '"+MaKT+"' AND TinhTrang = 1";
            return thucThiSQL_Count(query);
        }
       
    }
}
