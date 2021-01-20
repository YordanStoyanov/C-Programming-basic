using System;
using System.Text;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Travel")
            {
                StringBuilder addString = new StringBuilder();
                if (command.Contains("Add Stop"))
                {
                    string[] parts = command.Split(":");
                    int index = int.Parse(parts[1]);
                    string stateName = parts[2];
                    addString.Append(input);
                    addString.Insert(index, stateName);
                    input = addString.ToString();
                    Console.WriteLine(input);
                }

                if (command.Contains("Remove Stop"))
                {
                    string[] parts = command.Split(":");
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);
                    int lenght = endIndex - startIndex + 1;
                    input = input.Remove(startIndex, lenght);
                    Console.WriteLine(input);
                }

                if (command.Contains("Switch"))
                {
                    string[] parts = command.Split(":");
                    string oldString = parts[1];
                    string newString = parts[2];
                    input = input.Replace(oldString, newString);
                    Console.WriteLine(input);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
