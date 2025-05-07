using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BienLai
    {
        QLNHDataContext db = new QLNHDataContext();
        public IQueryable LoadBL()
        {
            IQueryable BL = from bl in db.BIENLAIs
                            select new {bl.MABL, bl.LOAIBL, bl.SOTIEN, bl.NGAYLAP, bl.MANV, bl.MaKH};
            return BL;
        }

        public IQueryable TimBLTheoMa(string ma)
        {
            IQueryable BL = from bl in db.BIENLAIs
                            where bl.MABL.Contains(ma)
                            select bl;
            return BL;
        }

        public IQueryable TimBLTheoLoai(string loai)
        {
            IQueryable BL = from bl in db.BIENLAIs
                            where bl.LOAIBL.Contains(loai)
                            select bl;
            return BL;
        }

        public IQueryable TimBLTheoMaNV(string mablnv)
        {
            IQueryable BL = from bl in db.BIENLAIs
                            where bl.MANV.Contains(mablnv)
                            select bl;
            return BL;
        }

        public IQueryable TimBLTheoMaKH(string mablkh)
        {
            IQueryable BL = from bl in db.BIENLAIs
                            where bl.MaKH.Contains(mablkh)
                            select bl;
            return BL;
        }

        public List<ET_BienLaiReport> LAYBL()
        {
            var clone = from bl in db.BIENLAIs
                        select new ET_BienLaiReport
                        {
                            MABL = bl.MABL,
                            LOAIBL = bl.LOAIBL,
                            SOTIEN = (float)bl.SOTIEN,
                            NGAYLAP = bl.NGAYLAP.Value,
                            MANV = bl.MANV,
                            MAKH = bl.MaKH
                        };
            return clone.ToList();
        }

        public List<ET_BienLaiReport> LAYBLTheoMa(string ma)
        {
            var clone = from bl in db.BIENLAIs
                        where bl.MABL.Contains(ma)
                        select new ET_BienLaiReport
                        {
                            MABL = bl.MABL,
                            LOAIBL = bl.LOAIBL,
                            SOTIEN = (float)bl.SOTIEN,
                            NGAYLAP = bl.NGAYLAP.Value,
                            MANV = bl.MANV,
                            MAKH = bl.MaKH
                        };
            return clone.ToList();
        }

        public List<ET_BienLaiReport> LayBLTheoLoai(string loai)
        {
            var clone = from bl in db.BIENLAIs
                        where bl.LOAIBL.Contains(loai)
                        select new ET_BienLaiReport
                        {
                            MABL = bl.MABL,
                            LOAIBL = bl.LOAIBL,
                            SOTIEN = (float)bl.SOTIEN,
                            NGAYLAP = bl.NGAYLAP.Value,
                            MANV = bl.MANV,
                            MAKH = bl.MaKH
                        };
            System.Diagnostics.Debug.WriteLine(" " +clone.First().MABL + " " + clone.First().LOAIBL + " " + clone.First().SOTIEN + " " + clone.First().NGAYLAP + " " + clone.First().MANV + " " + clone.First().MAKH);
            
            return clone.ToList();
        }

        public List<ET_BienLaiReport> LayBLTheoMaNV(string blmanv)
        {
            var clone = from bl in db.BIENLAIs
                        where bl.MANV.Contains(blmanv)
                        select new ET_BienLaiReport
                        {
                            MABL = bl.MABL,
                            LOAIBL = bl.LOAIBL,
                            SOTIEN = (float)bl.SOTIEN,
                            NGAYLAP = bl.NGAYLAP.Value,
                            MANV = bl.MANV,
                            MAKH = bl.MaKH
                        };
            return clone.ToList();
        }

        public List<ET_BienLaiReport> LayBLTheoMaKH(string blmakh)
        {
            var clone = from bl in db.BIENLAIs
                        where bl.MaKH.Contains(blmakh)
                        select new ET_BienLaiReport
                        {
                            MABL = bl.MABL,
                            LOAIBL = bl.LOAIBL,
                            SOTIEN = (float)bl.SOTIEN,
                            NGAYLAP = bl.NGAYLAP.Value,
                            MANV = bl.MANV,
                            MAKH = bl.MaKH
                        };
            return clone.ToList();
        }

        public bool ThemBL(ET_BienLai et)
        {
            bool clone = false;
            try
            {
                var space = db.BIENLAIs.Any(x => x.MABL == et.MaBL);
                if (!space)
                {
                    BIENLAI bl = new BIENLAI()
                    {
                        MABL = et.MaBL,
                        LOAIBL = et.LoaiBL,
                        SOTIEN = et.SoTien,
                        NGAYLAP = et.NgayLap,
                        MANV = et.MaNV,
                        MaKH = et.MaKH
                    };
                    db.BIENLAIs.InsertOnSubmit(bl);
                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm biên lai: " + ex.Message);
            }
            return clone;
        }

        public bool SuaBL(ET_BienLai et)
        {
            bool clone = false;
            try
            {
                var capnhat = db.BIENLAIs.SingleOrDefault(bl => bl.MABL == et.MaBL);
                if (capnhat != null)
                {
                    capnhat.MABL = et.MaBL;
                    capnhat.LOAIBL = et.LoaiBL;
                    capnhat.SOTIEN = et.SoTien;
                    capnhat.NGAYLAP = et.NgayLap;
                    capnhat.MANV = et.MaNV;
                    capnhat.MaKH = et.MaKH;
                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm biên lai: " + ex.Message);
            }
            return clone;
        }

        public bool XoaBL(ET_BienLai et)
        {
            bool clone = false;
            try
            {
                var xoa = db.BIENLAIs.SingleOrDefault(bl => bl.MABL == et.MaBL);
                if (xoa != null)
                {
                    db.BIENLAIs.DeleteOnSubmit(xoa);
                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm biên lai: " + ex.Message);
            }
            return clone;
        }
    }
}
