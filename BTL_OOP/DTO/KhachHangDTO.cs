using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string _ten = "Unknown";
        public string Ten
        {
            get => _ten;
            set { if (value != null) _ten = value; }
        }
        
        private string _diaChi = "Unknown";
        public string DiaChi
        {
            get => _diaChi;
            set { if (value != null) _diaChi = value; }
        }
        
        private string _maGianHang;
        public string MaGianHang
        {
            get => _maGianHang;
            set { if (value != null && value.Length <= 5) _maGianHang = value; }
        }

        private DateTime _thoiGianBatDauThue =  new DateTime(2010, 1, 1);
        public DateTime ThoiGianBatDauThue
        {
            get => _thoiGianBatDauThue;
            set { if (value.Year >= 2010) _thoiGianBatDauThue = value; }
        }

        private DateTime _thoiGianKetThucThue = new DateTime(2010, 1, 1);
        public DateTime ThoiGianKetThucThue
        {
            get => _thoiGianKetThucThue;
            set { if (value.Year >= 2010) _thoiGianKetThucThue = value; }
        }

        private decimal _tienDatCoc;
        public decimal TienDatCoc
        {
            get => _tienDatCoc;
            set { if (value >= 0) _tienDatCoc = value; }
        }

    }
}
