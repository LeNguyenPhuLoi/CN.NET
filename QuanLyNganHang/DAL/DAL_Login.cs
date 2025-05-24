using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Login
    {
        AutoConnection conn = new AutoConnection();
        QLNHDataContext db;

        public DAL_Login()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public ET_Login KiemTraDangNhap(string username, string password)
        {
            var user = db.TKDANGNHAPs
                .Where(nd => nd.TENDN == username && nd.MATKHAU == password)
                .Select(nd => new ET_Login(
                    nd.TENDN,
                    nd.MATKHAU,
                    nd.QUYEN,
                    nd.MANV))
                .FirstOrDefault();

            return user; // Trả về null nếu không đúng
        }
    }
}
