// Đồng Duy Tiến - 20194381
namespace DTO
{
    /// <summary>
    /// Class mô tả 1 gian hàng cao cấp, kế thừa từ class GianHangDTO
    /// </summary>
    public class GianHangCaoCapDTO : GianHangDTO
    {
        private int _soQuatLamMat = 0;
        /// <summary>
        /// Số quạt làm mát của gian hàng, >= 0
        /// </summary>
        public int SoQuatLamMat
        {
            get => _soQuatLamMat;
            set { if (value >= 0) _soQuatLamMat = value; }
        }


        private int _soBanGhe = 0;
        /// <summary>
        /// Số bộ bàn ghế của gian hàng, >= 0
        /// </summary>
        public int SoBanGhe
        {
            get => _soBanGhe;
            set { if (value >= 0) _soBanGhe = value; }
        }



        /// <summary>
        /// Phương thức khởi tạo của class
        /// </summary>
        /// <param name="maGianHang">Mã gian hàng</param>
        /// <param name="dienTich">Diện tích gian hàng</param>
        /// <param name="viTriGianHang">Vị trí gian hàng</param>
        /// <param name="tinhTrangThue">Tình trạng thuê của gian hàng</param>
        /// <param name="soQuatLamMat">Số quạt làm mát của gian hàng</param>
        /// <param name="soBanGhe">Số bộ bàn ghế của gian hàng</param>
        public GianHangCaoCapDTO(string maGianHang,
                                 double dienTich,
                                 string viTriGianHang,
                                 bool tinhTrangThue,
                                 int soQuatLamMat,
                                 int soBanGhe) : base(maGianHang, dienTich, viTriGianHang, tinhTrangThue)
        {
            SoQuatLamMat = soQuatLamMat;
            SoBanGhe = soBanGhe;
        }


        /// <summary>
        /// Phương thức tính chi phí thuê gian hàng theo số ngày thuê.
        /// Phương thức này thực thi phương thức trừu tượng TinhChiPhi của class GianHangDTO
        /// </summary>
        /// <param name="soNgayThue">Số ngày thuê gian hàng</param>
        /// <returns>Chi phí thuê gian hàng</returns>
        public override decimal TinhChiPhi(int soNgayThue)
        {
            return (decimal)(120000 * DienTich * soNgayThue + _soQuatLamMat * 50000);
        }
    }
}
