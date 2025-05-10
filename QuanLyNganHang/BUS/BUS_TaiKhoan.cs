using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan tk = new DAL_TaiKhoan();

        public IQueryable LoadTK()
        {
            return tk.LoadTaiKhoan();
        }
        
        public IQueryable LoadLTK()
        {
            return tk.LoadLoaiTK();
        }

        public IQueryable<string> LayTheoMaLTK(string ma)
        {
            return tk.sp_LayTheoMaLoaiTK(ma);
        }

        public IQueryable LoadKH()
        {
            return tk.LoadKhachHang();
        }
        public IQueryable<string> LayTheoMaKH(string ma)
        {
            return tk.sp_LayTheoMaKhachHang(ma);
        }

        public IQueryable LoadTT() 
        {
            return tk.LoadTienTe();
        }
        public IQueryable<string> LayTheoMaTT(string ma)
        {
            return tk.sp_LayTheoMaTienTe(ma);
        }

        public IQueryable LoadNV() { 
            return tk.LoadNhanVien();
        }
        public IQueryable<string> LayTheoMaNV(string ma)
        {
            return tk.sp_LayTheoMaNhanVien(ma);
        }

        public bool ThemTK(ET_TaiKhoan et)
        {
            return tk.ThemTK(et);
        }

        public bool CapNhatTK(ET_TaiKhoan et)
        {
            return tk.CapNhatTK(et);
        }

        public bool XoaTK(ET_TaiKhoan et)
        {
            return tk.XoaTK(et);
        }
    }
}
