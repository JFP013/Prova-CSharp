using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {

        //5- Escreva um programa em C # Sharp para contar o número de linhas em um arquivo.

        static void Main(string[] args)
        {
            try
            {
                ContarLinhas();

                Console.WriteLine("\nFim da aplicação. Aperte enter para sair...");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static void ContarLinhas()
        {
            string arquivo = "MeuArquivo.txt";

            CriarConteudoArquivo(arquivo);

            var quantidadeLinhas = File.ReadAllLines(arquivo);

            Console.WriteLine($"O arquivo {arquivo} possui {quantidadeLinhas.Length} linhas");

        }

        static void CriarConteudoArquivo(string arquivo)
        {
            using (FileStream fileStream = new FileStream(arquivo, FileMode.Create))
            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine("Conteudo3");
                streamWriter.WriteLine("Conteudo2");
                streamWriter.WriteLine("Conteudo1");
                streamWriter.WriteLine("Conteudo4");
                streamWriter.WriteLine("COnteudo5");
            }
        }
    }
}
