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
            Console.WriteLine($"{_name}: {_description}. Time: {_duration}");
        }
        public void DisplayEndingMessage()
        {

        }
        public void ShowSpinner(int seconds)
        {

        }
        public void ShowCountDown(int second)
        {

        }
    }
}