using System;

class Program
{
    static void Main(string[] args)
    {
        // The program hides ONLY words that are not
        // already hidden, preventing wasted attempts.
        // The number of words hidden per round is
        // adjustable (difficult control), helping 
        // users memorize at their own pace.
        // The design supports swapping or expanding
        // to multiple scriptures easily.


        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the lord with all thine heart and lean not unto thine own understanding " +
                        "In all thy ways acknowledge him and he shall direct thy paths";
                    
        Scripture scripture = new Scripture(reference, text);

        int wordsToHidePerRound = 2; // Difficulty adjustment

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press ENter to hide words or type 'quit' to exit: ");

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