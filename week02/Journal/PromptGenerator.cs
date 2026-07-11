using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    private Random _random;
    private string _lastPrompt;

    public PromptGenerator()
    {
        _random = new Random();
        _lastPrompt = "";
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today?",
            "Who am I grateful for today, and why?",
            "What challenge did I face today, and how did I respond?"            
        };
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "What stood out to you today?";
        }

        string prompt;
        do
        {
            int index = _random.Next(_prompts.Count);
            prompt = _prompts[index];
        } while (prompt == _lastPrompt && _prompts.Count > 1);
    }
}