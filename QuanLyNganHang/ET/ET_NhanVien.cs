using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhanVien
    {
        private string _MaNV;
        private string _TenNV;
        private string _GioiTinh;
        private DateTime _NgaySinh;
        private string _Chuc;
        private float _Luong;
        private string _DiaCHi;
        private int _SDT;
        private int _MaPB;
        private string _MaCN;

        public ET_NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string chuc, float luong, string diaCHi, int sDT, int maPB, string maCN)
        {
            _MaNV = maNV;
            _TenNV = tenNV;
            _GioiTinh = gioiTinh;
            _NgaySinh = ngaySinh;
            _Chuc = chuc;
            _Luong = luong;
            _DiaCHi = diaCHi;
            _SDT = sDT;
            _MaPB = maPB;
            _MaCN = maCN;
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string Chuc { get => _Chuc; set => _Chuc = value; }
        public float Luong { get => _Luong; set => _Luong = value; }
        public string DiaCHi { get => _DiaCHi; set => _DiaCHi = value; }
        public int SDT { get => _SDT; set => _SDT = value; }
        public int MaPB { get => _MaPB; set => _MaPB = value; }
        public string MaCN { get => _MaCN; set => _MaCN = value; }
    }

    public class ET_NhanVienReport
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Chuc { get; set; }
        public float Luong { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string TenPB { get; set; }
        public string TenChiNhanh { get; set; }
    }
}
