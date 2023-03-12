// See https://aka.ms/new-console-template for more information

using System;

public class KodePos
{
    public string getKodePos(string kelurahan)
    {
        switch (kelurahan)
        {
            case "Batununggal":
                return "40266";
            case "Kujangsari":
            case "Cijaura":
                return "40287";
            case "Mengger":
                return "40267";
            case "Wates":
                return "40256";
            case "Jatisari":
            case "Margasari":
            case "Sekejati":
                return "40286";
            case "Kebonwaru":
                return "40272";
            case "Maleer":
                return "40274";
            case "Samoja":
                return "40273";
            default:
                return "Kode pos tidak ditemukan";
        }
    }
} 

public class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine("| Kelurahan\t\t| Kode Pos |");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"| Batununggal\t\t| {kodePos.getKodePos("Batununggal")}\t|");
        Console.WriteLine($"| Kujangsari\t\t| {kodePos.getKodePos("Kujangsari")}\t|");
        Console.WriteLine($"| Mengger\t\t| {kodePos.getKodePos("Mengger")}\t|");
        Console.WriteLine($"| Wates\t\t\t| {kodePos.getKodePos("Wates")}\t|");
        Console.WriteLine($"| Cijaura\t\t| {kodePos.getKodePos("Cijaura")}\t|");
        Console.WriteLine($"| Jatisari\t\t| {kodePos.getKodePos("Jatisari")}\t|");
        Console.WriteLine($"| Margasari\t\t| {kodePos.getKodePos("Margasari")}\t|");
        Console.WriteLine($"| Sekejati\t\t| {kodePos.getKodePos("Sekejati")}\t|");
        Console.WriteLine($"| Kebonwaru\t\t| {kodePos.getKodePos("Kebonwaru")}\t|");
        Console.WriteLine($"| Maleer\t\t| {kodePos.getKodePos("Maleer")}\t|");
        Console.WriteLine($"| Samoja\t\t| {kodePos.getKodePos("Samoja")}\t|");

        Console.WriteLine("--------------------------------------");
    }
}