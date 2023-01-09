using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");

        Console.Write("What is your grade? ");
        string myGrade = Console.ReadLine();
        
        int finalGrade = int.Parse(myGrade);

        if (finalGrade >= 90)
        {   Console.WriteLine("Your letter grade is A");}
        
        else if (finalGrade >= 80)
        {   Console.WriteLine("YOur letter grade is B");}
        else if (finalGrade >= 70)
        {   Console.WriteLine("Your letter grade is C");}
        else if (finalGrade >= 60)
        {   Console.WriteLine("Your letter grade is D");}
        else if (finalGrade < 60)
        {   Console.WriteLine("You fail");}

        

    }
}