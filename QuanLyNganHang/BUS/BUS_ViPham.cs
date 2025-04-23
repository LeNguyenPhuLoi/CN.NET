using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_ViPham
    {
        DAL_ViPham vp = new DAL_ViPham();

        public IQueryable LoadVP()
        {
            return vp.LoadVP();
        }

        public IQueryable LoadTenNV()
        {
            return vp.LoadTenNV();
        }

        public IQueryable LoadMoTaNQ()
        {
            return vp.LoadMoTaNQ();
        }

        public string LayTenNVTheoMa(string ma)
        {
            return vp.LayTenNVTheoMa(ma);
        }

        public string LayMoTaTheoMa(string ma)
        {
            return vp.LayMoTaTheoMa(ma);
        }

        public string LayMaNVTheoTen(string ten)
        {
            return vp.LayMaNVTheoTen(ten);
        }

        public string LayMaNQTheoMoTa(string mota)
        {
            return vp.LayMaNQTheoMoTa(mota);
        }

        public float LayMucPhatTheoMoTa(string mota)
        {
            return vp.LayMucPhatTheoMoTa(mota);
        }

        public bool ThemVP(ET_ViPham et)
        {
            return vp.ThemVP(et);
        }

        public bool SuaVP(ET_ViPham et)
        {
            return vp.SuaVP(et);
        }

        public bool XoaVP(ET_ViPham et)
        {
            return vp.XoaVP(et);
        }
    }
}
