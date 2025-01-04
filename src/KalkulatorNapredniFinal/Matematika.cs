namespace KalkulatorNapredniFinal;

public static class Matematika
{
    private static void UnesiPrviBrojMessage()
    {
        Console.WriteLine("Unesite prvi broj:");
    }

    private static void UnesiDrugiBrojMessage()
    {
        Console.WriteLine("Unesite drugi broj:");
    }
    
    public static void PokreniSabiranje()
    {
        UnesiPrviBrojMessage();
        int prviBroj = Convert.ToInt32(Console.ReadLine());
        
        UnesiDrugiBrojMessage();
        int drugiBroj = Convert.ToInt32(Console.ReadLine());
                
        int rezultat = prviBroj + drugiBroj;
        Console.WriteLine($"Rezultat sabiranja je: {rezultat}");
    }

    public static void PokreniOduzimanje()
    {
        UnesiPrviBrojMessage();
        int prviBroj = Convert.ToInt32(Console.ReadLine());
        
        UnesiDrugiBrojMessage();
        int drugiBroj = Convert.ToInt32(Console.ReadLine());
                
        int rezultat = prviBroj - drugiBroj;
        Console.WriteLine($"Rezultat oduzimanja je: {rezultat}");
    }

    public static void PokreniMnozenje()
    {
        UnesiPrviBrojMessage();
        int prviBroj = Convert.ToInt32(Console.ReadLine());
                
        UnesiDrugiBrojMessage();
        int drugiBroj = Convert.ToInt32(Console.ReadLine());
                
        int rezultat = prviBroj * drugiBroj;
        Console.WriteLine($"Rezultat množenja je: {rezultat}");
    }

    public static void PokreniDeljenje()
    {
        UnesiPrviBrojMessage();
        int prviBroj = Convert.ToInt32(Console.ReadLine());
        
        UnesiDrugiBrojMessage();
        int drugiBroj = Convert.ToInt32(Console.ReadLine());
                
        int rezultat = prviBroj / drugiBroj;
        Console.WriteLine($"Rezultat deljenja je: {rezultat}");
    }
}