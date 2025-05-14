using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Login
    {
        DAL_Login lg = new DAL_Login();

        public ET_Login DangNhap(string username, string password)
        {
            return lg.KiemTraDangNhap(username, password); // trả về null nếu sai
        }

        public bool IsAdmin(ET_Login user)
        {
            return user != null && user.Quyen == "ADMIN";
        }

        public bool IsNhanVien(ET_Login user)
        {
            return user != null && user.Quyen == "NV";
        }
    }
}
