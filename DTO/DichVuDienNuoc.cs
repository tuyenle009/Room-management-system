using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDienNuoc
    {
        public string MaDN { get; set; }
        public string MaPT { get; set; }
        public string TuNgay { get; set; }
        public string ToiNgay { get; set; }
        public string ChiSoCu { get; set; }
        public string ChiSoMoi { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public DichVuDienNuoc(string MaDN, string MaPT, string TuNgay, string ToiNgay, string ChiSoCu, string ChiSoMoi, string DonGia, string ThanhTien)
        {
            this.MaDN = MaDN;
            this.MaPT = MaPT;
            this.TuNgay = TuNgay;
            this.ToiNgay = ToiNgay;
            this.ChiSoCu = ChiSoCu;
            this.ChiSoMoi = ChiSoMoi;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
        }
        public DichVuDienNuoc() { }
    }
}
