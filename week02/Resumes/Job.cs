public class Job
{
    public string _company ="";
    public string _jobTile ="";
    public int _startYear =0;
    public int _endYear =0;

    public Job()
    {}
    public void display()
    {
        Console.WriteLine($"{_jobTile} ({_company}) {_startYear}-{_endYear}");
    }
    
}