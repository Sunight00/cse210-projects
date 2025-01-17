public class PromptGenerator
{
    public List<string> _prompt = new List<string>();
    _prompt.Add("What was the best part of my day?")

   

    public string GetRandomPrompt()
    {
        Random  rmd = new Random();
        int index = rmd.Next(_prompt.Count);
        
        
        
        return "";



        
    }
}