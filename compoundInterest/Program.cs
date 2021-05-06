using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is a compound interest calculator. \nPlease enter the interest rate as a number: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            interestRate = (interestRate/100);            
            Console.Write("Please enter the amount of years you want to save for: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now please enter the amount you want to save: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            int years1 = years;
            while (years != 0)
            {
                amount = amount + (amount*interestRate);
                years--;
            }
            amount = Math.Round(amount, 2);
            Console.WriteLine($"Your value after {years1} years is {amount}");
            Console.ReadLine();



        }
    }
}
