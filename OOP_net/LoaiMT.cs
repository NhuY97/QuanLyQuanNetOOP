using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
   public class LoaiMT
    {
       public string maLoaiMay;
        public string Loaimt;
        public LoaiMT(string maLoaiMay, string Loaimt)
        {
            this.Loaimt = Loaimt;
            this.maLoaiMay = maLoaiMay;
        }
        public LoaiMT(LoaiMT lmt)
        {
            this.Loaimt = lmt.Loaimt;
            this.maLoaiMay = lmt.maLoaiMay;
        }
    }
}
