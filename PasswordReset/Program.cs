using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                StringBuilder oddChars = new StringBuilder();
                if (command.Contains("TakeOdd"))
                {
                    for (int i = 1; i < input.Length; i+=2)
                    {
                        oddChars.Append(input[i]);
                    }
                    input = oddChars.ToString();
                    Console.WriteLine(input);
                }

                if (command.Contains("Cut"))
                {
                    string[] splitted = command.Split();
                    int index = int.Parse(splitted[1]);
                    int lenght = int.Parse(splitted[2]);
                    input = input.Remove(index, lenght);
                    Console.WriteLine(input);
                }

                if (command.Contains("Substitute"))
                {
                    string[] splitted = command.Split();
                    string substring = splitted[1];
                    string substitute = splitted[2];
                    if (!input.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        input = input.Replace(substring, substitute);
                        Console.WriteLine(input);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}

/*
Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr 
TakeOdd
Cut 15 3
Substitute :: -
Substitute | ^
Done
 */
