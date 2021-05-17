// LE TON NANG - 20194339
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private List<TaiKhoanDTO> taiKhoanKhachHangs = new List<TaiKhoanDTO>();
        /// <summary>
        /// Danh sách tài khoản khách hàng có sẵn
        /// </summary>
        public TaiKhoanDAL()
        {
            taiKhoanKhachHangs.Add(
                new TaiKhoanDTO("nh3", "123456")
                );
            taiKhoanKhachHangs.Add(
               new TaiKhoanDTO("nang.lt194339", "123456")

               );
            taiKhoanKhachHangs.Add(
               new TaiKhoanDTO("hung.pm", "123456")

               );
            taiKhoanKhachHangs.Add(
               new TaiKhoanDTO("tien.dd", "123456")

               );

        }
        /// <summary>
        /// Phương thức trả về list tài khoản khách hàng
        /// </summary>
        public List<TaiKhoanDTO> TaiKhoanKhachHangs
        {
            get { return this.taiKhoanKhachHangs; }
        }
    }
}
