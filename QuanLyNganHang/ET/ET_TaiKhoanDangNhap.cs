using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TaiKhoanDangNhap
    {
        public ET_TaiKhoanDangNhap(string tENDN, string pASS, string qUYEN, string mANV)
        {
            TENDN = tENDN;
            PASS = pASS;
            QUYEN = qUYEN;
            MANV = mANV;
        }

        public string TENDN { get; set; }
        public string PASS { get; set; }
        public string QUYEN { get; set; }
        public string MANV { get; set; }
    }
}
