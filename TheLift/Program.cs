using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            //20
            //0 2 0

            int numberOfPeople = int.Parse(Console.ReadLine());
            int[] numberOfWagons = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < numberOfWagons.Length; i++)
            {
                if (numberOfWagons[i] > 0)
                {
                    numberOfPeople -= numberOfWagons[i];
                    if (numberOfWagons[i] == 0)
                    {
                        numberOfWagons[i] += 4;
                    }
                    else if (numberOfWagons[i] == 1)
                    {
                        numberOfWagons[i] += 3;
                    }
                    else if (numberOfWagons[i] == 2)
                    {
                        numberOfWagons[i] += 2;
                    }
                    else if (numberOfWagons[i] == 3)
                    {
                        numberOfWagons[i] += 1;
                    }
                }

                if (numberOfWagons[i] == 0)
                {
                    numberOfWagons[i] += 4;
                    numberOfPeople -= 4;
                }
                else if (numberOfWagons[i] == 1)
                {
                    numberOfWagons[i] += 3;
                    numberOfPeople -= 3;
                }
                else if (numberOfWagons[i] == 2)
                {
                    numberOfWagons[i] += 2;
                    numberOfPeople -= 2;
                }
                else if (numberOfWagons[i] == 3)
                {
                    numberOfWagons[i] += 1;
                    numberOfPeople -= 1;
                }

                if (numberOfPeople <= 0)
                {
                    numberOfWagons[i] += numberOfPeople;
                    Console.WriteLine("The lift has empty spots!");
                }
            }

            if (numberOfPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {numberOfPeople} people in a queue!");
            }

            foreach (var item in numberOfWagons)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
