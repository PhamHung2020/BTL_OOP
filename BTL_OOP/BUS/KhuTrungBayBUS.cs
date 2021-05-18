// Phạm Mạnh Hùng - 20194293
using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    /// <summary>
    /// Class cung cấp các chức năng và xử lý trung gian các vấn đề về khu trưng bày, về cả khách hàng lẫn gian hàng
    /// như : Tính doanh thu, Thuê gian hàng bởi 1 khách hàng, ...
    /// </summary>
    public class KhuTrungBayBUS
    {
        // Singleton pattern
        private static KhuTrungBayBUS _instance;
        public static KhuTrungBayBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhuTrungBayBUS();
                }
                return _instance;
            }
        }
        

        /// <summary>
        /// Thuê 1 gian hàng
        /// </summary>
        /// <param name="khachHangMoi">Khách hàng sẽ thuê</param>
        /// <returns>Nếu thuê thành công, trả về true. Ngược lại, trả về false hoặc trả ra Exception với thông báo lỗi cụ thể</returns>
        public bool Thue(KhachHangDTO khachHangMoi)
        {
            bool isSuccess = true;
            try
            {
                // Nếu thời điểm thuê gian hàng là hiện tại (không phải trong quá khứ hay tương lai),
                // thì sẽ thay đổi tình trạng thuê của gian hàng này
                if (khachHangMoi.ThoiGianBatDauThue.Date <= DateTime.Now.Date &&
                     DateTime.Now.Date <= khachHangMoi.ThoiGianKetThucThue.Date)
                    GianHangBUS.Instance.ThayDoiTinhTrangThue(khachHangMoi.MaGianHang, true);
                // Thêm khách hàng mới vào hệ thống
                isSuccess = KhachHangBUS.Instance.ThemKhachHang(khachHangMoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isSuccess;
        }


        /// <summary>
        /// Tính doanh thu của khu trưng bày theo một khoảng thời gian truyền vào
        /// </summary>
        /// <param name="thoiGianBatDau">Thời điểm bắt đầu tính doanh thu</param>
        /// <param name="thoiGianKetThuc">Thời điểm kết thúc tính doanh thu</param>
        /// <returns>Doanh thu của khu trưng bày theo khoảng thời gian nhập vào</returns>
        public decimal DoanhThu(DateTime thoiGianBatDau, DateTime thoiGianKetThuc)
        {
            decimal doanhThu = 0;
            var dsKhachHang = KhachHangBUS.Instance.LayDanhSachKhachHang();
            foreach (var khachHang in dsKhachHang)
            {
                // Tính thời gian thuê của một khách hàng nếu thời điểm thuê của khách hàng đó
                // nằm trong khoảng thời gian nhập vào
                var time = new TimeSpan(-1, 0, 0, 0);
                if (thoiGianBatDau.Date <= khachHang.ThoiGianBatDauThue.Date &&
                    khachHang.ThoiGianKetThucThue.Date <= thoiGianKetThuc.Date)
                {
                    time = khachHang.ThoiGianKetThucThue - khachHang.ThoiGianBatDauThue;
                }
                else if (khachHang.ThoiGianBatDauThue.Date < thoiGianBatDau.Date &&
                         khachHang.ThoiGianKetThucThue.Date < thoiGianKetThuc.Date &&
                         thoiGianBatDau.Date <= khachHang.ThoiGianKetThucThue.Date)
                {
                    time = khachHang.ThoiGianKetThucThue - thoiGianBatDau;
                }
                else if (thoiGianBatDau.Date < khachHang.ThoiGianBatDauThue.Date &&
                         thoiGianKetThuc.Date < khachHang.ThoiGianKetThucThue.Date &&
                         khachHang.ThoiGianBatDauThue.Date <= thoiGianKetThuc.Date)
                {
                    time = thoiGianKetThuc - khachHang.ThoiGianBatDauThue;
                }
                doanhThu += GianHangBUS.Instance.TimKiemTheoMaGianHang(khachHang.MaGianHang)[0].TinhChiPhi((int)time.TotalDays + 1);
            }
            return doanhThu;
        }


        /// <summary>
        /// Tính doanh thu của khu trưng bày trong 1 tháng của 1 năm nhất định.
        /// Nếu năm = 0 hoặc không truyền vào, thì lấy năm hiện tại
        /// </summary>
        /// <param name="thang">Tháng cần tính doanh thu</param>
        /// <param name="year">Năm cần tính doanh thu. Nếu năm = 0, lấy năm hiện tại</param>
        /// <returns>Doanh thu của khu trưng bày trong tháng và năm truyền vào</returns>
        public decimal DoanhThu(int thang, int year = 0)
        {
            // Kiểm tra tính hợp lệ của tham số
            if (thang < 1 || thang > 12)
                throw new Exception("Tháng phải nằm trong khoảng 1 - 12");
            if (year == 0)
                year = DateTime.Now.Year;
            else if (year < 0)
                throw new Exception("Năm phải lớn hơn 0");

            // Chuyển thời gian sang kiểu DateTime và gọi đến hàm DoanhThu(DateTime, DateTime)
            DateTime thoiGianBatDau = new DateTime(year, thang, 1);
            int ngayCuoiThang = DateTime.DaysInMonth(year, thang);
            DateTime thoiGianKetThuc = new DateTime(year, thang, ngayCuoiThang);
            return DoanhThu(thoiGianBatDau, thoiGianKetThuc);
        }


        /// <summary>
        /// Kiểm tra tình trạng thuê của toàn bộ gian hàng trong khu trưng bày.
        /// Nếu thời điểm thuê đã qua hoặc đã đến thì cần thay đổi tình trạng thuê
        /// của gian hàng tương ứng 1 cách phù hợp.
        /// Thường được gọi đến khi chương trình bắt đầu chạy
        /// </summary>
        public void KiemTraTinhTrangThue()
        {
            List<GianHangDTO> dsGianHangThue = GianHangBUS.Instance.LayDanhSachGianHang<GianHangDTO>();
            // Chuyển cấu trúc dữ liệu từ List sang Dictionary để tra cứu gian hàng nhanh hơn
            Dictionary<string, GianHangDTO> dsThue = new Dictionary<string, GianHangDTO>();
            foreach (GianHangDTO gianHang in dsGianHangThue)
            {
                dsThue.Add(gianHang.MaGianHang, gianHang);
            }

            List<KhachHangDTO> dsKhachHang = KhachHangBUS.Instance.LayDanhSachKhachHang();
            foreach (KhachHangDTO khachHang in dsKhachHang)
            {
                // Nếu gian hàng này có tình trạng thuê là true (đang thuê) và thời điểm thuê
                // của khách hàng đã qua thì chuyển tình trạng thuê về false (không thuê)
                if (dsThue[khachHang.MaGianHang].TinhTrangThue &&
                    khachHang.ThoiGianKetThucThue.Date < DateTime.Now.Date)
                {
                    dsThue[khachHang.MaGianHang].TinhTrangThue = false;
                }
                // Nếu gian hàng này có tình trạng thuê là false (không thuê) và 
                // thời điểm thuê của khách hàng này đã tới thì chuyển trình trạng thuê
                // thành true (đang thuê)
                else if (!dsThue[khachHang.MaGianHang].TinhTrangThue &&
                         khachHang.ThoiGianBatDauThue.Date <= DateTime.Now.Date)
                {
                    dsThue[khachHang.MaGianHang].TinhTrangThue = true;
                }
            }
        }
    }
}
