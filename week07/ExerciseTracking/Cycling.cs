namespace Sport
{
    public class Cycling:Sport
    {
       
        private double _speed;

    

    public Cycling(string date, int length, double speed):base(date,length)
    {
        _speed = speed;       
    }


    public override double GetDistance()
    {
        return (_speed/60)*getduration();   
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60/_speed;

    }   
    }
}