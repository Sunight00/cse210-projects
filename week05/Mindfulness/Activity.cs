namespace activity
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
            Console.Write($"Welcome to the {_name}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{_name}: {_description}");
            Console.WriteLine();
        }
        public void DisplayEndingMessage()
        {   
            Console.WriteLine("Well done.");
            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed {_duration} seconds of {_name}");
        }

        public void ShowSpinner(int seconds)
        {
        List<string> spinners = new List<string>();
        spinners = ["|", "/", "-", "\\"];
       
        int i = 0;
        double futureTime = seconds;
        double currentTime = 0;
        while (currentTime < futureTime)
        {
            Console.Write(spinners[i]);
            Thread.Sleep(1000);
            currentTime += 1;
            Console.Write("\b \b");
 
            i++;
 
            if (i >= spinners.Count)
            {
                i = 0;
            }
        }
           /* DateTime currenTime = DateTime.Now;
            DateTime futureTime = currenTime.AddSeconds(seconds);
            Console.WriteLine(futureTime);
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currenTime);

            List<string> spinners = new List<string>();
            spinners=["|","/","-","\\","|","/","-","//","|","/","-","\\","|","/","-","//","//","|","/","-","\\","|","/","-","//","//","|","/","-","\\","|","/","-","//"];
            foreach(string spinner in spinners)
            {
                Console.Write(spinner);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

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
                }*/
            }

        
        /*public void ShowCountDown(int second)
        {
            List<int> countDown = [4,3,2,1];
            {

                foreach(int n in countDown)
                {
                    Console.Write(n);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    
                }
                
            }
        }*/


        public void ShowCountDown(int second)
        {
            int n = 0;
            int seconds = second;
            {
                while(n!=second)
                {
                    Console.Write(seconds);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    seconds-=1;
                    n+=1;  
                }
            }
            /*List<int> countDown = [4,3,2,1];
            {

                foreach(int n in countDown)
                {
                    Console.Write(n);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    
                }
                
            }*/
        }

        public int GetDuration()
        {
            return _duration;
        }
    }
}