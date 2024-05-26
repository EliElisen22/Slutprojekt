
public class MinifigurKategori
{
    public int Id { get; set; }
    public string Namn { get; set; }
    public static void VisaMeny(List<MinifigurKategori> kategorier)
    {
        var avsluta = false;
        while (true != avsluta)
        {
            Console.WriteLine("");
            Console.WriteLine("minifigur katigorier");
            Console.WriteLine("1.leg till minifigure katigori");
            Console.WriteLine("2.ta bort minifigur kategori");
            Console.WriteLine("3.visa alla minifigur katigorier");
            Console.WriteLine("4.avsluta");
            Console.WriteLine("");
            Console.Write("sriv här: ");
            string gubval = Console.ReadLine();
            Console.WriteLine("");
            switch (gubval)
            {
                case "1":
                    Console.Write("skriv in vad du önskar katigorin heta här: ");
                    string controlminifigurkTIGORI = Console.ReadLine();
                    if (!kategorier.Any(katigori => katigori.Namn == controlminifigurkTIGORI))
                    {
                        if (kategorier.Count > 0)
                        {
                            var nyKategori = new MinifigurKategori
                            {
                                Id = kategorier.Max(kategori=>kategori.Id)+1
                            ,
                                Namn = controlminifigurkTIGORI
                            };
                            kategorier.Add(nyKategori);
                        }
                        else
                        {
                            var nyKategori = new MinifigurKategori
                            {
                                Id = 0
                                                      ,
                                Namn = controlminifigurkTIGORI
                            };
                            kategorier.Add(nyKategori);
                        }

                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("");
                        string antikontrol = Console.ReadLine();
                        var tabojt = kategorier.FirstOrDefault(katigori => katigori.Namn == antikontrol);
                        if (tabojt != null)
                        {
                            kategorier.Remove(tabojt);
                        }
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("");
                        foreach (var katigori in kategorier)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(katigori.Namn);
                        }
                    }
                    break;
                case "4":
                    {
                        avsluta = true;
                    }
                    break;
            }
        }
    }
}
















































