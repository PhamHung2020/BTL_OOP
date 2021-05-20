// Phạm Mạnh Hùng - 20194293
using System;
using DTO;

namespace BUS
{
    /// <summary>
    /// Class hỗ trợ việc sinh mã gian hàng và mã khách hàng cho chương trình
    /// </summary>
    public static class HelperBUS
    {
        /// <summary>
        /// Phương thức sinh mã gian hàng
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="viTriGianHang"></param>
        /// <returns>Mã gian hàng được sinh</returns>
        public static string GenerateMaGianHang<T>(string viTriGianHang) where T : GianHangDTO
        {
            // Lấy kiểu dữ liệu của T và lưu vào biến kiểu Type
            Type type = typeof(T);
            // So sánh kiểu để sinh ra mã gian hàng phù hợp
            if (type == typeof(GianHangTieuChuanDTO))
            {
                return "TC" + viTriGianHang;
            }
            else if (type == typeof(GianHangCaoCapDTO))
            {
                return "CC" + viTriGianHang;
            }
            return null;
        }

        /// <summary>
        /// Phương thức sinh mã khách hàng
        /// </summary>
        /// <param name="maGianHang"></param>
        /// <param name="thoiDiemBatDau"></param>
        /// <returns>Mã khách hàng</returns>
        public static string GenerateMaKhachHang(string maGianHang, DateTime thoiDiemBatDau)
        {
            // mã khách hàng là mã gian hàng + thời gian bắt đầu thuê (tính đến ngày, không tính đến giờ)
            // do mỗi gian hàng sẽ chỉ được thuê bởi duy nhất 1 khách hàng tại 1 thời điểm
            // nên mã khách hàng sẽ là duy nhất
            return maGianHang + thoiDiemBatDau.Year + thoiDiemBatDau.Month + thoiDiemBatDau.Day;
        }
    }
}
