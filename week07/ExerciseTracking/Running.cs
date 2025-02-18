namespace Sport
{
    public class Running:Sport
{   
    private double _distance;
   
    

    public Running(string date, int length,double distance):base(date,length)
    {
            _distance=distance;
    }


    public override void GetDistance()
    {
        
    }
    public override void GetSpeed()
    {

    }
    public override void GetPace()
    {


    }
}
}