using System;
using System.IO;

namespace ReadingFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishlist";
            string userfile = "Wishlist";
            string fullfilepath = $@"{rootDirectory}\{userfile}.txt";

            string[] dataFromFile = File.ReadAllLines(fullfilepath);

            foreach(string line in dataFromFile)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            dataFromFile[0] = "pink bruh";

            foreach (string line in dataFromFile)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(fullfilepath, dataFromFile);
        }
    }
}
