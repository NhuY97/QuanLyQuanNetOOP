using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    public class KhachHang
    {
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string diaChi { get; set; }
        public string sdtKH { get; set; }
        public string gioiTinh { get;set; }
        public LoaiKH LKH { get; set; }
        public KhachHang(string maKH, string tenKH, string diaChi, string sdtKH, string gioiTinh, LoaiKH LKH)
        {
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.maKH = maKH;
            this.sdtKH = sdtKH;
            this.tenKH = tenKH;
            this.LKH = LKH;
        }
        public KhachHang(KhachHang KH)
        {
            this.diaChi = KH.diaChi;
            this.gioiTinh = KH.gioiTinh;
            this.maKH = KH.maKH;
            this.sdtKH = KH.sdtKH;
            this.tenKH = KH.tenKH;
            this.LKH = KH.LKH;
        }
    }
}
