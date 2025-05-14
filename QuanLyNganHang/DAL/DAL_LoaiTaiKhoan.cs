using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiTaiKhoan
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadLoaiTaiKhoan()
        {
            IQueryable loaitaikhoan = from ltk in db.LOAITAIKHOANs
                                      select ltk;
            return loaitaikhoan;
        }

        public bool ThemLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            bool flage = false;
            try
            {
                LOAITAIKHOAN loai = new LOAITAIKHOAN()
                {
                    MALOAI = et.MALOAI,
                    TENNH = et.TENNGANHANG
                };
                db.LOAITAIKHOANs.InsertOnSubmit(loai);
                flage = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flage;
        }

        public bool CapNhatLTK(ET_LoaiTaiKhoan et)
        {
            bool flage = false;
            try
            {
                var capnhat = db.LOAITAIKHOANs.Single(sv => sv.MALOAI == et.MALOAI);
                capnhat.TENNH = et.TENNGANHANG;
                flage = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flage;
        }

        public bool XoaLTK(ET_LoaiTaiKhoan et)
        {
            bool flag = false;
            try
            {
                var xoa = from ltk in db.LOAITAIKHOANs
                          where ltk.MALOAI == et.MALOAI
                          select ltk;

                foreach (var i in xoa)
                {
                    db.LOAITAIKHOANs.DeleteOnSubmit(i);
                    db.SubmitChanges();
                }
                flag = true;
            }
            finally { }
            return flag;
        }
    }
}
