using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Escreva um programa em C # Sharp para criar uma função recursiva para calcular o número de Fibonacci de um termo específico
            try
            {
                int numero;
                Console.Write("Informe o número:");

                numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"O numero Fibonacci é {CalcularNumeroFibonacci(numero)}");

                Console.WriteLine("\nFim da aplicação. Aperte enter para sair.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static int CalcularNumeroFibonacci(int numero)
        {
            if(numero <= 2)
            {
                return 1;
            }
            else
            {
                return CalcularNumeroFibonacci(numero - 1) + CalcularNumeroFibonacci(numero - 2);
            }
        }
    }
}
