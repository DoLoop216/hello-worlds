namespace Prodavnica001;

public class Proizvod
{
    public string Naziv { get; set; }
    public double Cena { get; set; }
    
    public void IspisiProizvod()
    {
        Console.WriteLine($"Proizvod: {Naziv}, Cena: {Cena}");
    }
}