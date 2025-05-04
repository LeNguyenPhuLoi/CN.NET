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
        QLNHDataContext db = new QLNHDataContext();

        public bool kqdangnhap(ET_Login et)
        {
            var result = (from tk in db.TKDANGNHAPs
                          where tk.TENDN == et.Username
                                && tk.MATKHAU == et.Password
                                && tk.QUYEN == et.Quyen
                          select tk).FirstOrDefault();

            return result != null;
        }
    }
}
