using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededExperience = int.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            int experienceEarnedPerBattle = 0;
            double sum = 0;
            double totalNeededExp = (double)neededExperience;
            double result = 0;
            for (int i = 0; i < countOfBattles; i++)
            {

                if (sum > totalNeededExp)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    break;
                }

                if (result < 0)
                {
                    Console.WriteLine($"Player was not able to collect the needed experience," +
                        $" {Math.Abs(neededExperience):f2} more needed.");
                    break;
                }

                sum += (double)experienceEarnedPerBattle;
                if (i % 3 == 0)
                {
                    sum += (double)experienceEarnedPerBattle * (double)0.15;
                }
                else if (i % 5 == 0)
                {
                    sum -= (double)experienceEarnedPerBattle * (double)0.1;
                }
                else if (i % 15 == 0)
                {
                    sum += (double)experienceEarnedPerBattle * (double)0.05;
                }
                result = (double)neededExperience - sum;
                experienceEarnedPerBattle = int.Parse(Console.ReadLine());
            }
        }
    }
}
