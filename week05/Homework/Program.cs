using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        WritingAssignment writingAssignment1 = new WritingAssignment("Jimbo", "Fiction", "Creative writing");
        WritingAssignment writingAssignment2 = new WritingAssignment("John" , "Science Fiction", "Alien visitation");
        WritingAssignment writingAssignment3 = new WritingAssignment("Jerry" , "Historical Fiction", "Life during the Great Depression");


        MathAssignment mathAssignment1 = new MathAssignment("Marry", "Fractions", "5.2", "1-6");
        MathAssignment mathAssignment2 = new MathAssignment("Maddy", "Arrithmatic", "9.1", "1-3");
        MathAssignment mathAssignment3 = new MathAssignment("Minnie", "Quadratic Formulas", "7.4", "9-23");


    }
}