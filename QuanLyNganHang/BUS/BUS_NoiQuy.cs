using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;
using System.Globalization;

namespace BUS
{
    public class BUS_NoiQuy
    {
        DAL_NoiQuy nq = new DAL_NoiQuy();

        public IQueryable LoadNQ()
        {
            return nq.LoadNQ();
        }

        public IQueryable TimNQTheoMa(string ma)
        {
            return nq.TimNQTheoMa(ma);
        }

        public IQueryable TimNQTheoMoTa(string mota)
        {
            return nq.TimNQTheoMoTa(mota);
        }

        public List<ET_NoiQuyReport> LayNQChoReport()
        {
            return nq.LayNQChoReport();
        }

        public List<ET_NoiQuyReport> LayNQChoReportTheoMa(string ma)
        {
            return nq.LayNQChoReportTheoMa(ma);
        }

        public List<ET_NoiQuyReport> LayNQChoReportTheoMoTa(string mota)
        {
            return nq.LayNQChoReportTheoMoTa(mota);
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
