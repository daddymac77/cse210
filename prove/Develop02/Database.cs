
class Database
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(DateTime occurs, string text)
{
    entries.Add(new Entry(occurs, text));
}
public List<Entry> FindEntries(DateTime date, bool byTime)
{
    List<Entry> found = new List<Entry>();
    foreach (Entry entry in entries)
    {
        if (((byTime) && (entry.Occurs == date)) // filtered by time and date
        ||
        ((!byTime) && (entry.Occurs.Date == date.Date))) // filtered by date only
            found.Add(entry);
    }
    return found;
}
public void DeleteEntries(DateTime date)
{
    List<Entry> found = FindEntries(date, true);
    foreach (Entry entry in found)
        entries.Remove(entry);
}

}