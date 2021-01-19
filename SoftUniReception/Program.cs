using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirthEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int totalEmployeesAnsweredPerHour =
                firstEmployee + secondEmployee + thirthEmployee;
            double hours = 0;
            int count = 0;
            while (studentsCount >= 0)
            {
                studentsCount -= totalEmployeesAnsweredPerHour;
                hours++;
                count++;
                if (count % 3 == 0)
                {
                    hours += 1;
                }
            }
            hours = Math.Floor(hours);
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
