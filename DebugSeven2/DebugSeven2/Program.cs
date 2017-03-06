// Address an envelope one of two ways
// Using zip code, or using city and state
using static System.Console;

namespace DebugSeven2
{
    class Program
    {
        static void Main()
        {
            string addressee = "Ms. Brooke Jefferson";
            int zipCode = 60007;
            string cityAndState = "Elk Grove, IL";
            AddressMethod(addressee, zipCode);
            WriteLine("-----------------------");
            AddressMethod(addressee, cityAndState);
            WriteLine("-----------------------");
        }
        //add int num to the method to fix zipCode error above
        private static void AddressMethod(string person, int num)
        {
            WriteLine("To : {0}", person);
            //add a comma after quotes
            WriteLine("Zip: {0}",  num);
        }
        // make city a string type
        private static void AddressMethod(string person, string city)
        {
            WriteLine("To : {0}", person);
            //add quotes to fix errors
            WriteLine("{0}", city);
        }
    }
}
