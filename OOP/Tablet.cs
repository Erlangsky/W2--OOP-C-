public class Tablet : PerangkatElektronik
{
    public Tablet(string merk, int tahun, int harga)
        : base(merk, tahun, harga) { }

    public override void Info()
    {
        Console.WriteLine($"Tablet {Merk}, keluaran {Tahun}, harga {Harga}");
    }
}
