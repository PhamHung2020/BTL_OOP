// Đồng Duy Tiến - 20194381
namespace DTO
{
    /// <summary>
    /// Class mô tả 1 tài khoản sử dụng phần mềm
    /// </summary>
    public class TaiKhoanDTO
    {
        private string _username = "Unknown";
        /// <summary>
        /// Username của tài khoản, không rỗng
        /// </summary>
        public string Username
        {
            get => _username;
            set { if (!string.IsNullOrEmpty(value)) _username = value; }
        }


        private string _passWord = "Unknown";
        /// <summary>
        /// Mật khẩu của tài khoản, không rỗng
        /// </summary>
        public string PassWord
        {
            get => _passWord;
            set { if (!string.IsNullOrEmpty(value)) _passWord = value; }
        }


        /// <summary>
        /// Phương thức khởi tạo của class
        /// </summary>
        /// <param name="username">Username của tài khoản</param>
        /// <param name="passWord">Mật khẩu của tài khoản</param>
        public TaiKhoanDTO(string username, string passWord)
        {
            Username = username;
            PassWord = passWord;
        }
    }
}
