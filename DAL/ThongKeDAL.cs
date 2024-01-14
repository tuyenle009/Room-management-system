using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDAL: Database
    {
        public DataTable layBangTKDV(string thang, string nam)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM dbo.Fn_ThongKeDichVu(" + thang + ", " + nam + ")";
            MoKetNoi();
            adapter = new SqlDataAdapter(query, sqlCon);
            adapter.Fill(dataTable);
            DongKetNoi();
            return dataTable;

        }
        //lấy ra danh sách thống kê dịch vụ
        public List<ThongKe> hienThiDSTKDV(string thang, string nam) // Lấy danh sách phiếu chi
        {
            MoKetNoi();
            List<ThongKe> dsThongKe = new List<ThongKe>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.Fn_ThongKeDichVu("+ thang + ", "+nam+")", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                ThongKe tk = new ThongKe(
                      reader.GetString(0).Trim(),
                      reader.GetString(1).Trim(),
                      reader.GetDateTime(2).ToString("dd/MM/yyyy").Trim(),
                      reader.GetDouble(3).ToString().Trim(),
                      reader.GetDouble(4).ToString().Trim(),
                      reader.GetDouble(5).ToString().Trim(),
                      reader.GetDouble(6).ToString().Trim()
                     );
                dsThongKe.Add(tk);
            }
            reader.Close();
            DongKetNoi();
            return dsThongKe;
        }
        //lấy ra danh sách thống kê số lượng phong thuê
        public ThongKe thongKeDSPT() // Lấy danh sách phiếu chi
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.VW_TinhTrangPT", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            ThongKe tk = new ThongKe(reader.GetInt32(0), reader.GetInt32(01), reader.GetInt32(02));
            reader.Close();
            DongKetNoi();
            return tk;
        }
        //lấy ra danh sách thống kê số lượng phong thuê
        public ThongKe thongKeDienNuoc(string thang, string nam) // Lấy danh sách phiếu chi
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.Fn_TongChiSoTieuThu("+thang+","+nam+")", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            ThongKe tk = new ThongKe(reader.GetInt32(0), reader.GetInt32(01));
            reader.Close();
            DongKetNoi();
            return tk;
        }
        //tổng tiền chi trong 1 tháng
        public float tienChiTrongThang(string thang, string nam)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT dbo.FN_TienChiTrongThang(" + thang + "," + nam + ")", sqlCon);
            float tk = Convert.ToSingle(sqlCmd.ExecuteScalar());
            DongKetNoi();
            return tk;
        }
    }
}
