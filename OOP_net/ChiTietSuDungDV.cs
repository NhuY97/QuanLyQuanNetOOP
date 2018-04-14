using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
   public class ChiTietSuDungDV
    {
        public HoaDon hoadon { get; set; }
        public DichVu dichvu { get; set; }
        public int soLuong { get; set; }
        public double PhiSDDV { get; set; }
        public ChiTietSuDungDV(HoaDon hoadon, DichVu dichvu, int soLuong, double PhiSDDV)
        {
            this.dichvu = dichvu;
            this.hoadon = hoadon;
            this.PhiSDDV = PhiSDDV;
            this.soLuong = soLuong;      
        }
        public ChiTietSuDungDV(ChiTietSuDungDV CTSDDV)
        {         
            this.soLuong = CTSDDV.soLuong;
            this.PhiSDDV = CTSDDV.PhiSDDV;
            this.hoadon = CTSDDV.hoadon;
            this.dichvu = CTSDDV.dichvu;
        }
    }
}
