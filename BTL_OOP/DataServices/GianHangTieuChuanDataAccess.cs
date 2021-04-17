using System.Collections.Generic;
using DTO;

namespace DataServices
{
    public class GianHangTieuChuanDataAccess
    {
        public List<GianHangTieuChuanDTO> DsGianHangTieuChuan { get; set; }

        public void Load()
        {
            DsGianHangTieuChuan = new List<GianHangTieuChuanDTO>()
            {
                new GianHangTieuChuanDTO("00000", 5.2, "Tang 1 Khu A So 1", false),
                new GianHangTieuChuanDTO("00001", 8.7, "Tang 1 Khu B So 2", false),
                new GianHangTieuChuanDTO("00002", 10.5, "Tang 2 Khu C So 1", false),
            };
        }

        public void SaveChanges()
        {

        }

    }
}
