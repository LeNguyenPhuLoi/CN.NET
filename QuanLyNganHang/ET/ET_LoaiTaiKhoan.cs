using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiTaiKhoan
    {
        public ET_LoaiTaiKhoan(string maloai, string tennganhang)
        {
            MALOAI = maloai;
            TENNGANHANG = tennganhang;
        }

        public string MALOAI { get; set; }
        public string TENNGANHANG { get; set; }
    }
}
