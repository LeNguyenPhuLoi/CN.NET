using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_Login
    {
        private string _username;
        private string _password;
        private string _quyen;
        private string _MaNV;

        public ET_Login(string username, string password, string quyen, string maNV)
        {
            Username = username;
            Password = password;
            Quyen = quyen;
            MaNV = maNV;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Quyen { get => _quyen; set => _quyen = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
    }
}
