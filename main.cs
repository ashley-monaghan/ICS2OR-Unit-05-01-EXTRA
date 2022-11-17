// Created by: Ashley Monaghan
// Created on: Nov 2022
//
//This program converts Fahrenheit to Celsius

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int userNumber;
        int randomNumber;

        Console.WriteLine("Can you guess the mystery number?");
        Console.WriteLine("");

        Console.Write("Enter random value from 1-6: ");
        Console.WriteLine("");
        userNumber = Convert.ToInt16(Console.ReadLine());

        Random rnd = new Random();
        randomNumber = rnd.Next(1, 6);

        Console.WriteLine("");
        if (userNumber == randomNumber)
        {
            Console.WriteLine("The answer was: " + randomNumber + ". You got it right!");
        }

        if (userNumber != randomNumber)
        {
            Console.WriteLine("The answer was: " + randomNumber + ". You got it wrong. Better luck next time!");
        }

    Console.WriteLine("\nDone.");
    }
}