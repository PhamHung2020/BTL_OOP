using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GianHangCaoCapDTO : GianHangDTO
    {
        public GianHangCaoCapDTO(string _maGianHang,
                                 double _dienTich,
                                 string _viTriGianHang,
                                 bool _tinhTrangThue,
                                 int _soQuatLamMat = 0,
                                 int _soBanGhe = 0) : base(_maGianHang, _dienTich, _viTriGianHang, _tinhTrangThue) 
        {
            this._soQuatLamMat = _soQuatLamMat;
            this._soBanGhe = _soBanGhe;
        }

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
        public override decimal TinhChiPhi(int soNgayThue)
        {
            return (decimal)(120000 * DienTich * soNgayThue + _soQuatLamMat * 50000);
        }
    }
}
