using HuseByg;
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

        public void TilføjLejer(string navn, string cpr_nr, string tlf_nr, string mail, int husdyr, Hus hus)
        {
            Lejer lejer = new Lejer(navn, cpr_nr, tlf_nr, mail, husdyr, hus);
            lejere.Add(lejer);
        }

        public void TilføjLejemål(DateTime startdato, DateTime slutdato, string lejer_id)
        {
            foreach (Lejer lejer in lejere)
            {
                if(lejer.id == lejer_id)
                {
                    Lejemål lejemål = new Lejemål(startdato, slutdato);
                    lejer.lejemål = lejemål;
                }
            }
        }

        public List<Lejer> HentAlleLejere()
        {
            return lejere;
        }

        public List<Lejemål> HentAlleLejemål()
        {
            List<Lejemål> lejemål = new List<Lejemål>();
            foreach (Lejer lejer in lejere)
            {
                lejemål.Add(lejer.lejemål);
            }
            return lejemål;
        }

    }
}

