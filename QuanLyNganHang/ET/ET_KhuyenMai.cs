using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhuyenMai
    {
        private string _MaKM;
        private string _TenKM;
        private DateTime _NgayBatDau;
        private DateTime _NgayKetThuc;
        private string _DieuKien;

        public ET_KhuyenMai(string maKM, string tenKM, DateTime ngayBatDau, DateTime ngayKetThuc, string dieuKien)
        {
            _MaKM = maKM;
            _TenKM = tenKM;
            _NgayBatDau = ngayBatDau;
            _NgayKetThuc = ngayKetThuc;
            _DieuKien = dieuKien;
        }

        public string MaKM { get => _MaKM; set => _MaKM = value; }
        public string TenKM { get => _TenKM; set => _TenKM = value; }
        public DateTime NgayBatDau {  get => _NgayBatDau; set =>  _NgayBatDau = value;}
        public DateTime NgayKetThuc {  get => _NgayKetThuc; set =>  _NgayKetThuc = value;}
        public string DieuKien { get => _DieuKien; set => _DieuKien = value;} 
    }
}
