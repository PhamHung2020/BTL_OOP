// Lê Tôn Năng - 20194339
using DAL;

namespace BUS
{
    /// <summary>
    /// Class xử lý trung gian các vấn đề liên quan đến tài khoản người dùng
    /// </summary>
    public class TaiKhoanBUS
    {
        // Singleton Pattern
        private static TaiKhoanBUS _instance;

        public static TaiKhoanBUS Instance()
        {
            if (_instance == null)
            {
                _instance = new TaiKhoanBUS();
            }
            return _instance;
        }

        private TaiKhoanBUS() { }


        /// <summary>
        /// Kiểm tra xem username và password truyền vào có trùng với một tài khoản đã có nào hay không
        /// </summary>
        /// <param name="username">Username cần kiểm tra</param>
        /// <param name="password">Password cần kiếm tra</param>
        /// <returns>Nếu username và password hợp lệ, trả về true. Ngược lại, trả về false</returns>
        public bool Check(string username, string password)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            // Tìm kiếm trong danh sách tài khoản, có tài khoản nào trùng với username và password truyền vào hay không
            foreach (var taiKhoan in taiKhoanDAL.DsTaiKhoan)
            {
                if (taiKhoan.Username == username && taiKhoan.PassWord == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
