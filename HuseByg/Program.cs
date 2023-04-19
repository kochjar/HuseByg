using System.Text;
using HuseByg.controller;
using HuseByg.model;

namespace HuseByg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.OutputEncoding = Encoding.UTF8;

            Controller controller = new Controller();

            controller.TilføjHus("Søndergade 20, 8000 Aarhus", HusType.Lille, 60, 2);
            controller.TilføjLejer("Mike Oxlong", "1234567890", " mikeoxlong@gmail.com");
            controller.TilføjLejer("Wilma Diqfit", "2345678901", "wilma.diqfit@gmail.com");
            controller.TilføjLejemål(new DateTime(2019, 1, 1), new DateTime(2022, 1, 1), 15000, 1, 0, "H1", "L1", "L2");

            controller.TilføjHus("Østervej 11A, 6000 Kolding", HusType.Ende, 80, 3);
            controller.TilføjLejer("Heywood Jablowme", "1234567890", "heywood.jablowme@gmail.com");
            controller.TilføjLejemål(new DateTime(2019, 5, 1), new DateTime(2022, 1, 1), 25000, 0, 5, "H2", "L3");

            controller.TilføjHus("Østervej 11B, 6000 Kolding", HusType.Stor, 80, 3);
            controller.TilføjLejer("Hugh G. Rection", "1234567890", "hugh.g.rection@gmail.com");
            controller.TilføjLejer("Gabe Itch", "1234567890", "gabe.itch@gmail.com");
            controller.TilføjLejemål(new DateTime(2019, 1, 1), new DateTime(2022, 1, 1), 27000, 2, 0, "H3", "L4", "L5");

            controller.TilføjHus("Østervej 11C, 6000 Kolding", HusType.Stor, 85, 4);


            List<Hus> huse = controller.HentAlleHuse();
            List<Lejer> lejere = controller.HentAlleLejere();
            List<Lejemål> lejemåls = controller.HentAlleLejemål();

            foreach (Hus hus in huse)
            {
                Console.WriteLine($"{hus.HusId}: {hus.Adresse}");
                if (hus.Lejemål != null)
                {
                    Console.WriteLine($"  Indbetalt Depositum: {hus.Lejemål.IndbetaltDepositum}, Hund: {hus.Lejemål.AntalHunde}, Katte: {hus.Lejemål.AntalKatte}");
                    foreach (Lejer lejer in hus.Lejemål.Lejere)
                    {
                        Console.WriteLine($"  {lejer.LejerId}: {lejer.navn}, {lejer.mail}");
                    }

                }
                Console.WriteLine();
            }



            /*
            foreach (Lejemål lejemål in lejemåls)
            {
                foreach (Lejer lejer in lejemål.Lejere) 
                {
                    Console.WriteLine(lejer.navn);
                    Console.WriteLine(lejer.mail);
                }
            }
            */
        }
    }
}