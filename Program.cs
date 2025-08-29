using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Teste com Nokia ===");
        Smartphone nokia = new Nokia("119999999", "Nokia Tijolão", "111111111111", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine("\n=== Teste com iPhone ===");
        Smartphone iphone = new Iphone("119888888", "iPhone 14 Pro", "222222222222", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}