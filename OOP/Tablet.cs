using System;

public class Tablet : PerangkatElektronik
{
    public double UkuranLayar { get; private set; }

    public Tablet(string merk, int tahun, int harga, double layar)
        : base(merk, tahun, harga)
    {
        UkuranLayar = layar;
    }

    public override void Info()
    {
        Console.WriteLine($"Tablet {Merk}, tahun {Tahun}, harga {Harga}, layar {UkuranLayar} inch");
    }
}
