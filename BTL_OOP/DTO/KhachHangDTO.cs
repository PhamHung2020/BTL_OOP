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
    }
}
