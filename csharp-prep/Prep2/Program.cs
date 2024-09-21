using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage:");
        string  grade = Console.ReadLine();
        float userGrade = float.Parse(grade);
        string letter = "";
        if (userGrade >= 90 && userGrade <= 100)
        {
            letter = "A";
            if (userGrade < 93)
            {
                letter = "A-";
            }
        }
        else if (userGrade >= 80 && userGrade < 90)
        {
            letter = "B";
            if (userGrade >= 87)
            {
                letter = "B+";
            }
            else if (userGrade < 83)
            {
                letter = "B-";
            }
           
        }
        else if (userGrade >= 70 && userGrade < 80)
        {
            letter = "C";
            if (userGrade >= 77)
            {
                letter = "C+";
            }
            else if (userGrade < 73)
            {
                letter = "C-";
            }
        }
        else if (userGrade >= 60 && userGrade < 70)
        {
            letter = "D";
            if (userGrade >= 67)
            {
                letter = "D+";
            }
            else if (userGrade < 63)
            {
                letter = "D-";
            }
           
        }
        else if (userGrade < 60)
        {
            letter = "F";
            
        }
        else 
        {
            letter = "N/A";
        }
        Console.WriteLine($"Your grade is {userGrade} and you have {letter}.");
        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class.");
        }
        else 
        {
            Console.WriteLine("You have failed the class! You need to work harder for the next time.");
        }
        
    }
}