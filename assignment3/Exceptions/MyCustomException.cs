using System;

namespace assignment3.Exceptions
{
    public class MyCustomException : Exception
    {
        public static readonly MyCustomException IsNotANumber = new("is NaN");
        public static readonly MyCustomException IsNotABoolean = new("is not a bool");
        public static readonly MyCustomException QuestionNotFound = new("question does not found");
        public static readonly MyCustomException NegativeNumber = new("The number can not be negative");

        private MyCustomException(string message) : base(message)
        {
        }
    }
}