using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    public class TrucPhong
    {
        public int maTrucPhong { get; set; }
        public NhanVien nhanvien {get; set;}
        public Phong phong { get; set; }
        public string thoidiem { get; set; }
        public TrucPhong(NhanVien nhanvien, Phong phong, string thoidiem)
        {
            this.phong = phong;
            this.nhanvien = nhanvien;
            this.thoidiem = thoidiem;
        }
        public TrucPhong(TrucPhong TP)
        {
            this.phong = TP.phong;
            this.nhanvien = TP.nhanvien;
            this.thoidiem = TP.thoidiem;
        }
    }
}
