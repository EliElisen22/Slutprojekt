using System.Runtime.CompilerServices;

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
                int ut = 0;
                Console.WriteLine("");
                string gubnamn;
                int lineId;
                List<int> minifigurskategorier = new();
                while (true)
                {

                    Console.WriteLine("");
                    Console.Write("skriv in namnet på gubben här: ");

                    gubnamn = Console.ReadLine();

                    if (minifigurer.Any(minifigur => minifigur.Namn.ToLower() == gubnamn.ToLower()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("de fins redan en gubbe me sama namn.");
                        Console.WriteLine("1.tibaka");
                        Console.WriteLine("2.försök igen");
                        Console.Write("skriv dit val här: ");
                        string tilbaka = Console.ReadLine();
                        if (tilbaka == "1")
                        {
                            ut = 1;
                            break;
                        }


                    }

                    else { break; }
                }

                if (ut == 1)
                {
                    break;
                }
                while (true)
                {
                    Console.WriteLine("");
                    Console.Write("skriv vilken line den tilhör här: ");
                    string gubline = Console.ReadLine();
                    if (lines.Any(line => line.Namn.ToLower() == gubline.ToLower()))
                    {
                        var line = lines.First(l => l.Namn.ToLower() == gubline.ToLower());
                        lineId = line.Id;
                        break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("det fins ingen sådan line");

                }
                while (true)
                {

                    Console.WriteLine("");
                    Console.Write("skriv in en miniifigurs katigori som guben tillhör som du inte redan get den, om det inte fins någon tryck bara enter. Skriv här: ");
                    string katigoriminifigur = Console.ReadLine();
                    if (minifigurKategoris.Any(minifigurkatigori => minifigurkatigori.Namn.ToLower() == katigoriminifigur.ToLower()))
                    {
                        var minifigKat = minifigurKategoris.First(minifigurkatigori => minifigurkatigori.Namn.ToLower() == katigoriminifigur.ToLower());
                        if (!minifigurskategorier.Contains(minifigKat.Id))
                        {
                            minifigurskategorier.Add(minifigKat.Id);
                        }
                    }
                    else if (katigoriminifigur == "")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("det fins ingen sådan minifigurkatigori");
                    }

                }

                minifigurer.Add(new Minifigur
                {
                    Id=minifigurer.Max(mf=>mf.Id) + 1,
                    lineId = lineId,
                    Minifigurkatigorier = minifigurskategorier,
                    Namn = gubnamn
                });
                break;
            case "4":

                break;
        }
    }
}

















































