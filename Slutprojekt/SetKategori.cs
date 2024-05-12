
public class SetKategori
{
    public int Id { get; set; }
    public string Namn { get; set; }
   public static void VisaMeny(List<SetKategori> kategorier)
    {
        var avsluta = false;
        while (true != avsluta)
        {
            Console.WriteLine("");
            Console.WriteLine("Set katigorier");
            Console.WriteLine("1.leg till Set katigori");
            Console.WriteLine("2.ta bort Set kategori");
            Console.WriteLine("3.visa alla set katigorier");
            Console.WriteLine("4.avsluta");
            Console.WriteLine("");
            Console.Write("sriv här: ");
            string setval = Console.ReadLine();
            Console.WriteLine("");
            switch (setval)
            {
                case "1":
                    Console.Write("skriv in vad du önskar katigorin heta här: ");
                    string controlsetkTIGORI = Console.ReadLine();
                    if (!kategorier.Any(katigori => katigori.Namn == controlsetkTIGORI))
                    {
                        var nyKategori = new SetKategori { Id = 0, Namn = controlsetkTIGORI };
                        kategorier.Add(nyKategori);
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
















































