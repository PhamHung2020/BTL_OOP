using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GianHangTieuChuan : GianHangDTO
    {
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
    }
}
