using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuChi
    {
        public string MaPC { get; set; }
        public string NgayChi { get; set; }
        public string SoTien { get; set; }
        public string LyDo { get; set; }
        public string MaPT { get; set; }


        public PhieuChi(string MaPC, string NgayChi, string SoTien,string LyDo, string MaPT)
        {
            this.MaPC = MaPC;
            this.NgayChi = NgayChi;
            this.SoTien= SoTien;
            this.LyDo= LyDo;
            this.MaPT = MaPT;

        }
        public PhieuChi() { }
    }
}
