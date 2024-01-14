using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThu
    {
        public string MaThu { get; set; }
        public string MaPT { get; set; }
        public string MaKT { get; set; }
        public string NgayThu { get; set; }
        public string TongTien { get; set; }
        public string MaDV { get; set; }
        public string SoLuong { get; set; }


        public PhieuThu(string MaThu, string MaPT, string MaKT, string NgayThu, string TongTien)
        {
            this.MaThu = MaThu;
            this.MaPT = MaPT;
            this.MaKT = MaKT;
            this.NgayThu = NgayThu;
            this.TongTien = TongTien;

        }
        public PhieuThu(string MaThu, string MaDV, string SoLuong)
        {
            this.MaThu = MaThu;
            this.MaDV = MaDV;
            this.SoLuong = SoLuong;
        }
        public PhieuThu() 
        {
            this.MaThu = "";
            this.MaPT = "";
            this.MaKT = "";
            this.NgayThu = "";
            this.TongTien = "";
            this.MaDV = "";
            this.SoLuong = "";
        }
    }
}
