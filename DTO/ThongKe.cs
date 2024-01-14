using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKe
    {
        public string MaThu { get; set; }
        public string MaPT { get; set; }
        public string NgayThu { get; set; }
        public string GiaPhong { get; set; }
        public string TongTienDN { get; set; }
        public string TongTienDV { get; set; }
        public string TongTienThu { get; set; }
        public string TongTienChi { get; set; }
        public string LoiNhuan { get; set; }
        //Số lượng ng sử dụng phòng
        public int SLPhongDaThue { get; set; }
        public int SLPhongDaChuaThue { get; set; }
        public int SLTongPhong { get; set; }
        //so dien da su dung
        public int TongSoDienSD { get; set; }
        public int TongSoNuocSD { get; set; }

        //phong 
        public ThongKe(int SLPhongDaThue,int SLPhongDaChuaThue, int SLTongPhong)
        {
            this.SLPhongDaThue= SLPhongDaThue;
            this.SLPhongDaChuaThue = SLPhongDaChuaThue;
            this.SLTongPhong = SLTongPhong;
        }
        //so dien nuoc
        public ThongKe(int TongSoDienSD, int TongSoNuocSD)
        {
            this.TongSoDienSD = TongSoDienSD;
            this.TongSoNuocSD = TongSoNuocSD;
        }
        //dich vu
        public ThongKe(string MaThu, string MaPT, string NgayThu, string GiaPhong, string TongTienDN, string TongTienDV,string TongTienThu)
        {
            this.MaThu = MaThu;
            this.MaPT = MaPT;
            this.NgayThu = NgayThu;
            this.GiaPhong = GiaPhong;
            this.TongTienDN = TongTienDN;
            this.TongTienDV = TongTienDV;
            this.TongTienThu = TongTienThu;
        }
       
        public ThongKe()
        {
            this.MaThu = "";
            this.MaPT = "";
            this.NgayThu = "";
            this.GiaPhong = "";
            this.TongTienDN = "";
            this.TongTienDV = "";
            this.TongTienThu = "";
            this.TongTienChi = "";
            this.LoiNhuan = "";
            this.SLPhongDaThue = 0;
            this.SLPhongDaChuaThue = 0;
            this.SLTongPhong=0;
        }
        public ThongKe(string TongTienThu, string TongTienChi)
        {
            this.TongTienThu = TongTienThu;
            this.TongTienChi = TongTienChi;
            this.LoiNhuan = (int.Parse(TongTienThu) - int.Parse(TongTienChi)).ToString(); //tinh tiền lợi nhuận
        }
      
    }
}
