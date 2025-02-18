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


        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public int getduration()
        {
            return _length;
        }

        public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }


    }
}