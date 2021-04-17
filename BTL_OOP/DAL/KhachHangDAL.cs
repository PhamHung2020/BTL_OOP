using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataServices;

namespace DAL
{
    public class KhachHangDAL
    {
        private readonly KhachHangDataAccess _context;

        public KhachHangDAL(KhachHangDataAccess context)
        {
            _context = context;
            _context.Load();
        }


    }
}
