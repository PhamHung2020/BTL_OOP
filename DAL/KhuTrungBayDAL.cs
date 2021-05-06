using System.Collections.Generic;

namespace DAL
{
    public class KhuTrungBayDAL
    {
        private Dictionary<int, int> _soViTriMoiTang = new Dictionary<int, int>()
        {
            {1, 7},
            {2, 7},
            {3, 8},
            {4, 8}
        };

        public Dictionary<int, int> SoViTriMoiTang
        {
            get => _soViTriMoiTang;
        }
    }
}
