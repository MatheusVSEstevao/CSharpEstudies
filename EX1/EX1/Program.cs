﻿using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {


            string prod1 = "Computador";
            string prod2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{prod1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{prod2}, cujo preço é $ {preco2}");

            Console.WriteLine($"Registro: {idade}, anos de idade, codigo {codigo}, e genero: {genero}");

            Console.WriteLine($"Medida com oito casas  decimais: {medida:F8}");
            Console.WriteLine($"Arredondado: {medida:F3}");
            
        }

    }
}