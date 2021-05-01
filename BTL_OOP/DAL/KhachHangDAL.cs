using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class KhachHangDAL
    {
        private List<KhachHangDTO> _dsKhachHang;

        public List<KhachHangDTO> DsKhachHang
        {
            get
            {
                if (_dsKhachHang == null)
                {
                    Load();
                }
                return _dsKhachHang;
            }
        }

        public void Load()
        {
            _dsKhachHang = new List<KhachHangDTO>()
            {
                new KhachHangDTO("00001", "Pham Hung", "Lang Son", "TC101", new DateTime(2021, 3, 15), new DateTime(2021, 4, 16), 10000000),
            };
        }
    }
}
