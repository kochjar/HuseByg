using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuseByg
{
    public class Controller
    {
        public LejerRepository lejereRepo;
        public HusRepository huseRepo;
        public Oversigt oversigt;

        public Controller()
        {
            lejereRepo = new LejerRepository();
            huseRepo = new HusRepository();
            oversigt = new Oversigt();
        }

        public void VisOversigt()
        {
            oversigt.VisOversigt(lejereRepo, huseRepo);
        }
    }
}
