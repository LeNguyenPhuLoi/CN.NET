using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_NoiQuy
    {
        DAL_NoiQuy nq = new DAL_NoiQuy();

        public IQueryable LoadNQ()
        {
            return nq.LoadNQ();
        }

        public bool ThemNQ(ET_NoiQuy et)
        {
            return nq.ThemNQ(et);
        }

        public bool SuaNQ(ET_NoiQuy et) 
        {
            return nq.SuaNQ(et);
        }

        public bool XoaNQ(ET_NoiQuy et) 
        {
            return nq.XoaNQ(et);
        }
    }
}
