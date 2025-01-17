public class PromptGenerator
{
    public List<string> _prompt = new List<string>();
    

   

    public string GetRandomPrompt()
    {
        _prompt.Add("What was the best part of my day?");
        _prompt.Add("What was the best part of my day?");

        Random  rmd = new Random();
        int index = rmd.Next(_prompt.Count);
        string ran=_prompt[index];
        return ran;
  
    }
}