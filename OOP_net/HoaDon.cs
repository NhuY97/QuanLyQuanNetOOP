using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    public class HoaDon
    {
        public string maHoaDon { get; set; }
        public KhachHang KH { get; set; }
        public NhanVien NV { get; set; }
        public MayTinh MT { get; set; }
        public double PhiSDMT { get; set; }
        public double thanhTien { get; set; }
        public HoaDon(string maHoaDon, KhachHang KH, NhanVien NV, MayTinh MT, double PhiSDMT, double thanhTien)
        {
            this.KH = KH;
            this.maHoaDon = maHoaDon;
            this.MT = MT;
            this.NV = NV;
            this.thanhTien = thanhTien;
            this.PhiSDMT = PhiSDMT;

        }
        public HoaDon(HoaDon HD)
        {
            this.NV = HD.NV;
            this.MT = HD.MT;
            this.maHoaDon = HD.maHoaDon;
            this.KH = HD.KH;
            this.thanhTien = HD.thanhTien;
            this.PhiSDMT = HD.PhiSDMT;
        }
    }
}
