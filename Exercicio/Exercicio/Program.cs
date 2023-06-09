using System;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using Entities;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\ProjetosCSharp\myfolder\vendas.txt";
            string sourceFolderPath = Path.GetDirectoryName(filePath);
            string targetFolderPath = sourceFolderPath + @"\out";
            string targetFilePath = targetFolderPath + @"\summary.csv";

            Directory.CreateDirectory(targetFolderPath);

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] campos = line.Split(',');
                        string nomeDoProduto = campos[0];
                        double valor = double.Parse(campos[1]);
                        int quantidade = int.Parse(campos[2]);

                        // Console.WriteLine(nomeDoProduto + valor + quantidade);

                        Produto prod = new Produto(nomeDoProduto, valor, quantidade);

                        sw.WriteLine(prod.Nome + "," + prod.valorDaVenda().ToString("F2",CultureInfo.InvariantCulture)); 
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Erro !");
                Console.WriteLine(e.Message);
            }
        }
    }
}
