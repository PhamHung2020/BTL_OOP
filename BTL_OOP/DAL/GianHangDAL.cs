using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class GianHangDAL
    {
        private List<GianHangDTO> _dsGianHang;

        public List<GianHangDTO> DsGianHang
        {
            get
            {
                if (_dsGianHang == null)
                {
                    Load();
                }
                return _dsGianHang;
            }
        }

        public void Load()
        {
            _dsGianHang = new List<GianHangDTO>()
            {
                new GianHangCaoCapDTO("CC101", 5.6, "101", false, 5, 6),
                new GianHangCaoCapDTO("CC203", 10.25, "202", false, 10, 12),
                new GianHangTieuChuanDTO("TC101", 5.6, "101", true, "Ton", "Nhua"),
                new GianHangTieuChuanDTO("TC202", 10.25, "202", false, "Sat", "Dong")
            };
        }

        public List<T> LayDanhSachGianHang<T>() where T : GianHangDTO
        {
            if (typeof(T) == typeof(GianHangDTO))
            {
                return _dsGianHang as List<T>;
            }

            List<T> list = new List<T>();
            foreach (GianHangDTO gianHang in _dsGianHang)
            {
                if (gianHang is T)
                {
                    list.Add(gianHang as T);
                }
            }
            return list;
        }
    }
}
