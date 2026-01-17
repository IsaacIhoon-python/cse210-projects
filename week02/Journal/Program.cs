using System;

class Program
{
    static void Main(string[] args)
    {
        // In addition to the core requirements, this program addresses a common
        // journaling problem where users are unsure whether their data was saved
        // or loaded successfully. To solve this, clear confirmation message are
        // displayed after saving and loading the journal, reassuring the user
        // that their entries are safe and the action was completed correctly.

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    // Use Entry constructor that matches your Entry.cs
                    Entry entry = new Entry(prompt, response);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.Display();
                    break;
    
                case "3":
                    Console.WriteLine("What is the filename?");
                    string loadFile = Console.ReadLine();
                    journal.Load(loadFile);
                    Console.WriteLine("Journal loaded successfully.");
                    break;

                case "4":
                    Console.Write("What is the filename?");
                    string saveFile = Console.ReadLine();
                    journal.Save(saveFile);
                    Console.WriteLine("Journal saved successfully.");
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }
    }
}