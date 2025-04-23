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

        public bool ThemCN(ET_ChiNhanh et)
        {
            bool flag = false;
            try
            {
                CHINHANH cn = new CHINHANH() 
                { 
                    MACN = et.MaCN,
                    TENCHINHANH = et.TenCN,
                    DIACHI = et.DiaChi
                };   
                db.CHINHANHs.InsertOnSubmit(cn);
                flag = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }

        public bool SuaCN(ET_ChiNhanh et)
        {
            bool flag = false;
            try
            {
                var capnhat = db.CHINHANHs.Single(cn => cn.MACN == et.MaCN);
                capnhat.TENCHINHANH = et.TenCN;
                capnhat.DIACHI = et.DiaChi;
                flag = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }

        public bool XoaCN(ET_ChiNhanh et) 
        {
            bool flag = false;
            try
            {
                var xoa = from cn in db.CHINHANHs
                          where cn.MACN == et.MaCN
                          select cn;
                foreach (var cn in xoa) 
                { 
                    db.CHINHANHs.DeleteOnSubmit(cn);
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
