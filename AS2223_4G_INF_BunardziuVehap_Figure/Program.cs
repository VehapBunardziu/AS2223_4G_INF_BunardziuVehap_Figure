using System;

namespace AS2223_4G_INF_BunardziuVehap_Figure // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Quadrato quadrato = new Quadrato(5);
            Triangolo triangolo = new Triangolo(5, 4);
            Rettangolo rettangolo = new Rettangolo(3, 3);
            Cerchio cerchio = new Cerchio(2);
            Console.WriteLine($"Area quadrato: {quadrato.Area()}");
            Console.WriteLine($"Perimetro quadrato: {quadrato.Perimetro()}");
            Console.WriteLine($"Area triangolo: {triangolo.Area()}");
            Console.WriteLine($"Perimetro triangolo: {triangolo.Perimetro()}");
            Console.WriteLine($"Area rettangolo: {rettangolo.Area()}");
            Console.WriteLine($"Perimetro rettangolo: {rettangolo.Perimetro()}");
            Console.WriteLine($"Area cerchio: {cerchio.Area()}");
            Console.WriteLine($"Perimetro cerchio: {cerchio.Perimetro()}");
        }
    }
}
