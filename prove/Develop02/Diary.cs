class Diary
{
     private Database database;

    public Diary()
    {
        database = new Database();
    }
private DateTime ReadDateTime()
{
    Console.WriteLine("Enter date and time as e.g. 27/01/2023:");
    DateTime dateTime;
    while (! DateTime.TryParse(Console.ReadLine(), out dateTime))
        Console.WriteLine("Error. Please try again: ");
    return dateTime;
}
public void PrintEntries(DateTime day)
{
    List<Entry> entries = database.FindEntries(day, false);
    foreach (Entry entry in entries)
        Console.WriteLine(entry);
}
public void AddEntry()
{
    DateTime dateTime = DateTime.Now;
    Console.WriteLine("Enter the entry text:");
    string text = Console.ReadLine();
    database.AddEntry(dateTime, text);
}
public void SearchEntries()
{
    // Entering the date
    DateTime dateTime = ReadDateTime();
    // Searching for entries
    List<Entry> entries = database.FindEntries(dateTime, false);
    // Printing entries
    if (entries.Count() > 0)
    {
        Console.WriteLine("Entries found: ");
        foreach (Entry entry in entries)
            Console.WriteLine(entry);
    }
    else
        // Nothing found
        Console.WriteLine("No entries were found.");
}
public void DeleteEntries()
{
    Console.WriteLine("Entries with the same exact date will be deleted");
    DateTime dateTime = ReadDateTime();
    
    database.DeleteEntries(dateTime);
}
public void PrintHomeScreen()
{
    Console.Clear();
    Console.WriteLine("Dear diary!");
    Console.WriteLine("Today is: {0}", DateTime.Now);
    Console.WriteLine();
    // printing the home screen
}

}