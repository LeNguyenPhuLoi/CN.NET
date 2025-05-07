using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoanDangNhap
    {
        QLNHDataContext db = new QLNHDataContext();
        public IQueryable LoadTaiKhoanDN()
        {
            IQueryable taikhoanlogin = from tkl in db.TKDANGNHAPs
                                       select tkl;
            return taikhoanlogin;
        }

        public bool ThemTKLogin(ET_TaiKhoanDangNhap et)
        {
            bool flage = false;
            try
            {
                TKDANGNHAP tk = new TKDANGNHAP()
                {
                    TENDN = et.TENDN,
                    MATKHAU = et.PASS,
                    QUYEN = et.QUYEN,
                    MANV = et.MANV
                };
                db.TKDANGNHAPs.InsertOnSubmit(tk);
                flage = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flage;
        }

        public bool CapNhatTKL(ET_TaiKhoanDangNhap et)
        {
            bool flage = false;
            try
            {
                var capnhat = db.TKDANGNHAPs.Single(sv => sv.TENDN == et.TENDN);
                capnhat.MATKHAU = et.PASS;
                capnhat.QUYEN = et.QUYEN;
                capnhat.MANV = et.MANV;
                flage = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flage;
        }

        public bool XoaTKL(ET_TaiKhoanDangNhap et)
        {
            bool flag = false;
            try
            {
                var xoa = from tk in db.TKDANGNHAPs
                          where tk.TENDN == et.TENDN
                          select tk;

                foreach (var i in xoa)
                {
                    db.TKDANGNHAPs.DeleteOnSubmit(i);
                    db.SubmitChanges();
                }
                flag = true;
            }
            finally { }
            return flag;
        }
    }
}
