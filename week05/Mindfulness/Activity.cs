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
            DateTime futureTime = currenTime.AddSeconds(seconds);
            Console.Write(seconds);

            List<string> spinners = new List<string>();
            spinners=["|","/","-","\\","|","/","-","//"];
            /*foreach(string spinner in spinners)
            {
                Console.Write(spinner);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }*/

            int i = 0;
            while (currenTime < futureTime)
            {
                Console.Write(spinners[i]);
                Thread.Sleep(1000); 
                Console.Write("\b \b");

                i++;

                if (i >= spinners.Count())
                {
                    i=0;
                }
            }

        }
        public void ShowCountDown(int second)
        {
            
        }
    }
}