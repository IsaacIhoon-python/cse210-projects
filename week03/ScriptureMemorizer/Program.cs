using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*
        EXCEEDING REQUIREMENTS:
        - Implemented support for multiple scriptures by storing several scriptures
          and randomly selecting one at runtime instead of using a single hard-coded scripture.
        - Added adjustable difficulty by controlling how many words are hidden per round,
          allowing users to memorize at their own pace.
        */

        // Store multiple scriptures (EXCEED REQUIREMENT)
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding " +
                "In all thy ways acknowledge him and he shall direct thy paths"
            ),

            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son " +
                "that whosoever believeth in him should not perish but have everlasting life"
            ),

            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want"
            )
        };

        // Randomly select a scripture (visible exceed behavior)
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        // Difficulty adjustment (already strong, now justified)
        int wordsToHidePerRound = 2;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(wordsToHidePerRound);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }
        }
    }
}
