namespace KalkulatorNapredni1;

class Program
{
    static void Main(string[] args)
    {
        // Ovo je ista aplikacija kao KalkulatorNapredni,
        // samo što sam same metode prebacio u posebnu klasu
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
                Matematika.PokreniSabiranje();
            }
            else if (unos == "2")
            {
                Matematika.PokreniOduzimanje();
            }
            else if (unos == "3")
            {
                Matematika.PokreniMnozenje();
            }
            else if (unos == "4")
            {
                Matematika.PokreniDeljenje();
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
    
    static void NeispravnaOperacija()
    {
        Console.WriteLine("Niste uneli ispravnu opciju!");
    }
}