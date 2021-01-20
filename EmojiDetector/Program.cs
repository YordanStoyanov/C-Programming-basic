using System;
using System.Linq;
using System.Collections.Generic;
namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //Dictionary<string, int> emojis = new Dictionary<string, int>();
            string[] emoji = input.Split().ToArray();
            int multiplyNumbers = 1;
            int charNumber = 1;
            int intNumber = 1;
            int realNumber = 1;
            int emojiNumber = 1;
            int emojiSum = 1;
            int countOfEmojis = 0;
            foreach (char item in input)
            {
                //Console.WriteLine((int)item);
                charNumber = (int)item;
                //Console.WriteLine(charNumber);
                if (charNumber >= 48 && charNumber <= 57)
                {
                    intNumber = int.Parse(item.ToString());
                    multiplyNumbers *= intNumber;
                }
            }
            Console.WriteLine($"Cool threshold: {multiplyNumbers}");

            for (int i = 0; i < emoji.Length; i++)
            {
                if (emoji[i].Contains("::") || emoji[i].Contains("**"))
                {
                    foreach (char item in emoji[i])
                    {
                        emojiNumber = (int)item;
                        emojiSum += emojiNumber;
                    }

                    if (emojiSum > multiplyNumbers)
                    {
                        countOfEmojis++;
                        Console.WriteLine(emoji[i]);
                    }
                }
            }

            Console.WriteLine($"{countOfEmojis} emojis found in the text. The cool ones are:");
            ;
        }
    }
}
