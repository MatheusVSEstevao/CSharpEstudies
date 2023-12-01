using System;
using System.Globalization;

namespace LeituraDados
{
    internal class LeituraDados
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura: ");
            string[] dados = Console.ReadLine().Split(' ');
            string n = dados[0];
            int q = int.Parse(dados[1]);
            double p = double.Parse(dados[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(n);
            Console.WriteLine(q);
            Console.WriteLine(p);

            









        }
    }
}