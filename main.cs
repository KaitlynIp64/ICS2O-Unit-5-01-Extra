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
        int Guess = 0;
        Console.WriteLine("Guess a number between 1-6.");
        if (Guess != returnValue)
        {
            Guess = Convert.ToInt32(Console.Read());
            Console.WriteLine("Try again! The answer was " + returnValue);
            Console.ReadLine();
        }
        if (Guess == returnValue)
        {
            Guess = Convert.ToInt32(Console.Read());
            Console.WriteLine("Congratulations! The answer was " + returnValue);
            Console.ReadLine();
        }
    }
}