using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NoiQuy
    {
        private string _MaNQ;
        private string _MoTa;
        private float _MucPhat;
        private string _GhiChu;

        public ET_NoiQuy(string maNQ, string moTa, float mucPhat, string ghiChu)
        {
            _MaNQ = maNQ;
            _MoTa = moTa;
            _MucPhat = mucPhat;
            _GhiChu = ghiChu;
        }

        public string MaNQ { get => _MaNQ; set => _MaNQ = value; }
        public string MoTa { get => _MoTa; set => _MoTa = value; }
        public float MucPhat { get => _MucPhat; set => _MucPhat = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }

    public class ET_NoiQuyReport
    {
        public string MaNQ { get; set; }
        public string MoTa { get; set; }
        public float MucPhat { get; set; }
        public string GhiChu { get; set; }
    }
}
