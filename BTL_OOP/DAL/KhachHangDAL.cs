// Phạm Mạnh Hùng - 20194293
using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    /// <summary>
    /// Class khởi tạo và lưu trữ dữ liệu về khách hàng
    /// </summary>
    public class KhachHangDAL
    {
        private List<KhachHangDTO> _dsKhachHang;
        /// <summary>
        /// Danh sách các khách hàng
        /// </summary>
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


        /// <summary>
        /// Khởi tạo dữ liệu ban đầu cho chương trình, tránh việc khi chạy chương trình thì phải nhập lại dữ liệu từ đầu
        /// </summary>
        public void Load()
        {
            _dsKhachHang = new List<KhachHangDTO>()
            {
                new KhachHangDTO("TC10120211503", "Pham Hung", "Lang Son", "TC101", new DateTime(2021, 3, 15), new DateTime(2021, 6, 15), 10000000),
                new KhachHangDTO("TC20520210120 ", "Nguyen Van A", "Ha Noi", "TC205", new DateTime(2021, 1, 20), new DateTime(2021, 7, 23), 7000000),
                new KhachHangDTO("TC10420210113 ", "Nguyen Van B", "Ha Noi", "TC104", new DateTime(2021, 1, 13), new DateTime(2021, 5, 12), 10000000),
                new KhachHangDTO("TC30420210201 ", "Nguyen Van C", "Ha Noi", "TC304", new DateTime(2021, 2, 1), new DateTime(2021, 5, 30), 11000000),
                new KhachHangDTO("TC30520210202 ", "Nguyen Van D", "Ha Noi", "TC305", new DateTime(2021, 2, 2), new DateTime(2021, 5, 16), 7000000),

            };
        }
    }
}
