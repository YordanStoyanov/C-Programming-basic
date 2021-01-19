using System;

namespace Problem1.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());

            int peopleCount = int.Parse(Console.ReadLine());//broi vaprosi

            int totalEmployeeEfficiency = firstEmployeeEfficiency
                + secondEmployeeEfficiency
                + thirdEmployeeEfficiency;//broi otgovori na chas
            // vseki chetvarti chas e pochivka
            int hour = 0;
            
            while (peopleCount > 0)
            {
                peopleCount -= totalEmployeeEfficiency;
                hour++;
                if (hour % 4 == 0)
                {
                    hour++;
                }
            }
            Console.WriteLine("Time needed: {0}h.", Math.Floor((double)hour));//broyat chasove se zakruglya kum po golyamoto cyalo chislo
            
        }
    }
}
