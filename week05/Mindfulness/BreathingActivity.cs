using System.IO.Compression;

namespace activity
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
        {

        }
        public void Run()
        {
            DateTime n = DateTime.Now;
            Console.WriteLine(n);
            DateTime q = n.AddSeconds(GetDuration());
            Console.WriteLine(q);
            while (DateTime.Now<q)
            {
                Console.WriteLine($"Breath in...");
                ShowCountDown(1);

                Console.WriteLine($"Breath in...");
                ShowCountDown(1);

                Console.WriteLine();
                Console.WriteLine();
            }
 

       
        }
    }
}