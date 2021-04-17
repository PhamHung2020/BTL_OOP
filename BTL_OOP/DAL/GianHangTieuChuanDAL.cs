using System.Collections.Generic;
using System.Linq;
using DTO;
using DataServices;

namespace DAL
{
    public class GianHangTieuChuanDAL
    {
        private readonly GianHangTieuChuanDataAccess _context;

        public GianHangTieuChuanDAL(GianHangTieuChuanDataAccess context)
        {
            _context = context;
            _context.Load();
        }
          
        public void SaveChanges() => _context.SaveChanges();

        public List<GianHangTieuChuanDTO> LayDanhSachGianHang() => _context.DsGianHangTieuChuan;

        public GianHangTieuChuanDTO TimKiemTheoMaGianHang(string maGianHang)
        {
            foreach (var gianHang in _context.DsGianHangTieuChuan)
            {
                if (gianHang.MaGianHang == maGianHang)
                    return gianHang;
            }
            return null;
        }

        public List<GianHangTieuChuanDTO> TimKiemTheoKeyMaGianHang(string key)
        {
            var list = new List<GianHangTieuChuanDTO>();
            foreach (var gianHang in _context.DsGianHangTieuChuan)
            {
                if (gianHang.MaGianHang.Contains(key))
                    list.Add(gianHang);
            }
            return list;
        }

        public List<GianHangTieuChuanDTO> TimKiemTheoKeyViTri(string key)
        {
            var list = new List<GianHangTieuChuanDTO>();
            foreach (var gianHang in _context.DsGianHangTieuChuan)
            {
                if (gianHang.ViTriGianHang.Contains(key))
                    list.Add(gianHang);
            }
            return list;
        }

        public IEnumerable<GianHangTieuChuanDTO> DanhSachGianHangDuocThue()
        {
            return _context.DsGianHangTieuChuan.Where(gianHang => gianHang.TinhTrangThue);
        }

        public bool Them(GianHangTieuChuanDTO dto)
        {
            //foreach (var gianHang in _context.DsGianHangTieuChuan)
            //{
            //    if (gianHang.ViTriGianHang == dto.ViTriGianHang)
            //    {
            //        throw new Exception($"Gian hang moi trung vi tri voi gian hang co ma {gianHang.MaGianHang}");
            //    }
            //}

            _context.DsGianHangTieuChuan.Add(dto);
            return true;
        }

        public bool CapNhat(GianHangTieuChuanDTO dto)
        {
            var gianHang = TimKiemTheoMaGianHang(dto.MaGianHang);
            //if (gianHang.TinhTrangThue)
            //{
            //    throw new Exception("Gian hang dang duoc thue nen chua the cap nhat");
            //}
            gianHang.DienTich = dto.DienTich;
            gianHang.ViTriGianHang = dto.ViTriGianHang;
            gianHang.ChatLieuMaiChe = dto.ChatLieuMaiChe;
            gianHang.ChatLieuVachNgan = dto.ChatLieuVachNgan;
            return true;
        }

        public bool XoaGianHang(string maGianHang)
        {
            var gianHang = TimKiemTheoMaGianHang(maGianHang);
            //if (gianHang.TinhTrangThue)
            //{
            //    throw new Exception("Gian hang dang duoc thue. Ban khong the xoa gian hang nay");
            //}

            _context.DsGianHangTieuChuan.Remove(gianHang);
            return true;
        }

        public bool ThayDoiTinhTrangThue(string maGianHang, bool tinhTrangThue)
        {
            var gianHang = TimKiemTheoMaGianHang(maGianHang);
            gianHang.TinhTrangThue = tinhTrangThue;
            return true;
        }
    }
}
