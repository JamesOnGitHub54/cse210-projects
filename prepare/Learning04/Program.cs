using System;

class Program
{
    static void Main(string[] args)
    {
        assignment a1 = new assignment("Chris Jericho", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("John Cena", "Fractions", "1.0", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Randy Orton", "Wrestling 101", "The RKO");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());
    }
}