using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataServices;

namespace DAL
{
    public class KhachHangDAL
    {
        private readonly KhachHangDataAccess _context;

        public KhachHangDAL(KhachHangDataAccess context)
        {
            _context = context;
            _context.Load();
        }

        public void SaveChanges() => _context.SaveChanges();

        public KhachHangDTO TimKiemKhachHangTheoMaGianHang(string maGianHang)
        {
            return _context.DsKhachHang.First(khachHang => khachHang.MaGianHang == maGianHang);
        }

        public bool ThemKhachHang(KhachHangDTO dto)
        {
            _context.DsKhachHang.Add(dto);
            return true;
        }

        public bool CapNhatKhachHang(string maGianHang, KhachHangDTO dto)
        {
            KhachHangDTO khachHangCapNhat = TimKiemKhachHangTheoMaGianHang(maGianHang);
            if (khachHangCapNhat == null)
                return false;
            khachHangCapNhat = dto;
            return true;
        }

        public bool XoaKhachHang(string maGianHang)
        {
            KhachHangDTO khachHang = TimKiemKhachHangTheoMaGianHang(maGianHang);
            if (khachHang == null)
                return false;
            _context.DsKhachHang.Remove(khachHang);
            return true;
        }
    }
}
