using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magic = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        int userNumber;
        int counter = 0;

        do
        {
            Console.Write("What is your guess? ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber > magic)
            {
                 Console.WriteLine("Higher");
            }
            else if (userNumber < magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            } 
            counter++;  
                        
        }while (userNumber != magic);
        Console.WriteLine($"You have guessed the magic number: {counter} times."); 
        Console.WriteLine();

        string userAnswer = "yes";

        

        while (userAnswer == "yes")
        {
            Console.Write("Do you want to play again? ");
            userAnswer = Console.ReadLine();
            
            do
            {
                Console.Write("What is your guess? ");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber > magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (userNumber < magic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                } 
                counter++;  
                            
            }while (userNumber != magic);
            Console.WriteLine($"You have guessed the magic number: {counter} times."); 
            Console.WriteLine();   
        }              
    }
}