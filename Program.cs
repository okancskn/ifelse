internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        if(time>=6 && time<13)
        Console.WriteLine("Gunaydin!");
        else if(time<=18)
        Console.WriteLine("Iyi Gunler");
        else
        Console.WriteLine("Iyi Aksamlar!");


        string sonuc = time>=6 && time<13 ? "xGunaydin!" : time <=18 ? "xIyi Günler!" : "xIyi Aksamlar!";
        Console.WriteLine(sonuc);
    }
}