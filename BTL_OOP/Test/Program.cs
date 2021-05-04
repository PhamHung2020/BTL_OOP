using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using DTO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var gianHang1 = GianHangBUS.Instance.TimKiemTheoMaGianHang("TC202");
            //HelperBUS.InTT<GianHangDTO>(gianHang1);

            //GianHangTieuChuanDTO gianHang = new GianHangTieuChuanDTO("TC202", 7.8, "202", false, "Khong biet", "Khong biet");
            //bool isSuccess = GianHangBUS.Instance.CapNhatGianHang(gianHang);
            //Console.WriteLine(isSuccess);

            //Console.WriteLine();
            //var gianHang2 = GianHangBUS.Instance.TimKiemTheoMaGianHang("TC202");
            //HelperBUS.InTT<GianHangDTO>(gianHang2);

            //GianHangBUS.Instance.XoaGianHang("TC101");

            //GianHangBUS.Instance.ThayDoiTinhTrangThue("TC101", true);

            //var list = GianHangBUS.Instance.DanhSachGianHangTheoTinhTrangThue(true);
            //foreach (var newgianHang in list)
            //{
            //    HelperBUS.InTT<GianHangDTO>(newgianHang);
            //    Console.WriteLine();
            //}
            //KhachHangDTO khachHang = new KhachHangDTO("00002", "Dong Tien", "Hai Phong", "TC202", new DateTime(2021, 5, 1), new DateTime(2021, 5, 24), 20000000);
            //KhuTrungBayBUS.Instance.Thue(khachHang);
            //KhuTrungBayBUS.Instance.KiemTraTinhTrangThue();
            //var newlist = GianHangBUS.Instance.DanhSachGianHangTheoTinhTrangThue(true);
            //foreach (var newgianHang in newlist)
            //{
            //    HelperBUS.InTT<GianHangDTO>(newgianHang);
            //    Console.WriteLine();
            //}
            //var gianHang2 = GianHangBUS.Instance.TimKiemTheoMaGianHang("TC101");
            //HelperBUS.InTT<GianHangDTO>(gianHang2);

            //var list = KhachHangBUS.Instance.TimKiemTheoMaGianHang("TC101");
            //foreach (var khachHang in list)
            //{
            //    HelperBUS.InTT(khachHang);
            //    Console.WriteLine();
            //}

            //var khachHang = KhachHangBUS.Instance.TimKiemTheoMaKhachHang("00002");
            //HelperBUS.InTT(khachHang);

            //Console.WriteLine(KhuTrungBayBUS.Instance.DoanhThu(new DateTime(2021, 3, 1), new DateTime(2021, 3, 10)));
            var list = GianHangBUS.Instance.TimKiemTheoMaGianHang<GianHangDTO>("C1");
            foreach (var gianHang in list)
            {
                HelperBUS.InTT<GianHangDTO>(gianHang);
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
