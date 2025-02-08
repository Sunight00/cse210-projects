namespace sport
{
    public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        public Activity(string name, string discription, int duration)
        {
            _name = name;
            _description=discription;
            _duration = duration;
        }
        public Activity()
        {

        }
        public void DisplayStartingMessage()
        {
            Console.WriteLine($"{_name}: {_description} Time: {_duration}");
        }
        public void DisplayEndingMessage()
        {
            Console.WriteLine("Congrats you've done a good job.");
        }
        public void ShowSpinner(int seconds)
        {
            DateTime currenTime = DateTime.Now;
            DateTime futureTime = currenTime.AddSeconds(_duration);

            List<string> spinners = new List<string>();
            spinners=["|","/","-","\\","|","/","-","//"];
            foreach(string spinner in spinners)
            {
                Console.Write(spinner);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }
        public void ShowCountDown(int second)
        {
            
        }
    }
}