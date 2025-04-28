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

        public IQueryable TimCNTheoMa(string ma)
        {
            return cn.TimCNTheoMa(ma);
        }

        public IQueryable TimCNTheoTen(string ten)
        {
            return cn.TimCNTheoTen(ten);
        }

        public IQueryable TimCNTheoDiaChi(string diachi)
        {
            return cn.TimCNTheoDiaChi(diachi);
        }

        public List<ET_ChiNhanhReport> LayCNChoReport()
        {
            return cn.LayCNChoReport();
        }

        public List<ET_ChiNhanhReport> LayCNChoReportTheoMaCN(string ma)
        {
            return cn.LayCNChoReportTheoMaCN(ma);
        }

        public List<ET_ChiNhanhReport> LayCNChoReportTheoTenCN(string ten)
        {
            return cn.LayCNChoReportTheoTenCN(ten);
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
