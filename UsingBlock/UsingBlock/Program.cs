using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\ProjetosCSharp\file10.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
                /*Otimizando o using
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                */
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro!");
                Console.Write(e.Message);
            }
        }
    }
}
