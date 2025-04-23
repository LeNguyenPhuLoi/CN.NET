using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_ViPham
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadVP()
        {
            IQueryable VP = from vp in db.VIPHAMs
                            select vp;
            return VP;
        }

        public IQueryable LoadTenNV()
        {
            IQueryable TenNV = from nv in db.NHANVIENs
                               select nv.TENNV;
            return TenNV;
        }

        public IQueryable LoadMoTaNQ()
        {
            IQueryable MoTa = from nq in db.NOIQUYs
                              select nq.MOTA;
            return MoTa;
        }

        public string LayTenNVTheoMa(string ma)
        {
            string ten = (from nv in db.NHANVIENs
                          where nv.MANV == ma
                          select nv.TENNV).FirstOrDefault();
            return ten;
        }

        public string LayMoTaTheoMa(string ma)
        {
            string mota = (from nq in db.NOIQUYs
                           where nq.MANQ == ma  
                           select nq.MOTA).FirstOrDefault();
            return mota;
        }

        public string LayMaNVTheoTen(string ten)
        {
            string ma = (from nv in db.NHANVIENs
                         where nv.TENNV == ten
                         select nv.MANV).FirstOrDefault();
            return ma;
        }

        public string LayMaNQTheoMoTa(string mota)
        {
            string ma = (from nq in db.NOIQUYs
                         where nq.MOTA == mota
                         select nq.MANQ).FirstOrDefault();
            return ma;
        }

        public float LayMucPhatTheoMoTa(string mota)
        {
            var mucPhat = db.NOIQUYs
                            .Where(nq => nq.MOTA == mota)
                            .Select(nq => (float?)nq.MUCPHAT) // dùng nullable để tránh lỗi khi không có kết quả
                            .FirstOrDefault();

            return mucPhat ?? 0f; // nếu không tìm thấy, trả về 0
        }

        public bool ThemVP(ET_ViPham et)
        {
            bool flag = false;
            try
            {
                VIPHAM vp = new VIPHAM()
                {
                    MAVP = et.MaVP,
                    MANV = et.MaNV,
                    MANQ = et.MaNQ,
                    NGAYVIPHAM = et.NgayViPham,
                    TIENPHAT = et.TienPhat,
                    SOLANVIPHAM = et.SoLanViPham,
                    GHICHU = et.GhiChu
                };
                db.VIPHAMs.InsertOnSubmit(vp);
                flag = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }

        public bool SuaVP(ET_ViPham et) 
        {
            bool flag = false;
            try
            {
                var capnhat = db.VIPHAMs.Single(vp => vp.MAVP == et.MaVP);
                capnhat.MANV = et.MaNV;
                capnhat.MANQ = et.MaNQ;
                capnhat.NGAYVIPHAM = et.NgayViPham;
                capnhat.TIENPHAT = et.TienPhat;
                capnhat.SOLANVIPHAM = et.SoLanViPham;
                capnhat.GHICHU = et.GhiChu;
                flag = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }

        public bool XoaVP(ET_ViPham et) 
        {
            bool flag = false;
            try
            {
                var xoa = from vp in db.VIPHAMs
                          where vp.MAVP == et.MaVP
                          select vp;

                foreach (var vp in xoa) 
                { 
                    db.VIPHAMs.DeleteOnSubmit(vp);
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
