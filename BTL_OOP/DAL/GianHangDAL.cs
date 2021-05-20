// Phạm Mạnh Hùng - 20194293
using System.Collections.Generic;
using DTO;

namespace DAL
{
    /// <summary>
    /// Class khởi tạo và lưu trữ dữ liệu về gian hàng
    /// </summary>
    public class GianHangDAL
    {
        private List<GianHangDTO> _dsGianHang;
        /// <summary>
        /// Danh sách toàn bộ các gian hàng trong khu trưng bày
        /// </summary>
        public List<GianHangDTO> DsGianHang
        {
            get
            {
                if (_dsGianHang == null)
                {
                    _Load();
                }
                return _dsGianHang;
            }
        }


        /// <summary>
        /// Khởi tạo dữ liệu ban đầu cho chương trình, tránh việc khi chạy chương trình thì phải nhập lại dữ liệu từ đầu.
        /// </summary>
        private void _Load()
        {
            _dsGianHang = new List<GianHangDTO>()
            {
                new GianHangCaoCapDTO("CC102", 5.6, "102", false, 5, 6),
                new GianHangCaoCapDTO("CC203", 10.25, "203", false, 10, 12),
                new GianHangTieuChuanDTO("TC101", 5.6, "101", true, "Ton", "Nhua"),
                new GianHangTieuChuanDTO("TC202", 10.25, "202", false, "Sat", "Dong"),
                new GianHangTieuChuanDTO("TC205", 13.6, "205", true, "Sat", "Vai"),
                new GianHangTieuChuanDTO("TC104", 10.54, "104", true, "Nhua", "Dong"),
                new GianHangTieuChuanDTO("TC304", 7.8, "304", true, "Khong biet", "Cao su"),
                new GianHangTieuChuanDTO("TC305", 12.4, "305", true, "Vat lieu nano", "Khong biet"),
                new GianHangTieuChuanDTO("TC406", 8.87, "406", false, "Ton", "Thep"),
                new GianHangCaoCapDTO("CC103", 16.4, "103", false, 5, 6),
                new GianHangCaoCapDTO("CC201", 17.5, "201", false, 6, 8),
                new GianHangCaoCapDTO("CC204", 17.2, "204", false, 5, 5),
                new GianHangCaoCapDTO("CC301", 18.7, "301", false, 7, 8),
                new GianHangCaoCapDTO("CC302", 19, "302", false, 8, 8),
            };
        }


        /// <summary>
        /// Trả về danh sách gian hàng theo kiểu được truyền vào.
        /// Nếu T là GianHangDTO, toàn bộ danh sách được trả về.
        /// Nếu T là GianHangTieuChuanDTO, danh sách các gian hàng tiêu chuẩn được trả về.
        /// Tương tự với GianHangCaoCapDTO
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Danh sách gian hàng loại T</returns>
        public List<T> LayDanhSachGianHang<T>() where T : GianHangDTO
        {
            // Dùng toán tử typeof để kiểm tra kiểu dữ liệu
            // Nếu T là GianHangDTO, trả về toàn bộ danh sách
            if (typeof(T) == typeof(GianHangDTO))
            {
                return DsGianHang as List<T>;
            }

            // Danh sách sẽ được trả về
            List<T> list = new List<T>();
            // Duyệt qua các gian hàng trong danh sách gian hàng
            foreach (GianHangDTO gianHang in DsGianHang)
            {
                // Lọc các gian hàng kiểu T trong DsGianHang
                if (gianHang is T)
                {
                    list.Add(gianHang as T);
                }
            }
            return list;
        }
    }
}
