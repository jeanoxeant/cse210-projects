using System;


public class Journal
{
    public List<Entry> _entries;

    public void AddEntry()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    public void DisplayAll()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {
        
    }
}