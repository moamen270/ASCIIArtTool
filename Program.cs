using System;
using System.Collections.Generic;

namespace ASCII_Art
{
    class Program
    {
      
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n This is ASCII Art Program \n =============================\n Enter text :");
                ASCIIArtTool.Drow(Console.ReadLine());
                Console.WriteLine("\n\n Created by : Moamen Mostafa\n");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
