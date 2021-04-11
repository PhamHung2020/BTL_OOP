using System;

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
    }
    public class GianHangCaoCapDTO : GianHangDTO
    {
        private int _soQuatLamMat = 0;
        public int SoQuatLamMat
        {
            get => _soQuatLamMat;
            set { if (value >= 0) _soQuatLamMat = value; }
        }
        private int _soBanGhe = 0;
        public int SoBanGhe
        {
            get => _soBanGhe;
            set { if (value >= 0) _soBanGhe = value; }
        }
    }
    public class GianHangTieuChuan : GianHangDTO
    {
        private string _chatLieuVachNgan = "Unknown";
        public string ChatLieuVachNgan
        {
            get => _chatLieuVachNgan;
            set { if (value != null) _chatLieuVachNgan = value;  }
        }
        private string _chatLieuMaiChe = "Unknown";
        public string ChatLieuMaiChe
        {
            get => _chatLieuMaiChe;
            set { if (value != null) _chatLieuMaiChe = value; }
        }
    }
    public class KhachThueDTO
    {
        private string _ten = "Unknown";
        public string Ten
        {
            get => _ten;
            set {if (value != null) _ten = value; }
        }

    }
}
