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

        public bool Thue(KhachHangDTO khachHangMoi)
        {
            bool isSuccess = true;
            try
            {
                if (khachHangMoi.ThoiGianBatDauThue.Date <= DateTime.Now.Date &&
                     DateTime.Now.Date <= khachHangMoi.ThoiGianKetThucThue.Date)
                     GianHangBUS.Instance.ThayDoiTinhTrangThue(khachHangMoi.MaGianHang, true);
                isSuccess = KhachHangBUS.Instance.ThemKhachHang(khachHangMoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isSuccess;
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
                doanhThu += GianHangBUS.Instance.TimKiemTheoMaGianHang(khachHang.MaGianHang)[0].TinhChiPhi((int)time.TotalDays + 1);
            }
            return doanhThu;
        }

        public decimal DoanhThu(int thang, int year = 0)
        {
            if (thang < 1 || thang > 12)
                throw new Exception("Tháng phải nằm trong khoảng 1 - 12");
            if (year == 0)
                year = DateTime.Now.Year;
            else if (year < 0)
                throw new Exception("Năm phải lớn hơn 0");
            DateTime thoiGianBatDau = new DateTime(year, thang, 1);
            int ngayCuoiThang = DateTime.DaysInMonth(year, thang);
            DateTime thoiGianKetThuc = new DateTime(year, thang, ngayCuoiThang);
            return DoanhThu(thoiGianBatDau, thoiGianKetThuc);
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
            List<GianHangDTO> dsGianHangThue = GianHangBUS.Instance.LayDanhSachGianHang<GianHangDTO>();
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
                else if (!dsThue[khachHang.MaGianHang].TinhTrangThue &&
                         khachHang.ThoiGianBatDauThue.Date <= DateTime.Now.Date)
                {
                    dsThue[khachHang.MaGianHang].TinhTrangThue = false;
                }
            }
        }
    }
}
