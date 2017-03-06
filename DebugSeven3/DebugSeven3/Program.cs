// Program gets a quanity ordered from user
// then determines price and discount based on quantity
// price per item before discounts is $6.00
// order 15 or more, get a 20% discount
// order 10 to 14 - get a 14% discount
// order 5 to 9, get a 10% discount
using System;
using static System.Console;

namespace DebugSeven3
{
    class Program
    {
        static void Main()
        {
            int quantity;
            double price;
            quantity = GetQuantity();
            price = CalculatePrice(quantity);
            WriteLine("Final price for {0} items is {1}.",
              quantity, price.ToString("c"));
        }
        //needs to return
        private static int GetQuantity()
        {
            int quan;
            Write("Enter number of items >> ");
            quan = Convert.ToInt32(ReadLine());
            return quan;
        }
        //add static and make this method a double
        private static double CalculatePrice(int quantityOrdered)
        {
            double PRICE_PER_ITEM = 6.00;
            double price = 0;
            double discount = 0;
            //needs the } on the ends to fix
            int[] quanLimits = { 0, 5, 10, 15 };
            double[] limits = { 0, 0.10, 0.14, 0.20 };
            //changing for loop setup so it works my way:
            for (int x = 0 ; x <= limits.Length - 1; ++x)
            {
                //change limits to quanLimits
                if (quantityOrdered >= quanLimits[limits.Length - 1])
                {
                    discount = limits[limits.Length - 1];
                    break;
                }

                else if (quantityOrdered >= quanLimits[x + 1] && quantityOrdered < quanLimits[x + 2])
                {
                    discount = limits[x + 1];
                    break;
                }

                else
                    discount = limits[0];
            }
            
            //x=0 not needed
            //x = 0;
            price = quantityOrdered * PRICE_PER_ITEM;
            price = price - price * discount;
            return price;
        }
    }
}
