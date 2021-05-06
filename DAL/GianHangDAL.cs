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
                new GianHangCaoCapDTO("CC102", 5.6, "102", false, 5, 6),
                new GianHangCaoCapDTO("CC203", 10.25, "202", false, 10, 12),
                new GianHangTieuChuanDTO("TC101", 5.6, "101", true, "Ton", "Nhua"),
                new GianHangTieuChuanDTO("TC202", 10.25, "202", false, "Sat", "Dong"),
                new GianHangTieuChuanDTO("TC205", 13.6, "205", true, "Sat", "Vai"),
                new GianHangTieuChuanDTO("TC104", 10.54, "104", true, "Nhua", "Dong"),
                new GianHangTieuChuanDTO("TC304", 7.8, "304", true, "Khong biet", "Cao su"),
                new GianHangTieuChuanDTO("TC305", 12.4, "305", true, "Vat lieu nano", "Khong biet"),
                new GianHangTieuChuanDTO("TC406", 8.87, "406", false, "Ton", "Thep"),
                new GianHangCaoCapDTO("CC103", 16.4, "103", false, 5, 6),
                new GianHangCaoCapDTO("CC201", 17.5, "201", false, 6, 8),
                new GianHangCaoCapDTO("CC204", 17.2, "202", false, 5, 5),
                new GianHangCaoCapDTO("CC301", 18.7, "301", false, 7, 8),
                new GianHangCaoCapDTO("CC302", 19, "302", false, 8, 8),
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
