using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL; 

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();

        public IQueryable LoadNV()
        {
            return nv.LoadNV();
        }

        public IQueryable LoadTenPB()
        {
            return nv.LoadTenPB();
        }

        public IQueryable LoadTenCN()
        {
            return nv.LoadTenCN();
        }

        public string LayTenPBTheoMa(int ma)
        {
            return nv.LayTenPBTheoMa(ma);
        }

        public string LayTenCNTheoMa(string ma)
        {
            return nv.LayTenCNTheoMa(ma);
        }

        public int LayMaPBTheoTen(string ten)
        {
            return nv.LayMaPBTheoTen(ten);
        }

        public string LayMaCNTheoTen(string ten)
        {
            return nv.LayMaCNTheoTen(ten);
        }

        public IQueryable TimNVTheoMa(string ma)
        {
            return nv.TimNVTheoMa(ma);
        }

        public IQueryable TimNVTheoTen(string ten)
        {
            return nv.TimNVTheoTen(ten);
        }

        public IQueryable TimNVTheoSDT(int sdt)
        {
            return nv.TimNVTheoSDT(sdt);
        }

        public IQueryable TimNVTheoCN(string TenCN)
        {
            return nv.TimNVTheoCN(TenCN);
        }

        public List<ET_NhanVienReport> LayNVChoReport()
        {
            return nv.LayNVChoReport();
        }

        public List<ET_NhanVienReport> LayNVChoReportTheoMaNV(string ma)
        {
            return nv.LayNVChoReportTheoMaNV(ma);
        }

        public List<ET_NhanVienReport> LayNVChoReportTheoTenNV(string ten)
        {
            return nv.LayNVChoReportTheoTenNV(ten);
        }

        public List<ET_NhanVienReport> LayNVChoReportTheoSDT(int sdt)
        {
            return nv.LayNVChoReportTheoSDT(sdt);
        }

        public List<ET_NhanVienReport> LayNVChoReportTheoCN(string ten)
        {
            return nv.LayNVChoReportTheoCN(ten);
        }

        public bool ThemNV(ET_NhanVien et)
        {
            return nv.ThemNV(et);
        }

        public bool SuaNV(ET_NhanVien et)
        {
            return nv.SuaNV(et);
        }

        public bool XoaNV(ET_NhanVien et)
        {
            return nv.XoaNV(et);
        }
    }
}
