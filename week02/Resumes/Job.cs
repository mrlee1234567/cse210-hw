using System;
using System.Collections.Generic;

class Job
{
    public string _jobTitle;
    public class Year
    {
        public int _year = 0;
        public string GetYear()
        {
            if (_year == 0)
            {
                return "&nan";
            } else
            {
                
                return $"{_year}";
            }
        }
    }
    public Year _startYear = new Year();
    public Year _endYear = new Year();
    public string _company;

    public void AddStart(int year)
    {
        _startYear._year = year;
    }
    public void AddEnd(int year)
    {
        _endYear._year = year;
    }
    
    public void Company(string co)
    {
        _company = co;
    }
    public void Title(string ti)
    {
        _jobTitle = ti;
    }
    
}