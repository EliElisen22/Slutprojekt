public class Line
{
    public int Id { get; set; }
    public string Namn { get; set; }
   public static void Set_meny(List<Line> lines)
    {
        var avsluta = false;
        while (true != avsluta)
        {
            Console.WriteLine("");
            Console.WriteLine("lines");
            Console.WriteLine("1.leg till line");
            Console.WriteLine("2.ta bort line");
            Console.WriteLine("3.visa alla lines");
            Console.WriteLine("4.avsluta");
            Console.WriteLine("");
            Console.Write("sriv här: ");
            string linesval = Console.ReadLine();
            Console.WriteLine("");
            switch (linesval)
            {
                case "1":
                    Console.Write("skriv in vad linen här: ");
                    string controlline = Console.ReadLine();
                    if (!lines.Any(line => line.Namn == controlline))
                    {
                        var nyline = new Line { Id = 0, Namn = controlline };
                        lines.Add(nyline);
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("");
                        string antikontrol = Console.ReadLine();
                        var tabojt = lines.FirstOrDefault(line => line.Namn == antikontrol);
                        if (tabojt != null)
                        {
                            lines.Remove(tabojt);
                        }
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("");
                        foreach (var line in lines)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(line.Namn);
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
















































