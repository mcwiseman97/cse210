using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Conservice";
        job1._jobTitle = "Team Lead";
        job1._startYear = 2022;
        job1._endYear = 2026;
        

        job1.Display();

        Resume myResume = new Resume();
        myResume._name = "Michael Wiseman";


    }
}