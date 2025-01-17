public class PromptGenerator
{
    public List<string> _prompt = new List<string>();
    

    public string GetRandomPrompt()
    {
        _prompt.Add("What was the best part of your day?");
        _prompt.Add("What was the strongest emotion you felt today?");
        _prompt.Add("Made anyone happy today?");
        Random  rmd = new Random();
        int index = rmd.Next(_prompt.Count);
        string ran=_prompt[index];
        return ran;
  
    }
}