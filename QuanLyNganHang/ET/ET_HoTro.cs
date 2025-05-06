using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HoTro
    {
        private string _MaKH;
        private string _DVHT;
        private string _MaNV;
        private string _MaKM;
        

        public ET_HoTro(string maKH, string dVHT, string maNV, string maKM)
        {
            _MaKH = maKH;
            _DVHT = dVHT;
            _MaNV = maNV;
            _MaKM = maKM;
            
        }

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string DVHT { get => _DVHT; set => _DVHT = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaKM { get => _MaKM; set => _MaKM = value; }
        
    }

    public class ET_HoTroReport
    {
        public string MAKH { get; set; }
        public string DVHT { get; set; }
        public string MANV { get; set; }
        public string MAKM { get; set; }
        
    }
}
