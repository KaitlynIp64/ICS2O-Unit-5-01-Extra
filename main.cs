// Created by: Kaitlyn Ip
// Created on: Apr 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int returnValue = random.Next(1, 6);
        int guess = 0;
        Console.WriteLine("Guess a number between 1-6.");
        if (guess != returnValue)
        {
            guess = Convert.ToInt32(Console.Read());
            Console.WriteLine("Try again. The answer was " + returnValue);
            Console.ReadLine();
        }
        if (guess == returnValue)
        {
            Console.WriteLine("Congratulations. The answer was " + returnValue);
            Console.ReadLine();
        }
    }
}