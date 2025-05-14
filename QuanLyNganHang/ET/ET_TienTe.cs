using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TienTe
    {
        public ET_TienTe(string mATT, string tENTT)
        {
            MATT = mATT;
            TENTT = tENTT;
        }

        public string MATT { get; set; }
        public string TENTT { get; set; }
    }
}
