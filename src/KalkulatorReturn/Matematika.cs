namespace KalkulatorReturn;

public static class Matematika
{
    // Razlika je u UnesiPrviBroj (ranije UnesiPrviBrojMessage)
    // i UnesiDrugiBroj (ranije UnesiDrugiBrojmessage) metodama
    // Ove metode sada cekaju unos korisnika i vracaju taj unos
    // To dozvoljava da tamo gde pozivam metodu
    // ne moram rucno da pozivam Console.ReadLine() i Convert.ToInt32()
    
    private static int UnesiPrviBroj()
    {
        Console.WriteLine("Unesite prvi broj:");
        return Convert.ToInt32(Console.ReadLine());
    }

    private static int UnesiDrugiBroj()
    {
        Console.WriteLine("Unesite drugi broj:");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static void PokreniSabiranje()
    {
        Console.WriteLine($"Rezultat sabiranja je: {UnesiPrviBroj() + UnesiDrugiBroj()}");
    }

    public static void PokreniOduzimanje()
    {
        Console.WriteLine($"Rezultat oduzimanja je: {UnesiPrviBroj() - UnesiDrugiBroj()}");
    }

    public static void PokreniMnozenje()
    {
        Console.WriteLine($"Rezultat množenja je: {UnesiPrviBroj() * UnesiDrugiBroj()}");
    }

    public static void PokreniDeljenje()
    {
        Console.WriteLine($"Rezultat deljenja je: {UnesiPrviBroj() * UnesiDrugiBroj()}");
    }
}