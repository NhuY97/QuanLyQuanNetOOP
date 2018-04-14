using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
   public class LoaiDichVu
    {
        public string maLoaiDV { get; set; }
        public string LoaiDV { get; set; }
        public LoaiDichVu(string maLoaiDV, string LoaiDV)
        {
            this.LoaiDV = LoaiDV;
            this.maLoaiDV = maLoaiDV;
        }
        public LoaiDichVu(LoaiDichVu loaidv)
        {
            this.maLoaiDV = loaidv.maLoaiDV;
            this.LoaiDV = loaidv.LoaiDV;
        }
    }
}
