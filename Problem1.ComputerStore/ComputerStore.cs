using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.ComputerStore
{
    public class ComputerStore
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            
            decimal totalPrice = 0m;
            decimal taxes = 0m;
            while (true)
            {
                if (input.Contains("regular"))
                {
                    Console.WriteLine("Invalid order!");
                    break;
                }
                decimal newPrice = decimal.Parse(input);
                if (newPrice > 0)
                {
                    totalPrice += newPrice;
                    
                }
                else if (newPrice == 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
                input = Console.ReadLine();

                if (input.Contains("special") || input.Contains("regular"))
                {
                    
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                    taxes = totalPrice * (20m / 100m);
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    totalPrice += taxes;
                    if (totalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                    }


                    if (input.Contains("special"))
                    {
                        totalPrice = totalPrice - totalPrice * (10m / 100m);
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}$");
                    break;
                }
            }
            
        }
    }
}
