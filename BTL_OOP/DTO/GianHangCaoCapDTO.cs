using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
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
}
