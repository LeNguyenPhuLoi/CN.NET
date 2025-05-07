using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang kh = new DAL_KhachHang();

        public IQueryable LoadKH()
        {
            return kh.LoadKH();
        }

        public IQueryable TimKHTheoMa(string ma)
        {
            return kh.TimKHTheoMa(ma);
        }

        public IQueryable TimKHTheoTen(string ten)
        {
            return kh.TimKHTheoTen(ten);
        }

        public IQueryable TimKHTheoSDT(int sdt)
        {
            return kh.TimKHTheoSDT(sdt);
        }

        public List<ET_KhachHangReport> LayKH()
        {
            return kh.LayKH();
        }

        public List<ET_KhachHangReport> LayKHTheoMa(string ma)
        {
            return kh.LayKHTheoMa(ma);
        }

        public List<ET_KhachHangReport> LayKHTheoTen(string ten)
        {
            return kh.LayKHTheoTen(ten);
        }

        public List<ET_KhachHangReport> LayKHTheoSDT(int sdt)
        {
            return kh.LayKHTheoSDT(sdt);
        }

        public bool ThemKH(ET_KhachHang et)
        {
            return kh.ThemKH(et);
        }

        public bool SuaKH(ET_KhachHang et)
        {
            return kh.SuaKH(et);
        }

        public bool XoaKH(ET_KhachHang et)
        {
            return kh.XoaKH(et);
        }
    }
}
