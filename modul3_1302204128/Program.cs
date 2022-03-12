using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------- KodeBuah Program ----------");
        Console.Write("Masukan Nama Buah: ");
        string namaBuah = Console.ReadLine();
        Console.WriteLine(KodeBuah.getKodeBuah(namaBuah));
        Console.WriteLine("---------- PosisiKarakterGame Program ----------");
        PosisiKarakterGame.posisiKarakterGame();
    }
}