using System;
using DTO;

namespace BUS
{
    public static class HelperBUS
    {
        public static string GenerateMaGianHang<T>(string viTriGianHang) where T : GianHangDTO
        {
            Type type = typeof(T);
            if (type == typeof(GianHangTieuChuanDTO))
            {
                return "TC" + viTriGianHang;
            }
            else if (type == typeof(GianHangCaoCapDTO))
            {
                return "CC" + viTriGianHang;
            }
            return null;
        }

        public static string GenerateMaKhachHang(string maGianHang, DateTime thoiDiemBatDau)
        {
            return maGianHang + thoiDiemBatDau.Year + thoiDiemBatDau.Month + thoiDiemBatDau.Day;
        }

        public static void InTT<T>(T gianHang) where T : GianHangDTO
        {
            if (gianHang == null)
                return;
            Console.WriteLine($"Ma gian hang {gianHang.MaGianHang}");
            Console.WriteLine($"Dien tich : {gianHang.DienTich}");
            Console.WriteLine($"Vi tri : {gianHang.ViTriGianHang}");
            Console.WriteLine($"Tinh trang thue : {gianHang.TinhTrangThue}");
            if (typeof(T) == typeof(GianHangTieuChuanDTO))
            {
                var newGianHang = gianHang as GianHangTieuChuanDTO;
                Console.WriteLine($"Chat lieu mai che : {newGianHang.ChatLieuMaiChe}");
                Console.WriteLine($"Chat lieu vach ngan : {newGianHang.ChatLieuVachNgan}");
            }
            else if (typeof(T) == typeof(GianHangCaoCapDTO))
            {
                var newGianHang = gianHang as GianHangCaoCapDTO;
                Console.WriteLine($"So luong quat lam mat : {newGianHang.SoQuatLamMat}");
                Console.WriteLine($"So luong ban ghe : {newGianHang.SoBanGhe}");
            }
        }

        public static void InTT(KhachHangDTO khachHang)
        {
            if (khachHang == null)
                return;
            Console.WriteLine($"Ma khach hang : {khachHang.MaKhachHang}");
            Console.WriteLine($"Ten : {khachHang.Ten}");
            Console.WriteLine($"Dia chi : {khachHang.DiaChi}");
            Console.WriteLine($"Thoi gian bat dau thue : {khachHang.ThoiGianBatDauThue.ToShortDateString()}");
            Console.WriteLine($"Thoi gian ket thuc thue : {khachHang.ThoiGianKetThucThue.ToShortDateString()}");
            Console.WriteLine($"Tien dat coc : {khachHang.TienDatCoc}");
        }
    }
}
