public class Handphone : PerangkatElektronik
{
    public Handphone(string merk, int tahun, int harga)
        : base(merk, tahun, harga) { }

    public override void Info()
    {
        Console.WriteLine($"Handphone {Merk}, keluaran {Tahun}, harga {Harga}");
    }

    public void Telepon(string nomor)
    {
        Console.WriteLine($"Menelpon {nomor} dari {Merk} 📞");
    }
}
