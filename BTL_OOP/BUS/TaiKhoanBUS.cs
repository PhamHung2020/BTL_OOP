/*LE TON NANG - 20194339*/
using DAL;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS _instance;
        private TaiKhoanBUS() { }
        public static TaiKhoanBUS getInstance()
        {
            if (_instance == null)
            {
                _instance = new TaiKhoanBUS();
            }
            return _instance;
        }
        /// <summary>
        /// Phương thức check xem tài khoản có hợp lệ hay không
        /// </summary>
        /// <param name="email">Email nhập vào</param>
        /// <param name="password">Password nhập vào</param>
        /// <returns>True nếu tài khoản hợp lệ</returns>
        public bool Check(string email, string password)
        {
            bool check = false;
            TaiKhoanDAL taiKhoanKhachHangDAL = new TaiKhoanDAL();
            foreach (var i in taiKhoanKhachHangDAL.TaiKhoanKhachHangs)
            {
                if (i.Email == email && i.PassWord == password)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
