using System;

namespace Flex_Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FLEX SHELL VERSION 0.0.4");
            Console.WriteLine("Created by Jack Anderson");
            Console.WriteLine("Go to https://www.github.com/WindingTheRopes/flex");
            Console.WriteLine();
            fMain();
        }
        public static void fMain()
        {
            Console.Write("FLEX$> ");
            string fCMD = Console.ReadLine();
            fMain();
        }
    }
}
