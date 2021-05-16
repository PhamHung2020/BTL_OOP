using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanKhachHangDAL
    {
        private List<TaiKhoanDTO> taiKhoanKhachHangs = new List<TaiKhoanDTO>();
        public TaiKhoanKhachHangDAL()
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
        public List<TaiKhoanDTO> TaiKhoanKhachHangs
        {
            get { return this.taiKhoanKhachHangs; }
        }
    }
}
