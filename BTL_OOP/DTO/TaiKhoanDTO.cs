// LE TON NANG - 20194339
namespace DTO
{
    public class TaiKhoanDTO
    {
        private string _email;
        /// <summary>
        /// Phương thức get/set email
        /// </summary>
        public string Email
        {
            get => _email;
            set { if (value != null) _email = value; }
        }

        private string _passWord;
        public string PassWord
        {
            get => _passWord;
            set { if (value != null) _passWord = value; }
        }
        /// <summary>
        /// Phương thức khỏi tạo 2 tham số
        /// </summary>
        /// <param name="_email"></param>
        /// <param name="_passWord"></param>
        public TaiKhoanDTO(string _email, string _passWord)
        {
            this._email = _email;
            this._passWord = _passWord;
        }
    }
}
