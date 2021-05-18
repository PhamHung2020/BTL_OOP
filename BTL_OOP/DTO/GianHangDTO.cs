// Đồng Duy Tiến - 20194381
namespace DTO
{
    /// <summary>
    /// Class trừu tượng mô tả 1 gian hàng nói chung
    /// </summary>
    public abstract class GianHangDTO
    {
        private string _maGianHang;
        /// <summary>
        /// Mã định danh cho mỗi gian hàng, không rỗng và có độ dài không nhỏ hơn 5.
        /// </summary>
        public string MaGianHang
        {
            get => _maGianHang;
            set { if (!string.IsNullOrEmpty(value) && value.Length <= 5) _maGianHang = value; }
        }


        private double _dienTich = 5.0;
        /// <summary>
        /// Diện tích của gian hàng, tính theo đơn vị m2.
        /// Mặc định và nhỏ nhất là 5.0 m2.
        /// </summary>
        public double DienTich
        {
            get => _dienTich;
            set { if (value >= 5.0) _dienTich = value; }
        }


        private string _viTriGianHang;
        /// <summary>
        /// Vị trí của gian hàng trong khu trưng bày.
        /// Quy cách : tầng + vị trí tại tầng đó.
        /// Ví dụ : tầng 1, vị trí số 1 thì vị trí là 101
        /// </summary>
        public string ViTriGianHang
        {
            get => _viTriGianHang;
            set { if (!string.IsNullOrEmpty(value)) _viTriGianHang = value; }
        }


        private bool _tinhTrangThue = false;
        /// <summary>
        /// Tình trạng thuê/không được thuê của gian hàng.
        /// Thuê = true, không được thuê = false.
        /// </summary>
        public bool TinhTrangThue
        {
            get => _tinhTrangThue;
            set { _tinhTrangThue = value; }
        }



        /// <summary>
        /// Phương thức khởi tạo của class
        /// </summary>
        /// <param name="maGianHang">Mã gian hàng</param>
        /// <param name="dienTich">Diện tích gian hàng</param>
        /// <param name="viTriGianHang">Vị trí gian hàng</param>
        /// <param name="tinhTrangThue">Tình trạng thuê của gian hàng</param>
        public GianHangDTO(string maGianHang, double dienTich, string viTriGianHang, bool tinhTrangThue)
        {
            MaGianHang = maGianHang;
            DienTich = dienTich;
            ViTriGianHang = viTriGianHang;
            TinhTrangThue = tinhTrangThue;
        }


        /// <summary>
        /// Phương thức trừu tượng tính chi phí thuê gian hàng theo số ngày thuê
        /// </summary>
        /// <param name="soNgayThue">Số ngày thuê gian hàng</param>
        /// <returns>Chi phí thuê gian hàng</returns>
        public abstract decimal TinhChiPhi(int soNgayThue);
    }
}

