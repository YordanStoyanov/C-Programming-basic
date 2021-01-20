using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            List<string> activeKey = new List<string>();
            activeKey.Add(activationKey);
            string input = Console.ReadLine();

            while (input != "Generate")
            {
                
                string[] typesOfInstructions = input.Split('>').ToArray();
                string instructions = typesOfInstructions[0];

                if (instructions == "Contains")
                {
                    string substring = typesOfInstructions[1];

                    if (activeKey.Contains(substring))
                    {
                        Console.WriteLine($"{string.Join("", activeKey.ToList())} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (instructions == "Flip")
                {
                    string upperOrLower = typesOfInstructions[1];
                    int startIndex = int.Parse(typesOfInstructions[2]);
                    int endIndex = int.Parse(typesOfInstructions[3]);
                    int lenght = endIndex - startIndex;
                    if (upperOrLower == "Upper")
                    {
                        activeKey.Select(X => X.Substring(startIndex, lenght).ToUpper()).ToArray();
                        Console.WriteLine($"{activeKey}");
                    }
                    else if (upperOrLower == "Lower")
                    {
                        activeKey.Select(X => X.Substring(startIndex, lenght).ToLower()).ToArray();
                        Console.WriteLine($"{activeKey}");
                    }
                }
                else if (instructions == "Slice")
                {
                    int startIndex = int.Parse(typesOfInstructions[1]);
                    int endIndex = int.Parse(typesOfInstructions[2]);
                    int count = endIndex - startIndex;
                    activeKey.RemoveRange(startIndex, count);
                    Console.WriteLine($"{activeKey}");
                }
                input = Console.ReadLine();
                if (input == "Generate")
                {
                    Console.WriteLine($"Your activation key is: {activeKey}");
                }
            }
        }
    }
}
