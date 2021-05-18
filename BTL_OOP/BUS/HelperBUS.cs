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
            Type type = typeof(T);
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
            return maGianHang + thoiDiemBatDau.Year + thoiDiemBatDau.Month + thoiDiemBatDau.Day;
        }
    }
}
