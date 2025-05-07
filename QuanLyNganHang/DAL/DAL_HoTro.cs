using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoTro
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadHT()
        {
            IQueryable HT = from ht in db.HOTROs
                            select new {ht.MAKH, ht.DVHT, ht.MANV, ht.MAKM};
            return HT;
        }

        public IQueryable LoadMaNV()
        {
            IQueryable NV = from nv in db.NHANVIENs
                            select nv.MANV;
            return NV;
        }

        public IQueryable LoadMaKM()
        {
            IQueryable KM = from km in db.KHUYENMAIs
                            select km.MAKM;
            return KM;
        }

        public IQueryable TimHTTheoMaKH(string htmakh)
        {
            IQueryable HT = from ht in db.HOTROs
                            where ht.MAKH.Contains(htmakh)
                            select ht;
            return HT;
        }

        public IQueryable TimHTTheoDVHT(string htdvht)
        {
            IQueryable HT = from ht in db.HOTROs
                            where ht.DVHT.Contains(htdvht)
                            select ht;
            return HT;
        }

        public List<ET_HoTroReport> LayHT()
        {
            var clone = from ht in db.HOTROs
                        select new ET_HoTroReport
                        {
                            MAKH = ht.MAKH,
                            DVHT = ht.DVHT,
                            MANV = ht.MANV,
                            MAKM = ht.MAKM,
                        };
            return clone.ToList();
        }

        public List<ET_HoTroReport> LayHTTheoMa(string ma)
        {
            var clone = from ht in db.HOTROs
                        where ht.MAKH.Contains(ma)
                        select new ET_HoTroReport
                        {
                            MAKH = ht.MAKH,
                            DVHT = ht.DVHT,
                            MANV = ht.MANV,
                            MAKM = ht.MAKM,
                        };
            return clone.ToList();
        }

        public List<ET_HoTroReport> LayHTTheoDVHT(string dvht)
        {
            var clone = from ht in db.HOTROs
                        where ht.DVHT.Contains(dvht)
                        select new ET_HoTroReport
                        {
                            MAKH = ht.MAKH,
                            DVHT = ht.DVHT,
                            MANV = ht.MANV,
                            MAKM = ht.MAKM,
                        };
            return clone.ToList();
        }

        public bool ThemHT(ET_HoTro et)
        {
            bool clone = false;
            try
            {
                var space = db.HOTROs.Any(x => x.MAKH == et.MaKH && x.MANV == et.MaNV);
                if (!space)
                {
                    HOTRO ht = new HOTRO()
                    {
                        MAKH = et.MaKH,
                        DVHT = et.DVHT,
                        MANV = et.MaNV,
                        MAKM = et.MaKM
                    };
                    db.HOTROs.InsertOnSubmit(ht);
                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm hỗ trợ: " + ex.Message);
            }
            return clone;
        }

        public bool SuaHT(ET_HoTro et)
        {
            bool clone = false;
            try
            {
                var capnhat = db.HOTROs.SingleOrDefault(ht => ht.MAKH == et.MaKH && ht.MANV == et.MaNV);
                if (capnhat != null)
                {
                    capnhat.MAKH= et.MaKH;
                    capnhat.DVHT = et.DVHT;
                    capnhat.MANV = et.MaNV;
                    capnhat.MAKM = et.MaKM;                  
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm hỗ trợ: " + ex.Message);
            }
            return clone;
        }

        public bool XoaHT(ET_HoTro et)
        {
            bool clone = false;
            try
            {
                var xoa = db.HOTROs.SingleOrDefault(ht => ht.MAKH == et.MaKH && ht.MANV == et.MaNV);
                if (xoa != null)
                {
                    db.HOTROs.DeleteOnSubmit(xoa);
                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm hỗ trợ: " + ex.Message);
            }
            return clone;
        }
    }
}
