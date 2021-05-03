using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BUS
{
    public class GianHangBUS
    {
        // Singleton pattern
        private GianHangBUS()
        {
            _context = new GianHangDAL();
            _context.Load();
        }
        private static GianHangBUS _instance;
        public static GianHangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GianHangBUS();
                }
                return _instance;
            }
        }

        private GianHangDAL _context;

        public List<GianHangDTO> TimKiemTheoMaGianHang(string maGianHang)
        {
            return _context.DsGianHang.Where(gianHang => gianHang.MaGianHang.Contains(maGianHang)).ToList();
        }

        public List<T> TimKiemTheoMaGianHang<T>(string maGianHang) where T : GianHangDTO
        {
            return _context.DsGianHang.Where(gianHang => gianHang.MaGianHang.Contains(maGianHang) && gianHang is T).ToList() as List<T>;
        }

        public List<T> LayDanhSachGianHang<T>() where T : GianHangDTO
        {
            return _context.LayDanhSachGianHang<T>();
        }

        public bool ThemGianHang(GianHangDTO gianHangMoi)
        {
            foreach (var gianHang in _context.DsGianHang)
            {
                if (gianHang.ViTriGianHang == gianHangMoi.ViTriGianHang)
                {
                    throw new Exception($"Gian hàng mới có vị trí trùng với gian hàng có mã {gianHang.MaGianHang}");
                }
            }
            _context.DsGianHang.Add(gianHangMoi);
            return true;
        }

        public bool CapNhatGianHang(GianHangDTO gianHangCapNhat)
        {
            var gianHang = TimKiemTheoMaGianHang<GianHangDTO>(gianHangCapNhat.MaGianHang)[0];
            if (gianHang == null)
            {
                throw new Exception("Gian hàng không tồn tại");
            }
            else if (gianHang.TinhTrangThue)
            {
                throw new Exception("Gian hàng đang được thuê. Cập nhật không thành công");
            }
            int index = _context.DsGianHang.IndexOf(gianHang);
            _context.DsGianHang[index] = gianHangCapNhat;
            return true;
        }

        public bool XoaGianHang(string maGianHang)
        {
            var gianHang = TimKiemTheoMaGianHang(maGianHang)[0];
            if (gianHang == null)
            {
                throw new Exception("Gian hàng không tồn tại");
            }
            else if (gianHang.TinhTrangThue)
            {
                throw new Exception("Gian hàng đang được thuê. Xóa không thành công");
            }
            _context.DsGianHang.Remove(gianHang);
            return true;
        }

        public List<GianHangDTO> DanhSachGianHangTheoSoTang(int tang)
        {
            if (tang <= 0)
                return null;
            List<GianHangDTO> list = new List<GianHangDTO>();
            foreach (GianHangDTO gianHang in _context.DsGianHang)
            {
                if (gianHang.MaGianHang[2] - '0' == tang)
                {
                    list.Add(gianHang);
                }
            }
            return list;
        }

        public List<GianHangDTO> DanhSachGianHangTheoTinhTrangThue(bool tinhTrangThue)
        {
            return _context.DsGianHang.Where(gianHang => gianHang.TinhTrangThue == tinhTrangThue).ToList();
        }

        public void ThayDoiTinhTrangThue(string maGianHang, bool tinhTrangThue)
        {
            GianHangDTO gianHang = TimKiemTheoMaGianHang(maGianHang)[0];
            if (gianHang == null)
            {
                throw new Exception("Gian hàng không tồn tại");
            }
            else if (tinhTrangThue && gianHang.TinhTrangThue)
            {
                throw new Exception("Gian hàng này hiện tại đang được thuê bởi 1 khách hàng khác");
            }
            gianHang.TinhTrangThue = tinhTrangThue;
        }
    }
}
