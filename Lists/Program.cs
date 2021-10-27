using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishes = new List<string>();
            myWishes.Add("fresh new cool mints");
            myWishes.Add("mercury");
            myWishes.Add("gaming chair");

            int listLenght = myWishes.Count;
            Console.WriteLine($"List lenght : {listLenght}");
            //Console.WriteLine(myWishes[0]);
            //Console.WriteLine(myWishes[1]);
            //Console.WriteLine(myWishes[2]);

            foreach (string wish in myWishes)
            {
                Console.WriteLine($"you wish for : {wish}");

            }
        }
    }
}
