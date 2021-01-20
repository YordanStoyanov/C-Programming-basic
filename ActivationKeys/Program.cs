using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string instructions = Console.ReadLine();

            while (instructions != "Generate")
            {
                if (instructions.Contains("Contains"))
                {
                    string[] parts = instructions.Split(">>>");
                    string substring = parts[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                if (instructions.Contains("Flip"))
                {
                    string[] parts = instructions.Split(">>>");
                    string upperLower = parts[1];
                    int startIndex = int.Parse(parts[2]);
                    int endIndex = int.Parse(parts[3]);
                    string firtsPart = input.Substring(0, startIndex);
                    string secondPart = input.Substring(startIndex, endIndex - startIndex);
                    string thirdPart = input.Substring(endIndex);

                    if (upperLower == "Upper")
                    {
                        secondPart = secondPart.ToUpper();
                    }
                    else
                    {
                        secondPart = secondPart.ToLower();
                    }
                    input = firtsPart + secondPart + thirdPart;
                    Console.WriteLine(input);
                }

                if (instructions.Contains("Slice"))
                {
                    string[] parts = instructions.Split(">>>");
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);
                    int count = endIndex - startIndex;
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }

                instructions = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}


