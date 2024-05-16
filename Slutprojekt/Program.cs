using System.Text.Json;

mainmenu();

static void mainmenu()
{
  
    List<Minifigur> minifigurer = new();
 
    if (File.Exists("minifigurer.json"))
    {
        minifigurer = JsonSerializer.Deserialize<List<Minifigur>>(File.ReadAllText("minifigurer.json"));
    }
    List<MinifigurKategori> minifigurkatigorier = new();
    if (File.Exists("minifigurkategorier.json"))
    {
        minifigurkatigorier = JsonSerializer.Deserialize<List<MinifigurKategori>>(File.ReadAllText("minifigurkategorier.json"));
    }
    
    var Setkatigorier = new List<SetKategori>();
    if (File.Exists("setkatigori.json"))
    {
        Setkatigorier = JsonSerializer.Deserialize<List<SetKategori>>(File.ReadAllText("setkatigori.json"));
    }
    var lines = new List<Line>();
    if (File.Exists("lines.json"))
    {
       lines = JsonSerializer.Deserialize<List<Line>>(File.ReadAllText("lines.json"));
    }
    var stengaav = false;
    while (true != stengaav)
    {
        Console.WriteLine("");
        Console.WriteLine("1.äger");
        Console.WriteLine("2.äger inte");
        Console.WriteLine("3.alla");
        Console.WriteLine("4.katigorier och lines");
        Console.WriteLine("5. avsluta");
        Console.WriteLine("");
        Console.Write("skriv dit val här: ");
        string mainval = Console.ReadLine();
        switch (mainval)
        {
            case "1":
                {
                    Console.WriteLine("");
                    Console.WriteLine("1.minifigurer");
                    Console.WriteLine("2.sets");
                    Console.WriteLine("3.gå tillbaka");
                    string ägerval = Console.ReadLine();
                    if (ägerval == "1")
                    {
                        Minifigur.VisaMeny(minifigurer,lines,minifigurkatigorier);
                    }
                    else if (ägerval == "2")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("1.allt");
                        Console.WriteLine("2.sök");
                        Console.WriteLine("3.lega till");
                        Console.WriteLine("4.ta bort");
                        Console.WriteLine("5.gå tilbaka");
                        string setval = Console.ReadLine();
                        switch (setval)
                        {
                            case "1":

                                break;
                            case "2":

                                break;
                            case "3":

                                break;
                            case "4":

                                break;
                        }

                    }
                }
                break;
            case "2":
                {
                    Console.WriteLine("");
                    Console.WriteLine("1.minifigurer");
                    Console.WriteLine("2.sets");
                    Console.WriteLine("3.gå tillbaka");
                    string ägerejval = Console.ReadLine();
                    if (ägerejval == "1")
                    {
                        Minifigur.VisaMeny(minifigurer, lines, minifigurkatigorier);
                    }
                    else if (ägerejval == "2")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("1.allt");
                        Console.WriteLine("2.sök");
                        Console.WriteLine("3.lega till");
                        Console.WriteLine("4.ta bort");
                        Console.WriteLine("5.gå tilbaka");
                        string setval = Console.ReadLine();
                        switch (setval)
                        {
                            case "1":

                                break;
                            case "2":

                                break;
                            case "3":

                                break;
                            case "4":

                                break;
                        }

                    }
                }
                break;
            case "3":
                Console.WriteLine("");
                Console.WriteLine("1.minifigurer");
                Console.WriteLine("2.sets");
                Console.WriteLine("3.gå tillbaka");
                string allaval = Console.ReadLine();
                if (allaval == "1")
                {
                    Minifigur.VisaMeny(minifigurer, lines, minifigurkatigorier);
                }
                else if (allaval == "2")
                {
                    Console.WriteLine("");
                    Console.WriteLine("1.allt");
                    Console.WriteLine("2.sök");
                    Console.WriteLine("3.lega till");
                    Console.WriteLine("4.ta bort");
                    Console.WriteLine("5.gå tilbaka");
                    string alltval = Console.ReadLine();
                    switch (alltval)
                    {
                        case "1":

                            break;
                        case "2":

                            break;
                        case "3":

                            break;
                        case "4":

                            break;
                    }

                }


                break;
            case "4":
                {
                    Console.WriteLine("1.minifigurs katigori");
                    Console.WriteLine("2.setkatigori");
                    Console.WriteLine("3.lines");
                    Console.WriteLine("");
                    string katigorival = Console.ReadLine();
                    if (katigorival == "1")
                    {
                        MinifigurKategori.VisaMeny(minifigurkatigorier);
                    }
                    else if (katigorival == "2")
                    {
                        SetKategori.VisaMeny(Setkatigorier);
                    }
                    else if (katigorival == "3")
                    {
                    
                    }
                }
                break;
            case "5":
                {
                    Console.WriteLine("");
                    Console.WriteLine("buy buy not bye bye cuz that aint as funny");
                    stengaav = true;
                }
                break;
        }
    }
    File.WriteAllText("minifigurkategorier.json", JsonSerializer.Serialize(minifigurkatigorier));
    File.WriteAllText("setkatigori.json",JsonSerializer.Serialize(Setkatigorier));
    File.WriteAllText("minifigurer.json", JsonSerializer.Serialize(minifigurer));
    File.WriteAllText("lines.json", JsonSerializer.Serialize(lines));
}

