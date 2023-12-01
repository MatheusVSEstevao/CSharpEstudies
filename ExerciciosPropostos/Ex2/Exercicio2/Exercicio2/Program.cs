using System;

namespace ex2
{
    internal class exercicio2
    {
        static void Main(string[] args)
        {
            double raio = 2.00;
            double pi = 3.14159;

            double area = pi * (raio * raio);

            Console.WriteLine($"A= {area:F4}");
        }
    }
}