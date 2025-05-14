using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TienTe
    {
        DAL_TienTe dltt = new DAL_TienTe();
        public IQueryable LoadTT()
        {
            return dltt.LoadTienTe();
        }

        public bool ThemTT(ET_TienTe et)
        {
            return dltt.ThemTienTe(et);
        }

        public bool CapNhatTT(ET_TienTe et)
        {
            return dltt.SuaTienTe(et);
        }

        public bool XoaTT(ET_TienTe et)
        {
            return dltt.XoaTT(et);
        }
    }
}
