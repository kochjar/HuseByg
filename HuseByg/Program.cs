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

            controller.TilføjHus("Søndergade 30, 8000 Aarhus");
            controller.TilføjLejer("Jens Hansen", "1234567890", "10203040","Jenshansen@gmail", 1, "H1");
            controller.TilføjLejemål(DateTime.Parse("01-01-2019"), DateTime.Parse("01-01-2023"), "L1");

            controller.TilføjHus("Roskildevej 20, 4000 Roskilde");
            controller.TilføjLejer("Mette Nielsen", "2345678901", "20304050", "Mettenielsen@gmail", 2, "H2");
            controller.TilføjLejemål(DateTime.Parse("01-02-2020"), DateTime.Parse("01-02-2024"), "L2");

            controller.TilføjHus("Bredgade 10, 5000 Odense");
            controller.TilføjLejer("Peter Jensen", "3456789012", "30405060", "Peterjensen@gmail", 3, "H3");
            controller.TilføjLejemål(DateTime.Parse("01-03-2021"), DateTime.Parse("01-03-2025"), "L3");

            controller.TilføjHus("Nørrebrogade 5, 2200 København");
            controller.TilføjLejer("Sofie Larsen", "4567890123", "40506070", "Sofielarsen@gmail", 4, "H4");
            controller.TilføjLejemål(DateTime.Parse("01-04-2022"), DateTime.Parse("01-04-2026"), "L4");

            controller.TilføjHus("Åboulevarden 15, 8000 Aarhus");
            controller.TilføjLejer("Anders Nielsen", "5678901234", "50607080", "Andersnielsen@gmail", 5, "H5");
            controller.TilføjLejemål(DateTime.Parse("01-05-2023"), DateTime.Parse("01-05-2027"), "L5");
            
            controller.TilføjHus("Roskildevej 32, 4000 Roskilde");
            controller.TilføjHus("Bredgade 19, 5000 Odense");

            controller.VisOversigt();

        }
    }
}