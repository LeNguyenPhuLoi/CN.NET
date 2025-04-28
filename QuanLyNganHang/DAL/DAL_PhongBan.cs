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

        public IQueryable TimPBTheoMa(int ma)
        {
            IQueryable PB = from pb in db.PHONGBANs
                            where pb.MAPB == ma
                            select pb;
            return PB;
        }

        public IQueryable TimPBTheoTen(string ten)
        {
            IQueryable PB = from pb in db.PHONGBANs
                            where pb.TENPB.Contains(ten)
                            select pb;
            return PB;
        }

        public List<ET_PhongBanReport> LayPBChoReport()
        {
            var query = from pb in db.PHONGBANs
                        select new ET_PhongBanReport
                        {
                            MaPB = pb.MAPB,
                            TenPB = pb.TENPB,
                            TRPhong = pb.TRPHONG
                        };
            return query.ToList();
        }

        public List<ET_PhongBanReport> LayPBChoReportTheoMa(int ma)
        {
            var query = from pb in db.PHONGBANs
                        where pb.MAPB == ma
                        select new ET_PhongBanReport
                        {
                            MaPB = pb.MAPB,
                            TenPB = pb.TENPB,
                            TRPhong = pb.TRPHONG
                        };
            return query.ToList();
        }

        public List<ET_PhongBanReport> LayPBChoReportTheoTen(string ten)
        {
            var query = from pb in db.PHONGBANs
                        where pb.TENPB.Contains(ten)
                        select new ET_PhongBanReport
                        {
                            MaPB = pb.MAPB,
                            TenPB = pb.TENPB,
                            TRPhong = pb.TRPHONG
                        };
            return query.ToList();
        }

        public bool ThemPB(ET_PhongBan et)
        {
            bool flag = false;
            try
            {
                var pbTonTai = db.PHONGBANs.Any(pb => pb.MAPB == et.MaPB);
                if (!pbTonTai)
                {
                    PHONGBAN pb = new PHONGBAN()
                    {
                        MAPB = et.MaPB,
                        TENPB = et.TenPB,
                        TRPHONG = et.TRPhong
                    };
                    db.PHONGBANs.InsertOnSubmit(pb);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm phòng ban: " + ex.Message);
            }
            return flag;
        }


        public bool SuaPB(ET_PhongBan et)
        {
            bool flag = false;
            try
            {
                var pb = db.PHONGBANs.SingleOrDefault(p => p.MAPB == et.MaPB);
                if (pb != null)
                {
                    pb.TENPB = et.TenPB;
                    pb.TRPHONG = et.TRPhong;
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa phòng ban: " + ex.Message);
            }
            return flag;
        }


        public bool XoaPB(ET_PhongBan et)
        {
            bool flag = false;
            try
            {
                var pb = db.PHONGBANs.SingleOrDefault(p => p.MAPB == et.MaPB);
                if (pb != null)
                {
                    db.PHONGBANs.DeleteOnSubmit(pb);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa phòng ban: " + ex.Message);
            }
            return flag;
        }

    }
}
