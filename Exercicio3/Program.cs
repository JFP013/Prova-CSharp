using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 - Escreva um programa em C # Sharp para criar um arquivo e escreva uma matriz de strings no arquivo.

            try
            {
                EscreverMatrizDeString();

                Console.WriteLine("\nFim da aplicação. Aperte enter para sair...");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
        
        static void EscreverMatrizDeString()
        {
            string arquivo = "MatrizString.txt";
            int numeroLinhas;

            Console.Write("Informe a quantidade de linhas do arquivo: ");

            //Atribui a variavel, o numero digitado pelo usuario no console.
            numeroLinhas = int.Parse(Console.ReadLine());
            
            // Caso quantidade digitada seja menor que 0, lança uma execeção
            if (numeroLinhas < 0)
            {
                throw new OverflowException("Erro: O numero de linhas não pode ser menor que 0");
            }
            
            String[] stringArray = new String[numeroLinhas];
            for(int i = 0; i < numeroLinhas; i++)
            {
                Console.Write("Escreva o conteudo da linha {0}: ", i + 1);
                stringArray[i] = Console.ReadLine();
            }

            //Cria o arquivo e grava a Matriz de strings
            File.WriteAllLines(arquivo, stringArray);
            Console.WriteLine($"\nO arquivo {arquivo}, foi criado com sucesso!\n");

            //Chamada para leitura do conteudo do Arquivo
            LerArquivo(arquivo);
            
        }

        static void LerArquivo(string arquivo)
        {
            var linhasArquivo = File.ReadAllLines(arquivo);
            string mensagem = $"\nO arquivo {arquivo}, posssui {linhasArquivo.Length} linhas, com  o conteudo abaixo: \n";
            if (linhasArquivo.Length == 1)
            {
                mensagem.Replace("linhas", "linha");
                Console.WriteLine(mensagem.Replace("linhas", "linha"));
            }
            else
            {
                Console.WriteLine(mensagem);
            }

            foreach (var linha in linhasArquivo)
            {
                Console.WriteLine(linha);
            }
        }
    }
}
