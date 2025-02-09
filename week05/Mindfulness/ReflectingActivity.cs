namespace activity
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity()
        {
            _prompts=["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
        }
        public void Run()
        {

        }
        public string GetRandomPrompt()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(_prompts.Count());
            
            return _prompts[number];
        }
        public string GetRandomQuestion()
        {
            return "";
        }
        public void DisplayPrompt()
        {

        }
        public void DisplayQuestions()
        {

        }
    }
}