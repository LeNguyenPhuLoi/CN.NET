using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiTaiKhoan
    {
        DAL_LoaiTaiKhoan dlltk = new DAL_LoaiTaiKhoan();

        public IQueryable LoadLTK()
        {
            return dlltk.LoadLoaiTaiKhoan();
        }

        public bool ThemLTK(ET_LoaiTaiKhoan et)
        {
            return dlltk.ThemLoaiTaiKhoan(et);
        }

        public bool CapNhatLTK(ET_LoaiTaiKhoan et)
        {
            return dlltk.CapNhatLTK(et);
        }

        public bool XoaLTK(ET_LoaiTaiKhoan et)
        {
            return dlltk.XoaLTK(et);
        }
    }
}
