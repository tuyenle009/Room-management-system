using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace QuanLyPhongTro_10122399
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand sqlCmd; //truy van cau lenh ins, upd, del,..
        //SqlDataReader reader; //dung de doc dlieu trong table
        public List<TaiKhoan> lstTaiKhoan(string query)
        {
            List<TaiKhoan> taiKhoans= new List<TaiKhoan>();

            using (SqlConnection sqlCon= Connection.GetSqlCon())
            {
                sqlCon.Open();
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = query;
                sqlCmd.Connection = sqlCon;
                //Thuc thi
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(reader.GetString(0).ToString(), reader.GetString(1).ToString()));
                }
                //Dong reader
                sqlCon.Close();
                reader.Close();
            }
            return taiKhoans;
        }
        public void Command(string query )//dung để đăng kí tài khoản
        {
            using (SqlConnection sqlCon = Connection.GetSqlCon())
            {
                sqlCon.Open();
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = query;
                sqlCmd.Connection = sqlCon;
                //Thuc thi
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }
    }
}
