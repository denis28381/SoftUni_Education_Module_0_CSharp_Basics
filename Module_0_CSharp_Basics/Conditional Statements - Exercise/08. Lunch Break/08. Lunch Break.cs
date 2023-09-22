﻿using System;
namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {

            string seriesName = Console.ReadLine();
            int eoisodeDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double requiredTime = eoisodeDuration + (1 / 8.0) * breakDuration + (1 / 4.0) * breakDuration;

            if (requiredTime <= breakDuration)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(breakDuration - requiredTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(requiredTime - breakDuration)} more minutes.");
            }

        }
    }
}