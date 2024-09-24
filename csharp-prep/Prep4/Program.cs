using System;
using System.Collections.Generic;

class Program
{
   static void Main(string[] args)
  {   
    Console.WriteLine("Enter a list of numbers, type 0 when finished"); 

     List<int> numbers = new List<int>();
     int response = -1;
     do
     {
         Console.Write("Enter a number ");
         response = int.Parse(Console.ReadLine());
     } while (response != 0);     
     

      for (int i = 0; i < numbers.Count; i++)
      {
      Console.WriteLine(numbers[i]);
      }
      
      // Computing the sum 

      int sum = 0;
      foreach (int number in numbers)
      {
        sum += number;        
      }

     Console.WriteLine($"The sum is {sum}"); 

     //Calculating the average

     float average = ((float)sum) / numbers.Count;
     Console.Writeline($"The average is: {average}");

     int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max number is: {max}");
  }
}
