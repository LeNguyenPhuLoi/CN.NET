using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BienLai
    {
        DAL_BienLai bl = new DAL_BienLai();

        public IQueryable LoadBL()
        {
            return bl.LoadBL();
        }

        public IQueryable TimBLTheoMa(string ma)
        {
            return bl.TimBLTheoMa(ma);
        }

        public IQueryable TimBLTheoLoai(string loai)
        {
            return bl.TimBLTheoLoai(loai);
        }

        public IQueryable TimBLTheoMaNV(string mablnv)
        {
            return bl.TimBLTheoMaNV(mablnv);
        }

        public IQueryable TimBLTheoMaKH(string mablkh)
        {
            return bl.TimBLTheoMaKH(mablkh);
        }

        public bool ThemBL(ET_BienLai et)
        {
            return bl.ThemBL(et);
        }

        public bool SuaBL(ET_BienLai et)
        {
            return bl.SuaBL(et);
        }

        public bool XoaBL(ET_BienLai et)
        {
            return bl.XoaBL(et);
        }
    }
}
