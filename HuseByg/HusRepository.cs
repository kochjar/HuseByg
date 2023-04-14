using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuseByg
{
    public class HusRepository
    {
        private List<Hus> huse = new List<Hus>();

        public void TilføjHus(string adresse)
        {
            Hus hus = new Hus(adresse);
            huse.Add(hus);
        }

        public List<Hus> HentAlleHuse()
        {
            return huse;
        }

       
    }
}

