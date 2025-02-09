namespace activity
{
    public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;
        public void Run()
        {
            
        }
        public string GetRandomPrompt()
        {
            _prompts=["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(_prompts.Count());
            
            return _prompts[number];
        }

        public List<string> GetListFromUser()
        {  
            List<string> list =[];
           string input = Console.ReadLine();
           list.Add(input);

                    
                
            return list;
                    
            }
    }
}