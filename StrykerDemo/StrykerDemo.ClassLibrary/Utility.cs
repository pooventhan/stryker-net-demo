namespace StrykerDemo
{
    using System;

    public static class Utility
    {
        public static bool IsAdult(int age)
        {
            return age >= 18;
        }

        public static string AppendWithGuid(string value)
        {
            return $"{value}{Guid.NewGuid()}";
        }
    }
}