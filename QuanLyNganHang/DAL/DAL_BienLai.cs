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
                            select bl;
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
