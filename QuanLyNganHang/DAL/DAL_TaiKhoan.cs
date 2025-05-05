using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        QLNHDataContext db= new QLNHDataContext();

        public IQueryable LoadTaiKhoan()
        {
            IQueryable taikhoan= from tk in db.TAIKHOANs
                                 select tk;
            return taikhoan;
        }

        public IQueryable LoadLoaiTK()
        {
            IQueryable loaitk = from ltk in db.LOAITAIKHOANs
                                select ltk.MALOAI +"-"+ ltk.TENNH;
            return loaitk;
        }

        public IQueryable LoadTienTe()
        {
            IQueryable tiente = from tt in db.TIENTEs
                                select tt.MATT + "-" + tt.TENTT;
            return tiente;
        }

        public IQueryable LoadNhanVien()
        {
            IQueryable nhanvien = from nv in db.NHANVIENs
                                select nv.MANV + "-" + nv.TENNV;
            return nhanvien;
        }

        public IQueryable LoadKhachHang()
        {
            IQueryable khachhang = from kh in db.KHACHHANGs
                                  select kh.MAKH + "-" + kh.TENKH;
            return khachhang;
        }
        public bool ThemTK(ET_TaiKhoan et)
        {
            bool flage = false;
            try
            {
                TAIKHOAN tk = new TAIKHOAN()
                {
                    MATK = et.MATK,
                    SODU = et.SODU,
                    NGAYLAP = et.NGAYLAP,
                    MAKH = et.MAKH,
                    LOAITK = et.LOAITK,
                    LOAITIEN = et.LOAITIEN,
                    MANV = et.MANV
                };
                db.TAIKHOANs.InsertOnSubmit(tk);
                flage = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flage;
        }

        public bool CapNhatTK(ET_TaiKhoan et)
        {
            bool flage = false;
            try
            {
                var capnhat = db.TAIKHOANs.Single(sv => sv.MATK == et.MATK);
                capnhat.SODU = et.SODU;
                capnhat.NGAYLAP = et.NGAYLAP;
                capnhat.MAKH = et.MAKH;
                capnhat.LOAITK = et.LOAITK;
                capnhat.LOAITIEN = et.LOAITIEN;
                capnhat.MANV = et.MANV;
                flage = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flage;
        }

        public bool XoaTK(ET_TaiKhoan et)
        {
            bool flag = false;
            try
            {
                var xoa = from tk in db.TAIKHOANs
                          where tk.MATK == et.MATK
                          select tk;

                foreach (var i in xoa)
                {
                    db.TAIKHOANs.DeleteOnSubmit(i);
                    db.SubmitChanges();
                }
                flag = true;
            }
            finally { }
            return flag;
        }
    }
}
