using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        AutoConnection conn = new AutoConnection();
        QLNHDataContext db;

        public DAL_TaiKhoan()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public List<ET_TaiKhoanReport> LayTaiKhoanChoReport()
        {
            var query = from tk in db.TAIKHOANs
                        join ltk in db.LOAITAIKHOANs on tk.LOAITK equals ltk.MALOAI
                        join tt in db.TIENTEs on tk.LOAITIEN equals tt.MATT
                        join kh in db.KHACHHANGs on tk.MAKH equals kh.MAKH
                        select new ET_TaiKhoanReport
                        {
                            MATK = tk.MATK,
                            MAKH = tk.MAKH,
                            TenKH = kh.TENKH,
                            SODU = (float)tk.SODU,
                            NGAYLAP = tk.NGAYLAP.Value,
                            TenTT = tt.TENTT,
                            TenNH = ltk.TENNH
                        };

            return query.ToList();
        }

        
        public IQueryable LoadTaiKhoan()
        {
            IQueryable taikhoan = from tk in db.TAIKHOANs
                                  select new
                                  {
                                      tk.MATK,
                                      tk.SODU,
                                      tk.NGAYLAP,
                                      tk.MAKH,
                                      tk.LOAITK,
                                      tk.LOAITIEN,
                                      tk.MANV
                                  };
            return taikhoan;
        }

        public IQueryable TimTheoMaTaiKhoan(string ma)
        {
            IQueryable timtaikhoan = from tk in db.TAIKHOANs
                                     where tk.MATK == ma
                                     select new
                                     {
                                         tk.MATK,
                                         tk.SODU,
                                         tk.NGAYLAP,
                                         tk.MAKH,
                                         tk.LOAITK,
                                         tk.LOAITIEN,
                                         tk.MANV
                                     };
            return timtaikhoan;
        }

        public IQueryable TimTheoSoDu(float so)
        {
            IQueryable timtaikhoan = from tk in db.TAIKHOANs
                                     where tk.SODU == so
                                     select new
                                     {
                                         tk.MATK,
                                         tk.SODU,
                                         tk.NGAYLAP,
                                         tk.MAKH,
                                         tk.LOAITK,
                                         tk.LOAITIEN,
                                         tk.MANV
                                     };
            return timtaikhoan;
        }

        public IQueryable TimTheoMaOrTenKhach(string ma)
        {
            IQueryable tim = from tk in db.TAIKHOANs
                             join kh in db.KHACHHANGs on tk.MAKH equals kh.MAKH
                             where tk.MAKH == ma || kh.TENKH.Contains(ma)
                             select new
                             {
                                 tk.MATK,
                                 tk.SODU,
                                 tk.NGAYLAP,
                                 tk.MAKH,
                                 tk.LOAITK,
                                 tk.LOAITIEN,
                                 tk.MANV
                             };
            return tim;
        }

        public IQueryable LoadLoaiTK()
        {
            IQueryable loaitk = from ltk in db.LOAITAIKHOANs
                                select ltk.MALOAI + "-" + ltk.TENNH;
            return loaitk;
        }

        public IQueryable<string> sp_LayTheoMaLoaiTK(string ma)
        {
            var ten = from ltk in db.LOAITAIKHOANs
                      where ltk.MALOAI == ma
                      select ltk.MALOAI + "-" + ltk.TENNH;
            return ten;
        }

        public IQueryable LoadTienTe()
        {
            IQueryable tiente = from tt in db.TIENTEs
                                select tt.MATT + "-" + tt.TENTT;
            return tiente;
        }

        public IQueryable<string> sp_LayTheoMaTienTe(string ma)
        {
            var ten = from tt in db.TIENTEs
                      where tt.MATT == ma
                      select tt.MATT + "-" + tt.TENTT;
            return ten;
        }

        public IQueryable LoadNhanVien()
        {
            IQueryable nhanvien = from nv in db.NHANVIENs
                                  select nv.MANV + "-" + nv.TENNV;
            return nhanvien;
        }

        public IQueryable<string> sp_LayTheoMaNhanVien(string ma)
        {
            var ten = from nv in db.NHANVIENs
                      where nv.MANV == ma
                      select nv.MANV + "-" + nv.TENNV;
            return ten;
        }

        public IQueryable LoadKhachHang()
        {
            IQueryable khachhang = from kh in db.KHACHHANGs
                                   select kh.MAKH + "-" + kh.TENKH;
            return khachhang;
        }

        public IQueryable<string> sp_LayTheoMaKhachHang(string ma)
        {
            var ten = from kh in db.KHACHHANGs
                      where kh.MAKH == ma
                      select kh.MAKH + "-" + kh.TENKH;
            return ten;
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
