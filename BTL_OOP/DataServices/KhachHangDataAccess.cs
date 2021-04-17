using System;
using System.Collections.Generic;
using DTO;

namespace DataServices
{
    public class KhachHangDataAccess
    {
        public List<KhachHangDTO> DsKhachHang { get; set; }

        public void Load()
        {
            DsKhachHang = new List<KhachHangDTO>()
            {
                new KhachHangDTO()
                {
                    Ten = "Pham Hung",
                    DiaChi = "Lang Son",
                    ThoiGianBatDauThue = new DateTime(2020, 1, 30),
                    ThoiGianKetThucThue = new DateTime(2020, 2, 2),
                    MaGianHang = "00000",
                    TienDatCoc = 2000000,
                },
            };
        }

        public void SaveChanges()
        {

        }
    }
}
