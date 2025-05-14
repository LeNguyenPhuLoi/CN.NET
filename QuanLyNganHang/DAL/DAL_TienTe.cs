using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TienTe
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadTienTe()
        {
            IQueryable tiente = from tt in db.TIENTEs
                                select tt;
            return tiente;
        }

        public bool ThemTienTe(ET_TienTe et)
        {
            bool flage = false;
            try
            {
                TIENTE tt = new TIENTE()
                {
                    MATT = et.MATT,
                    TENTT = et.TENTT
                };
                db.TIENTEs.InsertOnSubmit(tt);
                flage = true;
            }
            finally { 
                db.SubmitChanges();
            }
            return flage;
        }

        public bool SuaTienTe(ET_TienTe et)
        {
            bool flage = false;
            try
            {
                var capnhat = db.TIENTEs.Single(sv => sv.MATT == et.MATT);
                capnhat.TENTT = et.TENTT;
                flage = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flage;
        }

        public bool XoaTT(ET_TienTe et)
        {
            bool flag = false;
            try
            {
                var xoa = from tt in db.TIENTEs
                          where tt.MATT == et.MATT
                          select tt;

                foreach (var i in xoa)
                {
                    db.TIENTEs.DeleteOnSubmit(i);
                    db.SubmitChanges();
                }
                flag = true;
            }
            finally { }
            return flag;
        }
    }
}
