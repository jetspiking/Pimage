using System;
using System.Drawing;

namespace Pimage
{
    class Program
    {
        private static String _rootFolder = System.IO.Directory.GetCurrentDirectory();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("...Made By Dustin Hendriks For Pi Day...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter desired fontsize (\"15\" is recommended)");
            Console.ForegroundColor = ConsoleColor.Green;
            String fontSize = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter desired number-width (total width = number-width * fontsize (\"image-width/fontsize\" is recommended).");
            Console.ForegroundColor = ConsoleColor.Green;
            String width = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter desired number-height (total height = number-height * fontsize (\"image-height/fontsize\" is recommended).");
            Console.ForegroundColor = ConsoleColor.Green;
            String height = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Working on your image, please wait a few Piconds :) ...");

            int fontSizeInt = int.Parse(fontSize);
            int widthInt = int.Parse(width);
            int widthHeight = int.Parse(height);

            try
            {
                fontSizeInt = int.Parse(fontSize);
                widthInt = int.Parse(width);
                widthHeight = int.Parse(height);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input must be numeric, terminating...");
                Console.Read();
                Environment.Exit(-1);
            }
            try
            {
                if (Pimage.ToPimage(_rootFolder, fontSizeInt, widthInt, widthHeight))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Succeeded! Image is named \"pimage_result.png\"");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Make sure you have a source image named \"pimage.png\" available in the same directory as this executable. Terminating...");
                    Console.Read();
                    Environment.Exit(-1);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your desired resolution is too high, attempt a smaller resolution. Terminating...");
                Console.Read();
                Environment.Exit(-1);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Environment.Exit(0);
        }

    }
}
