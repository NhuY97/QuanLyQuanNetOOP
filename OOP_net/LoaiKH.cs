using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    public class LoaiKH
    {
        public string maLoaiKH { get; set; }
        public string LoaiKh { get; set; }
        public LoaiKH(string maLoaiKH, string LoaiKh)
        {
            this.LoaiKh = LoaiKh;
            this.LoaiKh = LoaiKh;
        }
        public LoaiKH(LoaiKH LKH)
        {
            this.maLoaiKH = LKH.maLoaiKH;
            this.LoaiKh = LKH.LoaiKh;
        }
    }
}
