using System;
using System.Collections.Generic;
using System.Data;
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

        public IQueryable TimNVTheoMa(string ma)
        {
            IQueryable NV = from nv in db.NHANVIENs
                            where nv.MANV.Contains(ma)
                            select nv;
            return NV;
        }

        public IQueryable TimNVTheoTen(string ten)
        {
            IQueryable NV = from nv in db.NHANVIENs
                            where nv.TENNV.Contains(ten)
                            select nv;
            return NV;
        }

        public IQueryable TimNVTheoSDT(int  sdt)
        {
            IQueryable NV = from nv in db.NHANVIENs
                            where nv.SDT == sdt
                            select nv;
            return NV;
        }

        public IQueryable TimNVTheoCN(string TenCN)
        {
            IQueryable NV = from nv in db.NHANVIENs
                            where nv.MACN.Contains(LayMaCNTheoTen(TenCN))
                            select nv;
            return NV;
        }

        public List<ET_NhanVienReport> LayNVChoReport()
        {
            var query = from nv in db.NHANVIENs
                        join pb in db.PHONGBANs on nv.MAPB equals pb.MAPB
                        join cn in db.CHINHANHs on nv.MACN equals cn.MACN
                        select new ET_NhanVienReport
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioiTinh = nv.GIOITINH,
                            NgaySinh = nv.NGAYSINH.Value,  
                            Chuc = nv.CHUC,
                            Luong = (float)nv.LUONG,  
                            DiaChi = nv.DIACHI,
                            SDT = nv.SDT.ToString(),
                            TenPB = pb.TENPB,
                            TenChiNhanh = cn.TENCHINHANH
                        };

            return query.ToList(); 
        }

        public List<ET_NhanVienReport> LayNVChoReportTheoMaNV(string ma)
        {
            var query = from nv in db.NHANVIENs
                        join pb in db.PHONGBANs on nv.MAPB equals pb.MAPB
                        join cn in db.CHINHANHs on nv.MACN equals cn.MACN
                        where nv.MANV.Contains(ma)
                        select new ET_NhanVienReport
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioiTinh = nv.GIOITINH,
                            NgaySinh = nv.NGAYSINH.Value,
                            Chuc = nv.CHUC,
                            Luong = (float)nv.LUONG,
                            DiaChi = nv.DIACHI,
                            SDT = nv.SDT.ToString(),
                            TenPB = pb.TENPB,
                            TenChiNhanh = cn.TENCHINHANH
                        };

            return query.ToList();
        }

        public List<ET_NhanVienReport> LayNVChoReportTheoTenNV(string ten)
        {
            var query = from nv in db.NHANVIENs
                        join pb in db.PHONGBANs on nv.MAPB equals pb.MAPB
                        join cn in db.CHINHANHs on nv.MACN equals cn.MACN
                        where nv.TENNV.Contains(ten)
                        select new ET_NhanVienReport
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioiTinh = nv.GIOITINH,
                            NgaySinh = nv.NGAYSINH.Value,
                            Chuc = nv.CHUC,
                            Luong = (float)nv.LUONG,
                            DiaChi = nv.DIACHI,
                            SDT = nv.SDT.ToString(),
                            TenPB = pb.TENPB,
                            TenChiNhanh = cn.TENCHINHANH
                        };

            return query.ToList();
        }

        public List<ET_NhanVienReport> LayNVChoReportTheoSDT(int sdt)
        {
            var query = from nv in db.NHANVIENs
                        join pb in db.PHONGBANs on nv.MAPB equals pb.MAPB
                        join cn in db.CHINHANHs on nv.MACN equals cn.MACN
                        where nv.SDT == sdt
                        select new ET_NhanVienReport
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioiTinh = nv.GIOITINH,
                            NgaySinh = nv.NGAYSINH.Value,
                            Chuc = nv.CHUC,
                            Luong = (float)nv.LUONG,
                            DiaChi = nv.DIACHI,
                            SDT = nv.SDT.ToString(),
                            TenPB = pb.TENPB,
                            TenChiNhanh = cn.TENCHINHANH
                        };

            return query.ToList();
        }

        public List<ET_NhanVienReport> LayNVChoReportTheoCN(string ten)
        {
            var query = from nv in db.NHANVIENs
                        join pb in db.PHONGBANs on nv.MAPB equals pb.MAPB
                        join cn in db.CHINHANHs on nv.MACN equals cn.MACN
                        where nv.MACN.Contains(LayMaCNTheoTen(ten))
                        select new ET_NhanVienReport
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioiTinh = nv.GIOITINH,
                            NgaySinh = nv.NGAYSINH.Value,
                            Chuc = nv.CHUC,
                            Luong = (float)nv.LUONG,
                            DiaChi = nv.DIACHI,
                            SDT = nv.SDT.ToString(),
                            TenPB = pb.TENPB,
                            TenChiNhanh = cn.TENCHINHANH
                        };

            return query.ToList();
        }

        public bool ThemNV(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                var exists = db.NHANVIENs.Any(nv => nv.MANV == et.MaNV);
                if (!exists)
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
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm nhân viên: " + ex.Message);
            }

            return flag;
        }


        public bool SuaNV(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                var capnhat = db.NHANVIENs.SingleOrDefault(nv => nv.MANV == et.MaNV);
                if (capnhat != null)
                {
                    capnhat.TENNV = et.TenNV;
                    capnhat.GIOITINH = et.GioiTinh;
                    capnhat.NGAYSINH = et.NgaySinh;
                    capnhat.CHUC = et.Chuc;
                    capnhat.LUONG = et.Luong;
                    capnhat.DIACHI = et.DiaCHi;
                    capnhat.SDT = et.SDT;
                    capnhat.MAPB = et.MaPB;
                    capnhat.MACN = et.MaCN;

                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật nhân viên: " + ex.Message);
            }
            return flag;
        }


        public bool XoaNV(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                var nv = db.NHANVIENs.SingleOrDefault(n => n.MANV == et.MaNV);
                if (nv != null)
                {
                    db.NHANVIENs.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa nhân viên: " + ex.Message);
            }
            return flag;
        }

    }
}
