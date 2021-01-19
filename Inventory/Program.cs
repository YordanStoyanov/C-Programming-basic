using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            List<string> words = new List<string>(input);
            string commands = Console.ReadLine();

            while (!commands.Contains("Craft!"))
            {
                string[] command = commands.Split(" - ").ToArray();
                string commandName = command[0];
                string item = command[1];
                if (commandName.Contains("Collect"))
                {
                    if (!words.Contains(item))
                    {
                        words.Add(item);
                    }
                }
                else if (commandName.Contains("Drop"))
                {
                    if (words.Contains(item))
                    {
                        words.Remove(item);
                    }
                }
                else if (commandName.Contains("Combine"))
                {
                    string[] items = item.Split(":").ToArray();
                    string oldItem = items[0];
                    string newItem = items[1];
                    if (words.Contains(oldItem))
                    {
                        words.Remove(oldItem);
                        words.Add(newItem);
                    }
                }
                else if (commandName.Contains("Renew"))
                {
                    if (words.Contains(item))
                    {
                        words.Insert(words.Count, item);
                    }
                }
                commands = Console.ReadLine();
            }

            string word = string.Join(", ", words);
            Console.WriteLine(word);
        }
    }
}
