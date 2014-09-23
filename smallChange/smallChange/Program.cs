using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smallChange
{
    class Program
    {
        static void Main(string[] args)
        {

            //Assign variables
            double subTotal = 0; //Amount of the product.
            uint totalSum = 0; //customer pay.
            double roundingOffAmount; //Rounded.
            uint moneyBack = 0; //Money back.
            uint total ; // Subtotal rounded
            uint dividedAmount; //Divide to the diffrent notes and coins.

            while (true)
            {
                try
                {
                    Console.Write("Enter the total amount:"); //Collect the total sum of the product.
                    subTotal = double.Parse(Console.ReadLine());
                    // If the cost of the product costs less than 0.49 then close the program. If over thn continue
                    if (subTotal < 0.49)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The sum is too small!");
                        Console.ResetColor();
                        return;
                    }
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Wrong amount!");
                    Console.ResetColor();
                }
            }

            //Calculate rounding.
            total = (uint)Math.Round(subTotal);
            roundingOffAmount = total - subTotal;

            while (true)
            {
                try
                {
                    Console.Write("Enter the amount received:");
                    totalSum = uint.Parse(Console.ReadLine());
                    // If someone pay less than the products cost then close program(false)...if correct continue    
                    if (totalSum < total)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("The amount is less than the price for the product.");
                        Console.ResetColor();
                        return;
                    }
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Wrong amount!");
                    Console.ResetColor();
                }
            }

            //Money back cal...
            moneyBack = totalSum - total;
            //Results
            Console.Write(" KVITTO ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Total        =   {0:c}",
                subTotal);
            Console.WriteLine("Rounding     =   {0:c}",
                roundingOffAmount);
            Console.WriteLine("To pay       =   {0:C0}",
                subTotal);
            Console.WriteLine("Cash         =   {0:c}",
                totalSum);
            Console.WriteLine("Money back   =   {0:C0}",
                moneyBack);
            Console.WriteLine("-----------------------");

            dividedAmount = moneyBack / 500;
            if (dividedAmount > 0)
            {
                Console.WriteLine("500 crown notes\t\t= {0}",
                    dividedAmount);
            }
            moneyBack %= 500;

            dividedAmount = moneyBack / 100;
            if (dividedAmount > 0)
            {
                Console.WriteLine("100 crown notes\t\t= {0}",
                    dividedAmount);
            }
            moneyBack %= 100;

            dividedAmount = moneyBack / 50;
            if (dividedAmount > 0)
            {
                Console.WriteLine("50 crown notes\t\t= {0}",
                    dividedAmount);
            }
            moneyBack %= 50;

            dividedAmount = moneyBack / 20;
            if (dividedAmount > 0)
            {
                Console.WriteLine("20 crown notes\t\t= {0}",
                    dividedAmount);
            }
            moneyBack %= 20;

            dividedAmount = moneyBack / 10;
            if (dividedAmount > 0)
            {
                Console.WriteLine("10 crown coins\t\t= {0}",
                    dividedAmount);
            }
            moneyBack %= 10;

            dividedAmount = moneyBack / 5;
            if (dividedAmount > 0)
            {
                Console.WriteLine("5 crown coins\t\t= {0}",
                    dividedAmount);
            }
            moneyBack %= 5;

            dividedAmount = moneyBack;
            if (dividedAmount > 0)
            {
                Console.WriteLine("1 crown coins\t\t= {0}",
                    dividedAmount);
            }
        }
    }
}
