using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    public class Phong
    {
        public string maPhong { get; set; }
        public LoaiPhong lp { get; set; }
        public Phong(string maPhong, LoaiPhong lp)
        {
            this.lp = lp;
            this.maPhong = maPhong;
        }
        public Phong(Phong p)
        {
            this.lp = p.lp;
            this.maPhong = p.maPhong;
        }
    }
}
