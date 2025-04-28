using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_PhongBan
    {
        DAL_PhongBan pb = new DAL_PhongBan();

        public IQueryable LoadPB()
        {
            return pb.LoadPB();
        }

        public IQueryable LoadNV()
        {
            return pb.LoadNV();
        }

        public string LayMaNVTheoTen(string ten)
        {
            return pb.LayMaNVTheoTen(ten);
        }

        public string LayTenNVTheoMa(string ma)
        {
            return pb.LayTenNVTheoMa(ma);
        }

        public IQueryable TimPBTheoMa(int ma)
        {
            return pb.TimPBTheoMa(ma);
        }

        public IQueryable TimPBTheoTen(string ten)
        {
            return pb.TimPBTheoTen(ten);
        }

        public List<ET_PhongBanReport> LayPBChoReport()
        {
            return pb.LayPBChoReport();
        }

        public List<ET_PhongBanReport> LayPBChoReportTheoMa(int ma)
        {
            return pb.LayPBChoReportTheoMa(ma);
        }

        public List<ET_PhongBanReport> LayPBChoReportTheoTen(string ten)
        {
            return pb.LayPBChoReportTheoTen(ten);
        }

        public bool ThemPB(ET_PhongBan et)
        {
            return pb.ThemPB(et);
        }

        public bool SuaPB(ET_PhongBan et) 
        {
            return pb.SuaPB(et);
        }

        public bool XoaPB(ET_PhongBan et) 
        {
            return pb.XoaPB(et);
        }
    }
}
