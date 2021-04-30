using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OPP
{
    public class TaiKhoanKhachHangDAL
    {
        private List<TaiKhoanKhachHang> taiKhoanKhachHangs = new List<TaiKhoanKhachHang>();
        public TaiKhoanKhachHangDAL()
        {
            taiKhoanKhachHangs.Add(
                new TaiKhoanKhachHang("nh3", "123456")
                );
            taiKhoanKhachHangs.Add(
               new TaiKhoanKhachHang("nang.lt194339", "123456")

               );
            taiKhoanKhachHangs.Add(
               new TaiKhoanKhachHang("hung.pm", "123456")

               );
            taiKhoanKhachHangs.Add(
               new TaiKhoanKhachHang("tien.dd", "123456")

               );

        }
        public List<TaiKhoanKhachHang> TaiKhoanKhachHangs {
            get { return this.taiKhoanKhachHangs; }
        }
        

    }
}
