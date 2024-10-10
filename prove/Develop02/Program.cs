using System;
using System.Diagnostics;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      PromptGenerator promptGenerator = new PromptGenerator();
      Journal theJournal = new Journal();
        
       int action = -1;
       List<string> options = new List<string>();

       options.Add("1.Write");
       options.Add("2.Display");
       options.Add("3.Load");
       options.Add("4.Save");
       options.Add("5.Quite");

        Console.WriteLine("Welcome to the journal program"); 
        do
        {                  
        Console.WriteLine("Please select one of the folowing options ");
                   
        foreach(string option in options)
         {                 
           Console.WriteLine(option);
                
         }
         Console.Write("What would you like to do? ");
          action = int.Parse(Console.ReadLine());
          if (action == 1) 
          {
           string prompt = promptGenerator.GetRandomPrompts(); // Generates 5 random prompts                        
           
          Console.WriteLine("- " + prompt); 
          string entry = Console.ReadLine() ;
          Entry anEntry = new Entry("09/10/2024",prompt,entry );
          theJournal.AddEntry(anEntry);
          }
         else if (action == 2)
          {
            theJournal.DisplayAll();          
        
          }
        else  if (action == 3)
         {
         Console.WriteLine("What is the name of the file you want to load?");
         string file = Console.ReadLine();
         theJournal.LoadFromFile(file);
         } 
         else if (action == 4)
         {
          Console.WriteLine("Write a name for your file");
          string filename = Console.ReadLine();
          theJournal.SaveToFile(filename);
           
         } 
        else if (action == 5)
         {
          Console.WriteLine("The program has finished");
         } 
        else         
        {
          Console.WriteLine("Sorry the option you chosed is not in the menu");
        }

        } while (action != 5);     
        
        
                    
               
        
        
        
        
        

        
    }
}