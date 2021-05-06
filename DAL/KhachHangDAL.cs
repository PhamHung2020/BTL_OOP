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
                new KhachHangDTO("00001", "Pham Hung", "Lang Son", "TC101", new DateTime(2021, 3, 15), new DateTime(2021, 3, 15), 10000000),
                new KhachHangDTO("TC20520210120 ", "Nguyen Van A", "Ha Noi", "TC205", new DateTime(2021, 1, 20), new DateTime(2021, 2, 20), 7000000),
                new KhachHangDTO("TC10420210113 ", "Nguyen Van B", "Ha Noi", "TC104", new DateTime(2021, 1, 13), new DateTime(2021, 3, 1), 10000000),
                new KhachHangDTO("TC30420210201 ", "Nguyen Van C", "Ha Noi", "TC304", new DateTime(2021, 2, 1), new DateTime(2021, 4, 15), 11000000),
                new KhachHangDTO("TC30520210202 ", "Nguyen Van D", "Ha Noi", "TC305", new DateTime(2021, 2, 2), new DateTime(2021, 3, 2), 7000000),
                
            };
        }
    }
}
