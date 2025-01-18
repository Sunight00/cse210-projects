using System.Data;
using System.IO;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Text;

public class Journal
{
    public List<Entry> _entries=new List<Entry>();
    List<string> myEntry = new List<string>();

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

        // my way out 
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        myEntry.Add($"Date,{date}");
        myEntry.Add($"Prompt,{_prompt}");
        myEntry.Add($"Response,{response}");
        myEntry.Add("");
        
    }
    

    public void DisplayAll()
    {
        foreach(var newEntry in _entries)
        {
            Console.WriteLine($"______________");
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
        Console.Write("Where would you save file: ");
        string path = Console.ReadLine();
        Console.WriteLine("");
        if (path == "1")
        {
             path = $@"c:\Users\RUKN AL BAB\Desktop\{file}.txt";
             using (FileStream fs = File.Create(path));

             using (StreamWriter outputFile = new StreamWriter(path))
             {
                foreach(string entry in myEntry)
                {
                    outputFile.WriteLine(entry);
                }
             }
        }
        else if ( path == "2")
        {
            path = $@"c:\Users\RUKN AL BAB\Documents\{file}.txt";
             using (StreamWriter outputFile = new StreamWriter(path))
             {
                foreach(string entry in myEntry)
                {
                    outputFile.WriteLine(entry);
                }
             }

        }
    }
    public void LoadFromFile ( string file)
    {
        Console.WriteLine("1.Desktop");
        Console.WriteLine("2.Document");
        Console.Write("Load File From;");
        string path = Console.ReadLine();

        if (path == "1")
        {
            path = $@"c:\Users\RUKN AL BAB\Desktop\{file}.txt";
        }
    }
}