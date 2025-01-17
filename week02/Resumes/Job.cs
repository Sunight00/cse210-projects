using System;
public class Job
{
    public string _company ="";
    public string _jobTile ="";
    public int _startYear =0;
    public int _endYear =0;
    internal string _jobTitle;

    public Job()
    {}
    public void display()
    {
        Console.WriteLine($"{_jobTile} ({_company}) {_startYear}-{_endYear}");
    }
}
