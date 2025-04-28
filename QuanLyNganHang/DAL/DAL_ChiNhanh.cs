using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_ChiNhanh
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadCN()
        {
            IQueryable CN = from cn in db.CHINHANHs
                            select cn;
            return CN;
        }

        public IQueryable TimCNTheoMa(string ma)
        {
            IQueryable CN = from cn in db.CHINHANHs
                            where cn.MACN.Contains(ma)
                            select cn;
            return CN;
        }

        public IQueryable TimCNTheoTen(string ten)
        {
            IQueryable CN = from cn in db.CHINHANHs
                            where cn.TENCHINHANH.Contains(ten)
                            select cn;
            return CN;
        }

        public IQueryable TimCNTheoDiaChi(string diachi)
        {
            IQueryable CN = from cn in db.CHINHANHs
                            where cn.DIACHI.Contains(diachi)
                            select cn;
            return CN;
        }

        public List<ET_ChiNhanhReport> LayCNChoReport()
        {
            var query = from cn in db.CHINHANHs
                        select new ET_ChiNhanhReport
                        {
                            MaCN = cn.MACN,
                            TenCN = cn.TENCHINHANH,
                            DiaChi = cn.DIACHI,
                        };
            return query.ToList();
        }

        public List<ET_ChiNhanhReport> LayCNChoReportTheoMaCN(string ma)
        {
            var query = from cn in db.CHINHANHs
                        where cn.MACN.Contains(ma)
                        select new ET_ChiNhanhReport
                        {
                            MaCN = cn.MACN,
                            TenCN = cn.TENCHINHANH,
                            DiaChi = cn.DIACHI,
                        };
            return query.ToList();
        }

        public List<ET_ChiNhanhReport> LayCNChoReportTheoTenCN(string ten)
        {
            var query = from cn in db.CHINHANHs
                        where cn.TENCHINHANH.Contains(ten)
                        select new ET_ChiNhanhReport
                        {
                            MaCN = cn.MACN,
                            TenCN = cn.TENCHINHANH,
                            DiaChi = cn.DIACHI,
                        };
            return query.ToList();
        }

        public bool ThemCN(ET_ChiNhanh et)
        {
            bool flag = false;
            try
            {
                var exists = db.CHINHANHs.Any(x => x.MACN == et.MaCN);
                if (!exists)
                {
                    CHINHANH cn = new CHINHANH()
                    {
                        MACN = et.MaCN,
                        TENCHINHANH = et.TenCN,
                        DIACHI = et.DiaChi
                    };
                    db.CHINHANHs.InsertOnSubmit(cn);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm chi nhánh: " + ex.Message);
            }

            return flag;
        }


        public bool SuaCN(ET_ChiNhanh et)
        {
            bool flag = false;
            try
            {
                var capnhat = db.CHINHANHs.SingleOrDefault(x => x.MACN == et.MaCN);
                if (capnhat != null)
                {
                    capnhat.TENCHINHANH = et.TenCN;
                    capnhat.DIACHI = et.DiaChi;
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa chi nhánh: " + ex.Message);
            }
            return flag;
        }


        public bool XoaCN(ET_ChiNhanh et)
        {
            bool flag = false;
            try
            {
                var cn = db.CHINHANHs.SingleOrDefault(x => x.MACN == et.MaCN);
                if (cn != null)
                {
                    db.CHINHANHs.DeleteOnSubmit(cn);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa chi nhánh: " + ex.Message);
            }
            return flag;
        }

    }
}
