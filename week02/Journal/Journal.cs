using System.Data;
using System.IO;
using System.Text;

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
        Console.WriteLine("");
        Console.WriteLine("Choose File Location");
        Console.WriteLine("1.Desktop");
        Console.WriteLine("2.Document");
        Console.WriteLine("Where would you save file: ");
        string path = Console.ReadLine();
        if (path == "1")
        {
             path = $@"c:\Users\RUKN AL BAB\Desktop\{file}";
             using (FileStream fs = File.Create(path));
        }
        else if ( path == "2")
        {
            path = $@"c:\Users\RUKN AL BAB\Documents\{file}";
             using (FileStream fs = File.Create(path));
        }
    }

    public void LoadFromFile ( string file)
    {

    }
}