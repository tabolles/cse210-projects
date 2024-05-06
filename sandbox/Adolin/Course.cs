using System;

class Course
{
    //"_" in front is a naming convention to indicate the member variables
    public string _courseCode;
    public string _className;
    public int _numberOfCredits;
    public string _color;

    //method
    public void Display()
    {
        Console.WriteLine($"Course Code: {_courseCode}");
        Console.WriteLine($"Class Name: {_className}");
        Console.WriteLine($"Number of Credits: {_numberOfCredits}");
        Console.WriteLine($"Color: {_color}");
    }
}