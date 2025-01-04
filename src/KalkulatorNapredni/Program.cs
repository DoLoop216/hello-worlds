namespace KalkulatorNapredni;

class Program
{
    static void Main(string[] args)
    {
        // Ovo je ista aplikacija kao Kalkulator,
        // samo što sam ovde kod pomerio u zasebne metode
        // kako bih dobio bolju organizaciju koda.
        while (true)
        {
            IspisiMeni();

            string unos = Console.ReadLine();
            if (unos == "5")
            {
                return;
            }

            if (unos == "1")
            {
                PokreniSabiranje();
            }
            else if (unos == "2")
            {
                PokreniOduzimanje();
            }
            else if (unos == "3")
            {
                PokreniMnozenje();
            }
            else if (unos == "4")
            {
                PokreniDeljenje();
            }
            else
            {
                NeispravnaOperacija();
            }
        }
    }

    static void IspisiMeni()
    {
        Console.WriteLine("Izaberite operaciju");
        Console.WriteLine("1. Sabiranje");
        Console.WriteLine("2. Oduzimanje");
        Console.WriteLine("3. Množenje");
        Console.WriteLine("4. Deljenje");
        Console.WriteLine("5. Kraj");
    }

    static void PokreniSabiranje()
    {
        Console.WriteLine("Unesite prvi broj:");
        string prviBrojTekst = Console.ReadLine();
        int prviBroj = Convert.ToInt32(prviBrojTekst);
                
        Console.WriteLine("Unesite drugi broj:");
        string drugiBrojTekst = Console.ReadLine();
        int drugiBroj = Convert.ToInt32(drugiBrojTekst);
                
        int rezultat = prviBroj + drugiBroj;
        Console.WriteLine($"Rezultat sabiranja je: {rezultat}");
    }

    static void PokreniOduzimanje()
    {
        Console.WriteLine("Unesite prvi broj:");
        string prviBrojTekst = Console.ReadLine();
        int prviBroj = Convert.ToInt32(prviBrojTekst);
                
        Console.WriteLine("Unesite drugi broj:");
        string drugiBrojTekst = Console.ReadLine();
        int drugiBroj = Convert.ToInt32(drugiBrojTekst);
                
        int rezultat = prviBroj - drugiBroj;
        Console.WriteLine($"Rezultat oduzimanja je: {rezultat}");
    }

    static void PokreniMnozenje()
    {
        Console.WriteLine("Unesite prvi broj:");
        string prviBrojTekst = Console.ReadLine();
        int prviBroj = Convert.ToInt32(prviBrojTekst);
                
        Console.WriteLine("Unesite drugi broj:");
        string drugiBrojTekst = Console.ReadLine();
        int drugiBroj = Convert.ToInt32(drugiBrojTekst);
                
        int rezultat = prviBroj * drugiBroj;
        Console.WriteLine($"Rezultat množenja je: {rezultat}");
    }

    static void PokreniDeljenje()
    {
        Console.WriteLine("Unesite prvi broj:");
        string prviBrojTekst = Console.ReadLine();
        int prviBroj = Convert.ToInt32(prviBrojTekst);
                
        Console.WriteLine("Unesite drugi broj:");
        string drugiBrojTekst = Console.ReadLine();
        int drugiBroj = Convert.ToInt32(drugiBrojTekst);
                
        int rezultat = prviBroj / drugiBroj;
        Console.WriteLine($"Rezultat deljenja je: {rezultat}");
    }
    
    static void NeispravnaOperacija()
    {
        Console.WriteLine("Niste uneli ispravnu opciju!");
    }
}