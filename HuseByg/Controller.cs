using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuseByg
{
    public class Controller
    {
        private LejerRepository lejereRepo;
        private HusRepository huseRepo;

        public Controller()
        {
            lejereRepo = new LejerRepository();
            huseRepo = new HusRepository();
        }

        public void TilføjLejer(string navn, string cpr_nr, string tlf_nr, string mail, int husdyr, string hus_id)
        {
            List<Hus> huse = huseRepo.HentAlleHuse();
            foreach (Hus hus in huse)
            {
                if(hus.id == hus_id)
                {
                    lejereRepo.TilføjLejer(navn, cpr_nr, tlf_nr, mail, husdyr, hus);
                }
            }
        }

        public void TilføjLejemål(DateTime startdato, DateTime slutdato, string lejer_id)
        {
            lejereRepo.TilføjLejemål(startdato, slutdato, lejer_id);
        }

        public void TilføjHus(string adresse)
        {
            huseRepo.TilføjHus(adresse);
        }

        public void VisOversigt()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0, -40}{1, -70}", "Hus", "Lejer");
            Console.ResetColor();
            Console.WriteLine("{0, -40}{1, -70}", "-----------------------------------", "--------------------------------------------------------------------");
            Console.WriteLine("{0, -5}{1, -35}{2, -5}{3, -15}{4, -10}{5, -10}{6, -15}{7, -15}", "Id", "Adresse", "Id", "Navn", "Tlf.", "Kæledyr", "Startdato", "Slutdato");
            Console.WriteLine("{0, -40}{1, -70}", "-----------------------------------", "--------------------------------------------------------------------");

            List<Hus> huse = huseRepo.HentAlleHuse();
            List<Lejer> lejere = lejereRepo.HentAlleLejere();

            foreach (Hus hus in huse)
            {
                Console.Write("{0, -5}{1, -35}", hus.id, hus.adresse);
                bool LejerFundet = false;
                foreach (Lejer lejer in lejere)
                {
                    if (lejer.hus == hus)
                    {
                        Console.Write("{2, -5}{3, -15}{4, -10}{5, -10}{6, -15}{7, -15}",
                        hus.id, 
                        hus.adresse, 
                        lejer.id, 
                        lejer.navn, 
                        lejer.tlf_nr, 
                        lejer.husdyr,
                        lejer.lejemål.startdato.ToString("dd-MM-yyyy"), 
                        lejer.lejemål.slutdato.ToString("dd-MM-yyyy"));

                        LejerFundet = true;
                    }
                }

                if (!LejerFundet){ Console.Write("Der er ikke tilknyttet nogen lejer til dette hus."); }

                Console.WriteLine();
            }
        }
    }
}
