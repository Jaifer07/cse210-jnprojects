using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage ");
        string gradeFromUser = Console.ReadLine();

        int gradePercentage = int.Parse(gradeFromUser);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter ="D";
        }
        else 
        {
            letter = "F";
        }   
        
        Console.WriteLine($"Your grade is {letter}");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! you pass the class");
        }
        else
        {
            Console.WriteLine("Sorry you did'nt pass the class.We encourage you to improve.");
        }
    }
}