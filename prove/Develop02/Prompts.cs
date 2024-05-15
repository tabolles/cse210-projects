using System;
using System.Collections.Generic;

class Prompts
{   
    List<string> _prompts = new() {
        "What was the best part of your day?",
        "What was the most challenging part of your day?",
        "Did you learn something new today?",
        "What are you grateful for today?",
        "What is one thing you could have done better today?",
        "Is there anything you would like to improve in your daily routine?",
        "What made you smile today?",
        "Did you help someone today?",
        "What is one thing you are looking forward to tomorrow?",
        "How have you seen God's hand in your life today?"
    };

    public string GetPrompt()
    {
        Random random = new();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}