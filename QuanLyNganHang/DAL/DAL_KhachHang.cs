using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadKH()
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            select kh;
            return KH;
        }

        public IQueryable TimKHTheoMa(string ma)
        {
            IQueryable KH = from kh in db.KHACHHANGs  
                            where kh.MAKH.Contains(ma)
                            select kh;
            return KH;
        }

        public IQueryable TimKHTheoTen(string ten)
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            where kh.TENKH.Contains(ten)
                            select kh;
            return KH;
        }

        public IQueryable TimKHTheoSDT(int sdt)
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            where kh.SDT == sdt
                            select kh;
            return KH;
        }

        public List<ET_KhachHangReport> LayKH()
        {
            var clone = from kh in db.KHACHHANGs
                        select new ET_KhachHangReport
                        {
                            MAKH = kh.MAKH,
                            TENKH = kh.TENKH,
                            SDT = (int)kh.SDT,
                            GIOITINH = kh.GIOITINH,
                            DCHI = kh.DCHI,
                            NSINH = kh.NSINH.Value
                        };
            return clone.ToList();
        }

        public List<ET_KhachHangReport> LayKHTheoMa(string ma)
        {
            var clone = from kh in db.KHACHHANGs
                        where kh.MAKH.Contains(ma)
                        select new ET_KhachHangReport
                        {
                            MAKH = kh.MAKH,
                            TENKH = kh.TENKH,
                            SDT = (int)kh.SDT,
                            GIOITINH = kh.GIOITINH,
                            DCHI = kh.DCHI,
                            NSINH = kh.NSINH.Value
                        };
            return clone.ToList();
        }

        public List<ET_KhachHangReport> LayKHTheoTen(string ten)
        {
            var clone = from kh in db.KHACHHANGs
                        where kh.TENKH.Contains(ten)
                        select new ET_KhachHangReport
                        {
                            MAKH = kh.MAKH,
                            TENKH = kh.TENKH,
                            SDT = (int)kh.SDT,
                            GIOITINH = kh.GIOITINH,
                            DCHI = kh.DCHI,
                            NSINH = kh.NSINH.Value
                        };
            return clone.ToList();
        }

        public List<ET_KhachHangReport> LayKHTheoSDT(int sdt)
        {
            var clone = from kh in db.KHACHHANGs
                        where kh.SDT == sdt
                        select new ET_KhachHangReport
                        {
                            MAKH = kh.MAKH,
                            TENKH = kh.TENKH,
                            SDT = (int)kh.SDT,
                            GIOITINH = kh.GIOITINH,
                            DCHI = kh.DCHI,
                            NSINH = kh.NSINH.Value
                        };
            return clone.ToList();
        }

        public bool ThemKH(ET_KhachHang et)
        {
            bool clone = false;
            try
            {
                var space = db.KHACHHANGs.Any(x => x.MAKH == et.MaKH);
                if (!space)
                {
                    KHACHHANG kh = new KHACHHANG()
                    {
                        MAKH = et.MaKH,
                        TENKH = et.TenKH,
                        SDT = et.SDT,
                        GIOITINH = et.GioiTinh,
                        DCHI = et.DiaChi,
                        NSINH = et.NgaySinh
                    };
                    db.KHACHHANGs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                    clone = true;
                }               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm khách hàng: " + ex.Message);
            }
            return clone;
        }

        public bool SuaKH(ET_KhachHang et)
        {
            bool clone = false;
            try
            {
                var capnhat = db.KHACHHANGs.SingleOrDefault(kh => kh.MAKH == et.MaKH);
                if (capnhat != null)
                {
                    capnhat.MAKH = et.MaKH;
                    capnhat.TENKH = et.TenKH;
                    capnhat.SDT = et.SDT;
                    capnhat.GIOITINH = et.GioiTinh;
                    capnhat.DCHI = et.DiaChi;
                    capnhat.NSINH = et.NgaySinh;
                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm khách hàng: " + ex.Message);
            }
            return clone;
        }

        public bool XoaKH(ET_KhachHang et)
        {
            bool clone = false;
            try
            {
                var xoa = db.KHACHHANGs.SingleOrDefault(kh => kh.MAKH == et.MaKH);
                if (xoa != null)
                {
                    db.KHACHHANGs.DeleteOnSubmit(xoa);
                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm khách hàng: " + ex.Message);
            }
            return clone;
        }
    }
}
