namespace Kalkulator;

class Program
{
    /// <summary>
    /// Metoda koja se poziva prilikom pokretanja aplikacije.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        while (true) // Beskonačna petlja
        {
            // Ispisujem u konzoli tekst
            Console.WriteLine("Izaberite operaciju");
            Console.WriteLine("1. Sabiranje");
            Console.WriteLine("2. Oduzimanje");
            Console.WriteLine("3. Množenje");
            Console.WriteLine("4. Deljenje");
            Console.WriteLine("5. Kraj");

            string unos = Console.ReadLine();
            // Prvo proveravam da li je korisnik izabrao kraj
            if (unos == "5")
            {
                // Ako jeste, prekidam izvršavanje programa
                // tako sto pozovem return koji odmah prekida
                // izvršavanje metode u kojoj se nalazi.
                // S obzirom da se Main metoda završava, završava se i program
                return;
            }

            if (unos == "1") // Proveravam da li je korisnik izabrao sabiranje
            {
                // Ako jeste, radim ovo sto je u ovom bloku
                Console.WriteLine("Unesite prvi broj:");
                // Čitam unos korisnika i pretvaram ga u broj
                string prviBrojTekst = Console.ReadLine();
                int prviBroj = Convert.ToInt32(prviBrojTekst);
                
                Console.WriteLine("Unesite drugi broj:");
                string drugiBrojTekst = Console.ReadLine();
                int drugiBroj = Convert.ToInt32(drugiBrojTekst);
                
                // Sabiram dva broja
                int rezultat = prviBroj + drugiBroj;
                // Ispisujem rezultat
                Console.WriteLine($"Rezultat sabiranja je: {rezultat}");
            }
            else if (unos == "2") // Ako prethodni uslov nije ispunjen, proveravam da li je ovaj ispunjen
            {
                Console.WriteLine("Unesite prvi broj:");
                string prviBrojTekst = Console.ReadLine();
                int prviBroj = Convert.ToInt32(prviBrojTekst);
                
                Console.WriteLine("Unesite drugi broj:");
                string drugiBrojTekst = Console.ReadLine();
                int drugiBroj = Convert.ToInt32(drugiBrojTekst);
                
                // Oduzimam drugi broj od prvog
                int rezultat = prviBroj - drugiBroj;
                // Ispisujem rezultat
                Console.WriteLine($"Rezultat oduzimanja je: {rezultat}");
            }
            else if (unos == "3")
            {
                Console.WriteLine("Unesite prvi broj:");
                string prviBrojTekst = Console.ReadLine();
                int prviBroj = Convert.ToInt32(prviBrojTekst);
                
                Console.WriteLine("Unesite drugi broj:");
                string drugiBrojTekst = Console.ReadLine();
                int drugiBroj = Convert.ToInt32(drugiBrojTekst);
                
                // Množim dva broja
                int rezultat = prviBroj * drugiBroj;
                // Ispisujem rezultat
                Console.WriteLine($"Rezultat množenja je: {rezultat}");
            }
            else if (unos == "4")
            {
                Console.WriteLine("Unesite prvi broj:");
                string prviBrojTekst = Console.ReadLine();
                int prviBroj = Convert.ToInt32(prviBrojTekst);
                
                Console.WriteLine("Unesite drugi broj:");
                string drugiBrojTekst = Console.ReadLine();
                int drugiBroj = Convert.ToInt32(drugiBrojTekst);
                
                // Delim prvi broj sa drugim
                int rezultat = prviBroj / drugiBroj;
                // Ispisujem rezultat
                Console.WriteLine($"Rezultat deljenja je: {rezultat}");
            }
            else
            {
                // Ako korisnik nije uneo nijednu od ponuđenih opcija
                // Ispisujem mu poruku da je uneo pogrešnu opciju
                Console.WriteLine("Niste uneli ispravnu opciju!");
            }
        }
    }
}