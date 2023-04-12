using System.Text;

namespace HuseByg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.OutputEncoding = Encoding.UTF8;

            Controller controller = new Controller();

            Hus hus1 = new Hus("Søndergade 30, 8000 Aarhus");
            Lejer lejer1 = new Lejer("Jens Hansen", 1234567890, "10203040", 1, hus1);
            Lejemål lejemål1 = new Lejemål(DateTime.Parse("01-01-2019"), DateTime.Parse("01-01-2023"));

            lejer1.TilføjLejemål(lejemål1);
            controller.huseRepo.TilføjHus(hus1);
            controller.lejereRepo.TilføjLejer(lejer1);

            Hus hus2 = new Hus("Vesterbro 25, 5000 Odense");
            Lejer lejer2 = new Lejer("Mette Nielsen", 0876543210, "40506070", 2, hus2);
            Lejemål lejemål2 = new Lejemål(DateTime.Parse("01-06-2020"), DateTime.Parse("01-06-2022"));
            lejer2.TilføjLejemål(lejemål2);
            controller.huseRepo.TilføjHus(hus2);
            controller.lejereRepo.TilføjLejer(lejer2);
            
            Hus hus3 = new Hus("Nørrebrogade 10, 2200 København N");
            Lejer lejer3 = new Lejer("Peter Jensen", 0543217890, "30405060", 3, hus3);
            Lejemål lejemål3 = new Lejemål(DateTime.Parse("01-02-2022"), DateTime.Parse("01-02-2024"));
            lejer3.TilføjLejemål(lejemål3);
            controller.huseRepo.TilføjHus(hus3);
            controller.lejereRepo.TilføjLejer(lejer3);

            Hus hus4 = new Hus("Algade 5, 6000 Kolding");
            Lejer lejer4 = new Lejer("Lise Pedersen", 1567890123, "50607080", 4, hus4);
            Lejemål lejemål4 = new Lejemål(DateTime.Parse("01-09-2021"), DateTime.Parse("01-09-2023"));
            lejer4.TilføjLejemål(lejemål4);
            controller.huseRepo.TilføjHus(hus4);
            controller.lejereRepo.TilføjLejer(lejer4);

            Hus hus5 = new Hus("Søgade 20, 1820 Frederiksberg C");
            Lejer lejer5 = new Lejer("Anders Nielsen", 0890123456, "60708090", 5, hus5);
            Lejemål lejemål5 = new Lejemål(DateTime.Parse("01-04-2022"), DateTime.Parse("01-04-2024"));
            lejer5.TilføjLejemål(lejemål5);
            controller.huseRepo.TilføjHus(hus5);
            controller.lejereRepo.TilføjLejer(lejer5);
            
            
            Hus hus6 = new Hus("Roskildevej 32, 4000 Roskilde");
            Hus hus7 = new Hus("Bredgade 19, 5000 Odense");

            controller.huseRepo.TilføjHus(hus6);
            controller.huseRepo.TilføjHus(hus7);




            controller.VisOversigt();

        }
    }
}