using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please provide your current grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int percent = int.Parse(gradePercentage);

        int endNumber = 0;
        string grade = "";
        string sign = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80){
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F" ;
        }

        endNumber = percent % 10;
        if (endNumber >= 7)
        {
            sign = "+";
        }
        else if (endNumber <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your current grade is a(n) {grade}{sign}");

    }
}
