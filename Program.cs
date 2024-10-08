using System;
using System.IO;
namespace LerArquivos
{
    class Program
    {
        static void Main(String[] args)
        {

            string caminhoArquivo = "C:\\dev\\LerArquivos\\meuArquivo.txt";

            try
            {
                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
            }
        }
    }
}