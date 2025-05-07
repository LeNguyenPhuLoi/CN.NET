using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhuyenMai
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadKM()
        {
            IQueryable KM = from km in db.KHUYENMAIs
                            select km;
            return KM;
        }

        public IQueryable TimKMTheoMa(string ma)
        {
            IQueryable KM = from km in db.KHUYENMAIs
                            where km.MAKM.Contains(ma)
                            select km;
            return KM;
        }

        public IQueryable TimKMTheoTen(string ten)
        {
            IQueryable KM = from km in db.KHUYENMAIs
                            where km.TENKM.Contains(ten)
                            select km;
            return KM; 
        }

        public bool ThemKM(ET_KhuyenMai et)
        {
            bool clone = false;
            try
            {
                var space = db.KHUYENMAIs.Any(x => x.MAKM == et.MaKM);
                if (!space)
                {
                    KHUYENMAI km = new KHUYENMAI()
                    {
                        MAKM = et.MaKM,
                        TENKM = et.TenKM,
                        NGAYBATDAU = et.NgayBatDau,
                        NGAYKETTHUC = et.NgayKetThuc,
                        DIEUKIEN = et.DieuKien
                    };

                    db.KHUYENMAIs.InsertOnSubmit(km);
                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm khuyến mãi: " + ex.Message);
            }
            return clone;
        }

        public bool SuaKM(ET_KhuyenMai et)
        {
            bool clone = false;
            try
            {
                var capnhat = db.KHUYENMAIs.SingleOrDefault(km => km.MAKM == et.MaKM);
                if(capnhat != null)
                {
                    capnhat.MAKM = et.MaKM;
                    capnhat.TENKM = et.TenKM;
                    capnhat.NGAYBATDAU = et.NgayBatDau;
                    capnhat.NGAYKETTHUC = et.NgayKetThuc;
                    capnhat.DIEUKIEN = et.DieuKien;

                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa khuyến mãi: " + ex.Message);
            }
            return clone;
        }

        public bool XoaKM(ET_KhuyenMai et)
        {
            bool clone = false;
            try
            {
                var xoa = db.KHUYENMAIs.SingleOrDefault(km => km.MAKM == et.MaKM);
                if(xoa != null)
                {
                    db.KHUYENMAIs.DeleteOnSubmit(xoa);
                    db.SubmitChanges();
                    clone = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa khuyến mãi: " + ex.Message);
            }
            return clone;
        }
    }
}
