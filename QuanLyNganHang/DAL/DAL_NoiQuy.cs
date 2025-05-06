using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_NoiQuy
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadNQ()
        {
            IQueryable NQ = from nq in db.NOIQUYs
                            select nq;
            return NQ;
        }

        public IQueryable TimNQTheoMa(string ma)
        {
            IQueryable NQ = from nq in db.NOIQUYs
                            where nq.MANQ.Contains(ma)
                            select nq;
            return NQ;
        }

        public IQueryable TimNQTheoMoTa(string mota)
        {
            IQueryable NQ = from nq in db.NOIQUYs
                            where nq.MOTA.Contains(mota)
                            select nq;
            return NQ;
        }

        public List<ET_NoiQuyReport> LayNQChoReport()
        {
            var query = from nq in db.NOIQUYs
                        select new ET_NoiQuyReport
                        {
                            MaNQ = nq.MANQ,
                            MoTa = nq.MOTA,
                            MucPhat = (float)nq.MUCPHAT,
                            GhiChu = nq.GHICHU
                        };
            return query.ToList();
        }

        public List<ET_NoiQuyReport> LayNQChoReportTheoMa(string ma)
        {
            var query = from nq in db.NOIQUYs
                        where nq.MANQ.Contains(ma)
                        select new ET_NoiQuyReport
                        {
                            MaNQ = nq.MANQ,
                            MoTa = nq.MOTA,
                            MucPhat = (float)nq.MUCPHAT,
                            GhiChu = nq.GHICHU
                        };
            return query.ToList();
        }

        public List<ET_NoiQuyReport> LayNQChoReportTheoMoTa(string mota)
        {
            var query = from nq in db.NOIQUYs
                        where nq.MOTA.Contains(mota)
                        select new ET_NoiQuyReport
                        {
                            MaNQ = nq.MANQ,
                            MoTa = nq.MOTA,
                            MucPhat = (float)nq.MUCPHAT,
                            GhiChu = nq.GHICHU
                        };
            return query.ToList();
        }

        public bool ThemNQ(ET_NoiQuy et)
        {
            bool flag = false;
            try
            {
                var exists = db.NOIQUYs.Any(x => x.MANQ == et.MaNQ);
                if (!exists)
                {
                    NOIQUY nq = new NOIQUY()
                    {
                        MANQ = et.MaNQ,
                        MOTA = et.MoTa,
                        MUCPHAT = et.MucPhat,
                        GHICHU = et.GhiChu
                    };
                    db.NOIQUYs.InsertOnSubmit(nq);
                    db.SubmitChanges();
                    flag = true;
                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Lỗi khi thêm nội quy: " + ex.Message);
            }
            return flag;
        }

        public bool SuaNQ(ET_NoiQuy et) 
        {
            bool flag = false;
            try
            {

                var capnhat = db.NOIQUYs.SingleOrDefault(nq => nq.MANQ == et.MaNQ);
                if(capnhat != null)
                {
                    capnhat.MOTA = et.MoTa;
                    capnhat.MUCPHAT = et.MucPhat;
                    capnhat.GHICHU = et.GhiChu;
                    db.SubmitChanges();
                    flag = true;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm nội quy: " + ex.Message);
            }
            return flag;
        }

        public bool XoaNQ(ET_NoiQuy et)
        {
            bool flag = false;
            try
            {
               var xoa = db.NOIQUYs.SingleOrDefault(nq => nq.MANQ == et.MaNQ);
                if (xoa != null) 
                {
                    db.NOIQUYs.DeleteOnSubmit(xoa);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm nội quy: " + ex.Message);
            }
            return flag;
        }
    }
}
