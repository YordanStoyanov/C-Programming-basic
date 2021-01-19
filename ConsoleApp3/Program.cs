using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sum = 0;
            decimal totalSum = 0;
            decimal result = 0;
            decimal taxes = 0;
            while (input != "special" || input != "regular")
            {
                sum = decimal.Parse(input);
                if (sum >= 0)
                {
                    totalSum += sum;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }


                input = Console.ReadLine();
                if (input == "special")
                {
                    result = totalSum + totalSum * (20 / 100);
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine("Price without taxes: {0:f2}$", totalSum);
                    taxes = totalSum * (20 / 100);
                    result -= result * (10 / 100);
                    Console.WriteLine("Taxes: {0:f2}$", taxes);
                    Console.WriteLine("-----------");
                    Console.WriteLine("Total price: {0:f2}$", result);
                }
                else if (input == "regular")
                {
                    result = totalSum + totalSum * (20 / 100);
                    taxes = totalSum * (20 / 100);
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine("Price without taxes: {0:f2}$", totalSum);
                    Console.WriteLine("Taxes: {0:f2}$", taxes);
                    Console.WriteLine("-----------");
                    Console.WriteLine("Total price: {0:f2}$", result);
                }
            }
        }
    }
}
