using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuseByg
{
    public class HusRepository
    {
        public List<Hus> huse = new List<Hus>();

        public void TilføjHus(Hus hus)
        {
            huse.Add(hus);
        }
    }
}
