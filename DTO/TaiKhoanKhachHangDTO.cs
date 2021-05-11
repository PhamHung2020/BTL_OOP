using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class TaiKhoanKhachHang
    {
        private string _email;
        private string _password;
        public TaiKhoanKhachHang(string email, string password)
        {
            this._email = email;
            this._password = password;
        }
        public string Email {
            get { return _email; }
            set { _email = value; }

        }
        public string Password {
            get { return _password; }
            set { _password = value; }
        }
    }
}
