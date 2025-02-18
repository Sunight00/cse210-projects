namespace Sport
{
    public abstract class Sport
    {
        private int _length;
        private string _date;
            

        public Sport(string date, int length)
        {
            _date=date;
            _length=length;
        }

        public void setDistance( )
        {

        }

        public void displayDate()
        {
            Console.WriteLine(_date);
        }

        public abstract void GetDistance();
        public abstract void GetSpeed();
        public abstract void GetPace();


        public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }


    }
}