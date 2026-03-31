using System;

public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        Console.WriteLine(a + b + c);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan jumlah = new Penjumlahan();
        Console.Write("Jumlah Angka Adalah : ");
        jumlah.JumlahTigaAngka<long>(10, 30, 82);
    }
}
