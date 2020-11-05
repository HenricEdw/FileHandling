using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\MyFiles\NewFile.txt";
            string directoryPath = @"C:\MyFiles\";
            //File.Delete(path);

            FileInfo fileInfo = new FileInfo(directoryPath);

            DirectoryInfo di = new DirectoryInfo(directoryPath);

            

            Console.WriteLine("Skriv in ngt som ska sparas!");

            string[] strArray = new string[1];
            string myString = Console.ReadLine();
            strArray[0] = $"{myString + Environment.NewLine}";
            var  envs = Environment.GetEnvironmentVariables();
            
            File.WriteAllText(path, strArray[0]);

            var stringArray = File.ReadAllLines(path);

            Console.Read();
        }
    }
}