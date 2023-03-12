// See https://aka.ms/new-console-template for more information

using System;

public class KodePos
{
    public string getKodePos_1302210113(string kelurahan)
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

class DoorMachine
{
    private State currentState;

    public DoorMachine()
    {
        currentState = new LockedState();
    }

    public void SetState(State state)
    {
        currentState = state;
        currentState.DisplayState();
    }
}

interface State
{
    void DisplayState();
}

class LockedState : State
{
    public void DisplayState()
    {
        Console.WriteLine("Pintu terkunci");
    }
}

class UnlockedState : State
{
    public void DisplayState()
    {
        Console.WriteLine("Pintu tidak terkunci");
    }
}






public class Program
{
    static void Main()
    {
        //Bagian Tabel Keluarahan KodePos
        KodePos kodePos = new KodePos();

        Console.WriteLine("| Kelurahan\t\t| Kode Pos |");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"| Batununggal\t\t| {kodePos.getKodePos_1302210113("Batununggal")}\t|");
        Console.WriteLine($"| Kujangsari\t\t| {kodePos.getKodePos_1302210113("Kujangsari")}\t|");
        Console.WriteLine($"| Mengger\t\t| {kodePos.getKodePos_1302210113("Mengger")}\t|");
        Console.WriteLine($"| Wates\t\t\t| {kodePos.getKodePos_1302210113("Wates")}\t|");
        Console.WriteLine($"| Cijaura\t\t| {kodePos.getKodePos_1302210113("Cijaura")}\t|");
        Console.WriteLine($"| Jatisari\t\t| {kodePos.getKodePos_1302210113("Jatisari")}\t|");
        Console.WriteLine($"| Margasari\t\t| {kodePos.getKodePos_1302210113("Margasari")}\t|");
        Console.WriteLine($"| Sekejati\t\t| {kodePos.getKodePos_1302210113("Sekejati")}\t|");
        Console.WriteLine($"| Kebonwaru\t\t| {kodePos.getKodePos_1302210113("Kebonwaru")}\t|");
        Console.WriteLine($"| Maleer\t\t| {kodePos.getKodePos_1302210113("Maleer")}\t|");
        Console.WriteLine($"| Samoja\t\t| {kodePos.getKodePos_1302210113("Samoja")}\t|");

        Console.WriteLine("--------------------------------------");



        Console.WriteLine();

        //Bagian DoorMachine

        DoorMachine doorMachine = new DoorMachine();

        // Mengubah state menjadi UnlockedState
        doorMachine.SetState(new UnlockedState());

        // Mengubah state menjadi LockedState
        doorMachine.SetState(new LockedState());
    }
}