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

        Console.WriteLine("*****Program Sonu*****");

        int N = Convert.ToInt32(Console.ReadLine().Trim());      
        bool odd = N%2==1 ? true : false;
        
        if(N>= 1 && N<=100)
        {
        if(odd)
        Console.WriteLine("Weird");
        else if(!odd && N>=2 && N<=5)
        Console.WriteLine("Not Weird");
        else if(!odd && N>=6 && N<=20)
        Console.WriteLine("Weird");
        else
        Console.WriteLine("Not Weird");
        }
        
        else
        Console.WriteLine("1 ile 100 arasinde bir sayi giriniz!");
    }
}