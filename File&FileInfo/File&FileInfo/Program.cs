using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"F:\ProjetosCSharp\file1.txt";
            string targetPath = @"F:\ProjetosCSharp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}