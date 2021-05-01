using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class KhuTrungBayBUS
    {
        // Singleton pattern
        private KhuTrungBayBUS()
        {
            _context = new KhuTrungBayDAL();
        }
        private static KhuTrungBayBUS _instance;
        public static KhuTrungBayBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhuTrungBayBUS();
                }
                return _instance;
            }
        }

        private KhuTrungBayDAL _context;

        public void Thue(KhachHangDTO khachHangMoi)
        {
            try
            {
                GianHangBUS.Instance.ThayDoiTinhTrangThue(khachHangMoi.MaGianHang, true);
                KhachHangBUS.Instance.ThemKhachHang(khachHangMoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal DoanhThu(DateTime thoiGianBatDau, DateTime thoiGianKetThuc)
        {
            decimal doanhThu = 0;
            var dsKhachHang = KhachHangBUS.Instance.LayDanhSachKhachHang();
            foreach (var khachHang in dsKhachHang)
            {
                var time = new TimeSpan(-1, 0, 0, 0);
                if (thoiGianBatDau.Date <= khachHang.ThoiGianBatDauThue.Date && 
                    khachHang.ThoiGianKetThucThue.Date <= thoiGianKetThuc.Date)
                {
                    time = khachHang.ThoiGianKetThucThue - khachHang.ThoiGianBatDauThue;
                }
                else if (khachHang.ThoiGianBatDauThue.Date < thoiGianBatDau.Date && 
                         khachHang.ThoiGianKetThucThue.Date < thoiGianKetThuc.Date &&
                         thoiGianBatDau.Date <= khachHang.ThoiGianKetThucThue.Date)
                {
                    time = khachHang.ThoiGianKetThucThue - thoiGianBatDau;
                }
                else if (thoiGianBatDau.Date < khachHang.ThoiGianBatDauThue.Date && 
                         thoiGianKetThuc.Date < khachHang.ThoiGianKetThucThue.Date &&
                         khachHang.ThoiGianBatDauThue.Date <= thoiGianKetThuc.Date)
                {
                    time = thoiGianKetThuc - khachHang.ThoiGianBatDauThue;
                }
                doanhThu += GianHangBUS.Instance.TimKiemTheoMaGianHang(khachHang.MaGianHang).TinhChiPhi((int)time.TotalDays + 1);
            }
            return doanhThu;
        }

        public List<int> ViTriConTrong(int tang)
        {
            if (tang <= 0)
                return null;
            int soViTri = _context.SoViTriMoiTang[tang];
            List<GianHangDTO> dsGianHang = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(tang);
            List<int> result = new List<int>();
            for (int i = 1; i <= soViTri; ++i)
            {
                result.Add(i);
            }

            foreach (GianHangDTO gianHang in dsGianHang)
            {
                result.RemoveAt(gianHang.MaGianHang[4] - '0' - 1);
            }
            return result;
        }

        public void KiemTraTinhTrangThue()
        {
            List<GianHangDTO> dsGianHangThue = GianHangBUS.Instance.DanhSachGianHangTheoTinhTrangThue(true);
            Dictionary<string, GianHangDTO> dsThue = new Dictionary<string, GianHangDTO>();
            foreach (GianHangDTO gianHang in dsGianHangThue)
            {
                dsThue.Add(gianHang.MaGianHang, gianHang);
            }

            List<KhachHangDTO> dsKhachHang = KhachHangBUS.Instance.LayDanhSachKhachHang();
            foreach (KhachHangDTO khachHang in dsKhachHang)
            {
                if (dsThue[khachHang.MaGianHang].TinhTrangThue &&
                    khachHang.ThoiGianKetThucThue.Date < DateTime.Now.Date)
                {
                    dsThue[khachHang.MaGianHang].TinhTrangThue = false;
                }
            }
        }
    }
}
