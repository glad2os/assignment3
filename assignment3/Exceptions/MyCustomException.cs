using System;

namespace assignment3.Exceptions
{
    public class MyCustomException : Exception
    {
        public static readonly MyCustomException IsNotANumber = new("is NaN");
        public static readonly MyCustomException IsNotABoolean = new("is not a bool");
        public static readonly MyCustomException QuestionNotFound = new("question does not found");
        public static readonly MyCustomException NegativeNumber = new("The number can not be negative");
        public static readonly MyCustomException IsNotADouble = new("The number should be double");
        public static readonly MyCustomException LessThanNeeded = new("The number should be more than 5.65");
        public static readonly MyCustomException ValueLessGreater = new("The number should grate or equals 5.65 and less or equals than 49.99");

        private MyCustomException(string message) : base(message)
        {
        }
    }
}