using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhachHang
    {
        private string _MaKH;
        private string _TenKH;
        private int _SDT;
        private string _GioiTinh;
        private string _DiaChi;
        private DateTime _NgaySinh;

        public ET_KhachHang(string maKH, string tenKH, int sDT, string gioiTinh, string diaChi, DateTime ngaySinh)
        {
            _MaKH = maKH;
            _TenKH = tenKH;
            _SDT = sDT;
            _GioiTinh = gioiTinh;
            _DiaChi = diaChi;
            _NgaySinh = ngaySinh;
        }

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public int SDT { get => _SDT; set => _SDT = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
    }

    public class ET_KhachHangReport
    {
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public int SDT { get; set; }
        public string GIOITINH { set; get; }
        public string DCHI { get; set; }
        public DateTime NSINH { set; get; }
    }
}
