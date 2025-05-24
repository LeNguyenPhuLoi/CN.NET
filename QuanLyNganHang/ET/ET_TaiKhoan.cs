using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TaiKhoan
    {
        public ET_TaiKhoan(string mATK, float sODU, DateTime nGAYLAP, string mAKH, string lOAITK, string lOAITIEN, string mANV)
        {
            MATK = mATK;
            SODU = sODU;
            NGAYLAP = nGAYLAP;
            MAKH = mAKH;
            LOAITK = lOAITK;
            LOAITIEN = lOAITIEN;
            MANV = mANV;
        }

        public string MATK { get; set; }
        public float SODU { get; set; }
        public DateTime NGAYLAP { get; set; }
        public string MAKH { get; set; }
        public string LOAITK { get; set; }
        public string LOAITIEN { get; set; }
        public string MANV { get; set; }

    }

}
public class ET_TaiKhoanReport
{
    public string MATK { get; set; }
    public float SODU { get; set; }
    public DateTime NGAYLAP { get; set; }
    public string MAKH { get; set; }
    public string TenNH { get; set; }
    public string TenKH { get; set; }
    public string TenTT { get; set; }
}
