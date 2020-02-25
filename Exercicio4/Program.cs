using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 - Escreva um programa em C # Sharp para ler a primeira linha de um arquivo.

            try
            {
                LerLinhaArquivo();

                Console.WriteLine("\nFim da aplicação. Aperte enter para sair...");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }

        static void LerLinhaArquivo()
        {
            string arquivo = "Arquivo.txt";

            //Cria Arquivo e insere valores nele
            CriarConteudoArquivo(arquivo);

            //Abre o arquivo e faz a leitura da primeira linha
            using (FileStream fileStream = new FileStream(arquivo, FileMode.Open))
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                var primeiraLinha = streamReader.ReadLine();
                Console.WriteLine($"O conteudo da primeira linha é:");
                Console.WriteLine(primeiraLinha);
            }
        }

        static void CriarConteudoArquivo(string arquivo)
        {
            using (FileStream fileStream = new FileStream(arquivo, FileMode.Create))
            using(StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine("Conteudo1");
                streamWriter.WriteLine("Conteudo2");
                streamWriter.WriteLine("Conteudo2");
                streamWriter.WriteLine("Conteudo4");
                streamWriter.WriteLine("COnteudo5");
            }
        }
    }
}
