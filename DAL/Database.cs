using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Database
    {

        string strCon = @"Data Source=LAPTOP-B8LC3QPR;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        protected SqlConnection sqlCon = null;
        protected SqlDataAdapter adapter = null;
        protected DataTable dt = null;
        //Ham ket noi
        public void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
            { sqlCon.Open(); }
        }
        //Ham dong ket noi
        public void DongKetNoi()
        {
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
                sqlCon.Close();
        }
        public bool thucThiSQL(string query, byte[] b=null)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            int k = (int)sqlCmd.ExecuteNonQuery();
            DongKetNoi();
            return (k > 0);

        }
        public bool thucThiSQL_Count(string query, byte[] b = null)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            int k = (int)sqlCmd.ExecuteScalar();
            Console.WriteLine(k);
            Console.WriteLine(k > 0);
            Console.WriteLine("_________________");
            DongKetNoi();
            return (k > 0);

        }

        public DataTable dsDuLieu(string query)
        {
            MoKetNoi();
            adapter = new SqlDataAdapter(query,sqlCon);
            dt = new DataTable();
            adapter.Fill(dt);
            DongKetNoi();
            return dt;
        }


        //danh sách khách trọ và phòng trọ
        public List<string> dsKhachTro()
        {
            MoKetNoi();
            List<string> dsKT = new List<string>(); //khoi tao ds chua makt
            SqlCommand sqlCmd = new SqlCommand("select makt from KhachTro", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string makt = reader.GetString(0);
                dsKT.Add(makt);
            }
            reader.Close();
            DongKetNoi();
            return dsKT;
        }

        public List<string> dsPhongTro()
        {
            MoKetNoi();
            List<string> dsPT = new List<string>(); //khoi tao ds chua makt
            SqlCommand sqlCmd = new SqlCommand("select mapt from PhongTro", sqlCon);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string makt = reader.GetString(0);
                dsPT.Add(makt);
            }
            reader.Close();
            DongKetNoi();
            return dsPT;
        }
        public List<string> dsDichVu()
        {
            MoKetNoi();
            List<string> dsDV = new List<string>(); //khoi tao ds chua makt
            SqlCommand sqlCmd = new SqlCommand("select madv from DichVu", sqlCon);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string makt = reader.GetString(0);
                dsDV.Add(makt);
            }
            reader.Close();
            DongKetNoi();
            return dsDV;
        }
    }
}
