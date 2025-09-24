class Handphone : PerangkatElektronik
{
    public string OS { get; set; }
    private readonly Baterai baterai; // Composition: Handphone has-a Baterai

    public Handphone(string merek, int tahun, int harga, string os, string tipeBaterai, int kapasitasBaterai)
        : base(merek, tahun, harga)
    {
        OS = os;
        baterai = new Baterai(tipeBaterai, kapasitasBaterai); // isi sesuai input
    }
    
    public override void Info()
    {
        base.Info();
        Console.WriteLine($"OS: {OS}");
        baterai.Info();
    }

        // Overloading
    public void Info(bool denganDiskon)
    {
        if (denganDiskon)
            Console.WriteLine($"Handphone {Merk} dengan diskon: {Harga * 0.9}");
        else
            Info();
    }

    public static void Telepon(string nomor)
    {
        Console.WriteLine($"Menelpon {nomor}...");
    }
}