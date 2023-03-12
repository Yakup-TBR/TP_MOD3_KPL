// See https://aka.ms/new-console-template for more information

using System;

public class KodePos
{
    public string getKodePos(string kelurahan)
    {
        string kodePos = "";

        switch (kelurahan)
        {
            case "Batununggal":
                kodePos = "40266";
                break;
            case "Kujangsari":
            case "Cijaura":
                kodePos = "40287";
                break;
            case "Mengger":
                kodePos = "40267";
                break;
            case "Wates":
                kodePos = "40256";
                break;
            case "Jatisari":
            case "Margasari":
            case "Sekejati":
                kodePos = "40286";
                break;
            case "Kebonwaru":
                kodePos = "40272";
                break;
            case "Maleer":
                kodePos = "40274";
                break;
            case "Samoja":
                kodePos = "40273";
                break;
            default:
                kodePos = "Kode pos tidak ditemukan";
                break;
        }

        return $"{kelurahan}: {kodePos}";
    }
}

public class main
{
    public static void Main()
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine(kodePos.getKodePos("Batununggal")); // Output: Batununggal: 40266
        Console.WriteLine(kodePos.getKodePos("Kujangsari")); // Output: Kujangsari: 40287
        Console.WriteLine(kodePos.getKodePos("Mengger")); // Output: Mengger: 40267
        Console.WriteLine(kodePos.getKodePos("Wates")); // Output: Wates: 40256
        Console.WriteLine(kodePos.getKodePos("Cijaura")); // Output: Cijaura: 40287
        Console.WriteLine(kodePos.getKodePos("Jatisari")); // Output: Jatisari: 40286
        Console.WriteLine(kodePos.getKodePos("Margasari")); // Output: Margasari: 40286
        Console.WriteLine(kodePos.getKodePos("Sekejati")); // Output: Sekejati: 40286
        Console.WriteLine(kodePos.getKodePos("Kebonwaru")); // Output: Kebonwaru: 40272
        Console.WriteLine(kodePos.getKodePos("Maleer")); // Output: Maleer: 40274
        Console.WriteLine(kodePos.getKodePos("Samoja")); // Output: Samoja: 40273
        Console.WriteLine(kodePos.getKodePos("Tidak Ada")); // Output: Kode pos tidak ditemukan
    }
}