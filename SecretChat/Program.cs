using System;
using System.Linq;
using System.Collections.Generic;
namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commands = Console.ReadLine();

            while (commands != "Reveal")
            {
                if (commands.Contains("ChangeAll"))
                {
                    string[] parts = commands.Split(":|:");
                    string substring = parts[1];
                    string replacement = parts[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }

                if (commands.Contains("Reverse"))
                {
                    string[] parts = commands.Split(":|:");
                    string substring = parts[1];

                }
            }
        }
    }
}
