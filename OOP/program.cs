using System;

public static class Program
{
    static void Main()
    {
        PerangkatElektronik elektronik = new PerangkatElektronik("Sony", 2020, 3000000);
        elektronik.Nyalakan();
        elektronik.Info();
        elektronik.Matikan();

        Console.WriteLine();

        Handphone hp = new Handphone("Samsung", 2022, 5000000, "Android", "Li-Po", 4500);
        hp.Nyalakan();
        hp.Info();
        hp.Info(true);
        Handphone.Telepon("08123456789");
        hp.Matikan();

        Console.WriteLine();

        Tablet tab = new Tablet("iPad", 2021, 12000000, 12.9);
        tab.Nyalakan();
        tab.Info();
        tab.Matikan();

        Console.WriteLine();

    }
}
