using System;


namespace ASCII_Art
{
    class Program
    {
      
        static void Main(string[] args)
        {
            try
            {
                Display.display();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
