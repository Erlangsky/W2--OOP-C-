public class PerangkatElektronik
{
    public string Merk { get; private set; }
    public int Tahun { get; private set; }
    public int Harga { get; private set; }

    public PerangkatElektronik(string merk, int tahun, int harga)
    {
        Merk = merk;
        Tahun = tahun;
        Harga = harga;
    }

    public virtual void Info()
    {
        Console.WriteLine($"Perangkat Elektronik {Merk}, tahun {Tahun}, harga {Harga}");
    }

    public void Nyalakan() => Console.WriteLine($"{Merk} dinyalakan ");
    public void Matikan() => Console.WriteLine($"{Merk} dimatikan ");
}
