using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_NhanVien
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadNV()
        {
            IQueryable NV = from nv in db.NHANVIENs
                            select nv;
            return NV;
        }

        public IQueryable LoadTenPB()
        {
            IQueryable PB = from pb in db.PHONGBANs
                            select pb.TENPB;
            return PB;
        }

        public IQueryable LoadTenCN()
        {
            IQueryable CN = from cn in db.CHINHANHs
                            select cn.TENCHINHANH;
            return CN;
        }

        public string LayTenPBTheoMa(int ma)
        {
            string ten = (from pb in db.PHONGBANs
                         where pb.MAPB == ma
                         select pb.TENPB).FirstOrDefault();
            return ten;
        }

        public string LayTenCNTheoMa(string ma)
        {
            string ten = (from cn in db.CHINHANHs
                          where cn.MACN == ma
                          select cn.TENCHINHANH).FirstOrDefault();
            return ten;
        }

        public int LayMaPBTheoTen(string ten)
        {
            int ma = (from pb in db.PHONGBANs
                      where pb.TENPB == ten
                      select pb.MAPB).FirstOrDefault();
            return ma;
        }

        public string LayMaCNTheoTen(string ten)
        {
            string ma = (from cn in db.CHINHANHs
                         where cn.TENCHINHANH == ten
                         select cn.MACN).FirstOrDefault();
            return ma;
        }

        public bool ThemNV(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                NHANVIEN nv = new NHANVIEN()
                {
                    MANV = et.MaNV,
                    TENNV = et.TenNV,
                    GIOITINH = et.GioiTinh,
                    NGAYSINH = et.NgaySinh,
                    CHUC = et.Chuc,
                    LUONG = et.Luong,
                    DIACHI = et.DiaCHi,
                    SDT = et.SDT,
                    MAPB = et.MaPB,
                    MACN = et.MaCN
                };
                db.NHANVIENs.InsertOnSubmit(nv);
                flag = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }

        public bool SuaNV(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                var capnhat = db.NHANVIENs.Single(nv => nv.MANV == et.MaNV);
                capnhat.TENNV = et.TenNV;
                capnhat.GIOITINH = et.GioiTinh;
                capnhat.NGAYSINH = et.NgaySinh;
                capnhat.CHUC = et.Chuc;
                capnhat.LUONG = et.Luong;
                capnhat.DIACHI = et.DiaCHi;
                capnhat.SDT = et.SDT;
                capnhat.MAPB = et.MaPB;
                capnhat.MACN = et.MaCN;
                flag = true;
            }
            finally 
            { 
                db.SubmitChanges(); 
            }
            return flag;
        }

        public bool XoaNV(ET_NhanVien et) 
        {
            bool flag = false;
            try
            {
                var xoa = from nv in db.NHANVIENs
                          where nv.MANV == et.MaNV
                          select nv;
                foreach (var nv in xoa) 
                {
                    db.NHANVIENs.DeleteOnSubmit(nv);
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
