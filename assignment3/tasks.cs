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
            var firstNumber = GetInteger("Please enter first number: ");
            var secondNumber = GetInteger("Please enter second number: ");

            Console.Write("Please type a new char: ");

            var sum = firstNumber + secondNumber;
            var diff = secondNumber - firstNumber;
            var times = secondNumber * firstNumber;

            var rate = Console.ReadKey().KeyChar switch
            {
                'A' => sum,
                'S' => diff,
                _ => times
            };

            Console.WriteLine("Your result is: " + rate);
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}\n" +
                              $"{secondNumber} + {firstNumber} = {diff}\n" +
                              $"{firstNumber} * {secondNumber} = {times}");
        }

        public static void Question3()
        {
            const int domestic = 325;
            const int international = 1375;

            var locationNumber = GetInteger("Please input 1 as domestic or 2 as the international: ");
            var numberCourses = GetInteger("Please type number of courses: ");

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
            if (GetDouble("Please type your hourly pay rate: ") < 5.65)
                throw MyCustomException.LessThanNeeded;
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

            if (rate is < 5.65 or > 49.99) return callback();

            return rate * 40;
        }

        public static void Question8()
        {
            var averageGrades = GetDouble("Numeric high school grade point: ");
            var testScore = GetInteger("Test score: ");

            if (averageGrades >= 3 && testScore >= 60)
                Console.WriteLine("Accept");
            else if (testScore >= 80)
                Console.WriteLine("Accept");
            else
                Console.WriteLine("Reject");
        }

        public static void Question9()
        {
            var rate = GetDouble("Please input hourly pay rate : ");
            var hours = GetDouble("Please input hours worked: ");
            var grossPay = hours * rate;

            Console.WriteLine("gross pay: {0}", grossPay);
            Console.WriteLine("net pay: {0}", grossPay * (rate < 300 ? 0.9 : 0.88));
        }

        public static void Question10()
        {
            var width = GetDouble("Please input the width: ");
            var height = GetDouble("Please input the height: ");

            var rate = height * width switch
            {
                < 400 => 25,
                >= 600 => 50,
                _ => 35
            };

            Console.WriteLine("Your price is {0}", rate * 20);
        }

        private static double GetDouble(string text)
        {
            Console.Write(text);
            if (!double.TryParse(Console.ReadLine(), out var variable))
                throw MyCustomException.IsNotADouble;
            return variable;
        }

        private static double GetInteger(string text)
        {
            Console.Write(text);
            if (!int.TryParse(Console.ReadLine(), out var variable))
                throw MyCustomException.IsNotAnInteger;
            return variable;
        }
    }
}