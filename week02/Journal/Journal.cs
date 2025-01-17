using System.Data;

public class Journal
{
    public List<Entry> _entries=new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string _prompt=prompt.GetRandomPrompt();
        Console.WriteLine(_prompt);
        
        Entry newEntry = new Entry();
        string response = Console.ReadLine();
        newEntry._entryText=response;
        newEntry._promptText=_prompt;
        _entries.Add(newEntry);
    }
    

    public void DisplayAll()
    {
        foreach(var newEntry in _entries)
        {
            Console.WriteLine("_____");
            newEntry.Display();
        }
        Console.WriteLine("");
    }

    public void SaveToFile (string file)
    {
        
    }

    public void LoadFromFile ( string file)
    {

    }
}