using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('!').ToArray();
            List<string> items = new List<string>();
            items = input.ToList();
            string commandAndItem = Console.ReadLine();

            while (commandAndItem != "Go Shopping!")
            {
                string[] comandIt = commandAndItem.Split(' ');
                string command = comandIt[0];
                string item = comandIt[1];
                if (command == "Urgent")
                {
                    if (!input.Contains(item))
                    {
                        items.Add(item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (input.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    if (input.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                }
                else if (command == "Rearrange")
                {
                    if (input.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                    
                }
                commandAndItem = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
