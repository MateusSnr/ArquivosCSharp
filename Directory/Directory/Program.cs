using System;
using System.IO;

namespace directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\ProjetosCSharp\myfolder";
            try
            {
                //Listando todas as subpastas apartir de uma pasta
                //*.* significa qualquer arquivo de qualquer extensão
                IEnumerable <string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                //Listando todos os arquivos
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                //Criando uma pasta
                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e) 
            { 
                Console.WriteLine("Erro !");
                Console.WriteLine(e.Message);
            }
        }
    }
}