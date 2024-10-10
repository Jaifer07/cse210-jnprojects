
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the espiritual experience that I had today?",
        "Thinking about I did today ¿What have I to improve? ",
        "What was the remarkable thing I did today?",
        "I give my time and service to someone in need?",
        "What things I feel gratefull today for?"
        
    };

    

    public string GetRandomPrompts()
    {
       Random Random = new Random();   
       
        
            int randomIndex = Random.Next(_prompts.Count);
            
           string randomPrompts = _prompts[randomIndex];
        

        return randomPrompts;
    }
}
