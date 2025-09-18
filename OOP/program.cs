class Program
{
    static void Main()
    {
        Handphone hp = new Handphone("Samsung", 2022, 5000000);
        hp.Nyalakan();
        hp.Info();
        hp.Telepon("08123456789");
        hp.Matikan();

        Console.WriteLine();

        Tablet tab = new Tablet("iPad", 2021, 12000000);
        tab.Nyalakan();
        tab.Info();
        tab.Matikan();
    }
}
