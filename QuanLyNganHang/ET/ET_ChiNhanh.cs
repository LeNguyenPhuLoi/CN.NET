using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiNhanh
    {
        private string _MaCN;
        private string _TenCN;
        private string _DiaChi;

        public ET_ChiNhanh(string maCN, string tenCN, string diaChi)
        {
            _MaCN = maCN;
            _TenCN = tenCN;
            _DiaChi = diaChi;
        }

        public string MaCN { get => _MaCN; set => _MaCN = value; }
        public string TenCN { get => _TenCN; set => _TenCN = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
    }

    public class ET_ChiNhanhReport
    {
        public string MaCN { get; set; }
        public string TenCN { get; set; }
        public string DiaChi { get; set; }
    }
}
