public class Minifigur
{
    public int Id { get; set; }
    public int lineId { get; set; }
    public string Namn { get; set; }
    public List<int> Minifigurkatigorier { get; set; } = new();
    public static void VisaMeny(List<Minifigur> minifigurer, List<Line> lines, List<MinifigurKategori> minifigurKategoris)
    {
        Console.WriteLine("");
        Console.WriteLine("1.allt");
        Console.WriteLine("2.sök");
        Console.WriteLine("3.lega till");
        Console.WriteLine("4.ta bort");
        Console.WriteLine("5.gå tilbaka");
        string minifigurval = Console.ReadLine();
        switch (minifigurval)
        {
            case "1":

                break;
            case "2":

                break;
            case "3":

                Console.WriteLine("");
                Console.Write("skriv in namnet på gubben här: ");
                string gubnamn = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("skriv vilken line den tilhör här: ");
                string gubline = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("skriv in en miniifigurs katigori som guben tillhör som du inte redan get den, om det inte fins någon tryck bara enter. Skriv här: ");
                string minifigurkatigori = Console.ReadLine();

                break;
            case "4":

                break;
        }
    }
}

















































