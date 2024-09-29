using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string nombre = PromptUserName();
        int numero = PromptUserNumber();
        int raiz = SquareNumber(numero);
        DisplayResult(nombre, raiz); 
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to my program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Type your number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}