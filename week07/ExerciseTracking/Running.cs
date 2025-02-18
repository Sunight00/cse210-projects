using System.ComponentModel.DataAnnotations;

namespace Sport
{
    public class Running:Sport
{   
    private double _distance;
   
    

    public Running(string date, int length,double distance):base(date,length)
    {
            _distance=distance;
    }


    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance/getduration();
    }
    public override double GetPace()
    {
        return  getduration()/_distance;

    }
}
}