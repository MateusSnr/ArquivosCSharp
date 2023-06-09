using System;
using System.IO;

namespace streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"F:\ProjetosCSharp\file10.txt";
            string targetpath = @"F:\ProjetosCSharp\file12.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetpath))//Concatenar no final
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
