using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GianHangTieuChuanDTO : GianHangDTO
    {
        public GianHangTieuChuanDTO(string _maGianHang,
                                    double _dienTich,
                                    string _viTriGianHang,
                                    bool _tinhTrangThue,
                                    string _chatLieuVachNgan = "",
                                    string _chatLieuMaiChe = "") : base(_maGianHang, _dienTich, _viTriGianHang, _tinhTrangThue)
        {
            this._chatLieuMaiChe = _chatLieuMaiChe;
            this._chatLieuVachNgan = _chatLieuVachNgan;
        }

        private string _chatLieuVachNgan = "Unknown";
        public string ChatLieuVachNgan
        {
            get => _chatLieuVachNgan;
            set { if (value != null) _chatLieuVachNgan = value; }
        }
        private string _chatLieuMaiChe = "Unknown";
        public string ChatLieuMaiChe
        {
            get => _chatLieuMaiChe;
            set { if (value != null) _chatLieuMaiChe = value; }
        }
        public override decimal TinhChiPhi(int soNgayThue)
        {
            return (decimal)(100000 * DienTich * soNgayThue);
        }
    }
}
