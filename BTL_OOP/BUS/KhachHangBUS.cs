using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        // Singleton pattern
        private KhachHangBUS()
        {
            _context = new KhachHangDAL();
            _context.Load();
        }
        private static KhachHangBUS _instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhachHangBUS();
                }
                return _instance;
            }
        }
        private KhachHangDAL _context;

        public List<KhachHangDTO> TimKiemTheoMaGianHang(string maGianHang)
        {
            return _context.DsKhachHang.Where(khachHang => khachHang.MaGianHang == maGianHang).ToList();
        }

        public List<KhachHangDTO> TimKiemTheoMaGianHang(string maGianHang, DateTime time)
        {
            return _context.DsKhachHang.Where(khachHang => khachHang.MaGianHang == maGianHang &&
                                              khachHang.ThoiGianBatDauThue <= time &&
                                              time <= khachHang.ThoiGianKetThucThue).ToList();
        }


        public KhachHangDTO TimKiemTheoMaKhachHang(string maKhachHang)
        {
            return _context.DsKhachHang.FirstOrDefault(gianHang => gianHang.MaKhachHang == maKhachHang);
        }

        public List<KhachHangDTO> LayDanhSachKhachHang()
        {
            return _context.DsKhachHang;
        }

        public bool ThemKhachHang(KhachHangDTO khachHangMoi)
        {
            if (khachHangMoi.ThoiGianBatDauThue < DateTime.Now)
            {
                throw new Exception($"Thời điểm thuê không hợp lệ");
            }
            foreach (var khachHang in _context.DsKhachHang)
            {
                if (khachHangMoi.MaGianHang == khachHang.MaGianHang &&
                   (khachHang.ThoiGianBatDauThue <= khachHangMoi.ThoiGianBatDauThue &&
                    khachHang.ThoiGianKetThucThue >= khachHangMoi.ThoiGianKetThucThue) ||
                   (khachHang.ThoiGianBatDauThue <= khachHangMoi.ThoiGianKetThucThue &&
                    khachHang.ThoiGianKetThucThue >= khachHangMoi.ThoiGianKetThucThue))
                {
                    throw new Exception($"Gian hàng {khachHangMoi.MaGianHang} đang được thuê bởi khách hàng {khachHang.MaKhachHang} từ {khachHang.ThoiGianBatDauThue.ToString()} đến {khachHang.ThoiGianKetThucThue.ToString()}");
                }
            }
            _context.DsKhachHang.Add(khachHangMoi);
            return true;
        }

        public bool CapNhatKhachHang(KhachHangDTO khachHangCapNhat)
        {
            KhachHangDTO khachHang = TimKiemTheoMaKhachHang(khachHangCapNhat.MaKhachHang);
            if (khachHang == null)
            {
                throw new Exception("Khách hàng không tồn tại");
            }
            khachHang = khachHangCapNhat;
            return true;
        }
    }
}
