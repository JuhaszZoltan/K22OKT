namespace BukkMaraton2019
{
    internal class Program
    {
        static List<Versenyzo> versenyzok = new();
        const int restvevokSzama = 691;

        static void Main(string[] args)
        {
            Feladat03();
            Feladat04();
            Feladat05();
            Feladat06();
        }

        private static void Feladat06()
        {
            bool b = versenyzok.Any(x => x.Ido.TotalHours > 6);
            Console.WriteLine("6. feladat: " +
                $"{(b ? "Volt ilyen versenyző" : "Nem volt ilyen versenyző")}");
        }

        private static void Feladat05()
        {
            int c = versenyzok.Count(x => !x.Nem && x.Versenytav == "Rövid");
            Console.WriteLine($"5. feladat: " +
                $"Nővi versenyzők száma a rövittávú versenyen: {c} fő");
        }

        private static void Feladat04()
        {
            Console.WriteLine($"4. feladat: " +
                $"Versenytávot nem teljesítők: " +
                $"{100 - (versenyzok.Count / (double)restvevokSzama * 100)}%");
        }

        private static void Feladat03()
        {
            using StreamReader sr = new(path: @"..\..\..\src\bukkm2019.txt");
            _ = sr.ReadLine();
            while (!sr.EndOfStream)
                versenyzok.Add(new Versenyzo(sr.ReadLine()));
        }
    }
}