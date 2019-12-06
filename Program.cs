using System;
using System.IO;


namespace Flex_Shell
{
   
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("FLEX SHELL VERSION 0.0.4");
            Console.WriteLine("Created by Jack Anderson");
            Console.WriteLine("Go to https://www.github.com/WindingTheRopes/flex");
            Console.WriteLine();
        }
        void flex()
        {
            Console.Write("FLEX$> ");
            globals.FCMD = Console.ReadLine();
            
        }
            
    }
}
