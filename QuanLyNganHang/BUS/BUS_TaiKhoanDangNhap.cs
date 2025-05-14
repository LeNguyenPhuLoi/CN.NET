using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoanDangNhap
    {
        DAL_TaiKhoanDangNhap login = new DAL_TaiKhoanDangNhap();

        public IQueryable LoadTKL()
        {
            return login.LoadTaiKhoanDN();
        }
        public bool ThemTKL(ET_TaiKhoanDangNhap et)
        {
            return login.ThemTKLogin(et);
        }
        public bool CapNhatTKL(ET_TaiKhoanDangNhap et)
        {
            return login.CapNhatTKL(et);
        }

        public bool XoaTKL(ET_TaiKhoanDangNhap et)
        {
            return login.XoaTKL(et);
        }
    }
}
