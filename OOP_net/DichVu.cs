using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    public class DichVu
    {
        public string maDichVu { get; set; }
        public LoaiDichVu loaidichvu { get; set; }
        public string tendichvu { get; set; }
        public DichVu(string maDichVu, LoaiDichVu loaidichvu, string tendichvu)
        {
            this.loaidichvu = loaidichvu;
            this.maDichVu = maDichVu;
            this.tendichvu = tendichvu;
        }
        public DichVu(DichVu DV)
        {
            this.maDichVu = DV.maDichVu;
            this.loaidichvu = DV.loaidichvu;
            this.tendichvu = DV.tendichvu;
        }
    }
}
