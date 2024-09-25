using System;
using System.Collections.Generic;

class Program
{
   static void Main(string[] args)
  {   
    
     List<int> numbers = new List<int>();
     int response = -1;
     do
     {
         Console.Write("Enter a number and type 0 when finished ");
         response = int.Parse(Console.ReadLine());

         if (response != 0)
         {
          numbers.Add(response);
         }

     } while (response != 0);     
     

      
      
      if (response != 0)
      {
        numbers.Add(response);
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
      Console.WriteLine($"The average is: {average}");

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
