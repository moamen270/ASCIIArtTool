using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art
{
    public static class Display
    {
        public static void display()
        {
                Console.WriteLine("\n This is ASCII Art Program \n =============================\n Enter text :");
                ASCIIArtTool.Drow(Console.ReadLine());
                Console.WriteLine("\n\n Created by : Moamen Mostafa\n");
        }
    }
}
