// Overloaded method gives bonus points
// whether grade is a number or letter
using static System.Console;

namespace DebugEight2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numericScore = 82;
            //B needs to be in quotes
            string letterScore = "B";
            Write("Score was {0}. ", numericScore);
            GiveBonus(ref numericScore);
            WriteLine("Now it is {0}.", numericScore);
            //add {0}
            Write("Grade was {0}. ", letterScore);
            GiveBonus(ref letterScore);
            //add {0}
            WriteLine("Now it is {0}.", letterScore);
        }
        //needs to be ref int not int ref
        private static void GiveBonus(ref int testScore)
        {
            const int BONUS = 5;
            //+=
            testScore += BONUS;
        }
        //ref string
        private static void GiveBonus(ref string letterScore)
        {
            const string BONUS = "+";
            //+=
            letterScore += BONUS;
        }
    }
}
