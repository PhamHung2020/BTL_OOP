// Đồng Duy Tiến - 20194381
using System;

namespace DTO
{
    /// <summary>
    /// Class mô tả 1 khách hàng thuê gian hàng
    /// </summary>
    public class KhachHangDTO
    {
        private string _maKhachHang;
        /// <summary>
        /// Mã định danh cho mỗi khách hàng thuê gian hàng tại một khoảng thời gian nhất định.
        /// Mã khách hàng không được rỗng
        /// </summary>
        public string MaKhachHang
        {
            get => _maKhachHang;
            set { if (!string.IsNullOrEmpty(value)) _maKhachHang = value; }
        }


        private string _ten = "Unknown";
        /// <summary>
        /// Tên khách hàng, không rỗng, mặc định là "Unknown"
        /// </summary>
        public string Ten
        {
            get => _ten;
            set { if (!string.IsNullOrEmpty(value)) _ten = value; }
        }


        private string _diaChi = "Unknown";
        /// <summary>
        /// Địa chỉ của khách hàng, không rỗng, mặc định là "Unknown"
        /// </summary>
        public string DiaChi
        {
            get => _diaChi;
            set { if (!string.IsNullOrEmpty(value)) _diaChi = value; }
        }


        private string _maGianHang;
        /// <summary>
        /// Mã gian hàng mà khách hàng này thuê.
        /// </summary>
        public string MaGianHang
        {
            get => _maGianHang;
            set { if (!string.IsNullOrEmpty(value) && value.Length <= 5) _maGianHang = value; }
        }


        private DateTime _thoiGianBatDauThue = new DateTime(2010, 1, 1);
        /// <summary>
        /// Thời gian bắt đầu thuê, tính theo ngày (không tính theo giờ).
        /// Mặc định và muộn nhất là 1/1/2010
        /// </summary>
        public DateTime ThoiGianBatDauThue
        {
            get => _thoiGianBatDauThue;
            set { if (value.Year >= 2010) _thoiGianBatDauThue = value; }
        }


        private DateTime _thoiGianKetThucThue = new DateTime(2010, 1, 1);
        /// <summary>
        /// Thời gian kết thúc thuê, tính theo ngày (không tính theo giờ).
        /// Mặc định và muộn nhất là trùng với thời gian bắt đầu thuê
        /// </summary>
        public DateTime ThoiGianKetThucThue
        {
            get => _thoiGianKetThucThue;
            set { if (value.Year >= 2010 && value > _thoiGianBatDauThue) _thoiGianKetThucThue = value; }
        }


        private decimal _tienDatCoc;
        /// <summary>
        /// Tiền đặt cọc của khách hàng
        /// </summary>
        public decimal TienDatCoc
        {
            get => _tienDatCoc;
            set { if (value >= 0) _tienDatCoc = value; }
        }


        /// <summary>
        /// Phương thức khởi tạo của class
        /// </summary>
        /// <param name="_maKhachHang">Mã khách hàng</param>
        /// <param name="_ten">Tên khách hàng</param>
        /// <param name="_diaChi">Địa chỉ khách hàng</param>
        /// <param name="_maGianHang">Mã gian hàng được thuê</param>
        /// <param name="_thoiGianBatDauThue">Thời gian bắt đầu thuê</param>
        /// <param name="_thoiGianKetThucThue">Thời gian kết thúc thuê</param>
        /// <param name="_tienDatCoc">Tiền đặt cọc</param>
        public KhachHangDTO(string maKhachHang,
                            string ten,
                            string diaChi,
                            string maGianHang,
                            DateTime thoiGianBatDauThue,
                            DateTime thoiGianKetThucThue,
                            decimal tienDatCoc)
        {
            MaKhachHang = maKhachHang;
            Ten = ten;
            DiaChi = diaChi;
            MaGianHang = maGianHang;
            ThoiGianBatDauThue = thoiGianBatDauThue;
            ThoiGianKetThucThue = thoiGianKetThucThue;
            TienDatCoc = tienDatCoc;
        }
    }
}
