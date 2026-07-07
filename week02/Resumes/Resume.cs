using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Resume
{
    public string _fName = "John";
    public string _lName = "Doe";
    // public string _mName = "";
    public List<Job> _jobList = new List<Job>();

    public void Add(string jobName, string company)
    {
        Job toad = new Job();
        toad.Title(jobName);
        toad.Company(company);
        _jobList.Add(toad);
    }
    // this little trick i learned whilst trying to learn cs previously
    public void Add(string jobName, string company, int startYear)
    {
        Job toad = new Job();
        toad.Title(jobName);
        toad.Company(company);
        toad.AddStart(startYear);
        _jobList.Add(toad);
    }

    public void Add(string jobName, string company, int startYear, int endYear)
    {
        Job toad = new Job();
        toad.Title(jobName);
        toad.Company(company);
        toad.AddStart(startYear);
        toad.AddEnd(endYear);
        _jobList.Add(toad);
    }

    public void Print()
    {
        string namePrint = $"Name: {_fName} {_lName}\nJobs:";
        // if (string.IsNullOrEmpty(_mName))
        // {

    // } else
    //     {
    //         namePrint = $"{_fName} {_mName} {_lName}";
    //     }
        Console.WriteLine(namePrint);
        namePrint = "";
        foreach (Job i in _jobList)
        {
            
            string jub = $"{i._jobTitle} ({i._company})";
            string sYear = i._startYear.GetYear();
            string eYear = i._endYear.GetYear();
            if (sYear != "&nan")
            {
                jub += $" {sYear}-";
                if (eYear != "&nan")
                {
                    jub += eYear;
                }
            }
            Console.WriteLine(jub);
        }
    }
}