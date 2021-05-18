// Đồng Duy Tiến - 20194381
namespace DTO
{
    /// <summary>
    /// Class mô tả 1 gian hàng tiêu chuẩn, kế thừa từ class GianHangDTO
    /// </summary>
    public class GianHangTieuChuanDTO : GianHangDTO
    {
        private string _chatLieuVachNgan = "Unknown";
        /// <summary>
        /// Chất liệu vách ngăng của gian hàng, mặc định là "Unknown"
        /// </summary>
        public string ChatLieuVachNgan
        {
            get => _chatLieuVachNgan;
            set { if (!string.IsNullOrEmpty(value)) _chatLieuVachNgan = value; }
        }


        private string _chatLieuMaiChe = "Unknown";
        /// <summary>
        /// Chất liệu mái che của gian hàng, mặc định là "Unknown"
        /// </summary>
        public string ChatLieuMaiChe
        {
            get => _chatLieuMaiChe;
            set { if (!string.IsNullOrEmpty(value)) _chatLieuMaiChe = value; }
        }



        /// <summary>
        /// Phương thức khởi tạo của class
        /// </summary>
        /// <param name="maGianHang">Mã gian hàng</param>
        /// <param name="dienTich">Diện tích gian hàng</param>
        /// <param name="viTriGianHang">Vị trí gian hàng</param>
        /// <param name="tinhTrangThue">Tình trạng thuê của gian hàng</param>
        /// <param name="chatLieuVachNgan">Chất liệu vách ngăn của gian hàng</param>
        /// <param name="chatLieuMaiChe">Chất liệu mái che của gian hàng</param>
        public GianHangTieuChuanDTO(string maGianHang,
                                    double dienTich,
                                    string viTriGianHang,
                                    bool tinhTrangThue,
                                    string chatLieuVachNgan,
                                    string chatLieuMaiChe) : base(maGianHang, dienTich, viTriGianHang, tinhTrangThue)
        {
            ChatLieuMaiChe = chatLieuMaiChe;
            ChatLieuVachNgan = chatLieuVachNgan;
        }


        /// <summary>
        /// Phương thức tính chi phí thuê gian hàng theo số ngày thuê.
        /// Phương thức này thực thi phương thức trừu tượng TinhChiPhi của class GianHangDTO
        /// </summary>
        /// <param name="soNgayThue">Số ngày thuê gian hàng</param>
        /// <returns>Chi phí thuê gian hàng</returns>
        public override decimal TinhChiPhi(int soNgayThue)
        {
            return (decimal)(100000 * DienTich * soNgayThue);
        }
    }
}
