using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.WriteLine("Please enter some numbers integer: ");
        //int userNumber = int.Parse(Console.ReadLine());

        

        List<int> numbers = new List<int>();

        int userNumber = -1;

        do
        {
            Console.WriteLine("Please type numbers: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            

            /*foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //Console.WriteLine($"{numbers}");
            Console.WriteLine(numbers.Count);*/

        } while (userNumber != 0);  

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        //Console.WriteLine(numbers.Count);   

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}