using System;

public class HelpDesk 
{
    private static string[] helpInEntry = {"What special thing happened to you today?", "Something inspiring that you read today.", "Write about how you felt helping someone topay.", "Write something you overcome today.", "Report on your goals status. "};

    public static string GenerateSuggestion() 
    {
        var rand = new Random();
        string randomSuggestion = helpInEntry[rand.Next(helpInEntry.Length)];
        return $"{randomSuggestion}";
    }
}