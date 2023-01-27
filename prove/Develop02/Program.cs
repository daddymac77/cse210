using System;

class Program {
static void Main(string[] args)
{
    // diary instance
    Diary diary = new Diary();
    char choice = '0';
    // main loop
    while (choice != '5')
    {
        diary.PrintHomeScreen();
        Console.WriteLine();
        Console.WriteLine("Choose an action:");
        Console.WriteLine("1 - Add a Journal entry");
        Console.WriteLine("2 - Search for Journal entries");
        Console.WriteLine("3 - Delete Journal entries");
        Console.WriteLine("4 - Ask for suggestions in diary entry");
        Console.WriteLine("5 - End");
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
                diary.DeleteEntries();
                break;
            case '4':
                var randomHelp = HelpDesk.GenerateSuggestion();
                Console.WriteLine(randomHelp);
                break;
            case '5':
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
