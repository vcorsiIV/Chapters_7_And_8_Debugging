// Program demonstrates overloaded methods
// that display an int, an amount of money, or a string
// decorated with an argument character
// or a default character 'X'
using static System.Console;

namespace DebugEigth4
{
    class Program
    {
        static void Main(string[] args)
        {
            FancyDisplay(33);
            // @ should be a char not a string
            FancyDisplay(44, '@');
            FancyDisplay(55.55);
            FancyDisplay(77.77, '*');
            FancyDisplay("hello");
            FancyDisplay("goodbye", '#');
        }
        //fixed all the FancyDisplay WriteLines to be cleaner

        private static void FancyDisplay(int num, char decoration = 'X')
        {
            //there is no {2}
            WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n",
               decoration, num);
        }
        private static void FancyDisplay(double num, char decoration = 'X')
        {
            WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n",
               decoration, num.ToString("C"));
        }
        //add string infront of word
        private static void FancyDisplay(string word, char decoration = 'X')
        {
            WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n",
               decoration, word);
        }
    }
}
