using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    public class NhanVien
    {
        public string maNhanvien { get; set; }
        public string tenNV { get; set; }
        public string diaChiNV { get; set; }
        public string gioiTinhNV { get; set; }
        public string sdtNV { get; set; }
        public NhanVien(string maNhanVien, string tenNV, string diaChiNV, string gioitinhNV, string sdtNV)
        {
            this.diaChiNV = diaChiNV;
            this.gioiTinhNV = gioiTinhNV;
            this.maNhanvien = maNhanvien;
            this.sdtNV = sdtNV;
            this.tenNV = tenNV;     
        }
        public NhanVien(NhanVien NV)
        {
            this.tenNV = NV.tenNV;
            this.sdtNV = NV.sdtNV;
            this.maNhanvien = NV.maNhanvien;
            this.gioiTinhNV = NV.gioiTinhNV;
            this.diaChiNV = NV.diaChiNV;
        }
    }
}
