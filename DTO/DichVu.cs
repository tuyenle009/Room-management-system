using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string DonGia { get; set; }
        public string DonViTinh { get; set; }

        public DichVu(DataRow row) 
        {
            this.MaDV = row["MaDV"].ToString();
            this.TenDV = row["TenDV"].ToString() ;
            this.DonGia = row["DonGia"].ToString();
            this.DonViTinh = row["DonViTinh"].ToString();
        }
        public DichVu(string MaDV, string TenDV, string DonGia, string DonViTinh) 
        {
            this.MaDV = MaDV;
            this.TenDV= TenDV;
            this.DonGia= DonGia;
            this.DonViTinh = DonViTinh;
        }
        public DichVu() { }
    }
}
