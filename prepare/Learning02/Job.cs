using System;

public class Job
{
    
    public string _jobTitle;
    public string _nameOfCompany;
    public int _startYear;
    public int _endYear;  
    

    
    public void Display() 
    {
        Console.WriteLine($"{_jobTitle} {_nameOfCompany}  {_startYear} to {_endYear}");
    }
}
