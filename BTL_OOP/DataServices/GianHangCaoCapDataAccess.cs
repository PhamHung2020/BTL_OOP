using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataServices
{
    public class GianHangCaoCapDataAccess
    {
        public List<GianHangCaoCapDTO> DsGianHangCaoCap { get; set; }

        public void Load()
        {
            DsGianHangCaoCap = new List<GianHangCaoCapDTO>()
            {
                new GianHangCaoCapDTO("00000", 5.2, "Tang 1 Khu A So 1", false),
                new GianHangCaoCapDTO("00001", 8.7, "Tang 1 Khu B So 2", false),
                new GianHangCaoCapDTO("00002", 10.5, "Tang 2 Khu C So 1", false),
            };
        }

        public void SaveChanges()
        {

        }

    }
}
