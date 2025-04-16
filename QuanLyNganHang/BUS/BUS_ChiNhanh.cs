using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_ChiNhanh
    {
        DAL_ChiNhanh cn = new DAL_ChiNhanh();

        public IQueryable LoadCN()
        {
            return cn.LoadCN();
        }

        public bool ThemCN(ET_ChiNhanh et)
        {
            return cn.ThemCN(et);
        }

        public bool SuaCN(ET_ChiNhanh et)
        {
            return cn.SuaCN(et);
        }

        public bool XoaCN(ET_ChiNhanh et)
        {
            return cn.XoaCN(et);
        }
    }
}
