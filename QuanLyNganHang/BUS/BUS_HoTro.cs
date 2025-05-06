using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using ET;

namespace BUS
{
    public class BUS_HoTro
    {
        DAL_HoTro ht = new DAL_HoTro();

        public IQueryable LoadHT()
        {
            return ht.LoadHT();
        }

        public IQueryable LoadMaNV()
        {
            return ht.LoadMaNV();
        }

        public IQueryable LoadMaKM()
        {
            return ht.LoadMaKM();
        }
        public IQueryable TimHTTheoMaKH(string htmakh)
        {
            return ht.TimHTTheoMaKH(htmakh);
        }

        public IQueryable TimHTTheoDVHT(string htdvht)
        {
            return ht.TimHTTheoDVHT(htdvht);
        }

        public List<ET_HoTroReport> LayHT()
        {
            return ht.LayHT();
        }

        public List<ET_HoTroReport> LayHTTheoMa(string ma)
        {
            return ht.LayHTTheoMa(ma);
        }

        public List<ET_HoTroReport> LayHTTheoDVHT(string dvht)
        {
            return ht.LayHTTheoDVHT(dvht);
        }
        public bool ThemHT(ET_HoTro et)
        {
            return ht.ThemHT(et);
        }

        public bool SuaHT(ET_HoTro et)
        {
            return ht.SuaHT(et);
        }

        public bool XoaHT(ET_HoTro et)
        {
            return ht.XoaHT(et);
        }
    }
}
