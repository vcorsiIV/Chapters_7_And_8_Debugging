// Uses DisplayWebAddress method three times
using static System.Console;

namespace DebugSeven1
{
    class Program
    {
        static void Main()
        {
            //add () at the end of the method name
            DisplayWebAddress();
            WriteLine("Shop at Shopper's World");
            DisplayWebAddress();
            WriteLine("The best bargains from around the world");
            DisplayWebAddress();
        }
        //add static to private "static" void
        private static void DisplayWebAddress()
        {
            WriteLine("------------------------------");
            WriteLine("Visit us on the web at:");
            WriteLine("www.shoppersworldbargains.com");
            WriteLine("******************************");
        }
    }
}
