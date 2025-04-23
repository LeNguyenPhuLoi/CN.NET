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

        public bool ThemNQ(ET_NoiQuy et)
        {
            bool flag = false;
            try
            {
                NOIQUY nq = new NOIQUY()
                {
                    MANQ = et.MaNQ,
                    MOTA = et.MoTa,
                    MUCPHAT = et.MucPhat,
                    GHICHU = et.GhiChu
                };
                db.NOIQUYs.InsertOnSubmit(nq);
                flag = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }

        public bool SuaNQ(ET_NoiQuy et) 
        {
            bool flag = false;
            try
            {
                var capnhat = db.NOIQUYs.Single(nq => nq.MANQ == et.MaNQ);
                capnhat.MOTA = et.MoTa;
                capnhat.MUCPHAT = et.MucPhat;
                capnhat.GHICHU = et.GhiChu;
                flag = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }

        public bool XoaNQ(ET_NoiQuy et)
        {
            bool flag = false;
            try
            {
                var xoa = from nq in db.NOIQUYs
                          where nq.MANQ == et.MaNQ
                          select nq;
                foreach (var nq in xoa) 
                {
                    db.NOIQUYs.DeleteOnSubmit(nq);
                    db.SubmitChanges();
                }
                flag = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }
    }
}
