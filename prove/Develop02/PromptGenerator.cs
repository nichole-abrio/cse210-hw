using System;
using System.Collections.Generic;

public class Prompt
{
    public static List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "List 3 things that inspired or motivated you today. ",
        "What made you feel the most peaceful today?",
        "What surprised you the most today?",
        "What are your goals for the day? Did you accomplish them?",

    };

    //generate random no. within the range of no. of items in the list _prompts
    int _generateNumber()
    {
        Random n = new Random();
        int number = n.Next(0, _prompts.Count);
        return number;
    }

    public string promptOfTheDay()
    {
        int ranNo = _generateNumber();
        return _prompts[ranNo];
    }

    public string DisplayPrompt()
    {
        string p = promptOfTheDay();
        Console.WriteLine(p);
        return p;
    }





}