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

        Console.WriteLine(kodePos.getKodePos("Batununggal")); 
        Console.WriteLine(kodePos.getKodePos("Kujangsari")); 
        Console.WriteLine(kodePos.getKodePos("Mengger")); 
        Console.WriteLine(kodePos.getKodePos("Wates")); 
        Console.WriteLine(kodePos.getKodePos("Cijaura")); 
        Console.WriteLine(kodePos.getKodePos("Jatisari")); 
        Console.WriteLine(kodePos.getKodePos("Margasari")); 
        Console.WriteLine(kodePos.getKodePos("Sekejati")); 
        Console.WriteLine(kodePos.getKodePos("Kebonwaru")); 
        Console.WriteLine(kodePos.getKodePos("Maleer")); 
        Console.WriteLine(kodePos.getKodePos("Samoja")); 

    }
}