namespace KalkulatorNapredni1;

public static class Matematika
{
    // Metode moraju biti oznacene sa public
    // Da bi bile vidljive van ove klase

    public static void PokreniSabiranje()
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

    public static void PokreniOduzimanje()
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

    public static void PokreniMnozenje()
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

    public static void PokreniDeljenje()
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
}