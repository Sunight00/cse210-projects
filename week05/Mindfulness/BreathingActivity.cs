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
            DateTime q = DateTime.Now.AddSeconds(10);
            Console.WriteLine(q);
            int x = GetDuration(); 
            Console.WriteLine(x);         
       
        }
    }
}