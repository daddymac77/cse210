using System;

class Program {
static void Main(string[] args)
{
    // diary instance
    Diary diary = new Diary();
    char choice = '0';
    // main loop
    while (choice != '4')
    {
        diary.PrintHomeScreen();
        Console.WriteLine();
        Console.WriteLine("Choose your action carefully!!:");
        Console.WriteLine("1 - Add a Journal entry");
        Console.WriteLine("2 - Search for Journal entries");
        Console.WriteLine("3 - Ask for suggestions");
        Console.WriteLine("4 - End");
        choice = Console.ReadKey().KeyChar;
        Console.WriteLine();
        // reaction to the choice
        switch (choice)
        {
            case '1':
                diary.AddEntry();
                break;
            case '2':
                diary.SearchEntries();
                break;
            case '3':
                var randomHelp = HelpDesk.GenerateSuggestion();
                Console.WriteLine(randomHelp);
                break;
            case '4':
                Console.WriteLine("Press any key to quit the program...");
                break;
            default:
                Console.WriteLine("Error. Press any key to choose another action.");
                break;
        }
        Console.ReadKey();
    }
}
}
