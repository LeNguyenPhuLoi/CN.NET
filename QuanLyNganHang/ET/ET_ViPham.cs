using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ViPham
    {
        private string _MaVP;
        private string _MaNV;
        private string _MaNQ;
        private DateTime _NgayViPham;
        private float _TienPhat;
        private int _SoLanViPham;
        private string _GhiChu;

        public ET_ViPham(string maVP, string maNV, string maNQ, DateTime ngayViPham, float tienPhat, int soLanViPham, string ghiChu)
        {
            _MaVP = maVP;
            _MaNV = maNV;
            _MaNQ = maNQ;
            _NgayViPham = ngayViPham;
            _TienPhat = tienPhat;
            _SoLanViPham = soLanViPham;
            _GhiChu = ghiChu;
        }

        public string MaVP { get => _MaVP; set => _MaVP = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaNQ { get => _MaNQ; set => _MaNQ = value; }
        public DateTime NgayViPham { get => _NgayViPham; set => _NgayViPham = value; }
        public float TienPhat { get => _TienPhat; set => _TienPhat = value; }
        public int SoLanViPham { get => _SoLanViPham; set => _SoLanViPham = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }

    public class ET_ViPhamReport
    {
        public string MaVP { get; set; }
        public string TenNV {  get; set; }
        public string MoTa {  get; set; }
        public DateTime NgayViPham { get; set; }
        public float TienPhat { get; set; }
        public int SoLanViPham { get; set; }
        public string GhiChu { get; set; }
    }
}
