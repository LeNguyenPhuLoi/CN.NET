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

        public IQueryable TimVPTheoMa(string ma)
        {
            IQueryable VP = from vp in db.VIPHAMs
                            where vp.MAVP.Contains(ma)
                            select vp;
            return VP;
        }

        public IQueryable TimVPTheoTenNV(string ten)
        {
            IQueryable VP = from vp in db.VIPHAMs
                            where vp.MANV.Contains(LayMaNVTheoTen(ten))
                            select vp;
            return VP;
        }

        public IQueryable TimVPTheoMoTa(string mota)
        {
            IQueryable VP = from vp in db.VIPHAMs
                            where vp.MANQ.Contains(LayMaNQTheoMoTa(mota))
                            select vp;
            return VP;
        }

        public IQueryable TimVPTheoNgay(DateTime ngay)
        {
            IQueryable VP = from vp in db.VIPHAMs
                            where vp.NGAYVIPHAM.Value.Date == ngay.Date
                            select vp;
            return VP;
        }

        public List<ET_ViPhamReport> LayVPChoReport()
        {
            var query = from vp in db.VIPHAMs
                        join nv in db.NHANVIENs on vp.MANV equals nv.MANV
                        join nq in db.NOIQUYs on vp.MANQ equals nq.MANQ
                        select new ET_ViPhamReport
                        {
                            MaVP = vp.MAVP,
                            TenNV = nv.TENNV,
                            MoTa = nq.MOTA,
                            NgayViPham = vp.NGAYVIPHAM.Value,
                            TienPhat = (float)vp.TIENPHAT,
                            SoLanViPham = (int)vp.SOLANVIPHAM,
                            GhiChu = vp.GHICHU
                        };
            return query.ToList();
        }

        public List<ET_ViPhamReport> LayVPChoReportTheoMaVP(string ma)
        {
            var query = from vp in db.VIPHAMs
                        join nv in db.NHANVIENs on vp.MANV equals nv.MANV
                        join nq in db.NOIQUYs on vp.MANQ equals nq.MANQ
                        where vp.MAVP.Contains(ma)
                        select new ET_ViPhamReport
                        {
                            MaVP = vp.MAVP,
                            TenNV = nv.TENNV,
                            MoTa = nq.MOTA,
                            NgayViPham = vp.NGAYVIPHAM.Value,
                            TienPhat = (float)vp.TIENPHAT,
                            SoLanViPham = (int)vp.SOLANVIPHAM,
                            GhiChu = vp.GHICHU
                        };
            return query.ToList();
        }

        public List<ET_ViPhamReport> LayVPChoReportTheoTenNV(string ten)
        {
            var query = from vp in db.VIPHAMs
                        join nv in db.NHANVIENs on vp.MANV equals nv.MANV
                        join nq in db.NOIQUYs on vp.MANQ equals nq.MANQ
                        where vp.MANV.Contains(LayMaNVTheoTen(ten))
                        select new ET_ViPhamReport
                        {
                            MaVP = vp.MAVP,
                            TenNV = nv.TENNV,
                            MoTa = nq.MOTA,
                            NgayViPham = vp.NGAYVIPHAM.Value,
                            TienPhat = (float)vp.TIENPHAT,
                            SoLanViPham = (int)vp.SOLANVIPHAM,
                            GhiChu = vp.GHICHU
                        };
            return query.ToList();
        }

        public List<ET_ViPhamReport> LayVPChoReportTheoMoTa(string mota)
        {
            var query = from vp in db.VIPHAMs
                        join nv in db.NHANVIENs on vp.MANV equals nv.MANV
                        join nq in db.NOIQUYs on vp.MANQ equals nq.MANQ
                        where vp.MANQ.Contains(LayMaNQTheoMoTa(mota))
                        select new ET_ViPhamReport
                        {
                            MaVP = vp.MAVP,
                            TenNV = nv.TENNV,
                            MoTa = nq.MOTA,
                            NgayViPham = vp.NGAYVIPHAM.Value,
                            TienPhat = (float)vp.TIENPHAT,
                            SoLanViPham = (int)vp.SOLANVIPHAM,
                            GhiChu = vp.GHICHU
                        };
            return query.ToList();
        }

        public List<ET_ViPhamReport> LayVPChoReportTheoNgay(DateTime ngay)
        {
            var query = from vp in db.VIPHAMs
                        join nv in db.NHANVIENs on vp.MANV equals nv.MANV
                        join nq in db.NOIQUYs on vp.MANQ equals nq.MANQ
                        where vp.NGAYVIPHAM.Value == ngay
                        select new ET_ViPhamReport
                        {
                            MaVP = vp.MAVP,
                            TenNV = nv.TENNV,
                            MoTa = nq.MOTA,
                            NgayViPham = vp.NGAYVIPHAM.Value,
                            TienPhat = (float)vp.TIENPHAT,
                            SoLanViPham = (int)vp.SOLANVIPHAM,
                            GhiChu = vp.GHICHU
                        };
            return query.ToList();
        }

        public bool ThemVP(ET_ViPham et)
        {
            bool flag = false;
            try
            {
                var vpTonTai = db.VIPHAMs.Any(vp => vp.MAVP == et.MaVP);
                if (!vpTonTai)
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
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm vi phạm: " + ex.Message);
            }
            return flag;
        }


        public bool SuaVP(ET_ViPham et)
        {
            bool flag = false;
            try
            {
                var vp = db.VIPHAMs.SingleOrDefault(v => v.MAVP == et.MaVP);
                if (vp != null)
                {
                    vp.MANV = et.MaNV;
                    vp.MANQ = et.MaNQ;
                    vp.NGAYVIPHAM = et.NgayViPham;
                    vp.TIENPHAT = et.TienPhat;
                    vp.SOLANVIPHAM = et.SoLanViPham;
                    vp.GHICHU = et.GhiChu;
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa vi phạm: " + ex.Message);
            }
            return flag;
        }


        public bool XoaVP(ET_ViPham et)
        {
            bool flag = false;
            try
            {
                var vp = db.VIPHAMs.SingleOrDefault(v => v.MAVP == et.MaVP);
                if (vp != null)
                {
                    db.VIPHAMs.DeleteOnSubmit(vp);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa vi phạm: " + ex.Message);
            }
            return flag;
        }

    }
}
