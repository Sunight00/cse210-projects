namespace Sport
{
    public class Swimming:Sport
    {
   
    private int _laps;
    
    public Swimming(string date, int length, int laps):base(date,length)
    {
            _laps=laps;
    }


    public override double GetDistance()
    {
        return (_laps*50)/1000*0.62;
    }
    public override double GetSpeed()
    {
       return (GetDistance()/getduration())*60;
    }
    public override double GetPace()
    {
        return getduration()/GetDistance();
    }
    }
}