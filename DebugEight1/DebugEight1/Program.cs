// GetData() method accepts order number and quantity
// that are used in the Main() method
// Price is $3.99 each
using System;
using static System.Console;

namespace DebugEight1
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderNum, quantity;
            double total;
            const double PRICE_EACH = 3.99;
            //No values are in orderNum and quantity so out is required to set values
            GetData(out orderNum, out quantity);
            // "_" in Price_Each
            total = quantity * PRICE_EACH;
            WriteLine("Order #{0}. Quantity ordered = {1}",
                orderNum, quantity);
            WriteLine("Total is {0}", total.ToString("C"));
        }
        //set to ints
        private static void GetData(out int order, out int amount)
        {
            String s1, s2;
            Write("Enter order number ");
            s1 = ReadLine();
            Write("Enter quantity ");
            s2 = ReadLine();
            order = Convert.ToInt32(s1);
            amount = Convert.ToInt32(s2);
        }
    }
}
