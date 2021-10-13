using System;
using System.Collections.Generic;
using assignment3.Exceptions;

namespace assignment3
{
    public static class Tasks
    {
        public static void Question1()
        {
            Console.Write("Please print 1 to 4 number: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Calculate area");
                    break;
                case "2":
                    Console.Write("Calculate volume");
                    break;
                case "3":
                    Console.Write("Calculate surface area");
                    break;
                case "4":
                    Console.Write("Exit the program");
                    break;
                default:
                    Console.Write("ERROR: Invalid choice");
                    break;
            }
        }

        public static void Question2()
        {
            Console.Write("Please enter first number: ");

            if (!int.TryParse(Console.ReadLine(), out var firstNumber))
                throw MyCustomException.IsNotANumber;

            Console.Write("Please enter second number: ");

            if (!int.TryParse(Console.ReadLine(), out var secondNumber))
                throw MyCustomException.IsNotANumber;

            Console.Write("Please type a new char: ");

            var sum = firstNumber + secondNumber;
            var diff = secondNumber - firstNumber;
            var times = secondNumber * firstNumber;

            Console.Write("Result is: ");

            switch (Console.ReadKey().KeyChar)
            {
                case 'A':
                    Console.Write("{0}", sum);
                    break;
                case 'S':
                    Console.Write("{0}", diff);
                    break;
                default:
                    Console.Write("{0}", times);
                    break;
            }

            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}\n" +
                              $"{secondNumber} + {firstNumber} = {diff}\n" +
                              $"{firstNumber} * {secondNumber} = {times}");
        }

        public static void Question3()
        {
            const int domestic = 325;
            const int international = 1375;

            Console.Write("Please input 1 as domestic or 2 as the international: ");

            if (!int.TryParse(Console.ReadLine(), out var locationNumber))
                throw MyCustomException.IsNotANumber;

            Console.Write("Please type number of courses: ");

            if (!int.TryParse(Console.ReadLine(), out var numberCourses))
                throw MyCustomException.IsNotANumber;

            switch (locationNumber)
            {
                case '1':
                    Console.WriteLine("Yours total price is ${0}", numberCourses * domestic);
                    break;
                case '2':
                    Console.WriteLine("Yours total price is ${0}", numberCourses * international);
                    break;
            }
        }

        public static void Question4()
        {
            Console.Write("Please input day: ");

            Dictionary<string, string> weekSchedule = new()
            {
                {"Sun", "Home"},
                {"Mon", "Work"},
                {"Tue", "Work"},
                {"Wed", "Home"},
                {"Thu", "Work"},
                {"Fri", "Work"},
                {"Sat", "Work"}
            };

            if (!weekSchedule.TryGetValue(Console.ReadLine() ?? string.Empty, out var selected))
                throw MyCustomException.QuestionNotFound;

            Console.WriteLine(selected);
        }

        public static void Question5()
        {
            const int pineTables = 100;
            const int oakTables = 125;
            const int mahoganyTables = 310;

            Console.Write("Please select Pine, Oak or Mahogany: ");

            switch (Console.ReadLine()?.ToLower())
            {
                case "pine":
                    Console.WriteLine("Your price is: {0}", pineTables);
                    break;
                case "oak":
                    Console.WriteLine("Your price is: {0}", oakTables);
                    break;
                case "mahogany":
                    Console.WriteLine("Your price is: {0}", mahoganyTables);
                    break;
                default:
                    throw MyCustomException.QuestionNotFound;
            }
        }

        public static void Question6()
        {
            throw new NotImplementedException();
        }

        public static void Question7()
        {
            throw new NotImplementedException();
        }

        public static void Question8()
        {
            throw new NotImplementedException();
        }

        public static void Question9()
        {
            throw new NotImplementedException();
        }

        public static void Question10()
        {
            throw new NotImplementedException();
        }
    }
}