using System;

namespace FileStreamStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\ProjetosCSharp\file10.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                /*Mostrar apenas uma linha
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
                */

                //Mostrando o arquivo todo
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro !");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) sr.Close();
                if(fs != null) fs.Close();
            }
        }
    }
}