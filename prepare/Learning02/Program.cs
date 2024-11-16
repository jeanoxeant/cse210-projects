using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "SSM Construction";
        job1._jobTitle = "Project Manager";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Constructora Violetta";
        job2._jobTitle = "Civil Engineer";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Shannon Morrow";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
         
    }
    
}