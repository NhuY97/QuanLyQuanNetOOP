using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    public class MayTinh
    {
        public string maMT { get; set; }
        public LoaiMT loaimaytinh { get; set; }
        public Phong phong { get; set; }
        public MayTinh(string maMT, LoaiMT loaimaytinh, Phong phong)
        {
            this.loaimaytinh = loaimaytinh;
            this.maMT = maMT;
            this.phong = phong;
        }
        public MayTinh(MayTinh mt)
        {
            this.phong = mt.phong;
            this.maMT = mt.maMT;
            this.loaimaytinh = mt.loaimaytinh;
        }

    }
}
