using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuseByg
{
    public class LejerRepository
    {
        public List<Lejer> lejere = new List<Lejer>();

        public void TilføjLejer(Lejer lejer)
        {
            lejere.Add(lejer);
        }

    }
}
