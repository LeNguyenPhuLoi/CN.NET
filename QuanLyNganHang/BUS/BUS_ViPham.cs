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

        public IQueryable TimVPTheoMa(string ma)
        {
            return vp.TimVPTheoMa(ma);
        }

        public IQueryable TimVPTheoTenNV(string ten)
        {
            return vp.TimVPTheoTenNV(ten);
        }

        public IQueryable TimVPTheoMoTa(string mota)
        {
            return vp.TimVPTheoMoTa(mota);
        }

        public IQueryable TimVPTheoNgay(DateTime ngay)
        {
            return vp.TimVPTheoNgay(ngay);
        }

        public List<ET_ViPhamReport> LayVPChoReport()
        {
            return vp.LayVPChoReport();
        }

        public List<ET_ViPhamReport> LayVPChoReportTheoMaVP(string ma)
        {
            return vp.LayVPChoReportTheoMaVP(ma);
        }

        public List<ET_ViPhamReport> LayVPChoReportTheoTenNV(string ten)
        {
            return vp.LayVPChoReportTheoTenNV(ten);
        }

        public List<ET_ViPhamReport> LayVPChoReportTheoMoTa(string mota)
        {
            return vp.LayVPChoReportTheoMoTa(mota);
        }

        public List<ET_ViPhamReport> LayVPChoReportTheoNgay(DateTime ngay)
        {
            return vp.LayVPChoReportTheoNgay(ngay);
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
