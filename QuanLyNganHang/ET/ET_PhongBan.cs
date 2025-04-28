using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_PhongBan
    {
        private int _MaPB;
        private string _TenPB;
        private string _TRPhong;

        public ET_PhongBan(int maPB, string tenPB, string tRPhong)
        {
            _MaPB = maPB;
            _TenPB = tenPB;
            _TRPhong = tRPhong;
        }

        public int MaPB { get => _MaPB; set => _MaPB = value; }
        public string TenPB { get => _TenPB; set => _TenPB = value; }
        public string TRPhong { get => _TRPhong; set => _TRPhong = value; }
    }

    public class ET_PhongBanReport
    {
        public int MaPB { get; set; }
        public string TenPB { get; set; }
        public string TRPhong { get; set; }
    }
}
