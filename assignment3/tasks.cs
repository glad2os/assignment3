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
            Console.Write("Please type your hourly pay rate: ");

            if (!double.TryParse(Console.ReadLine(), out var userChoice))
                throw MyCustomException.IsNotADouble;

            if (userChoice < 5.65) throw MyCustomException.LessThanNeeded;
        }

        public static void Question7()
        {
            var rate = Solve(() => { return Solve(() => throw MyCustomException.ValueLessGreater); });
            Console.WriteLine("Your price is: " + rate);
        }

        private static double Solve(Func<double> callback)
        {
            Console.Write("Please type your hourly pay rate: ");

            if (!double.TryParse(Console.ReadLine(), out var rate))
                throw MyCustomException.IsNotADouble;

            if (rate is < 5.65 or > 49.99)
            {
                return callback();
            }

            return rate * 40;
        }

        public static void Question8()
        {
            Console.Write("Numeric high school grade point: ");

            if (!double.TryParse(Console.ReadLine(), out var averageGrades))
                throw MyCustomException.IsNotADouble; //TODO: inline function

            Console.Write("Test score: ");

            if (!double.TryParse(Console.ReadLine(), out var testScore))
                throw MyCustomException.IsNotADouble; //TODO: inline function

            if (averageGrades >= 3 && testScore >= 60)
            {
                Console.WriteLine("Accept");
            }
            else if (testScore >= 80)
            {
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Reject");
            }
        }

        public static void Question9()
        {
            Console.Write("Please input hourly pay rate : ");

            if (!double.TryParse(Console.ReadLine(), out var rate))
                throw MyCustomException.IsNotADouble; //TODO: inline function

            Console.Write("Please input hours worked: ");

            if (!double.TryParse(Console.ReadLine(), out var hours))
                throw MyCustomException.IsNotADouble; //TODO: inline function

            var grossPay = hours * rate;

            Console.WriteLine("gross pay: {0}", grossPay);
            Console.WriteLine("net pay: {0}", grossPay * (rate < 300 ? 0.9 : 0.88));
        }

        public static void Question10()
        {
            Console.Write("Please input the width: ");

            if (!double.TryParse(Console.ReadLine(), out var width))
                throw MyCustomException.IsNotADouble; //TODO: inline function

            Console.Write("Please input the height: ");

            if (!double.TryParse(Console.ReadLine(), out var height))
                throw MyCustomException.IsNotADouble; //TODO: inline function

            var rate = height * width switch
            {
                < 400 => 25,
                >= 600 => 50,
                _ => 35
            };

            Console.WriteLine("Your price is {0}", rate * 20);
        }
    }
}