public class PromptGenerator
{
    public List<string> _prompt = new List<string>();
    

    public string GetRandomPrompt()
    {
        _prompt.Add("What was the best part of your day?");
        _prompt.Add("What was the strongest emotion you felt today?");
        _prompt.Add("Made anyone happy today?");
        _prompt.Add("How did you see the hand of the Lord in my life today?");
        _prompt.Add("Who was the most interesting person you interacted with today?");
        _prompt.Add("What do you think you can do better from today?");

        Random  rmd = new Random();
        int index = rmd.Next(_prompt.Count);
        string randomPrompt=_prompt[index];
        return randomPrompt;
    }
}