using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class TaiKhoanKhachHangBUS
    {
        private static TaiKhoanKhachHangBUS _instance;
        private TaiKhoanKhachHangBUS() { }
        public static TaiKhoanKhachHangBUS getInstance()
        {
            if(_instance == null)
            {
                _instance = new TaiKhoanKhachHangBUS();
            }
            return _instance;
        }
        public bool Check(string email, string password)
        {
            bool check = false;
            TaiKhoanKhachHangDAL taiKhoanKhachHangDAL = new TaiKhoanKhachHangDAL();
            foreach(var i in taiKhoanKhachHangDAL.TaiKhoanKhachHangs)
            {
                if(i.Email == email && i.Password == password)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
