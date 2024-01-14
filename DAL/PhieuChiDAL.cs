using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuChiDAL: Database
    {
        public List<PhieuChi> hienThiDSPC() // Lấy danh sách phiếu chi
        {
            MoKetNoi();
            List<PhieuChi> dsPhieuChi = new List<PhieuChi>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM PhieuChi", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                PhieuChi phieuChi = new PhieuChi( 
                    reader.GetString(0).Trim(), // MaPC NgayChi SoTien LyDo
                    reader.GetDateTime(1).ToString("dd/MM/yyyy").Trim(), // NgayChi (assumed as DateTime in the database)
                    reader.GetDouble(2).ToString().Trim(), // SoTien (assumed as Double/Float in the database)
                    reader.GetString(3).Trim(), // LyDo
                    reader.GetString(4).Trim() // MaPT
                );
                dsPhieuChi.Add(phieuChi);
            }
            reader.Close();
            DongKetNoi();
            return dsPhieuChi;
        }
        //tìm kiếm phiếu chi

        public PhieuChi timKiemPC(string maPC)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM PhieuChi where maPC = '"+ maPC + "'", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            PhieuChi phieuChi = new PhieuChi(
                   reader.GetString(0).Trim(), // MaPC NgayChi SoTien LyDo
                   reader.GetDateTime(1).ToString("dd/MM/yyyy").Trim(), // NgayChi (assumed as DateTime in the database)
                   reader.GetDouble(2).ToString().Trim(), // SoTien (assumed as Double/Float in the database)
                   reader.GetString(3).Trim(), // LyDo
                   reader.GetString(4).Trim() // MaPT
               );
            reader.Close();
            DongKetNoi();
            return phieuChi;
        }



        public bool themPC(PhieuChi phieuChi)
        {
            string query = "INSERT INTO PhieuChi VALUES ('" + phieuChi.MaPC + "', '" + phieuChi.NgayChi + "', " + phieuChi.SoTien + ", N'" + phieuChi.LyDo + "','"+phieuChi.MaPT+"')";
            return thucThiSQL(query);
        }
        //kiem tra mã dich vu
        public bool kiemTraMaPC(string maPC)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM PhieuChi WHERE MaPC = '" + maPC + "'", sqlCon);
            int k = (int)sqlCmd.ExecuteScalar();
            DongKetNoi();
            return (k > 0); //k>0 có nghĩa là mã tồn tại
        }
        // Cập nhật phiếu chi 
        public bool capNhatPC(PhieuChi pheuChi)
        {
            string query = "UPDATE PhieuChi SET  NgayChi = N'" + pheuChi.NgayChi + "', SoTien = " + pheuChi.SoTien + ", LyDo = N'" + pheuChi.LyDo + "',MaPT = '"+pheuChi.MaPT+"' WHERE MaPC = '" + pheuChi.MaPC + "'";
            return thucThiSQL(query);
        }
        // Xóa phiếu chi
        public bool xoaPC(string maPC)
        {
            string query = "DELETE FROM PhieuChi WHERE MaPC = '" + maPC + "'";
            return thucThiSQL(query);
        }
        

        //ds phong tro
        //public List<string> dsPhongTro()
        //{
        //    MoKetNoi();
        //    List<string> dsPT = new List<string>(); //khoi tao ds chua makt
        //    SqlCommand sqlCmd = new SqlCommand("select mapt from PhongTro", sqlCon);
        //    SqlDataReader reader = sqlCmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        string makt = reader.GetString(0);
        //        dsPT.Add(makt);
        //    }
        //    reader.Close();
        //    DongKetNoi();
        //    return dsPT;
        //}
    }
}
