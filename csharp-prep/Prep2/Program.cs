using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string message = "";

        Console.Write("What is your grade percentage? ");
        string number = Console.ReadLine();

        int grade = int.Parse(number);

        if (grade >= 90)
        { letter = "A"; }

        else if (grade >= 80)
        { letter = "B"; }

        else if (grade >= 70)
        { letter = "C"; }

        else if (grade >= 60)
        { letter = "D"; }

        else
        { letter = "F"; }


        if (grade >= 70)
        { message = "Congratulations! You have passed the course!"; }
        else
        { message = "Unfortunately, you were unable to pass the course. Next time, lets aim for a successful grade!"; }

        Console.WriteLine("Your grade is as follows: " + letter);
        Console.WriteLine(message);
    }
}