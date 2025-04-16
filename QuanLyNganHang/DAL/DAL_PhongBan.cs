using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_PhongBan
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadPB()
        {
            IQueryable PB = from pb in db.PHONGBANs
                            select pb;
            return PB;
        }

        public IQueryable LoadNV()
        {
            IQueryable NV = from nv in db.NHANVIENs
                            select nv.TENNV;
            return NV;
        }

        public string LayMaNVTheoTen(string ten)
        {
            string ma = (from nv in db.NHANVIENs
                        where nv.TENNV == ten
                        select nv.MANV).FirstOrDefault();
            return ma;
        }

        public string LayTenNVTheoMa(string ma)
        {
            string ten = (from nv in db.NHANVIENs
                          where nv.MANV == ma
                          select nv.TENNV).FirstOrDefault();
            return ten;
        }

        public bool ThemPB(ET_PhongBan et)
        {
            bool flag = false;
            try
            {
                PHONGBAN pb = new PHONGBAN()
                {
                    MAPB = et.MaPB,
                    TENPB = et.TenPB,
                    TRPHONG = et.TRPhong
                };
                db.PHONGBANs.InsertOnSubmit(pb);
                flag = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }

        public bool SuaPB(ET_PhongBan et)
        {
            bool flag = false;
            try
            {
                var capnhat = db.PHONGBANs.Single(pb => pb.MAPB == et.MaPB);
                capnhat.TENPB = et.TenPB;
                capnhat.TRPHONG = et.TRPhong;
                flag = true;
            }
            finally
            {
                db.SubmitChanges(); 
            }
            return flag;
        }

        public bool XoaPB(ET_PhongBan et)
        {
            bool flag = false;
            try
            {
                var xoa = from pb in db.PHONGBANs
                          where pb.MAPB == et.MaPB
                          select pb;
                foreach( var pb in xoa)
                {
                    db.PHONGBANs.DeleteOnSubmit(pb);
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
