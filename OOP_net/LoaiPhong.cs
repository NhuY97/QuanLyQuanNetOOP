using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    public class LoaiPhong
    {
        public string maLoaiPhong { get; set; }
        public string Loaiphong { get; set; }
        public LoaiPhong(string maLoaiPhong, string Loaiphong)
        {
            this.Loaiphong = Loaiphong;
            this.maLoaiPhong = maLoaiPhong;
        }
        public LoaiPhong(LoaiPhong lp)
        {
            this.Loaiphong = lp.Loaiphong;
            this.maLoaiPhong = lp.maLoaiPhong;
        }
    }
}
