using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Escreva um programa em C # Sharp para criar um arquivo em branco no disco.
            try
            {
                CriarArquivo();

                Console.WriteLine("\nFim da aplicação. Aperte enter para sair...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                var origemErro = ex.StackTrace;
            }

            Console.ReadLine();
        }

        static void CriarArquivo()
        {
            string arquivo = "MeuArquivo.txt";

            using(FileStream fileStream = new FileStream(arquivo, FileMode.Create))
            {
                Console.WriteLine($"O arquivo, {arquivo}, foi criado com sucesso!");
            }
        }
    }
}

