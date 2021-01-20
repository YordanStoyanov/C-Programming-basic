using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TheImitationGame
{
    class Program
    {
        public static object StringBuilred { get; private set; }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string message = Console.ReadLine();
            while (message != "Decode")
            {
                StringBuilder moveElements = new StringBuilder();
                if (message.Contains("Move"))
                {
                    string[] parts = message.Split("|");
                    int moveNumberOfElements = int.Parse(parts[1]);
                    string newWord = input;
                    moveElements.Append(input);
                    moveElements.Remove(0, moveNumberOfElements);
                }
                message = Console.ReadLine();
            }
        }
    }
}
/*
zzHe
Move|3
Decode

 */
