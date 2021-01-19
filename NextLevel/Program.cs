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
            int sum = 0;
            int totalNeededExperience = neededExperience;
            for (int i = 0; i < countOfBattles; i++)
            {
                if (sum > totalNeededExperience)
                {
                    Console.WriteLine("Player successfully collected his needed experience for {0} battles.", i);
                    break;
                }

                if (neededExperience < 0)
                {
                    Console.WriteLine("Player was not able to collect the needed experience, {0:f2} more needed.", Math.Abs(neededExperience));
                    break;
                }

                sum += experienceEarnedPerBattle;
                if (i % 3 == 0)
                {
                    experienceEarnedPerBattle *= 15;
                    experienceEarnedPerBattle /= 100;
                    sum += experienceEarnedPerBattle;

                }
                else if (i % 5 == 0)
                {
                    experienceEarnedPerBattle *= 10;
                    experienceEarnedPerBattle /= 100;
                    sum -= experienceEarnedPerBattle;
                }
                else if (i % 15 == 0)
                {
                    experienceEarnedPerBattle *= 5;
                    experienceEarnedPerBattle /= 100;
                    sum += experienceEarnedPerBattle;
                }
                neededExperience -= sum;
                experienceEarnedPerBattle = int.Parse(Console.ReadLine());
            }
        }
    }
}
