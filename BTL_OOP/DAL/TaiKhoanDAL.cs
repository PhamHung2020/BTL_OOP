// Lê Tôn Năng - 20194339
using System.Collections.Generic;
using DTO;

namespace DAL
{
    /// <summary>
    /// Class lưu trữ danh sách các tài khoản của phần mềm
    /// </summary>
    public class TaiKhoanDAL
    {
        private List<TaiKhoanDTO> _dsTaiKhoan = new List<TaiKhoanDTO>();
        /// <summary>
        /// Danh sách các tài khoản của phần mềm
        /// </summary>
        public List<TaiKhoanDTO> DsTaiKhoan { get => _dsTaiKhoan; }


        /// <summary>
        /// Phương thức khởi tạo của class
        /// </summary>
        public TaiKhoanDAL()
        {
            _dsTaiKhoan = new List<TaiKhoanDTO>()
            {
               new TaiKhoanDTO("nh3", "123456"),
               new TaiKhoanDTO("nang.lt194339", "123456"),
               new TaiKhoanDTO("hung.pm", "123456"),
               new TaiKhoanDTO("tien.dd", "123456")
            };
        }
    }
}
