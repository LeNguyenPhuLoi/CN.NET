using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using ET;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        DAL_KhuyenMai km = new DAL_KhuyenMai();

        public IQueryable LoadKM()
        {
            return km.LoadKM();
        }

        public IQueryable TimKMTheoMa(string ma)
        {
            return km.TimKMTheoMa(ma);
        }

        public IQueryable TimKMTheoTen(string ten)
        {
            return km.TimKMTheoTen(ten);
        }

        public bool ThemKM(ET_KhuyenMai et)
        {
            return km.ThemKM(et);
        }

        public bool SuaKM(ET_KhuyenMai et)
        {
            return km.SuaKM(et);
        }

        public bool XoaKM(ET_KhuyenMai et)
        {
            return km.XoaKM(et);
        }
    }
}
