// Phạm Mạnh Hùng - 20194293
using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BUS
{
    /// <summary>
    /// Class cung cấp các chức năng và xử lý trung gian các vấn đề liên quan đến khách hàng
    /// </summary>
    public class KhachHangBUS
    {
        /// <summary>
        /// Thuộc tính tham chiếu đến 1 object kiểu KhachHangDAL, lưu trữ thông tin các khách hàng.
        /// Được gọi đến khi cần lấy dữ liệu
        /// </summary>
        private KhachHangDAL _context;


        // Singleton pattern
        private static KhachHangBUS _instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhachHangBUS();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Phương thức khởi tạo của class
        /// </summary>
        private KhachHangBUS()
        {
            _context = new KhachHangDAL();
        }


        /// <summary>
        /// Tìm kiếm các khách hàng theo mã của gian hàng mà các khách hàng đó thuê
        /// </summary>
        /// <param name="maGianHang">Mã của gian hàng được thuê</param>
        /// <returns>Danh sách các khách hàng thuê gian hàng có mã maGianHang. Nếu không có khách hàng nào, trả về null</returns>
        public List<KhachHangDTO> TimKiemTheoMaGianHang(string maGianHang)
        {
            // Sử dụng LinQ để truy vấn
            return _context.DsKhachHang.Where(khachHang => khachHang.MaGianHang == maGianHang).ToList();
        }


        /// <summary>
        /// Tìm kiếm khách hàng theo mã của gian hàng được thuê tại một thời điểm xác định (tại một thời điểm)
        /// </summary>
        /// <param name="maGianHang">Mã của gian hàng được thuê</param>
        /// <param name="time">Thời điểm thuê</param>
        /// <returns>Khách hàng thuê gian hàng có mã maGianHang tại thời điểm time. Nếu không có, trả về null</returns>
        public KhachHangDTO TimKiemTheoMaGianHang(string maGianHang, DateTime time)
        {
            // Sử dụng LinQ để truy vấn
            // Trả về ngay khi có khách hàng phù hợp, không cần duyệt hết danh sách khách hàng
            return _context.DsKhachHang.FirstOrDefault(khachHang => khachHang.MaGianHang == maGianHang &&
                                              khachHang.ThoiGianBatDauThue.Date <= time.Date &&
                                              time.Date <= khachHang.ThoiGianKetThucThue.Date);
        }


        /// <summary>
        /// Tìm kiếm khách hàng theo mã khách hàng 
        /// </summary>
        /// <param name="maKhachHang">Mã của khách hàng cần tìm</param>
        /// <returns>Khách hàng có mã tương ứng. Nếu không có, trả về null</returns>
        public KhachHangDTO TimKiemTheoMaKhachHang(string maKhachHang)
        {
            // Sử dụng LinQ để truy vấn
            // Trả về ngay khi có khách hàng phù hợp, không cần duyệt hết danh sách khách hàng
            return _context.DsKhachHang.FirstOrDefault(gianHang => gianHang.MaKhachHang == maKhachHang);
        }


        /// <summary>
        /// Lấy ra danh sách toàn bộ khách hàng
        /// </summary>
        /// <returns>Danh sách toàn bộ khách hàng</returns>
        public List<KhachHangDTO> LayDanhSachKhachHang()
        {
            return _context.DsKhachHang;
        }


        /// <summary>
        /// Thêm khách hàng mới vào hệ thống
        /// </summary>
        /// <param name="khachHangMoi">Object chứa thông tin về khách hàng mới</param>
        /// <returns>Nếu thêm thành công, trả về true. Ngược lại, trả về false hoặc trả ra Exception với thông báo lỗi cụ thể</returns>
        public bool ThemKhachHang(KhachHangDTO khachHangMoi)
        {
            // Kiểm tra xem gian hàng mà khách hàng mới cần thuê có đang được thuê
            // bởi khách hàng khác tại cùng thời điểm hay không
            foreach (var khachHang in _context.DsKhachHang)
            {
                if (khachHangMoi.MaGianHang == khachHang.MaGianHang &&
                   ((khachHangMoi.ThoiGianBatDauThue.Date <= khachHang.ThoiGianBatDauThue.Date &&
                    khachHangMoi.ThoiGianKetThucThue.Date >= khachHang.ThoiGianKetThucThue.Date) ||
                   (khachHangMoi.ThoiGianBatDauThue.Date >= khachHang.ThoiGianBatDauThue.Date &&
                    khachHangMoi.ThoiGianBatDauThue.Date <= khachHang.ThoiGianKetThucThue.Date) ||
                   (khachHangMoi.ThoiGianKetThucThue.Date >= khachHang.ThoiGianBatDauThue.Date &&
                    khachHangMoi.ThoiGianKetThucThue.Date <= khachHang.ThoiGianKetThucThue.Date)))
                {
                    throw new Exception($"Gian hàng {khachHangMoi.MaGianHang} đang được thuê");
                }
            }
            _context.DsKhachHang.Add(khachHangMoi);
            return true;
        }
    }
}
