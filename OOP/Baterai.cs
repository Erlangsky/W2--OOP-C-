class Baterai
{
    public string Tipe { get; set; }
    public int Kapasitas { get; set; }

    public Baterai(string tipe, int kapasitas)
    {
        Tipe = tipe;
        Kapasitas = kapasitas;
    }

    public void Info()
    {
        Console.WriteLine($"Baterai: {Tipe}, Kapasitas: {Kapasitas} mAh");
    }
}