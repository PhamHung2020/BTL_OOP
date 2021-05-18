// Phạm Mạnh Hùng - 20194293
using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BUS
{
    /// <summary>
    /// Class cung cấp các chức năng và xử lý trung gian các vấn đề liên quan đến gian hàng
    /// </summary>
    public class GianHangBUS
    {
        /// <summary>
        /// Thuộc tính tham chiếu đến 1 object kiểu GianHangDAL, lưu thông tin về toàn bộ gian hàng trong khu trưng bày.
        /// Được gọi đến khi cần lấy dữ liệu
        /// </summary>
        private GianHangDAL _context;


        // Singleton pattern
        private static GianHangBUS _instance;
        public static GianHangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GianHangBUS();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Phương thức khởi tạo của class
        /// </summary>
        private GianHangBUS()
        {
            _context = new GianHangDAL();
            _context.Load();
        }



        /// <summary>
        /// Tìm kiếm các gian hàng (cả tiêu chuẩn và cao cấp) mà trong mã gian hàng
        /// có chứa xâu được truyền vào
        /// </summary>
        /// <param name="maGianHang">Mã gian hàng (toàn bộ hoặc 1 phần) của các gian hàng cần tìm kiếm</param>
        /// <returns>Danh sách gian hàng có mã gian hàng chứa xâu được truyền vào</returns>
        public List<GianHangDTO> TimKiemTheoMaGianHang(string maGianHang)
        {
            // Sử dụng LinQ để truy vấn
            return _context.DsGianHang.Where(gianHang => gianHang.MaGianHang.Contains(maGianHang)).ToList();
        }


        /// <summary>
        /// Tìm kiếm các gian hàng loại T mà trong mã gian hàng có chứa xâu được truyền vào
        /// </summary>
        /// <typeparam name="T">Loại gian hàng</typeparam>
        /// <param name="maGianHang">Mã gian hàng (toàn bộ hoặc 1 phần) của các gian hàng cần tìm kiếm</param>
        /// <returns>Danh sách gian hàng loại T có mã gian hàng chứa xâu được truyền vào</returns>
        public List<T> TimKiemTheoMaGianHang<T>(string maGianHang) where T : GianHangDTO
        {
            List<T> list = new List<T>();
            // Lọc các gian hàng loại T có chứa maGianHang trong mã gian hàng
            foreach (GianHangDTO gianHang in _context.DsGianHang)
            {
                if (gianHang is T && gianHang.MaGianHang.Contains(maGianHang))
                    list.Add(gianHang as T);
            }
            return list;
        }


        /// <summary>
        /// Lấy danh sách toàn bộ gian hàng loại T
        /// </summary>
        /// <typeparam name="T">Loại gian hàng</typeparam>
        /// <returns>Danh sách các gian hàng loại T</returns>
        public List<T> LayDanhSachGianHang<T>() where T : GianHangDTO
        {
            // Gọi phương thức của DAL
            return _context.LayDanhSachGianHang<T>();
        }


        /// <summary>
        /// Thêm gian hàng mới vào hệ thống
        /// </summary>
        /// <param name="gianHangMoi">Object chứa thông tin về gian hàng mới</param>
        /// <returns>Nếu thêm thành công, trả về true. Ngược lại, trả về false hoặc trả ra Exception có chứa thông báo lỗi cụ thể</returns>
        public bool ThemGianHang(GianHangDTO gianHangMoi)
        {
            // Tìm kiếm trong hệ thống xem có gian hàng nào trùng vị trí với gian hàng mới không
            // Nếu có thì trả ra Exception
            foreach (var gianHang in _context.DsGianHang)
            {
                if (gianHang.ViTriGianHang == gianHangMoi.ViTriGianHang)
                {
                    throw new Exception($"Gian hàng mới có vị trí trùng\nvới gian hàng có mã {gianHang.MaGianHang}");
                }
            }

            _context.DsGianHang.Add(gianHangMoi);
            return true;
        }


        /// <summary>
        /// Cập nhật thông tin về một gian hàng đã có trong hệ thống
        /// </summary>
        /// <param name="gianHangCapNhat">Object chứa thông tin đã cập nhật của gian hàng cần sửa</param>
        /// <returns>Nếu cập nhật thành công, trả về true. Ngược lại, trả về false hoặc trả ra Exception có chứa thông báo lỗi cụ thể</returns>
        /// <exception cref="System.Exception">
        /// Gian hàng cần cập nhật không tồn tại hoặc đang được thuê
        /// </exception>
        public bool CapNhatGianHang(GianHangDTO gianHangCapNhat)
        {
            // Kiểm tra xem gian hàng cần sửa có thực sự tồn tại trong hệ thống hoặc đang được thuê không
            var gianHang = TimKiemTheoMaGianHang<GianHangDTO>(gianHangCapNhat.MaGianHang)[0];
            if (gianHang == null)
            {
                throw new Exception("Gian hàng không tồn tại");
            }
            else if (gianHang.TinhTrangThue)
            {
                throw new Exception("Gian hàng đang được thuê. Cập nhật không thành công");
            }

            int index = _context.DsGianHang.IndexOf(gianHang);
            _context.DsGianHang[index] = gianHangCapNhat;
            return true;
        }


        /// <summary>
        /// Xóa 1 gian hàng đã có trong hệ thống
        /// </summary>
        /// <param name="maGianHang">Mã gian hàng của gian hàng cần xóa</param>
        /// <returns>Nếu xóa thành công, trả về true. Ngược lại, trả về false hoặc trả ra Exception có chứa thông báo lỗi cụ thể</returns>
        public bool XoaGianHang(string maGianHang)
        {
            // Kiểm tra xem gian hàng cần xóa có thực sự tồn tại trong hệ thống hoặc đang được thuê không
            var gianHang = TimKiemTheoMaGianHang(maGianHang)[0];
            if (gianHang == null)
            {
                throw new Exception("Gian hàng không tồn tại");
            }
            else if (gianHang.TinhTrangThue)
            {
                throw new Exception("Gian hàng đang được thuê.\nXóa không thành công");
            }
            _context.DsGianHang.Remove(gianHang);
            return true;
        }


        /// <summary>
        /// Lấy ra danh sách gian hàng tại một tầng nhất định
        /// </summary>
        /// <param name="tang">Tầng cần lấy ra danh sách gian hàng</param>
        /// <returns>Danh sách các gian hàng thuộc tầng được truyền vào</returns>
        public List<GianHangDTO> DanhSachGianHangTheoSoTang(int tang)
        {
            if (tang <= 0)
                return null;
            List<GianHangDTO> list = new List<GianHangDTO>();
            foreach (GianHangDTO gianHang in _context.DsGianHang)
            {
                // Kí tự thứ 3 trong mã gian hàng thể hiện gian hàng đó ở tầng số mấy
                // Vì là kiểu char nên phải trừ đi '0' để lấy ra chỉ số tầng
                if (gianHang.MaGianHang[2] - '0' == tang)
                {
                    list.Add(gianHang);
                }
            }
            return list;
        }


        /// <summary>
        /// Lấy ra danh sách gian hàng theo tình trạng thuê được truyền vào(thuê/không được thuê)
        /// </summary>
        /// <param name="tinhTrangThue">Tình trạng thuê. Thuê = true, Không thuê = false</param>
        /// <returns>Danh sách gian hàng có tình trạng thuê thỏa mãn tham số truyền vào</returns>
        public List<GianHangDTO> DanhSachGianHangTheoTinhTrangThue(bool tinhTrangThue)
        {
            // Sử dụng LinQ để truy vấn
            return _context.DsGianHang.Where(gianHang => gianHang.TinhTrangThue == tinhTrangThue).ToList();
        }


        /// <summary>
        /// Thay đổi tình trạng thuê của một gian hàng nhất định
        /// </summary>
        /// <param name="maGianHang">Mã gian hàng của gian hàng cần thay đổi tình trạng thuê</param>
        /// <param name="tinhTrangThue">Tình trạng thuê cần cập nhật</param>
        public void ThayDoiTinhTrangThue(string maGianHang, bool tinhTrangThue)
        {
            // Kiếm tra xem gian hàng cần cập nhật tình trạng thuê có tồn tại trong hệ thống hoặc đang được thuê hay không.
            GianHangDTO gianHang = TimKiemTheoMaGianHang(maGianHang)[0];
            if (gianHang == null)
            {
                throw new Exception("Gian hàng không tồn tại");
            }
            else if (tinhTrangThue && gianHang.TinhTrangThue)
            {
                throw new Exception("Gian hàng này hiện tại đang được thuê bởi 1 khách hàng khác. Thay đổi không thành công");
            }
            gianHang.TinhTrangThue = tinhTrangThue;
        }
    }
}
