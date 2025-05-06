using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_BienLai
    {
        private string _MaBL;
        private string _LoaiBL;
        private float _SoTien;
        private DateTime _NgayLap;
        private string _MaNV;
        private string _MaKH;

        public ET_BienLai(string maBL, string loaiBL, float soTien, DateTime ngayLap, string maNV, string maKH)
        {
            _MaBL = maBL;
            _LoaiBL = loaiBL;
            _SoTien = soTien;
            _NgayLap = ngayLap;
            _MaNV = maNV;
            _MaKH = maKH;
        }

        public string MaBL { get => _MaBL; set => _MaBL = value; }
        public string LoaiBL { get => _LoaiBL; set => _LoaiBL = value; }
        public float SoTien { get => _SoTien; set => _SoTien = value; }
        public DateTime NgayLap { get => _NgayLap; set => _NgayLap = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
    }

    public class ET_BienLaiReport
    {
        public string MABL { get; set; }
        public string LOAIBL { get; set; }
        public float SOTIEN { get; set; }
        public DateTime NGAYLAP { get; set; }
        public string MANV { get; set; }
        public string MAKH { get; set; }
    }

}
