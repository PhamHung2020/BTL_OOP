using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GianHangDTO
    {
        private string _maGianHang;
        public string MaGianHang
        {
            get => _maGianHang;
            set { if (value != null && value.Length <= 5) _maGianHang = value; }
        }
        
        private double _dienTich = 5.0;
        public double DienTich
        {
            get => _dienTich;
            set { if (value >= 5.0) _dienTich = value; }
        }
        
        private string _viTriGianHang;
        public string ViTriGianHang
        {
            get => _viTriGianHang;
            set { if (value != null) _viTriGianHang = value; }
        }
        
        private bool _tinhTrangThue = false;
        public bool TinhTrangThue
        {
            get => _tinhTrangThue;
            set { _tinhTrangThue = value; }
        }
        public GianHangDTO(string _maGianHang, double _dienTich, string _viTriGianHang, bool _tinhTrangThue)
        {
            this._maGianHang = _maGianHang;
            this._dienTich = _dienTich;
            this._viTriGianHang = _viTriGianHang;
            this._tinhTrangThue = _tinhTrangThue;
        }
    }
}

