using System;

class Program
{
    static void Main(string[] args)
    {    
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNUmber();
        DisplayResult(userName, userNumber);
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello Prep5 World!");
            }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            return name;
            }
        static int PromptUserNUmber()
        {
            Console.WriteLine("What is you favorite number:");
            int number = int.Parse(Console.ReadLine());
            return number;
            }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
            } 
        static void  DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}'s favorite number if squared is {square}");
            }   
    }
